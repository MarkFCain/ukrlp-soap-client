namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ukrlp.co.uk.server.ws.v3", ConfigurationName="ProviderQueryServiceV4.ProviderQueryPortType")]
    public interface ProviderQueryPortType {
        
        // CODEGEN: Generating message contract since the operation retrieveAllProviders is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="retrieveAllProviders", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.faultDetail), Action="retrieveAllProviders", Name="faultDetail")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PersonMaritalStatusStructure))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PersonDeathDateStructure))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PersonBirthDateStructure))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AONrangeStructure))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BasicLandAndPropertyUnitStructure))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProviderQueryResultStructure))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(authenticationDetails))]
        Ukrlp.SoapApi.Client.ProviderQueryServiceV4.response retrieveAllProviders(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam request);
        
        [System.ServiceModel.OperationContractAttribute(Action="retrieveAllProviders", ReplyAction="*")]
        System.Threading.Tasks.Task<Ukrlp.SoapApi.Client.ProviderQueryServiceV4.response> retrieveAllProvidersAsync(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam request);
    }
}