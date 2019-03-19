﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TwinklCRM.BusinessObjectService.Models;
using TwinkleDAL.Models.DatabaseObjectModels.Tables;
using TwinkleDAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.BusinessObjectService
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

        public void UpdateDeal(int id)
        {
            try
            {
                _dataManager.UpdateDeal(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void UpdatePerformer(int id)
        {
            try
            {
                _dataManager.UpdatePerformer(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }


}