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

        #region Customer

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

        #endregion

        #region Performer

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

        #endregion

        #region Deal

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

        public IEnumerable<Deal> GetAllDeals()
        {
            try
            {
                return _dataManager.GetAllDeals();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        #endregion

        #region Vehicle

        public Vehicle GetVehicle(int id)
        {
            try
            {
                return _dataManager.GetVehicle(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteVehicle(int id)
        {
            try
            {
                _dataManager.DeleteVehicle(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            try
            {
                _dataManager.UpdateVehicle(vehicle);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            try
            {
                _dataManager.InsertVehicle(vehicle);
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

        #endregion
        
        #region DictionaryTripType

        public DictionaryTripType GetTripType(int id)
        {
            try
            {
                return _dataManager.GetTripType(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteTripType(int id)
        {
            try
            {
                _dataManager.DeleteTripType(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateTripType(DictionaryTripType tripType)
        {
            try
            {
                _dataManager.UpdateTripType(tripType);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertTripType(DictionaryTripType tripType)
        {
            try
            {
                _dataManager.InsertTripType(tripType);
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

        #endregion

        #region DictionaryVehicleType

        public DictionaryVehicleType GetVehicleType(int id)
        {
            try
            {
                return _dataManager.GetVehicleType(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteVehicleType(int id)
        {
            try
            {
                _dataManager.DeleteVehicleType(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateVehicleType(DictionaryVehicleType vehicleType)
        {
            try
            {
                _dataManager.UpdateVehicleType(vehicleType);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertVehicleType(DictionaryVehicleType vehicleType)
        {
            try
            {
                _dataManager.InsertVehicleType(vehicleType);
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

        #endregion

        #region DictionaryEmailFolderType

        public DictionaryEmailFolderType GetEmailFolderType(int id)
        {
            try
            {
                return _dataManager.GetEmailFolderType(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteEmailFolderType(int id)
        {
            try
            {
                _dataManager.DeleteEmailFolderType(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateEmailFolderType(DictionaryEmailFolderType emailFolderType)
        {
            try
            {
                _dataManager.UpdateEmailFolderType(emailFolderType);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertEmailFolderType(DictionaryEmailFolderType emailFolderType)
        {
            try
            {
                _dataManager.InsertEmailFolderType(emailFolderType);
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

        #endregion

        #region DictionaryEmailServer

        public DictionaryEmailServer GetEmailServer(int id)
        {
            try
            {
                return _dataManager.GetEmailServer(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteEmailServer(int id)
        {
            try
            {
                _dataManager.DeleteEmailServer(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateEmailServer(DictionaryEmailServer emailServer)
        {
            try
            {
                _dataManager.UpdateEmailServer(emailServer);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertEmailServer(DictionaryEmailServer emailServer)
        {
            try
            {
                _dataManager.InsertEmailServer(emailServer);
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

        #endregion

        #region DictionaryEmailServerParam

        public DictionaryEmailServerParam GetEmailServerParam(int id)
        {
            try
            {
                return _dataManager.GetEmailServerParam(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteEmailServerParam(int id)
        {
            try
            {
                _dataManager.DeleteEmailServerParam(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateEmailServerParam(DictionaryEmailServerParam emailServerParam)
        {
            try
            {
                _dataManager.UpdateEmailServerParam(emailServerParam);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertEmailServerParam(DictionaryEmailServerParam emailServerParam)
        {
            try
            {
                _dataManager.InsertEmailServerParam(emailServerParam);
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

        #endregion

        #region DictionaryHierarchy

        public DictionaryHierarchy GetHierarchy(int id)
        {
            try
            {
                return _dataManager.GetHierarchy(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteHierarchy(int id)
        {
            try
            {
                _dataManager.DeleteHierarchy(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateHierarchy(DictionaryHierarchy hierarchy)
        {
            try
            {
                _dataManager.UpdateHierarchy(hierarchy);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertHierarchy(DictionaryHierarchy hierarchy)
        {
            try
            {
                _dataManager.InsertHierarchy(hierarchy);
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

        #endregion

        #region DictionaryVehicleCapacityColor
        
        public DictionaryVehicleCapacityColor GetVehicleCapacityColor(int id)
        {
            try
            {
                return _dataManager.GetVehicleCapacityColor(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteVehicleCapacityColor(int id)
        {
            try
            {
                _dataManager.DeleteVehicleCapacityColor(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateVehicleCapacityColor(DictionaryVehicleCapacityColor emailFolderType)
        {
            try
            {
                _dataManager.UpdateVehicleCapacityColor(emailFolderType);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void InsertVehicleCapacityColor(DictionaryVehicleCapacityColor emailFolderType)
        {
            try
            {
                _dataManager.InsertVehicleCapacityColor(emailFolderType);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<DictionaryVehicleCapacityColor> GetVehicleCapacityColors()
        {
            try
            {
                return _dataManager.GetVehicleCapacityColors();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        #endregion
    }

}
