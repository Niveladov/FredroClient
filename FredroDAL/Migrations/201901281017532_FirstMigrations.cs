namespace FredroDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CachedEmailBoxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        UserId = c.Int(),
                        EmailServerId = c.Int(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        SubjectName = c.String(),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateStart = c.DateTime(),
                        DateEnd = c.DateTime(),
                        Route = c.String(),
                        CustomerId = c.Int(),
                        PerformerId = c.Int(),
                        VehicleId = c.Int(),
                        TripTypeId = c.Int(),
                        DealStatusId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DictionaryEmailServers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        Caption = c.String(),
                        Code = c.String(),
                        OriginClientUrl = c.String(),
                        PopHostname = c.String(),
                        PopUseSsl = c.Boolean(nullable: false),
                        PopPort = c.Int(nullable: false),
                        ImapHostname = c.String(),
                        ImapUseSsl = c.Boolean(nullable: false),
                        ImapPort = c.Int(nullable: false),
                        SmtpHostname = c.String(),
                        SmtpUseSsl = c.Boolean(nullable: false),
                        SmtpPort = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TheMessages",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FromFullRaw = c.String(),
                        FromAddress = c.String(),
                        FromDisplayName = c.String(),
                        ToFullRaw = c.String(),
                        ToAddress = c.String(),
                        ToDisplayName = c.String(),
                        Date = c.DateTime(),
                        Subject = c.String(),
                        MailedBy = c.String(),
                        SignedBy = c.String(),
                        Body = c.String(),
                        IsOutcoming = c.Boolean(nullable: false),
                        IsIncoming = c.Boolean(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Performers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        SubjectName = c.String(),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DictionaryTripTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        Login = c.String(),
                        PasswordHash = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        Name = c.String(),
                        RegistrationNumber = c.String(),
                        PassengersCount = c.Short(),
                        TypeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DictionaryVehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ViewAssignedDeals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDel = c.Boolean(),
                        CreationDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateStart = c.DateTime(),
                        DateEnd = c.DateTime(),
                        Route = c.String(),
                        CustomerId = c.Int(),
                        PerformerId = c.Int(),
                        VehicleId = c.Int(),
                        TripTypeId = c.Int(),
                        DealStatusId = c.Int(),
                        Description = c.String(),
                        PassengersCount = c.Short(),
                        TripTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ViewVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RegistrationNumber = c.String(),
                        PassengersCount = c.Short(),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ViewVehicles");
            DropTable("dbo.ViewAssignedDeals");
            DropTable("dbo.DictionaryVehicleTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Users");
            DropTable("dbo.DictionaryTripTypes");
            DropTable("dbo.Performers");
            DropTable("dbo.TheMessages");
            DropTable("dbo.DictionaryEmailServers");
            DropTable("dbo.Deals");
            DropTable("dbo.Customers");
            DropTable("dbo.CachedEmailBoxes");
        }
    }
}
