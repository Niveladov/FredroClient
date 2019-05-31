using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TwinklCRM.BusinessObjectServiceLibrary.Models;
using TwinklCRM.BusinessObjectServiceLibrary.Models.Interfaces;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class BusinessObjectService : IBusinessObjectService
    {
        private readonly IDbDataManager _dataManager;

        public BusinessObjectService()
        {
            try
            {
                _dataManager = new DbDataManager();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteCustomer(int id)
        {
            try
            {
                _dataManager.DeleteCustomer(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteDeal(int id)
        {
            try
            {
                _dataManager.DeleteDeal(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeletePerformer(int id)
        {
            try
            {
                _dataManager.DeletePerformer(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            try
            {
                return _dataManager.GetAllCustomers();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<Performer> GetAllPerformers()
        {
            try
            {
                return _dataManager.GetAllPerformers();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<DictionaryTripType> GetAllTripTypes()
        {
            try
            {
                return _dataManager.GetAllTripTypes();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            try
            {
                return _dataManager.GetAllVehicles();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public Customer GetCustomer(int id)
        {
            try
            {
                return _dataManager.GetCustomer(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public Deal GetDeal(int id)
        {
            try
            {
                return _dataManager.GetDeal(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public Performer GetPerformer(int id)
        {
            try
            {
                return _dataManager.GetPerformer(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertCustomer(Customer customer)
        {
            try
            {
                _dataManager.InsertCustomer(customer);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertDeal(Deal deal)
        {
            try
            {
                _dataManager.InsertDeal(deal);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertPerformer(Performer performer)
        {
            try
            {
                _dataManager.InsertPerformer(performer);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                _dataManager.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateDeal(Deal deal)
        {
            try
            {
                _dataManager.UpdateDeal(deal);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdatePerformer(Performer performer)
        {
            try
            {
                _dataManager.UpdatePerformer(performer);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<DictionaryVehicleType> GetAllVehicleTypes()
        {
            try
            {
                return _dataManager.GetAllVehicleTypes();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<DictionaryEmailFolderType> GetAllEmailFolderTypes()
        {
            try
            {
                return _dataManager.GetAllEmailFolderTypes();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<DictionaryEmailServer> GetAllEmailServers()
        {
            try
            {
                return _dataManager.GetAllEmailServers();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<DictionaryEmailServerParam> GetAllEmailServerParams()
        {
            try
            {
                return _dataManager.GetAllEmailServerParams();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<DictionaryHierarchy> GetAllHierarchies()
        {
            try
            {
                return _dataManager.GetAllHierarchies();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }


}
