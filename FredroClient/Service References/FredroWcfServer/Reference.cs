﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FredroClient.FredroWcfServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FredroWcfServer.IFredroWcfServer")]
    public interface IFredroWcfServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFredroWcfServer/GetAllMessages", ReplyAction="http://tempuri.org/IFredroWcfServer/GetAllMessagesResponse")]
        FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[] GetAllMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFredroWcfServer/GetAllMessages", ReplyAction="http://tempuri.org/IFredroWcfServer/GetAllMessagesResponse")]
        System.Threading.Tasks.Task<FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[]> GetAllMessagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFredroWcfServerChannel : FredroClient.FredroWcfServer.IFredroWcfServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FredroWcfServerClient : System.ServiceModel.ClientBase<FredroClient.FredroWcfServer.IFredroWcfServer>, FredroClient.FredroWcfServer.IFredroWcfServer {
        
        public FredroWcfServerClient() {
        }
        
        public FredroWcfServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FredroWcfServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FredroWcfServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FredroWcfServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[] GetAllMessages() {
            return base.Channel.GetAllMessages();
        }
        
        public System.Threading.Tasks.Task<FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[]> GetAllMessagesAsync() {
            return base.Channel.GetAllMessagesAsync();
        }
    }
}
