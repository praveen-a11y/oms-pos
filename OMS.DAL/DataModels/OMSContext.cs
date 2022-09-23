using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OMS.Models.Models;

namespace OMS.DAL.DataModels
{
    public partial class OMSContext : DbContext
    {
        public OMSContext()
        {
        }

        public OMSContext(DbContextOptions<OMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BikeConsumptionDetail> BikeConsumptionDetails { get; set; } = null!;
        public virtual DbSet<BikeMaster> BikeMasters { get; set; } = null!;
        public virtual DbSet<CardType> CardTypes { get; set; } = null!;
        public virtual DbSet<CashDrawerLog> CashDrawerLogs { get; set; } = null!;
        public virtual DbSet<CityMaster> CityMasters { get; set; } = null!;
        public virtual DbSet<ComboDetail> ComboDetails { get; set; } = null!;
        public virtual DbSet<ComboMaster> ComboMasters { get; set; } = null!;
        public virtual DbSet<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; set; } = null!;
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; } = null!;
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; } = null!;
        public virtual DbSet<DeliveryBoyMaster> DeliveryBoyMasters { get; set; } = null!;
        public virtual DbSet<DiscountDetail> DiscountDetails { get; set; } = null!;
        public virtual DbSet<DiscountMaster> DiscountMasters { get; set; } = null!;
        public virtual DbSet<FinancialYear> FinancialYears { get; set; } = null!;
        public virtual DbSet<FormMaster> FormMasters { get; set; } = null!;
        public virtual DbSet<ItemBarCode> ItemBarCodes { get; set; } = null!;
        public virtual DbSet<ItemCategoryMapping> ItemCategoryMappings { get; set; } = null!;
        public virtual DbSet<ItemCategoryMaster> ItemCategoryMasters { get; set; } = null!;
        public virtual DbSet<ItemCategoryMasterBackup> ItemCategoryMasterBackups { get; set; } = null!;
        public virtual DbSet<ItemStock> ItemStocks { get; set; } = null!;
        public virtual DbSet<ItemStockDetail> ItemStockDetails { get; set; } = null!;
        public virtual DbSet<ItemSubCategoryMapping> ItemSubCategoryMappings { get; set; } = null!;
        public virtual DbSet<ItemSubCategoryMaster> ItemSubCategoryMasters { get; set; } = null!;
        public virtual DbSet<LoyaltyProgramme> LoyaltyProgrammes { get; set; } = null!;
        public virtual DbSet<LoyaltyProgrammeItem> LoyaltyProgrammeItems { get; set; } = null!;
        public virtual DbSet<MenuMapping> MenuMappings { get; set; } = null!;
        public virtual DbSet<MenuMasterOld> MenuMasterOlds { get; set; } = null!;
        public virtual DbSet<MenuRecepie> MenuRecepies { get; set; } = null!;
        public virtual DbSet<Menumaster> Menumasters { get; set; } = null!;
        public virtual DbSet<MenumasterBackup> MenumasterBackups { get; set; } = null!;
        public virtual DbSet<MenumasterBk> MenumasterBks { get; set; } = null!;
        public virtual DbSet<Menumasterkamal> Menumasterkamals { get; set; } = null!;
        public virtual DbSet<ModifierDetail> ModifierDetails { get; set; } = null!;
        public virtual DbSet<ModifierMaster> ModifierMasters { get; set; } = null!;
        public virtual DbSet<OrderComboDetail> OrderComboDetails { get; set; } = null!;
        public virtual DbSet<OrderDeliveryDetail> OrderDeliveryDetails { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderDetailTest> OrderDetailTests { get; set; } = null!;
        public virtual DbSet<OrderMaster> OrderMasters { get; set; } = null!;
        public virtual DbSet<OrderMaster1> OrderMaster1s { get; set; } = null!;
        public virtual DbSet<OrderMasterTest> OrderMasterTests { get; set; } = null!;
        public virtual DbSet<OrderModifier> OrderModifiers { get; set; } = null!;
        public virtual DbSet<OrderSettlementDetail> OrderSettlementDetails { get; set; } = null!;
        public virtual DbSet<OrderSettlementDetailTest> OrderSettlementDetailTests { get; set; } = null!;
        public virtual DbSet<OutletDiscountMaster> OutletDiscountMasters { get; set; } = null!;
        public virtual DbSet<OutletMaster> OutletMasters { get; set; } = null!;
        public virtual DbSet<OutletSeries> OutletSeries { get; set; } = null!;
        public virtual DbSet<PaymentTypeMaster> PaymentTypeMasters { get; set; } = null!;
        public virtual DbSet<PaymentTypeMasterBk> PaymentTypeMasterBks { get; set; } = null!;
        public virtual DbSet<Posmachine> Posmachines { get; set; } = null!;
        public virtual DbSet<ShiftMaster> ShiftMasters { get; set; } = null!;
        public virtual DbSet<StateMaster> StateMasters { get; set; } = null!;
        public virtual DbSet<StateTaxMapping> StateTaxMappings { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<TaxMaster> TaxMasters { get; set; } = null!;
        public virtual DbSet<TillDenominationsDetail> TillDenominationsDetails { get; set; } = null!;
        public virtual DbSet<TillManagementMaster> TillManagementMasters { get; set; } = null!;
        public virtual DbSet<TillStatus> TillStatuses { get; set; } = null!;
        public virtual DbSet<TimeClock> TimeClocks { get; set; } = null!;
        public virtual DbSet<UnitMaster> UnitMasters { get; set; } = null!;
        public virtual DbSet<UserMaster> UserMasters { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<ZoneMaster> ZoneMasters { get; set; } = null!;

        public virtual DbSet<LoginCheckResponse> LoginCheckResponses { get; set; } = null!;
        public virtual DbSet<ItemListOutletCategoryWise> ItemListOutletCategoryWises { get; set; } = null!;
        public virtual DbSet<OrderResponseModel> OrderResponse { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BikeConsumptionDetail>(entity =>
            {
                entity.HasKey(e => e.BikeConsumptionId);

                entity.ToTable("BikeConsumptionDetail");

                entity.Property(e => e.BikeConsumptionId).ValueGeneratedNever();

                entity.Property(e => e.BikeId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ConsumptionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RatePerKg)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("RatePerKG");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BikeMaster>(entity =>
            {
                entity.HasKey(e => e.BikeId);

                entity.ToTable("BikeMaster");

                entity.Property(e => e.BikeId).ValueGeneratedNever();

                entity.Property(e => e.BikeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BikeColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BikeModel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BikeNumer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CardType>(entity =>
            {
                entity.ToTable("CardType");

                entity.Property(e => e.CardTypeId).ValueGeneratedNever();

                entity.Property(e => e.CardTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CashDrawerLog>(entity =>
            {
                entity.ToTable("CashDrawerLog");

                entity.Property(e => e.CashDrawerLogId).ValueGeneratedNever();

                entity.Property(e => e.CashDrawerOpenTime).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("CityMaster");

                entity.Property(e => e.CityId)
                    .ValueGeneratedNever()
                    .HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ComboDetail>(entity =>
            {
                entity.ToTable("ComboDetail");

                entity.Property(e => e.ComboDetailId).ValueGeneratedNever();

                entity.Property(e => e.ActualPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ComboPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.QuantityKg).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.QuantityNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SellingPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ComboMaster>(entity =>
            {
                entity.HasKey(e => e.ComboId);

                entity.ToTable("ComboMaster");

                entity.Property(e => e.ComboId).ValueGeneratedNever();

                entity.Property(e => e.ComboCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComboDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComboEndDate).HasColumnType("datetime");

                entity.Property(e => e.ComboName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComboStartDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerDeliveryAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.Property(e => e.AddressId).ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("CustomerDetail");

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Reamarks).HasMaxLength(500);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("CustomerMaster");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LandMark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OTP");

                entity.Property(e => e.PasswordOnline)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterdDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DeliveryBoyMaster>(entity =>
            {
                entity.HasKey(e => e.DeliveryBoyId);

                entity.ToTable("DeliveryBoyMaster");

                entity.Property(e => e.DeliveryBoyId)
                    .ValueGeneratedNever()
                    .HasColumnName("DeliveryBoyID");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryBoyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DiscountDetail>(entity =>
            {
                entity.ToTable("DiscountDetail");

                entity.Property(e => e.DiscountDetailId).ValueGeneratedNever();
            });

            modelBuilder.Entity<DiscountMaster>(entity =>
            {
                entity.HasKey(e => e.DiscountId)
                    .HasName("PK_DiscountMaster_DiscountId");

                entity.ToTable("DiscountMaster");

                entity.Property(e => e.DiscountId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderMaxAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderMinAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Percentage).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<FinancialYear>(entity =>
            {
                entity.ToTable("FinancialYear");

                entity.Property(e => e.FinancialYearId).ValueGeneratedNever();

                entity.Property(e => e.FinancialYear1)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("FinancialYear");

                entity.Property(e => e.FinancialYearPrefix)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormMaster>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("PK_Form_Master");

                entity.ToTable("FormMaster");

                entity.Property(e => e.FormId).ValueGeneratedNever();

                entity.Property(e => e.FormDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormGroup)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemBarCode>(entity =>
            {
                entity.ToTable("ItemBarCode");

                entity.Property(e => e.ItemBarCodeId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IsApplicableToHd)
                    .HasColumnName("IsApplicableToHD")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsApplicableToPos)
                    .HasColumnName("IsApplicableToPOS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemBarCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemBarCode");

                entity.Property(e => e.ItemId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MenuId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OutletId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Price1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Price2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Price3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Price4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Price5).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ItemCategoryMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemCategoryMapping");
            });

            modelBuilder.Entity<ItemCategoryMaster>(entity =>
            {
                entity.HasKey(e => e.ItemCategoryId);

                entity.ToTable("ItemCategoryMaster");

                entity.Property(e => e.ItemCategoryId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryPrefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerNameForMrntally)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LedgerNameForMRNTally");

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ItemCategoryMasterBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemCategoryMasterBackup");

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategoryPrefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerNameForMrntally)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LedgerNameForMRNTally");

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ItemStock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.ToTable("ItemStock");

                entity.Property(e => e.StockId).ValueGeneratedNever();

                entity.Property(e => e.ClosingStock).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ClosingValue).HasColumnType("money");

                entity.Property(e => e.OpeningStock).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OpeningValue).HasColumnType("money");
            });

            modelBuilder.Entity<ItemStockDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemStockDetail");

                entity.Property(e => e.IssueQuantity).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ReceivedQuantity).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StockAdjustmentValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemSubCategoryMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemSubCategoryMapping");
            });

            modelBuilder.Entity<ItemSubCategoryMaster>(entity =>
            {
                entity.HasKey(e => e.ItemSubCategoryId);

                entity.ToTable("ItemSubCategoryMaster");

                entity.Property(e => e.ItemSubCategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemSubCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSubCategoryPrefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<LoyaltyProgramme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoyaltyProgramme");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.ModifiedDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProgrammId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProgrammID");

                entity.Property(e => e.ProgrammeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<LoyaltyProgrammeItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Day)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.MaxAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProgrammId).HasColumnName("ProgrammID");

                entity.Property(e => e.ProgrammeItemId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProgrammeItemID");
            });

            modelBuilder.Entity<MenuMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("MenuMapping");

                entity.Property(e => e.MappingId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NetPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProcessedNetPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServiceTaxApplicableOnCh)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ServiceTaxApplicableOn_ch")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MenuMasterOld>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK_MenuMaster_MenuID");

                entity.ToTable("MenuMaster_old");

                entity.Property(e => e.MenuId)
                    .ValueGeneratedNever()
                    .HasColumnName("MenuID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecipeStanderdQty).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.WebSku)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WebSKU");

                entity.Property(e => e.WebUom)
                    .HasMaxLength(50)
                    .HasColumnName("WebUOM");
            });

            modelBuilder.Entity<MenuRecepie>(entity =>
            {
                entity.HasKey(e => e.RecepieId)
                    .HasName("PK_MenuRecepie_RecepieId");

                entity.ToTable("MenuRecepie");

                entity.Property(e => e.RecepieId).ValueGeneratedNever();

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 3)");
            });

            modelBuilder.Entity<Menumaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menumaster");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HSNCode");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemImageBk).HasColumnName("ItemImageBK");

                entity.Property(e => e.ItemImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PktSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeStanderdQty).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.WebSku)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WebSKU");

                entity.Property(e => e.WebUkm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebUom)
                    .HasMaxLength(50)
                    .HasColumnName("WebUOM");

                entity.Property(e => e.Webuse)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenumasterBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MenumasterBackup");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HSNCode");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemImageBk).HasColumnName("ItemImageBK");

                entity.Property(e => e.ItemImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PktSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeStanderdQty).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.WebSku)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WebSKU");

                entity.Property(e => e.WebUkm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebUom)
                    .HasMaxLength(50)
                    .HasColumnName("WebUOM");

                entity.Property(e => e.Webuse)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenumasterBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menumaster_bk");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemImageBk).HasColumnName("ItemImageBK");

                entity.Property(e => e.ItemImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecipeStanderdQty).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.WebSku)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WebSKU");

                entity.Property(e => e.WebUkm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebUom)
                    .HasMaxLength(50)
                    .HasColumnName("WebUOM");

                entity.Property(e => e.Webuse)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menumasterkamal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menumasterkamal");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecipeStanderdQty).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.WebSku)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WebSKU");

                entity.Property(e => e.WebUkm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebUom)
                    .HasMaxLength(50)
                    .HasColumnName("WebUOM");

                entity.Property(e => e.Webuse)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModifierDetail>(entity =>
            {
                entity.ToTable("ModifierDetail");

                entity.Property(e => e.ModifierDetailId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ModifierMaster>(entity =>
            {
                entity.HasKey(e => e.ModifierId);

                entity.ToTable("ModifierMaster");

                entity.Property(e => e.ModifierId).ValueGeneratedNever();

                entity.Property(e => e.ModifierCharges).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ModifierDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifierName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderComboDetail>(entity =>
            {
                entity.ToTable("OrderComboDetail");

                entity.Property(e => e.OrderComboDetailId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<OrderDeliveryDetail>(entity =>
            {
                entity.ToTable("OrderDeliveryDetail");

                entity.Property(e => e.OrderDeliveryDetailId).ValueGeneratedNever();

                entity.Property(e => e.MeterReading)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TranactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderDetailId).ValueGeneratedNever();

                entity.Property(e => e.Cgstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CGSTAmount");

                entity.Property(e => e.Cgstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CGSTPercentage");

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Igstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("IGSTAmount");

                entity.Property(e => e.Igstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("IGSTPercentage");

                entity.Property(e => e.ModifierTotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NetAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sgstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SGSTAmount");

                entity.Property(e => e.Sgstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SGSTPercentage");

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TranactionDate).HasColumnType("datetime");

                entity.Property(e => e.UnitGstPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Utgstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("UTGSTAmount");

                entity.Property(e => e.Utgstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("UTGSTPercentage");
            });

            modelBuilder.Entity<OrderDetailTest>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId)
                    .HasName("PK_OrderDetail_TEST_OrderDetailId");

                entity.ToTable("OrderDetail_TEST");

                entity.Property(e => e.OrderDetailId).ValueGeneratedNever();

                entity.Property(e => e.Cgstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CGSTAmount");

                entity.Property(e => e.Cgstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CGSTPercentage");

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Igstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("IGSTAmount");

                entity.Property(e => e.Igstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("IGSTPercentage");

                entity.Property(e => e.ModifierTotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NetAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sgstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SGSTAmount");

                entity.Property(e => e.Sgstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SGSTPercentage");

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TranactionDate).HasColumnType("datetime");

                entity.Property(e => e.UnitGstPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Utgstamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("UTGSTAmount");

                entity.Property(e => e.Utgstpercentage)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("UTGSTPercentage");
            });

            modelBuilder.Entity<OrderMaster>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.OutletId })
                    .HasName("PK_OrderMaster_OrderId_OutletId");

                entity.ToTable("OrderMaster");

                entity.Property(e => e.OutletId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.BookingTimeTo).HasColumnType("datetime");

                entity.Property(e => e.ChangeGiven).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPay).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kot).HasColumnName("KOT");

                entity.Property(e => e.ModifiedDateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("ModifiedDate_dt");

                entity.Property(e => e.OrderAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDeliverTime).HasColumnType("datetime");

                entity.Property(e => e.OrderDiscount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderGst)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("OrderGST");

                entity.Property(e => e.OrderItemAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderTotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaxDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VoidReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderMaster1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderMaster_1");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BookingTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.BookingTimeTo).HasColumnType("datetime");

                entity.Property(e => e.ChangeGiven).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPay).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kot).HasColumnName("KOT");

                entity.Property(e => e.ModifiedDateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("ModifiedDate_dt");

                entity.Property(e => e.OrderAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutletId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaxDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderMasterTest>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.OutletId })
                    .HasName("PK_OrderMaster_TEST_OrderId_OutletId");

                entity.ToTable("OrderMaster_TEST");

                entity.Property(e => e.OutletId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BookingTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.BookingTimeTo).HasColumnType("datetime");

                entity.Property(e => e.ChangeGiven).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPay).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kot).HasColumnName("KOT");

                entity.Property(e => e.ModifiedDateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("ModifiedDate_dt");

                entity.Property(e => e.OrderAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaxDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderModifier>(entity =>
            {
                entity.ToTable("OrderModifier");

                entity.Property(e => e.OrderModifierId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderSettlementDetail>(entity =>
            {
                entity.ToTable("OrderSettlementDetail");

                entity.Property(e => e.OrderSettlementDetailId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CardExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.CardHolder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderSettlementDetailTest>(entity =>
            {
                entity.HasKey(e => e.OrderSettlementDetailId);

                entity.ToTable("OrderSettlementDetail_TEST");

                entity.Property(e => e.OrderSettlementDetailId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CardExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.CardHolder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutletDiscountMaster>(entity =>
            {
                entity.HasKey(e => e.OutletDiscountId);

                entity.ToTable("OutletDiscountMaster");

                entity.Property(e => e.OutletDiscountId).ValueGeneratedNever();

                entity.Property(e => e.DisPercentage).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<OutletMaster>(entity =>
            {
                entity.HasKey(e => e.OutletId);

                entity.ToTable("OutletMaster");

                entity.Property(e => e.OutletId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BillNumberPrefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DispalyOutletName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosused).HasColumnName("IsPOSUsed");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NewName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OutletName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tinno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TINNo");
            });

            modelBuilder.Entity<OutletSeries>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.OutletPrefix)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentTypeMaster>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId);

                entity.ToTable("PaymentTypeMaster");

                entity.Property(e => e.PaymentTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentTypeMasterBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentTypeMaster_BK");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Posmachine>(entity =>
            {
                entity.HasKey(e => e.PosmachinesId);

                entity.ToTable("POSMachines");

                entity.Property(e => e.PosmachinesId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("POSMachinesID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PosmachineCode)
                    .IsUnicode(false)
                    .HasColumnName("POSMachineCode");

                entity.Property(e => e.PosmachineDescription)
                    .IsUnicode(false)
                    .HasColumnName("POSMachineDescription");

                entity.Property(e => e.PosmachineName)
                    .IsUnicode(false)
                    .HasColumnName("POSMachineName");
            });

            modelBuilder.Entity<ShiftMaster>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("ShiftMaster");

                entity.Property(e => e.ShiftId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.ShiftDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<StateMaster>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("StateMaster");

                entity.Property(e => e.StateId)
                    .ValueGeneratedNever()
                    .HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StateName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StateTaxMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StateTaxMapping");

                entity.Property(e => e.StateId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TaxId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Status");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxMaster>(entity =>
            {
                entity.HasKey(e => e.TaxId)
                    .HasName("TaxMaster_TaxId");

                entity.ToTable("TaxMaster");

                entity.Property(e => e.TaxId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TaxDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TillDenominationsDetail>(entity =>
            {
                entity.ToTable("TillDenominationsDetail");

                entity.Property(e => e.TilldenominationsDetailId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DenominationName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DenominationValue).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TillManagementMaster>(entity =>
            {
                entity.HasKey(e => e.TillManagementId);

                entity.ToTable("TillManagementMaster");

                entity.Property(e => e.TillManagementId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BusinessDateDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("BusinessDate_datetime");

                entity.Property(e => e.InvoiceAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OpeningAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PosmachinesId).HasColumnName("POSMachinesID");

                entity.Property(e => e.TillDenominationsTotalAmount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Variance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VarianceReason)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TillStatus>(entity =>
            {
                entity.ToTable("TillStatus");

                entity.Property(e => e.TillStatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeClock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TimeClock");

                entity.Property(e => e.AttendanceDate).HasColumnType("datetime");

                entity.Property(e => e.ClockType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.ModifiedBy).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.TimeClockId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<UnitMaster>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("UnitMaster");

                entity.Property(e => e.UnitId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserMaster");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("UserRole");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZoneMaster>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK_ZoneMaster_ZoneId");

                entity.ToTable("ZoneMaster");

                entity.Property(e => e.ZoneId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ZoneDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
