using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using Ukrlp.SoapApi.Client;
using Ukrlp.SoapApi.Client.ProviderQueryServiceV4;

namespace Ukrlp.SoapApi.UnitTests
{
    [TestFixture]
    public class ProviderQueryApiClientTests
    {
        [Test]
        public void ShouldMakePageAUkprnCollectionIntoTwoCalls()
        {
            // Arrange
            var mockClient = new Mock<IProviderQueryPortTypeClient>();
            var sut = new ProviderQueryApiClient(mockClient.Object);

            mockClient.Setup(x => x.retrieveAllProviders(It.IsAny<ProviderQueryStructure>()))
                .Returns(new ProviderQueryResponse
                {
                    MatchingProviderRecords = new ProviderRecordStructure[] {}
                });
            var ukprns = GenerateUKPRNs(30).ToArray();
            var criteria = new SelectionCriteriaStructure { UnitedKingdomProviderReferenceNumberList = ukprns };
            

            // Act
            var response = sut.ProviderQuery(criteria, batchSize: 20);

            //
            mockClient.Verify(x => x.retrieveAllProviders(It.IsAny<ProviderQueryStructure>()), Times.Exactly(2));
            Assert.AreEqual(30, response.Warnings.Keys.Count);
        }

        private IEnumerable<string> GenerateUKPRNs(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return (10000000 + i).ToString();
            }
        }
    }
}
