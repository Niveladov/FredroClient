﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FredroClient.MailService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MailService.IMailService", CallbackContract=typeof(FredroClient.MailService.IMailServiceCallback))]
    public interface IMailService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMailService/Join")]
        void Join();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMailService/Join")]
        System.Threading.Tasks.Task JoinAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        void SendMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        System.Threading.Tasks.Task SendMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMailService/UpdateMail")]
        void UpdateMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMailService/UpdateMail")]
        System.Threading.Tasks.Task UpdateMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMailService/RemoveMail")]
        void RemoveMail(string Id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMailService/RemoveMail")]
        System.Threading.Tasks.Task RemoveMailAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/GetUserEmailBoxes", ReplyAction="http://tempuri.org/IMailService/GetUserEmailBoxesResponse")]
        FredroDAL.Models.DatabaseObjectModels.Tables.CachedEmailBox[] GetUserEmailBoxes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/GetUserEmailBoxes", ReplyAction="http://tempuri.org/IMailService/GetUserEmailBoxesResponse")]
        System.Threading.Tasks.Task<FredroDAL.Models.DatabaseObjectModels.Tables.CachedEmailBox[]> GetUserEmailBoxesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMailService/SendNewMails")]
        void SendNewMails(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail[] newMails);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailServiceChannel : FredroClient.MailService.IMailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailServiceClient : System.ServiceModel.DuplexClientBase<FredroClient.MailService.IMailService>, FredroClient.MailService.IMailService {
        
        public MailServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MailServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MailServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Join() {
            base.Channel.Join();
        }
        
        public System.Threading.Tasks.Task JoinAsync() {
            return base.Channel.JoinAsync();
        }
        
        public void SendMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail) {
            base.Channel.SendMail(mail);
        }
        
        public System.Threading.Tasks.Task SendMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail) {
            return base.Channel.SendMailAsync(mail);
        }
        
        public void UpdateMail(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail) {
            base.Channel.UpdateMail(mail);
        }
        
        public System.Threading.Tasks.Task UpdateMailAsync(FredroDAL.Models.DatabaseObjectModels.Tables.TheMail mail) {
            return base.Channel.UpdateMailAsync(mail);
        }
        
        public void RemoveMail(string Id) {
            base.Channel.RemoveMail(Id);
        }
        
        public System.Threading.Tasks.Task RemoveMailAsync(string Id) {
            return base.Channel.RemoveMailAsync(Id);
        }
        
        public FredroDAL.Models.DatabaseObjectModels.Tables.CachedEmailBox[] GetUserEmailBoxes() {
            return base.Channel.GetUserEmailBoxes();
        }
        
        public System.Threading.Tasks.Task<FredroDAL.Models.DatabaseObjectModels.Tables.CachedEmailBox[]> GetUserEmailBoxesAsync() {
            return base.Channel.GetUserEmailBoxesAsync();
        }
    }
}
