using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.Client.MailService;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;

namespace TwinklCRM.Client.Models
{
    internal sealed class NewMailModel
    {
        private MailServiceClient _serviceClient;

        private int? _fromEmalBoxId;
        public int? FromEmailBoxId
        {
            get { return _fromEmalBoxId; }
            set
            {
                if (_fromEmalBoxId != value)
                {
                    _fromEmalBoxId = value;
                    FromEmailBoxAddress = UserEmailBoxes.Single(x => x.Id == value).Login;
                }
            }
        }
        public string FromEmailBoxAddress { get; private set; }
        public CachedEmailBox[] UserEmailBoxes { get; }

        public NewMailModel(MailServiceClient serviceClient)
        {
            try
            {
                _serviceClient = serviceClient;
                UserEmailBoxes = _serviceClient.GetUserEmailBoxes();
                FromEmailBoxId = UserEmailBoxes.First().Id.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void SendMail(TheMail responseMail)
        {
            try
            {
                _serviceClient.SendMail(responseMail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
