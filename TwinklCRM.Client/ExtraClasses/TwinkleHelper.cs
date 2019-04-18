using TwinklCRM.DAL.Models.Contexts;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Views;
using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TwinklCRM.Client.ExtraClasses
{
    internal static class TwinkleHelper
    {
        //internal static async void SaveNewMessages(List<TheMail> allMails)
        //{
        //    using (var db = new FredroDbContext())
        //    {
        //        foreach (var message in allMails)
        //        {
        //            db.Mails.AddIfNotExists(message);
        //        }
        //        await db.SaveChangesAsync();
        //    }
        //}

        //internal static void TruncateMails()
        //{
        //    using (var db = new FredroDbContext())
        //    {
        //        db.Database.ExecuteSqlCommand("TRUNCATE TABLE TheMails");
        //    }
        //}

        //resource 1 time
        //internal static BindingList<ViewVehicle> GetAllViewVehicles()
        //{
        //    try
        //    {
        //        BindingList<ViewVehicle> viewVehicles = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.ViewVehicles.Load();
        //            viewVehicles = db.ViewVehicles.Local.ToBindingList();
        //        }
        //        return viewVehicles;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}

        //internal static BindingList<Vehicle> GetAllVehicles()
        //{
        //    try
        //    {
        //        BindingList<Vehicle> vehicles = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.Vehicles.Load();
        //            vehicles = db.Vehicles.Local.ToBindingList();
        //        }
        //        return vehicles;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}
        
        //internal static BindingList<Deal> GetAllDeals()
        //{
        //    try
        //    {
        //        BindingList<Deal> deals = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.Deals.Load();
        //            deals = db.Deals.Local.ToBindingList();
        //        }
        //        return deals;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}
        ////appts many times
        //internal static BindingList<ViewAssignedDeal> GetAllViewAssignedDeals()
        //{
        //    try
        //    {
        //        BindingList<ViewAssignedDeal> viewVehicles = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.ViewAssignedDeals.Load();
        //            viewVehicles = db.ViewAssignedDeals.Local.ToBindingList();
        //        }
        //        return viewVehicles;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}
        ////
        //internal static Deal GetDeal(int dealId)
        //{
        //    try
        //    {
        //        Deal deal = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            deal = db.Deals.Find(dealId);
        //        }
        //        return deal;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}

        //internal static ViewAssignedDeal GetViewAssignedDeal(int dealId)
        //{
        //    try
        //    {
        //        ViewAssignedDeal deal = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            deal = db.ViewAssignedDeals.Find(dealId);
        //        }
        //        return deal;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}

        //internal static List<Deal> GetAssignedDeals()
        //{
        //    try
        //    {
        //        List<Deal> deals = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.Deals.Load();
        //            deals = db.Deals.Where(x => x.VehicleId != null).ToList();
        //        }
        //        return deals;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}
        ////will be appts many times
        //internal static List<Deal> GetNotAssignedDeals()
        //{
        //    try
        //    {
        //        List<Deal> deals = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.Deals.Load();
        //            deals = db.Deals.Where(x => x.VehicleId == null).ToList();
        //        }
        //        return deals;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}

        //internal static BindingList<Customer> GetAllCustomers()
        //{
        //    try
        //    {
        //        BindingList<Customer> deals = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.Customers.Load();
        //            deals = db.Customers.Local.ToBindingList();
        //        }
        //        return deals;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}

        //internal static BindingList<Performer> GetAllPerformes()
        //{
        //    try
        //    {
        //        BindingList<Performer> deals = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.Performers.Load();
        //            deals = db.Performers.Local.ToBindingList();
        //        }
        //        return deals;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}

        //internal static BindingList<DictionaryTripType> GetAllTripTypes()
        //{
        //    try
        //    {
        //        BindingList<DictionaryTripType> deals = null;
        //        using (var db = new TwinkleDbContext())
        //        {
        //            db.TripTypes.Load();
        //            deals = db.TripTypes.Local.ToBindingList();
        //        }
        //        return deals;
        //    }
        //    catch (Exception ex)
        //    {
        //        TwinkleMessageBox.ShowError(ex.Message);
        //        return null;
        //        throw ex;
        //    }
        //}
    }

    //public static class DbSetExtensions
    //{
    //    public static T AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
    //    {
    //        var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
    //        return !exists ? dbSet.Add(entity) : null;
    //    }
    //}

}
