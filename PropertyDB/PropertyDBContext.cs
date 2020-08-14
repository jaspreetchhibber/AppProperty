using Microsoft.EntityFrameworkCore;
using PropertyDB.Accounting;
using PropertyDB.Admin;
using PropertyDB.Building;
using PropertyDB.Inventory;
using PropertyDB.Payroll;
using PropertyDB.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDB
{
    public class PropertyDBContext : DbContext
    {
        public PropertyDBContext(DbContextOptions opt) : base(opt) { }

        //Accounting
        public DbSet<CssCatalog> Catalog { get; set; }

        //Admin
        public DbSet<CssAddress> Address { get; set; }
        public DbSet<CssCity> City { get; set; }
        public DbSet<CssCountry> Country { get; set; }
        public DbSet<CssCompany> Company { get; set; }
        public DbSet<CssEmail> Email { get; set; }
        public DbSet<CssGeneral> General { get; set; }
        public DbSet<CssKind> Kind { get; set; }
        public DbSet<CssOfferContext> OfferContext { get; set; }
        public DbSet<CssPhone> Phone { get; set; }
        public DbSet<CssReponsability> Reponsability { get; set; }
        public DbSet<CssRole> Role { get; set; }
        public DbSet<CssState> State { get; set; }
        public DbSet<CssUser> User { get; set; }

        //Building
        public DbSet<CssAmenities> Amenities { get; set; }
        public DbSet<CssBuilding> Building { get; set; }
        public DbSet<CssPicture> BuildPic{ get; set; }
        public DbSet<CssSection> Section { get; set; }
        public DbSet<CssTicket> Ticket { get; set; }
        public DbSet<CssUnit> Unit { get; set; }
        public DbSet<CssUnitHas> UnitHas { get; set; }
        public DbSet<CssUnitInOut> UnitInOut { get; set; }

        //Inventory

        public DbSet<CssItem> Item { get; set; }
        public DbSet<CssPurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<CssPurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public DbSet<CssSupplier> Supplier { get; set; }

        //Payroll

        public DbSet<CssBenefit> Benefit { get; set; }
        public DbSet<CssCompensation> Compensation { get; set; }
        public DbSet<CssSalary> Salary { get; set; }

        //People

        public DbSet<CssAsignedTo> AsignedTo { get; set; }
        public DbSet<CssEmployee> Employee { get; set; }
        public DbSet<CssPerson> Person { get; set; }
    }
}
