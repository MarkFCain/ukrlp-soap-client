namespace Ukrlp.SoapApi.Client.ProviderQueryServiceV4
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ProviderQueryParam {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ukrlp.co.uk.server.ws.v3", Order=0)]
        public Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryStructure ProviderQueryRequest;
        
        public ProviderQueryParam() {
        }
        
        public ProviderQueryParam(Ukrlp.SoapApi.Client.ProviderQueryServiceV4.ProviderQueryStructure ProviderQueryRequest) {
            this.ProviderQueryRequest = ProviderQueryRequest;
        }
    }
}