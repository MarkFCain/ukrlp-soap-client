namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProviderQueryPortTypeClient : System.ServiceModel.ClientBase<Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryPortType>, Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryPortType, IProviderQueryPortTypeClient
    {
        
        public ProviderQueryPortTypeClient() {
        }
        
        public ProviderQueryPortTypeClient(string endpointConfigurationName) : 
            base(endpointConfigurationName) {
            }
        
        public ProviderQueryPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
            }
        
        public ProviderQueryPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
            }
        
        public ProviderQueryPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress) {
            }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ukrlp.SoapApi.Client.ProviderQueryServiceV4.response Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryPortType.retrieveAllProviders(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam request) {
            return base.Channel.retrieveAllProviders(request);
        }
        
        public Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryResponse retrieveAllProviders(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryStructure ProviderQueryRequest) {
            Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam inValue = new Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam();
            inValue.ProviderQueryRequest = ProviderQueryRequest;
            Ukrlp.SoapApi.Client.ProviderQueryServiceV4.response retVal = ((Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryPortType)(this)).retrieveAllProviders(inValue);
            return retVal.ProviderQueryResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ukrlp.SoapApi.Client.ProviderQueryServiceV4.response> Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryPortType.retrieveAllProvidersAsync(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam request) {
            return base.Channel.retrieveAllProvidersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ukrlp.SoapApi.Client.ProviderQueryServiceV4.response> retrieveAllProvidersAsync(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryStructure ProviderQueryRequest) {
            Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam inValue = new Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryParam();
            inValue.ProviderQueryRequest = ProviderQueryRequest;
            return ((Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryPortType)(this)).retrieveAllProvidersAsync(inValue);
        }
    }
}