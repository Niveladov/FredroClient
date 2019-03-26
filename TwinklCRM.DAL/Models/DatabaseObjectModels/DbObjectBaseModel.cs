using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels
{
    [DataContract]
    public class DbObjectBaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
