using System.ServiceModel;
using System.ServiceModel.Description;

namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    public interface IProviderQueryPortTypeClient
    {
        Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryResponse retrieveAllProviders(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryStructure ProviderQueryRequest);
        System.Threading.Tasks.Task<Ukrlp.SoapApi.Client.ProviderQueryServiceV4.response> retrieveAllProvidersAsync(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryStructure ProviderQueryRequest);
        void Open();
        void Abort();
        void Close();
        void DisplayInitializationUI();
        ChannelFactory<ProviderQueryPortType> ChannelFactory { get; }
        ClientCredentials ClientCredentials { get; }
        CommunicationState State { get; }
        IClientChannel InnerChannel { get; }
        ServiceEndpoint Endpoint { get; }
    }
}