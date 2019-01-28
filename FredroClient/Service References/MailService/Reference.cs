﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FredroClient.MailService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MailService.IMailService")]
    public interface IMailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/GetAllMails", ReplyAction="http://tempuri.org/IMailService/GetAllMailsResponse")]
        FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[] GetAllMails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/GetAllMails", ReplyAction="http://tempuri.org/IMailService/GetAllMailsResponse")]
        System.Threading.Tasks.Task<FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[]> GetAllMailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        void SendMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        System.Threading.Tasks.Task SendMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/UpdateMail", ReplyAction="http://tempuri.org/IMailService/UpdateMailResponse")]
        void UpdateMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/UpdateMail", ReplyAction="http://tempuri.org/IMailService/UpdateMailResponse")]
        System.Threading.Tasks.Task UpdateMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/RemoveMail", ReplyAction="http://tempuri.org/IMailService/RemoveMailResponse")]
        void RemoveMail(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/RemoveMail", ReplyAction="http://tempuri.org/IMailService/RemoveMailResponse")]
        System.Threading.Tasks.Task RemoveMailAsync(string Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailServiceChannel : FredroClient.MailService.IMailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailServiceClient : System.ServiceModel.ClientBase<FredroClient.MailService.IMailService>, FredroClient.MailService.IMailService {
        
        public MailServiceClient() {
        }
        
        public MailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[] GetAllMails() {
            return base.Channel.GetAllMails();
        }
        
        public System.Threading.Tasks.Task<FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage[]> GetAllMailsAsync() {
            return base.Channel.GetAllMailsAsync();
        }
        
        public void SendMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message) {
            base.Channel.SendMail(message);
        }
        
        public System.Threading.Tasks.Task SendMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message) {
            return base.Channel.SendMailAsync(message);
        }
        
        public void UpdateMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message) {
            base.Channel.UpdateMail(message);
        }
        
        public System.Threading.Tasks.Task UpdateMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMessage message) {
            return base.Channel.UpdateMailAsync(message);
        }
        
        public void RemoveMail(string Id) {
            base.Channel.RemoveMail(Id);
        }
        
        public System.Threading.Tasks.Task RemoveMailAsync(string Id) {
            return base.Channel.RemoveMailAsync(Id);
        }
    }
}
