using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MainProject
{
    public partial class HospitalAndPharmacyContext : DbContext
    {
        public HospitalAndPharmacyContext()
        {
        }

        public HospitalAndPharmacyContext(DbContextOptions<HospitalAndPharmacyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountsPo> AccountsPos { get; set; } = null!;
        public virtual DbSet<AnaLyzerTestInformation> AnaLyzerTestInformations { get; set; } = null!;
        public virtual DbSet<AnalyzerApi> AnalyzerApis { get; set; } = null!;
        public virtual DbSet<AnalyzerMaster> AnalyzerMasters { get; set; } = null!;
        public virtual DbSet<AnesthesiologistMaster> AnesthesiologistMasters { get; set; } = null!;
        public virtual DbSet<AyaChargeCollectionDetail> AyaChargeCollectionDetails { get; set; } = null!;
        public virtual DbSet<AyaChargeCollectionHead> AyaChargeCollectionHeads { get; set; } = null!;
        public virtual DbSet<AyaChargesMaster> AyaChargesMasters { get; set; } = null!;
        public virtual DbSet<BedCabinType> BedCabinTypes { get; set; } = null!;
        public virtual DbSet<BedMaster> BedMasters { get; set; } = null!;
        public virtual DbSet<CabinMaster> CabinMasters { get; set; } = null!;
        public virtual DbSet<CardMaster> CardMasters { get; set; } = null!;
        public virtual DbSet<ChargeTypeMaster> ChargeTypeMasters { get; set; } = null!;
        public virtual DbSet<CommonTestTable> CommonTestTables { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<DemergingDtl> DemergingDtls { get; set; } = null!;
        public virtual DbSet<DemergingHead> DemergingHeads { get; set; } = null!;
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; } = null!;
        public virtual DbSet<DischargeDetail> DischargeDetails { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<DoctorMaster> DoctorMasters { get; set; } = null!;
        public virtual DbSet<DoctorMedicineAdvice> DoctorMedicineAdvices { get; set; } = null!;
        public virtual DbSet<DoctorPrescriptionDtl> DoctorPrescriptionDtls { get; set; } = null!;
        public virtual DbSet<DoctorPrescriptionHead> DoctorPrescriptionHeads { get; set; } = null!;
        public virtual DbSet<DoctorUnit> DoctorUnits { get; set; } = null!;
        public virtual DbSet<FeeTypeMaster> FeeTypeMasters { get; set; } = null!;
        public virtual DbSet<Hsn> Hsns { get; set; } = null!;
        public virtual DbSet<IndoorCheckupAdviceDtl> IndoorCheckupAdviceDtls { get; set; } = null!;
        public virtual DbSet<IndoorCheckupAdviceHead> IndoorCheckupAdviceHeads { get; set; } = null!;
        public virtual DbSet<IndoorCheckupAdviceInfo> IndoorCheckupAdviceInfos { get; set; } = null!;
        public virtual DbSet<IndoorCheckupAdviceItemParameter> IndoorCheckupAdviceItemParameters { get; set; } = null!;
        public virtual DbSet<IndoorCheckupAdviceLabParameter> IndoorCheckupAdviceLabParameters { get; set; } = null!;
        public virtual DbSet<IndoorCheckupAdviceTestsParameter> IndoorCheckupAdviceTestsParameters { get; set; } = null!;
        public virtual DbSet<IndoorCheckupParameter> IndoorCheckupParameters { get; set; } = null!;
        public virtual DbSet<IpdadvanceCollection> IpdadvanceCollections { get; set; } = null!;
        public virtual DbSet<IpdfeesCollectionHead> IpdfeesCollectionHeads { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryBedDetail> IpdfeesEntryBedDetails { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryHead> IpdfeesEntryHeads { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryLab> IpdfeesEntryLabs { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryLabDetail> IpdfeesEntryLabDetails { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryOtcharge> IpdfeesEntryOtcharges { get; set; } = null!;
        public virtual DbSet<IpdfeesEntrySaveOcharge> IpdfeesEntrySaveOcharges { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryService> IpdfeesEntryServices { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryTestParameter> IpdfeesEntryTestParameters { get; set; } = null!;
        public virtual DbSet<IpdfeesEntryTestParametersDetail> IpdfeesEntryTestParametersDetails { get; set; } = null!;
        public virtual DbSet<ItemWiseSupplier> ItemWiseSuppliers { get; set; } = null!;
        public virtual DbSet<LabFeesEntryDtl> LabFeesEntryDtls { get; set; } = null!;
        public virtual DbSet<LabFeesEntryHead> LabFeesEntryHeads { get; set; } = null!;
        public virtual DbSet<LabMaster> LabMasters { get; set; } = null!;
        public virtual DbSet<LabTestCategory> LabTestCategories { get; set; } = null!;
        public virtual DbSet<MergingDtl> MergingDtls { get; set; } = null!;
        public virtual DbSet<MergingHead> MergingHeads { get; set; } = null!;
        public virtual DbSet<MigrationErrorLog> MigrationErrorLogs { get; set; } = null!;
        public virtual DbSet<MiscellaneousFeesDetail> MiscellaneousFeesDetails { get; set; } = null!;
        public virtual DbSet<MiscellaneousFeesHead> MiscellaneousFeesHeads { get; set; } = null!;
        public virtual DbSet<Module> Modules { get; set; } = null!;
        public virtual DbSet<ModulesPolicyMapping> ModulesPolicyMappings { get; set; } = null!;
        public virtual DbSet<OpdIpdFeesEntryDtl> OpdIpdFeesEntryDtls { get; set; } = null!;
        public virtual DbSet<OpdIpdFeesEntryHead> OpdIpdFeesEntryHeads { get; set; } = null!;
        public virtual DbSet<OpdIpdFeesMaster> OpdIpdFeesMasters { get; set; } = null!;
        public virtual DbSet<OpdipdtestParametersEntryDtl> OpdipdtestParametersEntryDtls { get; set; } = null!;
        public virtual DbSet<OpdipdtestParametersEntryHead> OpdipdtestParametersEntryHeads { get; set; } = null!;
        public virtual DbSet<OtMaster> OtMasters { get; set; } = null!;
        public virtual DbSet<OtTypeMaster> OtTypeMasters { get; set; } = null!;
        public virtual DbSet<Otdetail> Otdetails { get; set; } = null!;
        public virtual DbSet<PatientAdmissionMaster> PatientAdmissionMasters { get; set; } = null!;
        public virtual DbSet<PatientAntenatal> PatientAntenatals { get; set; } = null!;
        public virtual DbSet<PatientCardType> PatientCardTypes { get; set; } = null!;
        public virtual DbSet<PatientGeneralCheckup> PatientGeneralCheckups { get; set; } = null!;
        public virtual DbSet<PatientGyno> PatientGynos { get; set; } = null!;
        public virtual DbSet<PatientRegistration> PatientRegistrations { get; set; } = null!;
        public virtual DbSet<PatientType> PatientTypes { get; set; } = null!;
        public virtual DbSet<PhAccgroup> PhAccgroups { get; set; } = null!;
        public virtual DbSet<PhAccledger> PhAccledgers { get; set; } = null!;
        public virtual DbSet<PhAttrDtl> PhAttrDtls { get; set; } = null!;
        public virtual DbSet<PhAttrHead> PhAttrHeads { get; set; } = null!;
        public virtual DbSet<PhFinAdvance> PhFinAdvances { get; set; } = null!;
        public virtual DbSet<PhFinCbAdjust> PhFinCbAdjusts { get; set; } = null!;
        public virtual DbSet<PhFinCbDtl> PhFinCbDtls { get; set; } = null!;
        public virtual DbSet<PhFinCbHead> PhFinCbHeads { get; set; } = null!;
        public virtual DbSet<PhGrnDtl> PhGrnDtls { get; set; } = null!;
        public virtual DbSet<PhGrnHead> PhGrnHeads { get; set; } = null!;
        public virtual DbSet<PhIndentDtl> PhIndentDtls { get; set; } = null!;
        public virtual DbSet<PhIndentHead> PhIndentHeads { get; set; } = null!;
        public virtual DbSet<PhItemAttr> PhItemAttrs { get; set; } = null!;
        public virtual DbSet<PhItemHead> PhItemHeads { get; set; } = null!;
        public virtual DbSet<PhItemHsnHead> PhItemHsnHeads { get; set; } = null!;
        public virtual DbSet<PhItemOpStock> PhItemOpStocks { get; set; } = null!;
        public virtual DbSet<PhItemdupcheck> PhItemdupchecks { get; set; } = null!;
        public virtual DbSet<PhLocation> PhLocations { get; set; } = null!;
        public virtual DbSet<PhParty> PhParties { get; set; } = null!;
        public virtual DbSet<PhPurBillDtl> PhPurBillDtls { get; set; } = null!;
        public virtual DbSet<PhPurBillHead> PhPurBillHeads { get; set; } = null!;
        public virtual DbSet<PhPurBillItemCharge> PhPurBillItemCharges { get; set; } = null!;
        public virtual DbSet<PhPurOrderDtl> PhPurOrderDtls { get; set; } = null!;
        public virtual DbSet<PhPurOrderHead> PhPurOrderHeads { get; set; } = null!;
        public virtual DbSet<PhPurReturnDtl> PhPurReturnDtls { get; set; } = null!;
        public virtual DbSet<PhPurReturnHead> PhPurReturnHeads { get; set; } = null!;
        public virtual DbSet<PhQuotDtl> PhQuotDtls { get; set; } = null!;
        public virtual DbSet<PhQuotHead> PhQuotHeads { get; set; } = null!;
        public virtual DbSet<PhSalBillDtl> PhSalBillDtls { get; set; } = null!;
        public virtual DbSet<PhSalBillHead> PhSalBillHeads { get; set; } = null!;
        public virtual DbSet<PhSalReturnDtl> PhSalReturnDtls { get; set; } = null!;
        public virtual DbSet<PhSalReturnHead> PhSalReturnHeads { get; set; } = null!;
        public virtual DbSet<PhTaxMaster> PhTaxMasters { get; set; } = null!;
        public virtual DbSet<PhUnit> PhUnits { get; set; } = null!;
        public virtual DbSet<PhWarehouse> PhWarehouses { get; set; } = null!;
        public virtual DbSet<PrescribedMedicine> PrescribedMedicines { get; set; } = null!;
        public virtual DbSet<SaveO2> SaveO2s { get; set; } = null!;
        public virtual DbSet<SisterLogin> SisterLogins { get; set; } = null!;
        public virtual DbSet<SisterNotification> SisterNotifications { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<StockDtl> StockDtls { get; set; } = null!;
        public virtual DbSet<SummarizeTestResult> SummarizeTestResults { get; set; } = null!;
        public virtual DbSet<SystemVariable> SystemVariables { get; set; } = null!;
        public virtual DbSet<TestUnit> TestUnits { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersModulesMapping> UsersModulesMappings { get; set; } = null!;
        public virtual DbSet<WardMaster> WardMasters { get; set; } = null!;
        public virtual DbSet<WardSisterMaster> WardSisterMasters { get; set; } = null!;
        public virtual DbSet<Year> Years { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=DESKTOP-IO0K8OU\\SQL2024; database=HospitalAndPharmacy; User Id=sa; Password=Sovan@123; TrustServerCertificate=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountsPo>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__accounts__0148B3847057CC29");

                entity.ToTable("accounts_pos");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.ChequeNo).HasColumnName("cheque_no");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.CustomerCode).HasColumnName("customer_code");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(500)
                    .HasColumnName("doc_no");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(10)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.IdentifierId).HasColumnName("identifier_id");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(50)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(20)
                    .HasColumnName("patient_type");
            });

            modelBuilder.Entity<AnaLyzerTestInformation>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__AnaLyzer__B773C999179E048A");

                entity.Property(e => e.BarcodeNo).HasMaxLength(255);

                entity.Property(e => e.DoctorPrescriptionDate).HasColumnType("date");

                entity.Property(e => e.DoctorPrescriptionNo).HasMaxLength(255);

                entity.Property(e => e.PatientRegNo).HasMaxLength(255);

                entity.Property(e => e.RecordStatus).HasMaxLength(100);

                entity.Property(e => e.TestCode).HasMaxLength(255);
            });

            modelBuilder.Entity<AnalyzerApi>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__Analyzer__B773C999250A4E63");

                entity.ToTable("AnalyzerApi");

                entity.Property(e => e.BarcodeNo).HasMaxLength(255);

                entity.Property(e => e.PrescriptionNo).HasMaxLength(255);

                entity.Property(e => e.TestCode).HasMaxLength(255);

                entity.Property(e => e.TestResult).HasMaxLength(255);
            });

            modelBuilder.Entity<AnalyzerMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__Analyzer__B773C9998FD2AF50");

                entity.ToTable("AnalyzerMaster");

                entity.HasIndex(e => e.BarcodeNo, "UQ__Analyzer__2192492AD9E8B146")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "UQ__Analyzer__737584F6B5E6077D")
                    .IsUnique();

                entity.HasIndex(e => e.Code, "UQ__Analyzer__A25C5AA794AC0893")
                    .IsUnique();

                entity.Property(e => e.BarcodeNo).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<AnesthesiologistMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__Anesthes__B773C999D025F241");

                entity.ToTable("AnesthesiologistMaster");

                entity.HasIndex(e => e.RegistrationNo, "uk_AnesthesiologistMaster_RegistrationNo")
                    .IsUnique();

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RegistrationNo).HasMaxLength(255);

                entity.Property(e => e.YearOfPassing).HasMaxLength(25);
            });

            modelBuilder.Entity<AyaChargeCollectionDetail>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__AyaCharg__B773C9998CA4884D");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.AyaChargeCollectionDetails)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AyaCharge__AcCod__1B1EE1BE");

                entity.HasOne(d => d.AyaType)
                    .WithMany(p => p.AyaChargeCollectionDetails)
                    .HasForeignKey(d => d.AyaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AyaCharge__AyaTy__0BDC9E2E");

                entity.HasOne(d => d.Head)
                    .WithMany(p => p.AyaChargeCollectionDetails)
                    .HasForeignKey(d => d.HeadId)
                    .HasConstraintName("FK__AyaCharge__HeadI__0CD0C267");
            });

            modelBuilder.Entity<AyaChargeCollectionHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__AyaCharg__B773C9993829473A");

                entity.ToTable("AyaChargeCollectionHead");

                entity.HasOne(d => d.CbCodeNavigation)
                    .WithMany(p => p.AyaChargeCollectionHeads)
                    .HasForeignKey(d => d.CbCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AyaCharge__AcCod__09003183");
            });

            modelBuilder.Entity<AyaChargesMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__AyaCharg__B773C9996040FD79");

                entity.ToTable("AyaChargesMaster");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.AyaChargesMasters)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccLedger_AyaChargesMaster_AcCode");
            });

            modelBuilder.Entity<BedCabinType>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__BedCabin__B773C999286C13AB");

                entity.ToTable("BedCabinType");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.BedCabinTypes)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccLedger_BedCabinType_AcCode");
            });

            modelBuilder.Entity<BedMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__BedMaste__B773C9990F6CC3F7");

                entity.ToTable("BedMaster");

                entity.HasIndex(e => new { e.BedNo, e.WardIdNo }, "uk_BedMaster_BedNo_WardIdNo")
                    .IsUnique();

                entity.Property(e => e.BedNo).HasMaxLength(255);

                entity.HasOne(d => d.BedType)
                    .WithMany(p => p.BedMasters)
                    .HasForeignKey(d => d.BedTypeId)
                    .HasConstraintName("FK__BedMaster__BedTy__3607E224");

                entity.HasOne(d => d.WardIdNoNavigation)
                    .WithMany(p => p.BedMasters)
                    .HasForeignKey(d => d.WardIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_BedMaster_WardIdNo");
            });

            modelBuilder.Entity<CabinMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__CabinMas__B773C999E27C637C");

                entity.ToTable("CabinMaster");

                entity.HasIndex(e => new { e.CabinNo, e.WardIdNo }, "uk_CabinMaster_CabinNo_WardIdNo")
                    .IsUnique();

                entity.Property(e => e.CabinNo).HasMaxLength(255);

                entity.HasOne(d => d.CabinType)
                    .WithMany(p => p.CabinMasters)
                    .HasForeignKey(d => d.CabinTypeId)
                    .HasConstraintName("FK__CabinMast__Cabin__36FC065D");

                entity.HasOne(d => d.WardIdNoNavigation)
                    .WithMany(p => p.CabinMasters)
                    .HasForeignKey(d => d.WardIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CabinMaster_WardIdNo");
            });

            modelBuilder.Entity<CardMaster>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK__card_mas__BDF201DDA75D38FB");

                entity.ToTable("card_master");

                entity.HasIndex(e => e.CardType, "UQ__card_mas__02123CF94E801ED1")
                    .IsUnique();

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CardType)
                    .HasMaxLength(100)
                    .HasColumnName("card_type");
            });

            modelBuilder.Entity<ChargeTypeMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__ChargeTy__B773C99960D83EEB");

                entity.ToTable("ChargeTypeMaster");

                entity.HasIndex(e => e.ChargeTypeName, "uk_ChargeTypeMaster_ChargeTypeName")
                    .IsUnique();

                entity.Property(e => e.ChargeTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<CommonTestTable>(entity =>
            {
                entity.HasKey(e => e.CommonTestId)
                    .HasName("PK__CommonTe__79E0AE848AFE5563");

                entity.ToTable("CommonTestTable");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.CommonTestTables)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK__CommonTes__TestI__041B80D5");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__customer__0148B384271321D5");

                entity.ToTable("customers");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PhoneNo).HasColumnName("phone_no");
            });

            modelBuilder.Entity<DemergingDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__demergin__97D3CABD596554DB");

                entity.ToTable("demerging_dtl");

                entity.HasIndex(e => new { e.HeadIdNo, e.ItemId, e.BatchNo, e.ExpDate }, "uk_demerging_dtl")
                    .IsUnique();

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(100)
                    .HasColumnName("doc_no");

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(100)
                    .HasColumnName("exp_date");

                entity.Property(e => e.HeadIdNo).HasColumnName("head_id_no");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.ReasonsForDemerging).HasColumnName("reasons_for_demerging");

                entity.HasOne(d => d.HeadIdNoNavigation)
                    .WithMany(p => p.DemergingDtls)
                    .HasForeignKey(d => d.HeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_demerging_dtl_head_id_no");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.DemergingDtls)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_demerging_dtl_item_id");
            });

            modelBuilder.Entity<DemergingHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__demergin__0148B384570206C5");

                entity.ToTable("demerging_head");

                entity.HasIndex(e => e.DocNo, "uk_demerging_head_doc_no")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(100)
                    .HasColumnName("doc_no");

                entity.Property(e => e.ReasonsForDemerging).HasColumnName("reasons_for_demerging");
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__departme__0148B38438A07C06");

                entity.ToTable("department_master");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .HasColumnName("category");

                entity.Property(e => e.DeptName).HasColumnName("dept_name");

                entity.Property(e => e.DeptNo).HasColumnName("dept_no");
            });

            modelBuilder.Entity<DischargeDetail>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__Discharg__B773C9990BF99638");

                entity.Property(e => e.IdNo).ValueGeneratedNever();

                entity.Property(e => e.Firno).HasColumnName("FIRNo");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__District__B773C99929BDF187");

                entity.HasIndex(e => new { e.Name, e.StateIdNo }, "uk_Districts_Name_state_id_no")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<DoctorMaster>(entity =>
            {
                entity.HasKey(e => e.DoctorId)
                    .HasName("PK__Doctor_M__2DC00EBF56611C13");

                entity.ToTable("Doctor_Master");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.RegistrationNo).HasColumnName("registration_no");

                entity.Property(e => e.YearOfPassing)
                    .HasMaxLength(4)
                    .HasColumnName("year_of_passing");
            });

            modelBuilder.Entity<DoctorMedicineAdvice>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__Doctor_M__81BCD9CA3F775089");

                entity.ToTable("Doctor_Medicine_Advice");

                entity.Property(e => e.RecId).HasColumnName("Rec_Id");

                entity.Property(e => e.DoctorHeadId).HasColumnName("Doctor_Head_Id");

                entity.Property(e => e.ItemId).HasColumnName("Item_Id");

                entity.Property(e => e.MedicineAdvice).HasColumnName("Medicine_Advice");

                entity.HasOne(d => d.DoctorHead)
                    .WithMany(p => p.DoctorMedicineAdvices)
                    .HasForeignKey(d => d.DoctorHeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_Medicine_Advice_Doctor_Head_Id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.DoctorMedicineAdvices)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_Medicine_Advice_Item_Id");
            });

            modelBuilder.Entity<DoctorPrescriptionDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__Doctor_P__97D3CABDB9569B2C");

                entity.ToTable("Doctor_Prescription_dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.HeadIdNo).HasColumnName("head_id_no");

                entity.Property(e => e.LabMasterIdNo).HasColumnName("lab_master_id_no");

                entity.HasOne(d => d.HeadIdNoNavigation)
                    .WithMany(p => p.DoctorPrescriptionDtls)
                    .HasForeignKey(d => d.HeadIdNo)
                    .HasConstraintName("FK__Doctor_Pr__head___6CE315C2");

                entity.HasOne(d => d.LabMasterIdNoNavigation)
                    .WithMany(p => p.DoctorPrescriptionDtls)
                    .HasForeignKey(d => d.LabMasterIdNo)
                    .HasConstraintName("FK__Doctor_Pr__lab_m__6DD739FB");
            });

            modelBuilder.Entity<DoctorPrescriptionHead>(entity =>
            {
                entity.ToTable("Doctor_Prescription_Head");

                entity.HasIndex(e => e.RegNo, "idx_Doctor_Prescription_Head_reg_no");

                entity.Property(e => e.ActionTaken)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.DescriptionOfDisease).HasColumnName("Description_of_disease");

                entity.Property(e => e.GeneralCheckupId).HasColumnName("General_Checkup_ID");

                entity.Property(e => e.PrescriptionDate).HasColumnType("date");

                entity.Property(e => e.ReVisitDate).HasColumnType("date");

                entity.Property(e => e.RegNo).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.HasOne(d => d.GeneralCheckup)
                    .WithMany(p => p.DoctorPrescriptionHeads)
                    .HasForeignKey(d => d.GeneralCheckupId)
                    .HasConstraintName("FK__Doctor_Pr__Gener__35B2DC69");
            });

            modelBuilder.Entity<DoctorUnit>(entity =>
            {
                entity.ToTable("Doctor_Unit");
            });

            modelBuilder.Entity<FeeTypeMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__FeeTypeM__B773C9997E7E9BEC");

                entity.ToTable("FeeTypeMaster");

                entity.HasIndex(e => e.FeeTypeName, "uk_FeeTypeMaster_FeeTypeName")
                    .IsUnique();

                entity.Property(e => e.FeeTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Hsn>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__hsn__0148B3845D27B4E3");

                entity.ToTable("hsn");

                entity.HasIndex(e => e.HsnCode, "uk_hsn_hsn_code")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.CgstAcCodePur).HasColumnName("cgst_ac_code_pur");

                entity.Property(e => e.CgstAcCodeSal).HasColumnName("cgst_ac_code_sal");

                entity.Property(e => e.CgstPur)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst_pur");

                entity.Property(e => e.CgstSal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst_sal");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(255)
                    .HasColumnName("hsn_code");

                entity.Property(e => e.IgstAcCodePur).HasColumnName("igst_ac_code_pur");

                entity.Property(e => e.IgstAcCodeSal).HasColumnName("igst_ac_code_sal");

                entity.Property(e => e.IgstPur)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst_pur");

                entity.Property(e => e.IgstSal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst_sal");

                entity.Property(e => e.SgstAcCodePur).HasColumnName("sgst_ac_code_pur");

                entity.Property(e => e.SgstAcCodeSal).HasColumnName("sgst_ac_code_sal");

                entity.Property(e => e.SgstPur)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst_pur");

                entity.Property(e => e.SgstSal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst_sal");
            });

            modelBuilder.Entity<IndoorCheckupAdviceDtl>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IndoorCh__B773C999E882F982");

                entity.ToTable("IndoorCheckupAdviceDtl");

                entity.Property(e => e.BedOccupiedFrom).HasColumnType("date");

                entity.Property(e => e.BedOccupiedTo).HasColumnType("date");

                entity.HasOne(d => d.BedMasterIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceDtls)
                    .HasForeignKey(d => d.BedMasterIdNo)
                    .HasConstraintName("fk_IndoorCheckupAdviceDtl_BedMasterIdNo");

                entity.HasOne(d => d.CabinMasterIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceDtls)
                    .HasForeignKey(d => d.CabinMasterIdNo)
                    .HasConstraintName("fk_IndoorCheckupAdviceDtl_CabinMasterIdNo");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceDtls)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceDtl_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.WardSisterMasterIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceDtls)
                    .HasForeignKey(d => d.WardSisterMasterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceDtl_WardSisterMasterIdNo");
            });

            modelBuilder.Entity<IndoorCheckupAdviceHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IndoorCh__B773C9993491A68C");

                entity.ToTable("IndoorCheckupAdviceHead");

                entity.HasIndex(e => e.RefNo, "uk_IndoorCheckupAdviceHead_RefNo")
                    .IsUnique();

                entity.Property(e => e.IsFeesEntryMadeYn)
                    .HasMaxLength(3)
                    .HasColumnName("IsFeesEntryMadeYN")
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.RefNo).HasMaxLength(255);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.IndoorCheckupAdviceHeads)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__IndoorChe__Docto__2F8FEEBF");

                entity.HasOne(d => d.PatientAdmissionMasterIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceHeads)
                    .HasForeignKey(d => d.PatientAdmissionMasterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceHead_PatientAdmissionMasterIdNo");
            });

            modelBuilder.Entity<IndoorCheckupAdviceInfo>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IndoorCh__B773C999DE469181");

                entity.ToTable("IndoorCheckupAdviceInfo");

                entity.Property(e => e.CheckUpDate).HasColumnType("date");

                entity.Property(e => e.CheckupDay).HasMaxLength(255);

                entity.Property(e => e.OtId).HasColumnName("OtID");

                entity.Property(e => e.OtyesNo)
                    .HasMaxLength(3)
                    .HasColumnName("OTYesNo")
                    .HasDefaultValueSql("('No')");

                entity.HasOne(d => d.IndoorCheckupAdviceDtlIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceInfos)
                    .HasForeignKey(d => d.IndoorCheckupAdviceDtlIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceInfo_IndoorCheckupAdviceDtlIdNo");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceInfos)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceInfo_IndoorCheckupAdviceHeadIdNo");
            });

            modelBuilder.Entity<IndoorCheckupAdviceItemParameter>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IndoorCh__B773C9996D94D456");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceItemParameters)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceItemParameters_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IndoorCheckupAdviceInfoIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceItemParameters)
                    .HasForeignKey(d => d.IndoorCheckupAdviceInfoIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceItemParameters_IndoorCheckupAdviceInfoIdNo");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.IndoorCheckupAdviceItemParameters)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceItemParameters_ItemId");
            });

            modelBuilder.Entity<IndoorCheckupAdviceLabParameter>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IndoorCh__B773C9994984751C");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceLabParameters)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IIndoorCheckupAdviceLabParameters_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IndoorCheckupAdviceInfoIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceLabParameters)
                    .HasForeignKey(d => d.IndoorCheckupAdviceInfoIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceLabParameters_IndoorCheckupAdviceInfoIdNo");

                entity.HasOne(d => d.LabMasterIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceLabParameters)
                    .HasForeignKey(d => d.LabMasterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceLabParameters_LabMasterIdNo");
            });

            modelBuilder.Entity<IndoorCheckupAdviceTestsParameter>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IndoorCh__B773C999D64D2FF3");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceTestsParameters)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceTestsParameters_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IndoorCheckupAdviceInfoIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceTestsParameters)
                    .HasForeignKey(d => d.IndoorCheckupAdviceInfoIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceTestsParameters_IndoorCheckupAdviceInfoIdNo");

                entity.HasOne(d => d.TestParameterIdNoNavigation)
                    .WithMany(p => p.IndoorCheckupAdviceTestsParameters)
                    .HasForeignKey(d => d.TestParameterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IndoorCheckupAdviceTestsParameters_TestParameterIdNo");
            });

            modelBuilder.Entity<IndoorCheckupParameter>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__indoor_c__0148B3844A54DB98");

                entity.ToTable("indoor_checkup_parameters");

                entity.HasIndex(e => e.ParameterName, "uk_indoor_checkup_parameters_parameter_name")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(255)
                    .HasColumnName("parameter_name");

                entity.Property(e => e.RatePerHour)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate_per_hour");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.IndoorCheckupParameters)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__indoor_ch__dept___652CE561");
            });

            modelBuilder.Entity<IpdadvanceCollection>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDAdvan__B773C999CE6A736F");

                entity.ToTable("IPDAdvanceCollection");

                entity.HasIndex(e => e.TransactionNo, "UQ__IPDAdvan__554342D99C6704F5")
                    .IsUnique();

                entity.Property(e => e.AdmissionPurpose).HasMaxLength(255);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cbcode).HasColumnName("CBCode");

                entity.Property(e => e.PatientRegNo).HasMaxLength(255);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionNo).HasMaxLength(255);

                entity.HasOne(d => d.CbcodeNavigation)
                    .WithMany(p => p.IpdadvanceCollections)
                    .HasForeignKey(d => d.Cbcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IPDAdvanc__CBCod__2B554987");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.IpdadvanceCollections)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__IPDAdvanc__Docto__2A61254E");

                entity.HasOne(d => d.PatientAdmissionMasterIdNoNavigation)
                    .WithMany(p => p.IpdadvanceCollections)
                    .HasForeignKey(d => d.PatientAdmissionMasterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IPDAdvanc__Patie__2D3D91F9");
            });

            modelBuilder.Entity<IpdfeesCollectionHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesC__B773C9992F2042CA");

                entity.ToTable("IPDFeesCollectionHead");

                entity.HasIndex(e => e.DocNo, "fk_IPDFeesCollectionHead_DocNo")
                    .IsUnique();

                entity.Property(e => e.Amount).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Cbcode).HasColumnName("CBCode");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocNo).HasMaxLength(255);

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.IpdfeesCollectionHeadAcCodeNavigations)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesCollectionHead_AcCode");

                entity.HasOne(d => d.CbcodeNavigation)
                    .WithMany(p => p.IpdfeesCollectionHeadCbcodeNavigations)
                    .HasForeignKey(d => d.Cbcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesCollectionHead_CBCode");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesCollectionHeads)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesCollectionHead_IPDFeesEntryHeadIdNo");
            });

            modelBuilder.Entity<IpdfeesEntryBedDetail>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C999D24303C3");

                entity.ToTable("IPDFeesEntryBedDetails");

                entity.Property(e => e.BedCabinOtid).HasColumnName("bedCabinOTId");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryBedDetails)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .HasConstraintName("FK__IPDFeesEn__IPDFe__5B3966D3");
            });

            modelBuilder.Entity<IpdfeesEntryHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C9995D79C228");

                entity.ToTable("IPDFeesEntryHead");

                entity.Property(e => e.InsertedOn).HasColumnType("date");

                entity.Property(e => e.IsPaymentMadeYn)
                    .HasMaxLength(3)
                    .HasColumnName("IsPaymentMadeYN")
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.NetAmountPaid)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NetAmountPayable)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientRegNo).HasMaxLength(255);

                entity.Property(e => e.RefNo).HasMaxLength(255);

                entity.Property(e => e.TotalChargableAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.IpdfeesEntryHeads)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryHead_AcCode");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryHeads)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryHead_IndoorCheckupAdviceHeadIdNo");
            });

            modelBuilder.Entity<IpdfeesEntryLab>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C9991EC7DB3A");

                entity.ToTable("IPDFeesEntryLab");

                entity.Property(e => e.ActualAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.IpdfeesEntryLabs)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryLab_AcCode");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryLabs)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryLab_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryLabs)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryLab_IPDFeesEntryHeadIdNo");

                entity.HasOne(d => d.LabMasterIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryLabs)
                    .HasForeignKey(d => d.LabMasterIdNo)
                    .HasConstraintName("fk_IPDFeesEntryLab_LabMasterIdNo");
            });

            modelBuilder.Entity<IpdfeesEntryLabDetail>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C9992F8634D3");

                entity.ToTable("IPDFeesEntryLabDetails");

                entity.Property(e => e.ActualAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckUpDate).HasColumnType("date");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.NoOfTest).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryLabDetails)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryLabDetails_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryLabDetails)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryLabDetails_IPDFeesEntryHeadIdNo");

                entity.HasOne(d => d.LabMasterIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryLabDetails)
                    .HasForeignKey(d => d.LabMasterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryLabDetails_LabMasterIdNo");
            });

            modelBuilder.Entity<IpdfeesEntryOtcharge>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C999980611BB");

                entity.ToTable("IPDFeesEntryOTCharge");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.OtdetailsId).HasColumnName("OTDetailsId");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryOtcharges)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .HasConstraintName("FK__IPDFeesEn__IPDFe__0FAD2F12");

                entity.HasOne(d => d.Otdetails)
                    .WithMany(p => p.IpdfeesEntryOtcharges)
                    .HasForeignKey(d => d.OtdetailsId)
                    .HasConstraintName("FK__IPDFeesEn__OTDet__10A1534B");
            });

            modelBuilder.Entity<IpdfeesEntrySaveOcharge>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C999F33BA3BC");

                entity.ToTable("IPDFeesEntrySaveOCharge");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.OtdetailsId).HasColumnName("OTDetailsId");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntrySaveOcharges)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .HasConstraintName("FK__IPDFeesEn__IPDFe__137DBFF6");

                entity.HasOne(d => d.Otdetails)
                    .WithMany(p => p.IpdfeesEntrySaveOcharges)
                    .HasForeignKey(d => d.OtdetailsId)
                    .HasConstraintName("FK__IPDFeesEn__OTDet__1471E42F");
            });

            modelBuilder.Entity<IpdfeesEntryService>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C99966D41EC7");

                entity.ToTable("IPDFeesEntryServices");

                entity.Property(e => e.ActualAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.IpdfeesEntryServices)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryServices_AcCode");

                entity.HasOne(d => d.FeesMasterIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryServices)
                    .HasForeignKey(d => d.FeesMasterIdNo)
                    .HasConstraintName("fk_IPDFeesEntryServices_FeesMasterIdNo");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryServices)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryServices_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryServices)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryServices_IPDFeesEntryHeadIdNo");
            });

            modelBuilder.Entity<IpdfeesEntryTestParameter>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C9992B25C75F");

                entity.ToTable("IPDFeesEntryTestParameters");

                entity.Property(e => e.ActualAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RatePerCount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RatePerHour)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RatePerMinute)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalDurations)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.IpdfeesEntryTestParameters)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryTestParameters_AcCode");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryTestParameters)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryTestParameters_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryTestParameters)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryTestParameters_IPDFeesEntryHeadIdNo");

                entity.HasOne(d => d.TestParameterIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryTestParameters)
                    .HasForeignKey(d => d.TestParameterIdNo)
                    .HasConstraintName("fk_IPDFeesEntryTestParameters_TestParameterIdNo");
            });

            modelBuilder.Entity<IpdfeesEntryTestParametersDetail>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__IPDFeesE__B773C9998E6B8824");

                entity.ToTable("IPDFeesEntryTestParametersDetails");

                entity.Property(e => e.ActualAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CheckUpDate).HasColumnType("date");

                entity.Property(e => e.IpdfeesEntryHeadIdNo).HasColumnName("IPDFeesEntryHeadIdNo");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RatePerCount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RatePerHour)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestTime).HasMaxLength(255);

                entity.Property(e => e.TestTimeFrom).HasMaxLength(255);

                entity.Property(e => e.TestTimeTo).HasMaxLength(255);

                entity.Property(e => e.TotalDurations).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryTestParametersDetails)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryTestParametersDetails_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.IndoorCheckupParameterIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryTestParametersDetails)
                    .HasForeignKey(d => d.IndoorCheckupParameterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryLabDetails_IndoorCheckupParameterIdNo");

                entity.HasOne(d => d.IpdfeesEntryHeadIdNoNavigation)
                    .WithMany(p => p.IpdfeesEntryTestParametersDetails)
                    .HasForeignKey(d => d.IpdfeesEntryHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_IPDFeesEntryTestParametersDetails_IPDFeesEntryHeadIdNo");
            });

            modelBuilder.Entity<ItemWiseSupplier>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__item_wis__97D3CABDD0117B2C");

                entity.ToTable("item_wise_supplier");

                entity.HasIndex(e => new { e.ItemId, e.PartyCode }, "uk_item_wise_supplier")
                    .IsUnique();

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");
            });

            modelBuilder.Entity<LabFeesEntryDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__lab_fees__97D3CABD05ECFD5B");

                entity.ToTable("lab_fees_entry_dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CollectionAcCode).HasColumnName("collection_ac_code");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(255)
                    .HasColumnName("doc_no");

                entity.Property(e => e.HeadIdNo).HasColumnName("head_id_no");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(255)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestIdNo).HasColumnName("test_id_no");

                entity.HasOne(d => d.HeadIdNoNavigation)
                    .WithMany(p => p.LabFeesEntryDtls)
                    .HasForeignKey(d => d.HeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lab_fees_entry_dtl_id_no");

                entity.HasOne(d => d.TestIdNoNavigation)
                    .WithMany(p => p.LabFeesEntryDtls)
                    .HasForeignKey(d => d.TestIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lab_fees_entry_dtl_test_id_no");
            });

            modelBuilder.Entity<LabFeesEntryHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__lab_fees__0148B384B0599C5F");

                entity.ToTable("lab_fees_entry_head");

                entity.HasIndex(e => e.DocNo, "uk_lab_fees_entry_head_doc_no")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.CollectionAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("collection_amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectionCbCode).HasColumnName("collection_cb_code");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("created_on");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(255)
                    .HasColumnName("doc_no");

                entity.Property(e => e.DoctorPrescriptionHeadIdNo).HasColumnName("doctor_prescription_head_id_no");

                entity.Property(e => e.IsPaymentMade)
                    .HasMaxLength(3)
                    .HasColumnName("is_payment_made")
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(255)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(20)
                    .HasColumnName("patient_type");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("total_amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("updated_on");

                entity.HasOne(d => d.DoctorPrescriptionHeadIdNoNavigation)
                    .WithMany(p => p.LabFeesEntryHeads)
                    .HasForeignKey(d => d.DoctorPrescriptionHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_doctor_prescription_head_id_no");
            });

            modelBuilder.Entity<LabMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__lab_mast__0148B3844DF6853F");

                entity.ToTable("lab_master");

                entity.HasIndex(e => e.TestName, "UQ__lab_mast__94D0CA297A7BAA6E")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.TestCharge)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("Test_Charge");

                entity.Property(e => e.TestCode)
                    .HasMaxLength(255)
                    .HasColumnName("test_code");

                entity.Property(e => e.TestName)
                    .HasMaxLength(255)
                    .HasColumnName("test_name");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.LabMasters)
                    .HasForeignKey(d => d.AcCode)
                    .HasConstraintName("fk_lab_master_ac_code");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.LabMasters)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Category_Id");

                entity.HasOne(d => d.TestUnit)
                    .WithMany(p => p.LabMasters)
                    .HasForeignKey(d => d.TestUnitId)
                    .HasConstraintName("Fk_testUnit_lab_master_TestUnitId");
            });

            modelBuilder.Entity<LabTestCategory>(entity =>
            {
                entity.ToTable("lab_Test_Category");

                entity.Property(e => e.TestCategoryName).HasColumnName("Test_CategoryName");
            });

            modelBuilder.Entity<MergingDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__merging___97D3CABDC75035D5");

                entity.ToTable("merging_Dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(255)
                    .HasColumnName("doc_no");

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(100)
                    .HasColumnName("exp_date");

                entity.Property(e => e.HeadIdNo).HasColumnName("head_id_no");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReasonsForMerging).HasColumnName("reasons_for_merging");

                entity.HasOne(d => d.HeadIdNoNavigation)
                    .WithMany(p => p.MergingDtls)
                    .HasForeignKey(d => d.HeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__merging_D__head___4456017B");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.MergingDtls)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__merging_D__item___454A25B4");
            });

            modelBuilder.Entity<MergingHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__merging___0148B3848E2183BF");

                entity.ToTable("merging_head");

                entity.HasIndex(e => e.DocNo, "UQ__merging___8AD0FE5E6FDFDB3C")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(255)
                    .HasColumnName("doc_no");

                entity.Property(e => e.ReasonsForMerging).HasColumnName("reasons_for_merging");
            });

            modelBuilder.Entity<MigrationErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("migration_error_log");

                entity.Property(e => e.ErrorMessage).HasColumnName("error_message");

                entity.Property(e => e.ItemName).HasColumnName("item_name");

                entity.Property(e => e.TableName).HasColumnName("table_name");
            });

            modelBuilder.Entity<MiscellaneousFeesDetail>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__Miscella__B773C999859BB84B");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.MiscellaneousFeesDetails)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Miscellan__AcCod__1936994C");

                entity.HasOne(d => d.Head)
                    .WithMany(p => p.MiscellaneousFeesDetails)
                    .HasForeignKey(d => d.HeadId)
                    .HasConstraintName("FK__Miscellan__HeadI__0347582D");
            });

            modelBuilder.Entity<MiscellaneousFeesHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__Miscella__B773C9998D6A8232");

                entity.ToTable("MiscellaneousFeesHead");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.CbCodeNavigation)
                    .WithMany(p => p.MiscellaneousFeesHeads)
                    .HasForeignKey(d => d.CbCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Miscellan__CbCod__15660868");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.HasKey(e => e.ModuleName)
                    .HasName("PK__module__609F72B84C3454B5");

                entity.ToTable("module");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Category).HasColumnName("category");
            });

            modelBuilder.Entity<ModulesPolicyMapping>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__modules___0148B3841EB8E1E4");

                entity.ToTable("modules_policy_mapping");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.PermissionType)
                    .HasMaxLength(50)
                    .HasColumnName("permission_type");

                entity.Property(e => e.PolicyName).HasColumnName("policy_name");
            });

            modelBuilder.Entity<OpdIpdFeesEntryDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__opd_ipd___97D3CABD33892FA8");

                entity.ToTable("opd_ipd_fees_entry_dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(255)
                    .HasColumnName("doc_no");

                entity.Property(e => e.FeesIdNo).HasColumnName("fees_id_no");

                entity.Property(e => e.HeadIdNo).HasColumnName("head_id_no");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(255)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FeesIdNoNavigation)
                    .WithMany(p => p.OpdIpdFeesEntryDtls)
                    .HasForeignKey(d => d.FeesIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("uk_opd_ipd_fees_entry_dtl_fees_id_no");

                entity.HasOne(d => d.HeadIdNoNavigation)
                    .WithMany(p => p.OpdIpdFeesEntryDtls)
                    .HasForeignKey(d => d.HeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("uk_opd_ipd_fees_entry_dtl_head_id_no");
            });

            modelBuilder.Entity<OpdIpdFeesEntryHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__opd_ipd___0148B38443BBDF17");

                entity.ToTable("opd_ipd_fees_entry_head");

                entity.HasIndex(e => e.DocNo, "uk_opd_ipd_fees_entry_head_doc_no")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("created_on");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(255)
                    .HasColumnName("doc_no");

                entity.Property(e => e.FeeType)
                    .HasMaxLength(255)
                    .HasColumnName("fee_type");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(255)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(20)
                    .HasColumnName("patient_type");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(6)
                    .HasColumnName("payment_status");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("updated_on");
            });

            modelBuilder.Entity<OpdIpdFeesMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__opd_ipd___0148B38403381FBF");

                entity.ToTable("opd_ipd_fees_master");

                entity.HasIndex(e => e.FeesName, "uk_opd_ipd_fees_master_fees_name")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.ChargeTypeIdNo).HasColumnName("charge_type_id_no");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.FeeType)
                    .HasMaxLength(255)
                    .HasColumnName("fee_type");

                entity.Property(e => e.FeeTypeIdNo).HasColumnName("fee_type_id_no");

                entity.Property(e => e.FeesName)
                    .HasMaxLength(255)
                    .HasColumnName("fees_name");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.OpdIpdFeesMasters)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_opd_ipd_fees_master_ac_code");

                entity.HasOne(d => d.ChargeTypeIdNoNavigation)
                    .WithMany(p => p.OpdIpdFeesMasters)
                    .HasForeignKey(d => d.ChargeTypeIdNo)
                    .HasConstraintName("FK__opd_ipd_f__charg__4890A6B3");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.OpdIpdFeesMasters)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__opd_ipd_f__dept___6438C128");

                entity.HasOne(d => d.FeeTypeIdNoNavigation)
                    .WithMany(p => p.OpdIpdFeesMasters)
                    .HasForeignKey(d => d.FeeTypeIdNo)
                    .HasConstraintName("FK__opd_ipd_f__fee_t__479C827A");
            });

            modelBuilder.Entity<OpdipdtestParametersEntryDtl>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__OPDIPDTe__B773C9997E1D3359");

                entity.ToTable("OPDIPDTestParametersEntryDtl");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocNo).HasMaxLength(255);

                entity.Property(e => e.NoOfCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientRegNo).HasMaxLength(255);

                entity.Property(e => e.RatePerCount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.RatePerHour)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalDurations).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRateCountWise)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalRateTimeWise)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.CollectionAcCodeNavigation)
                    .WithMany(p => p.OpdipdtestParametersEntryDtls)
                    .HasForeignKey(d => d.CollectionAcCode)
                    .HasConstraintName("fk_OPDIPDTestParametersEntryDtl_CollectionAcCode");

                entity.HasOne(d => d.HeadIdNoNavigation)
                    .WithMany(p => p.OpdipdtestParametersEntryDtls)
                    .HasForeignKey(d => d.HeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OPDIPDTestParametersEntryDtl_HeadIdNo");

                entity.HasOne(d => d.TestParameterIdNoNavigation)
                    .WithMany(p => p.OpdipdtestParametersEntryDtls)
                    .HasForeignKey(d => d.TestParameterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OPDIPDTestParametersEntryDtl_TestParameterIdNo");
            });

            modelBuilder.Entity<OpdipdtestParametersEntryHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__OPDIPDTe__B773C99900BF751D");

                entity.ToTable("OPDIPDTestParametersEntryHead");

                entity.HasIndex(e => e.DocNo, "UQ__OPDIPDTe__3EF1E0577FAC241F")
                    .IsUnique();

                entity.Property(e => e.CollectionAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectionCbcode).HasColumnName("CollectionCBCode");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocNo).HasMaxLength(255);

                entity.Property(e => e.IsPaymentMade)
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.PatientRegNo).HasMaxLength(255);

                entity.Property(e => e.PatientType).HasMaxLength(20);

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.HasOne(d => d.CollectionCbcodeNavigation)
                    .WithMany(p => p.OpdipdtestParametersEntryHeads)
                    .HasForeignKey(d => d.CollectionCbcode)
                    .HasConstraintName("fk_OPDIPDTestParametersEntryHead_CollectionCBCode");
            });

            modelBuilder.Entity<OtMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__OtMaster__B773C999DB594B87");

                entity.ToTable("OtMaster");

                entity.HasIndex(e => new { e.OtNo, e.WardIdNo }, "uk_OtMaster_WardIdNo_OtNo")
                    .IsUnique();

                entity.Property(e => e.OtNo).HasMaxLength(200);

                entity.HasOne(d => d.OtType)
                    .WithMany(p => p.OtMasters)
                    .HasForeignKey(d => d.OtTypeId)
                    .HasConstraintName("FK__OtMaster__OtType__37F02A96");

                entity.HasOne(d => d.WardIdNoNavigation)
                    .WithMany(p => p.OtMasters)
                    .HasForeignKey(d => d.WardIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OtMaster_WardIdNo");
            });

            modelBuilder.Entity<OtTypeMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__OtTypeMa__B773C99967EDB439");

                entity.ToTable("OtTypeMaster");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.OtTypeMasters)
                    .HasForeignKey(d => d.AcCode)
                    .HasConstraintName("FK_AccLedger_OtTypeMaster_AcCode");
            });

            modelBuilder.Entity<Otdetail>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__OTDetail__B773C999D14EAC94");

                entity.ToTable("OTDetails");

                entity.HasIndex(e => e.RefNo, "uk_OTDetails_RefNo")
                    .IsUnique();

                entity.Property(e => e.Otdate)
                    .HasColumnType("date")
                    .HasColumnName("OTDate");

                entity.Property(e => e.OtendTime).HasColumnName("OTEndTime");

                entity.Property(e => e.Otoutcome)
                    .HasMaxLength(255)
                    .HasColumnName("OTOutcome");

                entity.Property(e => e.OtsisterIdNo).HasColumnName("OTSisterIdNo");

                entity.Property(e => e.OtstartTime).HasColumnName("OTStartTime");

                entity.Property(e => e.RefNo).HasMaxLength(255);

                entity.HasOne(d => d.Anesthesiologist)
                    .WithMany(p => p.Otdetails)
                    .HasForeignKey(d => d.AnesthesiologistId)
                    .HasConstraintName("FK__OTDetails__Anest__0D3AD6BB");

                entity.HasOne(d => d.AsstDoctor)
                    .WithMany(p => p.OtdetailAsstDoctors)
                    .HasForeignKey(d => d.AsstDoctorId)
                    .HasConstraintName("FK__OTDetails__AsstD__0C46B282");

                entity.HasOne(d => d.BedIdNoNavigation)
                    .WithMany(p => p.Otdetails)
                    .HasForeignKey(d => d.BedIdNo)
                    .HasConstraintName("FK__OTDetails__BedId__31783731");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.OtdetailDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OTDetails_DoctorId");

                entity.HasOne(d => d.IndoorCheckupAdviceHeadIdNoNavigation)
                    .WithMany(p => p.Otdetails)
                    .HasForeignKey(d => d.IndoorCheckupAdviceHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OTDetails_IndoorCheckupAdviceHeadIdNo");

                entity.HasOne(d => d.OtType)
                    .WithMany(p => p.Otdetails)
                    .HasForeignKey(d => d.OtTypeId)
                    .HasConstraintName("FK_OtTypeMaster_OTDetails_OtTypeId");

                entity.HasOne(d => d.OtsisterIdNoNavigation)
                    .WithMany(p => p.OtdetailOtsisterIdNoNavigations)
                    .HasForeignKey(d => d.OtsisterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OTDetails_OTSisterIdNo");

                entity.HasOne(d => d.SisterIdNoNavigation)
                    .WithMany(p => p.OtdetailSisterIdNoNavigations)
                    .HasForeignKey(d => d.SisterIdNo)
                    .HasConstraintName("FK__OTDetails__Siste__33607FA3");

                entity.HasOne(d => d.WardIdNoNavigation)
                    .WithMany(p => p.Otdetails)
                    .HasForeignKey(d => d.WardIdNo)
                    .HasConstraintName("FK__OTDetails__WardI__326C5B6A");
            });

            modelBuilder.Entity<PatientAdmissionMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__patient___0148B3845029DF4A");

                entity.ToTable("patient_admission_master");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnType("date")
                    .HasColumnName("admission_date");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BedIdNo).HasColumnName("bed_id_no");

                entity.Property(e => e.CabinIdNo).HasColumnName("cabin_id_no");

                entity.Property(e => e.CauseOfDischarge).HasColumnName("cause_of_discharge");

                entity.Property(e => e.CbCode).HasColumnName("cb_code");

                entity.Property(e => e.CriticalityDuringAdmission).HasColumnName("criticality_during_admission");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DischargeDate)
                    .HasColumnType("date")
                    .HasColumnName("discharge_date");

                entity.Property(e => e.ImageUrl).HasColumnName("image_url");

                entity.Property(e => e.PatientRegNo).HasColumnName("patient_reg_no");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.WardIdNo).HasColumnName("ward_id_no");

                entity.Property(e => e.WardSisterId).HasColumnName("ward_sister_id");

                entity.HasOne(d => d.BedIdNoNavigation)
                    .WithMany(p => p.PatientAdmissionMasters)
                    .HasForeignKey(d => d.BedIdNo)
                    .HasConstraintName("fk_admission_counter_bed_id_no");

                entity.HasOne(d => d.CabinIdNoNavigation)
                    .WithMany(p => p.PatientAdmissionMasters)
                    .HasForeignKey(d => d.CabinIdNo)
                    .HasConstraintName("fk_admission_counter_cabin_id_no");

                entity.HasOne(d => d.WardIdNoNavigation)
                    .WithMany(p => p.PatientAdmissionMasters)
                    .HasForeignKey(d => d.WardIdNo)
                    .HasConstraintName("fk_admission_counter_ward_id_no");

                entity.HasOne(d => d.WardSister)
                    .WithMany(p => p.PatientAdmissionMasters)
                    .HasForeignKey(d => d.WardSisterId)
                    .HasConstraintName("FK__patient_a__ward___308412F8");
            });

            modelBuilder.Entity<PatientAntenatal>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__patient___0148B384DB858824");

                entity.ToTable("patient_antenatal");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.Abo).HasColumnName("abo");

                entity.Property(e => e.Allergy)
                    .HasMaxLength(3)
                    .HasColumnName("allergy");

                entity.Property(e => e.Anemia)
                    .HasMaxLength(3)
                    .HasColumnName("anemia");

                entity.Property(e => e.BloodGroup).HasColumnName("blood_group");

                entity.Property(e => e.BloodLoss)
                    .HasMaxLength(20)
                    .HasColumnName("blood_loss");

                entity.Property(e => e.CardioVascularSystem).HasColumnName("cardio_vascular_system");

                entity.Property(e => e.Contraception).HasColumnName("contraception");

                entity.Property(e => e.CurrentMedications).HasColumnName("current_medications");

                entity.Property(e => e.CurrentPregnencyProblems).HasColumnName("current_pregnency_problems");

                entity.Property(e => e.Dysmenorrhoea).HasColumnName("dysmenorrhoea");

                entity.Property(e => e.Dyspareunia)
                    .HasMaxLength(20)
                    .HasColumnName("dyspareunia");

                entity.Property(e => e.Edd).HasColumnName("edd");

                entity.Property(e => e.EddByUsg).HasColumnName("edd_by_usg");

                entity.Property(e => e.Edema)
                    .HasMaxLength(3)
                    .HasColumnName("edema");

                entity.Property(e => e.FamilyHistory).HasColumnName("family_history");

                entity.Property(e => e.GeneralCheckUpIdNo).HasColumnName("general_check_up_id_no");

                entity.Property(e => e.GraviraExistsNotexists)
                    .HasMaxLength(3)
                    .HasColumnName("gravira_exists_notexists");

                entity.Property(e => e.HbPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("hb_perc");

                entity.Property(e => e.HbsAg).HasColumnName("hbs_ag");

                entity.Property(e => e.Heart).HasColumnName("heart");

                entity.Property(e => e.Hiv).HasColumnName("hiv");

                entity.Property(e => e.HusbandsBloodGroup).HasColumnName("husbands_blood_group");

                entity.Property(e => e.LastPregnancy).HasColumnName("last_pregnancy");

                entity.Property(e => e.Lcb).HasColumnName("lcb");

                entity.Property(e => e.LivingChildren).HasColumnName("living_children");

                entity.Property(e => e.Lmp).HasColumnName("lmp");

                entity.Property(e => e.Lungs).HasColumnName("lungs");

                entity.Property(e => e.MedicalSurgicalHistory).HasColumnName("medical_surgical_history");

                entity.Property(e => e.MenstrualCycle).HasColumnName("menstrual_cycle");

                entity.Property(e => e.ObstetricExaminations).HasColumnName("obstetric_examinations");

                entity.Property(e => e.OtherTypeOfAllergy).HasColumnName("other_type_of_allergy");

                entity.Property(e => e.Para).HasColumnName("para");

                entity.Property(e => e.PastIllness).HasColumnName("past_illness");

                entity.Property(e => e.PastMedication).HasColumnName("past_medication");

                entity.Property(e => e.PastObstetricHistory).HasColumnName("past_obstetric_history");

                entity.Property(e => e.PatientRegNo).HasColumnName("patient_reg_no");

                entity.Property(e => e.RespiratorySystem).HasColumnName("respiratory_system");

                entity.Property(e => e.Rh).HasColumnName("rh");

                entity.Property(e => e.SugarFasting).HasColumnName("sugar_fasting");

                entity.Property(e => e.SugarPp).HasColumnName("sugar_pp");

                entity.Property(e => e.Tsh).HasColumnName("tsh");

                entity.Property(e => e.TypeOfAllergy).HasColumnName("type_of_allergy");

                entity.Property(e => e.UsgFinding).HasColumnName("usg_finding");

                entity.Property(e => e.Vdrl).HasColumnName("vdrl");

                entity.HasOne(d => d.GeneralCheckUpIdNoNavigation)
                    .WithMany(p => p.PatientAntenatals)
                    .HasForeignKey(d => d.GeneralCheckUpIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_patient_antenatal_general_check_up_id_no");
            });

            modelBuilder.Entity<PatientCardType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("patient_card_type");

                entity.Property(e => e.Cardname).HasColumnName("cardname");

                entity.Property(e => e.IdNo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_no");
            });

            modelBuilder.Entity<PatientGeneralCheckup>(entity =>
            {
                entity.ToTable("patient_general_checkup");

                entity.Property(e => e.BloodPressure)
                    .HasMaxLength(10)
                    .HasColumnName("Blood_Pressure");

                entity.Property(e => e.CheckupDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.Height).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RegId).HasColumnName("Reg_Id");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.Property(e => e.Weight).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PatientGeneralCheckups)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__patient_g__Docto__396371BC");

                entity.HasOne(d => d.Reg)
                    .WithMany(p => p.PatientGeneralCheckups)
                    .HasForeignKey(d => d.RegId)
                    .HasConstraintName("FK__patient_g__Reg_I__3A5795F5");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PatientGeneralCheckups)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK__patient_g__UnitI__3B4BBA2E");
            });

            modelBuilder.Entity<PatientGyno>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__patient___0148B384E39D5911");

                entity.ToTable("patient_gyno");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.Allergy)
                    .HasMaxLength(3)
                    .HasColumnName("allergy")
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.BloodLoss)
                    .HasMaxLength(15)
                    .HasColumnName("blood_loss");

                entity.Property(e => e.CardiovascularSystem).HasColumnName("cardiovascular_system");

                entity.Property(e => e.Cns).HasColumnName("cns");

                entity.Property(e => e.Contraception).HasColumnName("contraception");

                entity.Property(e => e.Dyspareunia)
                    .HasMaxLength(15)
                    .HasColumnName("dyspareunia");

                entity.Property(e => e.GeneralCheckUpIdNo).HasColumnName("general_check_up_id_no");

                entity.Property(e => e.GeneralComplaints).HasColumnName("general_complaints");

                entity.Property(e => e.Lcb).HasColumnName("lcb");

                entity.Property(e => e.LivingChildren).HasColumnName("living_children");

                entity.Property(e => e.Lmp).HasColumnName("lmp");

                entity.Property(e => e.Medications).HasColumnName("medications");

                entity.Property(e => e.MenstrualCycle).HasColumnName("menstrual_cycle");

                entity.Property(e => e.OtherTypeOfAllergy).HasColumnName("other_type_of_allergy");

                entity.Property(e => e.Para).HasColumnName("para");

                entity.Property(e => e.PastIllness).HasColumnName("past_illness");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(255)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.RespiratorySystem).HasColumnName("respiratory_system");

                entity.Property(e => e.TypeOfAllergy)
                    .HasMaxLength(100)
                    .HasColumnName("type_of_allergy");

                entity.HasOne(d => d.GeneralCheckUpIdNoNavigation)
                    .WithMany(p => p.PatientGynos)
                    .HasForeignKey(d => d.GeneralCheckUpIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_patient_gyno_general_check_up_id_no");
            });

            modelBuilder.Entity<PatientRegistration>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__patient___0148B38426302394");

                entity.ToTable("patient_registrations");

                entity.HasIndex(e => e.DeptId, "ind_patient_registrations_dept_id");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FamilyIncome)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("family_income")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Gurdian).HasColumnName("gurdian");

                entity.Property(e => e.GurdianEmail).HasColumnName("gurdian_email");

                entity.Property(e => e.GurdianMobile).HasColumnName("gurdian_mobile");

                entity.Property(e => e.GurdianOccupation).HasColumnName("gurdian_occupation");

                entity.Property(e => e.ImuRegNo).HasColumnName("imu_reg_no");

                entity.Property(e => e.MainRegDate)
                    .HasColumnType("date")
                    .HasColumnName("main_reg_date");

                entity.Property(e => e.MainRegNo).HasColumnName("main_reg_no");

                entity.Property(e => e.MaritalStatus).HasColumnName("marital_status");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Occupation).HasColumnName("occupation");

                entity.Property(e => e.OldRegNo).HasColumnName("old_reg_no");

                entity.Property(e => e.PatientCardTypeId).HasColumnName("patient_card_type_id");

                entity.Property(e => e.PatientTypeId).HasColumnName("patient_type_id");

                entity.Property(e => e.PermanantAddress).HasColumnName("permanant_Address");

                entity.Property(e => e.PresentAddress).HasColumnName("present_address");

                entity.Property(e => e.RelationWithGurdian).HasColumnName("relation_with_gurdian");

                entity.Property(e => e.Religion).HasColumnName("religion");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.Property(e => e.Zip).HasColumnName("zip");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.PatientRegistrations)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK__patient_r__Distr__2235F3A1");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PatientRegistrations)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__patient_r__Docto__259C7031");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.PatientRegistrations)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__patient_r__State__2141CF68");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PatientRegistrations)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK__patient_r__UnitI__2690946A");
            });

            modelBuilder.Entity<PatientType>(entity =>
            {
                entity.ToTable("patient_type");

                entity.Property(e => e.PatientTypeId).HasColumnName("patient_type_id");

                entity.Property(e => e.ConcessionPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("concession_perc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientTypeName).HasColumnName("patient_type_name");
            });

            modelBuilder.Entity<PhAccgroup>(entity =>
            {
                entity.HasKey(e => e.GroupCode)
                    .HasName("PK__ph_accgr__05AF4D1497247FFE");

                entity.ToTable("ph_accgroup");

                entity.Property(e => e.GroupCode).HasColumnName("GROUP_CODE");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .HasColumnName("GROUP_NAME");

                entity.Property(e => e.ParGroupCode).HasColumnName("PAR_GROUP_CODE");

                entity.HasOne(d => d.ParGroupCodeNavigation)
                    .WithMany(p => p.InverseParGroupCodeNavigation)
                    .HasForeignKey(d => d.ParGroupCode)
                    .HasConstraintName("FK_PH_ACCGRP_PAR_GROUP_CODE");
            });

            modelBuilder.Entity<PhAccledger>(entity =>
            {
                entity.HasKey(e => e.AcCode)
                    .HasName("PK__ph_accle__A496B64D6F930076");

                entity.ToTable("ph_accledger");

                entity.Property(e => e.AcCode).HasColumnName("AC_CODE");

                entity.Property(e => e.AcName)
                    .HasMaxLength(100)
                    .HasColumnName("AC_NAME");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(30)
                    .HasColumnName("account_no");

                entity.Property(e => e.Add1).HasMaxLength(100);

                entity.Property(e => e.Add2).HasMaxLength(100);

                entity.Property(e => e.BankNature).HasMaxLength(10);

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .HasColumnName("branch");

                entity.Property(e => e.BrsCode)
                    .HasMaxLength(30)
                    .HasColumnName("brs_code");

                entity.Property(e => e.Category)
                    .HasMaxLength(2)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .HasColumnName("contact_person");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.GroupCode).HasColumnName("GROUP_CODE");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(20)
                    .HasColumnName("ifsc_code");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .HasColumnName("mobile");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.Pin)
                    .HasMaxLength(100)
                    .HasColumnName("pin");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(2)
                    .HasColumnName("SCHEDULE");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .HasColumnName("state");

                entity.Property(e => e.TaxStructure)
                    .HasMaxLength(10)
                    .HasColumnName("tax_structure");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .HasColumnName("website");
            });

            modelBuilder.Entity<PhAttrDtl>(entity =>
            {
                entity.HasKey(e => e.DtlId)
                    .HasName("PK__ph_attr___E7960B8E5F404DCB");

                entity.ToTable("ph_attr_dtl");

                entity.HasIndex(e => new { e.AttrId, e.AttrValue }, "uk_ph_attr_dtl_attr_id_value")
                    .IsUnique();

                entity.Property(e => e.DtlId).HasColumnName("dtl_id");

                entity.Property(e => e.AttrId).HasColumnName("attr_id");

                entity.Property(e => e.AttrValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("attr_value");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(100)
                    .HasColumnName("deleted_by");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("date")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(3)
                    .HasColumnName("is_deleted");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.PhAttrDtls)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ph_attr_dtl_attr_id");
            });

            modelBuilder.Entity<PhAttrHead>(entity =>
            {
                entity.HasKey(e => e.AttrId)
                    .HasName("PK__ph_attr___FC9D0A07C4311C23");

                entity.ToTable("ph_attr_head");

                entity.HasIndex(e => e.AttrName, "uk_ph_attr_head")
                    .IsUnique();

                entity.Property(e => e.AttrId).HasColumnName("attr_id");

                entity.Property(e => e.AttrName)
                    .HasMaxLength(100)
                    .HasColumnName("attr_name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(100)
                    .HasColumnName("deleted_by");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("date")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(3)
                    .HasColumnName("is_deleted");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<PhFinAdvance>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__PH_FIN_A__23B2A19AB47F2999");

                entity.ToTable("PH_FIN_ADVANCE");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.AccountsAdjAmt)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("ACCOUNTS_ADJ_AMT");

                entity.Property(e => e.AdvanceType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADVANCE_TYPE");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.CbDtlRecId).HasColumnName("CB_DTL_REC_ID");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("DOC_DATE");

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOC_NO");

                entity.Property(e => e.PartyCode).HasColumnName("PARTY_CODE");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("reg_no");

                entity.HasOne(d => d.CbDtlRec)
                    .WithMany(p => p.PhFinAdvances)
                    .HasForeignKey(d => d.CbDtlRecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVANCE_CB_DTL_REC_ID");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.PhFinAdvances)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ADVANCE_DOC_ID");
            });

            modelBuilder.Entity<PhFinCbAdjust>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_fin_c__23B2A19ADE400557");

                entity.ToTable("ph_fin_cb_adjust");

                entity.HasIndex(e => new { e.DocId, e.VchId, e.VchType }, "UK_CB_ADJUST")
                    .IsUnique();

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("DOC_DATE");

                entity.Property(e => e.DocId).HasColumnName("DOC_ID");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(100)
                    .HasColumnName("DOC_NO");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.Sign)
                    .HasMaxLength(4)
                    .HasColumnName("SIGN");

                entity.Property(e => e.VchId).HasColumnName("VCH_ID");

                entity.Property(e => e.VchModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("vch_module_name");

                entity.Property(e => e.VchType)
                    .HasMaxLength(50)
                    .HasColumnName("VCH_TYPE");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.PhFinCbAdjusts)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CB_ADJUST_DOC_ID");
            });

            modelBuilder.Entity<PhFinCbDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_fin_c__97D3CABDBC12B5A4");

                entity.ToTable("ph_fin_cb_dtl");

                entity.HasIndex(e => new { e.DocId, e.AcCode, e.PartyCode }, "uk1_cb_dtl")
                    .IsUnique();

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.AdjType)
                    .HasMaxLength(50)
                    .HasColumnName("adj_type");

                entity.Property(e => e.CbCode).HasColumnName("cb_code");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.CustomerCode).HasColumnName("customer_code");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(100)
                    .HasColumnName("doc_no");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(10)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(50)
                    .HasColumnName("patient_type");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .HasColumnName("reg_no");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.PhFinCbDtlAcCodeNavigations)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cb_dtl_ac_code");

                entity.HasOne(d => d.CbCodeNavigation)
                    .WithMany(p => p.PhFinCbDtlCbCodeNavigations)
                    .HasForeignKey(d => d.CbCode)
                    .HasConstraintName("fk_cb_dtl_cb_code");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.PhFinCbDtls)
                    .HasForeignKey(d => d.CustomerCode)
                    .HasConstraintName("FK__ph_fin_cb__custo__6EEB59C5");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.PhFinCbDtls)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cb_dtl_doc_id");
            });

            modelBuilder.Entity<PhFinCbHead>(entity =>
            {
                entity.HasKey(e => e.DocId)
                    .HasName("PK__ph_fin_c__8AD0292463333E70");

                entity.ToTable("ph_fin_cb_head");

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.CbCode).HasColumnName("cb_code");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(100)
                    .HasColumnName("doc_no");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");
            });

            modelBuilder.Entity<PhGrnDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_grn_d__23B2A19A67F148F5");

                entity.ToTable("ph_grn_dtl");

                entity.HasIndex(e => new { e.GrnId, e.ItemId, e.PodtlRecId }, "UK_GRN_DTL")
                    .IsUnique();

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("BATCH_NO");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("date")
                    .HasColumnName("EXP_DATE");

                entity.Property(e => e.FromOrderAdhoc)
                    .HasMaxLength(5)
                    .HasColumnName("FROM_ORDER_ADHOC");

                entity.Property(e => e.GrnDate)
                    .HasColumnType("date")
                    .HasColumnName("GRN_DATE");

                entity.Property(e => e.GrnId).HasColumnName("GRN_ID");

                entity.Property(e => e.GrnNo)
                    .HasMaxLength(100)
                    .HasColumnName("GRN_NO");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.MfgDate)
                    .HasColumnType("date")
                    .HasColumnName("MFG_DATE");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("MODULE_NAME");

                entity.Property(e => e.PartyCode).HasColumnName("PARTY_CODE");

                entity.Property(e => e.PbQtyAdj)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("PB_QTY_ADJ");

                entity.Property(e => e.PodtlRecId).HasColumnName("PODTL_REC_ID");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("QTY");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.Property(e => e.WhId).HasColumnName("WH_ID");

                entity.HasOne(d => d.Grn)
                    .WithMany(p => p.PhGrnDtls)
                    .HasForeignKey(d => d.GrnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRN_DTL_GRN_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhGrnDtls)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRN_DTL_ITEM_ID");

                entity.HasOne(d => d.ModuleNameNavigation)
                    .WithMany(p => p.PhGrnDtls)
                    .HasForeignKey(d => d.ModuleName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRN_DTL_MODULE");

                entity.HasOne(d => d.PartyCodeNavigation)
                    .WithMany(p => p.PhGrnDtls)
                    .HasForeignKey(d => d.PartyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRN_DTL_PARTY_CODE");

                entity.HasOne(d => d.PodtlRec)
                    .WithMany(p => p.PhGrnDtls)
                    .HasForeignKey(d => d.PodtlRecId)
                    .HasConstraintName("FK_GRN_DTL_PODTL_REC_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PhGrnDtls)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRN_DTL_UNIT_CODE");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.PhGrnDtls)
                    .HasForeignKey(d => d.WhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRN_DTL_WH_ID");
            });

            modelBuilder.Entity<PhGrnHead>(entity =>
            {
                entity.HasKey(e => e.GrnId)
                    .HasName("PK__ph_grn_h__ACCC6B89093DC6EC");

                entity.ToTable("ph_grn_head");

                entity.HasIndex(e => e.GrnNo, "UK_GRN_HEAD_GRN_NO")
                    .IsUnique();

                entity.Property(e => e.GrnId).HasColumnName("GRN_ID");

                entity.Property(e => e.FromOrderAdhoc)
                    .HasMaxLength(5)
                    .HasColumnName("FROM_ORDER_ADHOC");

                entity.Property(e => e.GatepassEntryDate)
                    .HasColumnType("date")
                    .HasColumnName("GATEPASS_ENTRY_DATE");

                entity.Property(e => e.GatepassEntryTime)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("GATEPASS_ENTRY_TIME");

                entity.Property(e => e.GatepassSlipNo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GATEPASS_SLIP_NO");

                entity.Property(e => e.GrnDate)
                    .HasColumnType("date")
                    .HasColumnName("GRN_DATE");

                entity.Property(e => e.GrnNo)
                    .HasMaxLength(100)
                    .HasColumnName("GRN_NO");

                entity.Property(e => e.LrNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LR_NO");

                entity.Property(e => e.LrNote)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LR_NOTE");

                entity.Property(e => e.PartyCode).HasColumnName("PARTY_CODE");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.HasOne(d => d.PartyCodeNavigation)
                    .WithMany(p => p.PhGrnHeads)
                    .HasForeignKey(d => d.PartyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRN_HEAD_PARTY_CODE");
            });

            modelBuilder.Entity<PhIndentDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_inden__97D3CABD9B5E6834");

                entity.ToTable("ph_indent_dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AppliedToPo)
                    .HasMaxLength(3)
                    .HasColumnName("applied_to_po")
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.IndentDate)
                    .HasColumnType("date")
                    .HasColumnName("indent_date");

                entity.Property(e => e.IndentHeadIdNo).HasColumnName("indent_head_id_no");

                entity.Property(e => e.IndentNo)
                    .HasMaxLength(100)
                    .HasColumnName("indent_no");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.QuotDtlRecId).HasColumnName("quot_dtl_rec_id");

                entity.Property(e => e.QuotHeadIdNo).HasColumnName("quot_head_id_no");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.SendToPo)
                    .HasMaxLength(3)
                    .HasColumnName("send_to_po")
                    .HasDefaultValueSql("('No')");

                entity.HasOne(d => d.IndentHeadIdNoNavigation)
                    .WithMany(p => p.PhIndentDtls)
                    .HasForeignKey(d => d.IndentHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_indent_dtl_head_id_no");

                entity.HasOne(d => d.QuotDtlRec)
                    .WithMany(p => p.PhIndentDtls)
                    .HasForeignKey(d => d.QuotDtlRecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_indent_dtl_quot_dtl_rec_id");

                entity.HasOne(d => d.QuotHeadIdNoNavigation)
                    .WithMany(p => p.PhIndentDtls)
                    .HasForeignKey(d => d.QuotHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_indent_dtl_quot_head_id_no");
            });

            modelBuilder.Entity<PhIndentHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__ph_inden__0148B384F36FD29C");

                entity.ToTable("ph_indent_head");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.IndentDate)
                    .HasColumnType("date")
                    .HasColumnName("indent_date");

                entity.Property(e => e.IndentNo)
                    .HasMaxLength(100)
                    .HasColumnName("indent_no");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");
            });

            modelBuilder.Entity<PhItemAttr>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_item___97D3CABDC47CF783");

                entity.ToTable("ph_item_attr");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.AttrDtlId).HasColumnName("attr_dtl_id");

                entity.Property(e => e.AttrId).HasColumnName("attr_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.HasOne(d => d.AttrDtl)
                    .WithMany(p => p.PhItemAttrs)
                    .HasForeignKey(d => d.AttrDtlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ph_item_attr_attr_dtl_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhItemAttrs)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ph_item_attr_item_id");
            });

            modelBuilder.Entity<PhItemHead>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__PH_ITEM___ADFD89A0A8644839");

                entity.ToTable("PH_ITEM_HEAD");

                entity.HasIndex(e => e.HsnCode, "ind_ph_item_head_item");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .HasColumnName("hsn_code");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .HasColumnName("ITEM_NAME");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("MAX_LEVEL");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("MIN_LEVEL");

                entity.Property(e => e.OnValuePrice)
                    .HasMaxLength(10)
                    .HasColumnName("on_value_price");

                entity.Property(e => e.Prate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("PRATE");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("REORDER_LEVEL");

                entity.Property(e => e.Srate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("SRATE");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PhItemHeads)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PH_ITEM_HEAD_UNIT_CODE");
            });

            modelBuilder.Entity<PhItemHsnHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__ph_item___0148B38447DEA660");

                entity.ToTable("ph_item_hsn_head");

                entity.HasIndex(e => e.ItemId, "uk_ph_item_hsn_head")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.CgstPur)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst_pur");

                entity.Property(e => e.CgstSal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst_sal");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .HasColumnName("hsn_code");

                entity.Property(e => e.IgstPur)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst_pur");

                entity.Property(e => e.IgstSal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst_sal");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.SgstPur)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst_pur");

                entity.Property(e => e.SgstSal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst_sal");
            });

            modelBuilder.Entity<PhItemOpStock>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__ph_item___0148B384A9AF78CC");

                entity.ToTable("ph_item_op_stock");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.BatchNo).HasColumnName("batch_no");

                entity.Property(e => e.ExpDate).HasColumnName("exp_date");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.OpStock)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("op_stock");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("value");

                entity.Property(e => e.WhId).HasColumnName("wh_id");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.PhItemOpStocks)
                    .HasForeignKey(d => d.WhId)
                    .HasConstraintName("fk_ph_item_op_stock");
            });

            modelBuilder.Entity<PhItemdupcheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ph_itemdupcheck");

                entity.Property(e => e.BarcodeNo)
                    .HasMaxLength(20)
                    .HasColumnName("BARCODE_NO");

                entity.Property(e => e.BarcodeYesNo)
                    .HasMaxLength(3)
                    .HasColumnName("BARCODE_YES_NO");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .HasColumnName("hsn_code");

                entity.Property(e => e.ItemDesc).HasColumnName("ITEM_DESC");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .HasColumnName("ITEM_NAME");

                entity.Property(e => e.MaintainInBatches)
                    .HasMaxLength(3)
                    .HasColumnName("MAINTAIN_IN_BATCHES");

                entity.Property(e => e.Prate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("PRATE");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("REORDER_LEVEL");

                entity.Property(e => e.Srate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("SRATE");

                entity.Property(e => e.UnitCode).HasColumnName("UNIT_CODE");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(100)
                    .HasColumnName("UNIT_NAME");
            });

            modelBuilder.Entity<PhLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__ph_locat__D2263B8ECF7EFC90");

                entity.ToTable("ph_location");

                entity.HasIndex(e => e.LocationName, "PH_INV_LOC_LOC_NAME")
                    .IsUnique();

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.ParentLocationId).HasColumnName("PARENT_LOCATION_ID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.HasOne(d => d.ParentLocation)
                    .WithMany(p => p.InverseParentLocation)
                    .HasForeignKey(d => d.ParentLocationId)
                    .HasConstraintName("FK_INV_LOC_PAR_LOC_ID");
            });

            modelBuilder.Entity<PhParty>(entity =>
            {
                entity.HasKey(e => e.PartyCode)
                    .HasName("PK__ph_party__7A08FDEBDB7332D2");

                entity.ToTable("ph_party");

                entity.Property(e => e.PartyCode).HasColumnName("PARTY_CODE");

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .HasColumnName("ADD1");

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .HasColumnName("ADD2");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("CITY");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Dist)
                    .HasMaxLength(100)
                    .HasColumnName("DIST");

                entity.Property(e => e.DrugLicenceNo).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.GstNo)
                    .HasMaxLength(100)
                    .HasColumnName("GST_NO");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.PanNo)
                    .HasMaxLength(50)
                    .HasColumnName("PAN_NO");

                entity.Property(e => e.PartyName)
                    .HasMaxLength(100)
                    .HasColumnName("PARTY_NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Pin)
                    .HasMaxLength(100)
                    .HasColumnName("PIN");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .HasColumnName("STATE");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .HasColumnName("WEBSITE");
            });

            modelBuilder.Entity<PhPurBillDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_pur_b__97D3CABDA1BAF89D");

                entity.ToTable("ph_pur_bill_dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountAfterDiscount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount_after_discount");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.BillDate)
                    .HasColumnType("date")
                    .HasColumnName("bill_date");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(100)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Cgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst");

                entity.Property(e => e.CgstAcCode).HasColumnName("cgst_ac_code");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_value");

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(255)
                    .HasColumnName("exp_date");

                entity.Property(e => e.FreeQty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("free_qty");

                entity.Property(e => e.FromOrderAdhoc)
                    .HasMaxLength(5)
                    .HasColumnName("from_order_adhoc");

                entity.Property(e => e.Igst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst");

                entity.Property(e => e.IgstAcCode).HasColumnName("igst_ac_code");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MfgDate)
                    .HasMaxLength(255)
                    .HasColumnName("mfg_date");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.PodtlRecId).HasColumnName("podtl_rec_id");

                entity.Property(e => e.PurCode).HasColumnName("pur_code");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.Sgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst");

                entity.Property(e => e.SgstAcCode).HasColumnName("sgst_ac_code");

                entity.Property(e => e.SpDiscountLedgerCode).HasColumnName("sp_discount_ledger_code");

                entity.Property(e => e.SpDiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sp_discount_perc");

                entity.Property(e => e.SpDiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sp_discount_value");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WhId).HasColumnName("wh_id");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.PhPurBillDtls)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pur_bill_dtl_bill_id");

                entity.HasOne(d => d.PurCodeNavigation)
                    .WithMany(p => p.PhPurBillDtls)
                    .HasForeignKey(d => d.PurCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pur_bill_dtl_pur_code");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.PhPurBillDtls)
                    .HasForeignKey(d => d.WhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pur_bill_dtl_wh_id");
            });

            modelBuilder.Entity<PhPurBillHead>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("PK__ph_pur_b__D706DDB3109F2FDA");

                entity.ToTable("ph_pur_bill_head");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.AccountsAdjAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("accounts_adj_amount");

                entity.Property(e => e.BillDate)
                    .HasColumnType("date")
                    .HasColumnName("bill_date");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(100)
                    .HasColumnName("bill_no");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.NetAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("net_amount");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.PhPurBillHeads)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pur_bill_head_ac_code");
            });

            modelBuilder.Entity<PhPurBillItemCharge>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_pur_b__97D3CABDA21B92F6");

                entity.ToTable("ph_pur_bill_item_charges");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BillDate)
                    .HasColumnType("date")
                    .HasColumnName("bill_date");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(100)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Formula).HasColumnName("formula");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Perc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("perc");

                entity.Property(e => e.PodtlRecId).HasColumnName("podtl_rec_id");

                entity.Property(e => e.Sign)
                    .HasMaxLength(5)
                    .HasColumnName("sign");

                entity.Property(e => e.TaxId).HasColumnName("tax_id");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.PhPurBillItemCharges)
                    .HasForeignKey(d => d.AcCode)
                    .HasConstraintName("fk_pur_bill_item_charges_ac_code");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.PhPurBillItemCharges)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pur_bill_item_charges_bill_id");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.PhPurBillItemCharges)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("fk_pur_bill_item_charges_tax_id");
            });

            modelBuilder.Entity<PhPurOrderDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__PH_PUR_O__23B2A19A6C54152F");

                entity.ToTable("PH_PUR_ORDER_DTL");

                entity.Property(e => e.RecId).HasColumnName("REC_ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.GrnQtyAdj)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("GRN_QTY_ADJ");

                entity.Property(e => e.IndentDtlRecId).HasColumnName("indent_dtl_rec_id");

                entity.Property(e => e.IndentHeadIdNo).HasColumnName("indent_head_id_no");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("ORDER_DATE");

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ORDER_NO");

                entity.Property(e => e.PbQtyAdj)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("PB_QTY_ADJ");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("QTY");

                entity.Property(e => e.QuotDtlRecId).HasColumnName("quot_dtl_rec_id");

                entity.Property(e => e.QuotHeadIdNo).HasColumnName("quot_head_id_no");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("RATE");

                entity.Property(e => e.UnitId).HasColumnName("UNIT_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhPurOrderDtls)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PUR_ORD_DTL_ITEM_ID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PhPurOrderDtls)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PUR_ORD_DTL_ORDER_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PhPurOrderDtls)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PUR_ORD_DTL_UNIT_ID");
            });

            modelBuilder.Entity<PhPurOrderHead>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__ph_pur_o__460A9464C828E8FB");

                entity.ToTable("ph_pur_order_head");

                entity.HasIndex(e => e.OrderNo, "UK_ORDERHEAD")
                    .IsUnique();

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(50)
                    .HasColumnName("APPROVAL_STATUS");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("ORDER_DATE");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .HasColumnName("ORDER_NO");

                entity.Property(e => e.OtherReferences).HasColumnName("OTHER_REFERENCES");

                entity.Property(e => e.PartyCode).HasColumnName("PARTY_CODE");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.TermsOfDelivery).HasColumnName("TERMS_OF_DELIVERY");

                entity.Property(e => e.TermsOfPayment).HasColumnName("TERMS_OF_PAYMENT");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("TOTAL_AMOUNT");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.HasOne(d => d.PartyCodeNavigation)
                    .WithMany(p => p.PhPurOrderHeads)
                    .HasForeignKey(d => d.PartyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDERHEAD_PARTY_CODE");
            });

            modelBuilder.Entity<PhPurReturnDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_pur_r__97D3CABDA566E10F");

                entity.ToTable("ph_pur_return_dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountAfterDiscount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount_after_discount");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.Cgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst");

                entity.Property(e => e.CgstAcCode).HasColumnName("cgst_ac_code");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_value");

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(255)
                    .HasColumnName("exp_date");

                entity.Property(e => e.Igst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst");

                entity.Property(e => e.IgstAcCode).HasColumnName("igst_ac_code");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MfgDate)
                    .HasMaxLength(255)
                    .HasColumnName("mfg_date");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.PurBillDtlRecId).HasColumnName("pur_bill_dtl_rec_id");

                entity.Property(e => e.PurReturnCode).HasColumnName("pur_return_code");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.ReturnNo)
                    .HasMaxLength(100)
                    .HasColumnName("return_no");

                entity.Property(e => e.Sgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst");

                entity.Property(e => e.SgstAcCode).HasColumnName("sgst_ac_code");

                entity.Property(e => e.SpDiscountLedgerCode).HasColumnName("sp_discount_ledger_code");

                entity.Property(e => e.SpDiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sp_discount_perc");

                entity.Property(e => e.SpDiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sp_discount_value");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WhId).HasColumnName("wh_id");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.PhPurReturnDtls)
                    .HasForeignKey(d => d.ReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pur_return_dtl_return_id");
            });

            modelBuilder.Entity<PhPurReturnHead>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK__ph_pur_r__35C234734A389730");

                entity.ToTable("ph_pur_return_head");

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.AccountsAdjAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("accounts_adj_amount");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.NetAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("net_amount");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.ReturnNo)
                    .HasMaxLength(100)
                    .HasColumnName("return_no");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");
            });

            modelBuilder.Entity<PhQuotDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_quot___97D3CABD0297FCBF");

                entity.ToTable("ph_quot_dtl");

                entity.HasIndex(e => new { e.QuotHeadIdNo, e.ItemId, e.PartyCode }, "uk_ph_quot_dtl")
                    .IsUnique();

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.QuotDate)
                    .HasColumnType("date")
                    .HasColumnName("quot_date");

                entity.Property(e => e.QuotHeadIdNo).HasColumnName("quot_head_id_no");

                entity.Property(e => e.QuotNo)
                    .HasMaxLength(100)
                    .HasColumnName("quot_no");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate");

                entity.HasOne(d => d.QuotHeadIdNoNavigation)
                    .WithMany(p => p.PhQuotDtls)
                    .HasForeignKey(d => d.QuotHeadIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ph_quot_dtl_head_id_no");
            });

            modelBuilder.Entity<PhQuotHead>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__ph_quot___0148B384CAF89149");

                entity.ToTable("ph_quot_head");

                entity.HasIndex(e => e.QuotNo, "UQ__ph_quot___D3B394D24FAB5736")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.IndentDone)
                    .HasMaxLength(3)
                    .HasColumnName("indent_done")
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.QuotDate)
                    .HasColumnType("date")
                    .HasColumnName("quot_date");

                entity.Property(e => e.QuotNo)
                    .HasMaxLength(100)
                    .HasColumnName("quot_no");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");
            });

            modelBuilder.Entity<PhSalBillDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_sal_b__97D3CABD3E3211FD");

                entity.ToTable("ph_sal_bill_dtl");

                entity.HasIndex(e => e.BillId, "idx_ph_sal_bill_dtl_bill_id");

                entity.HasIndex(e => e.ItemId, "idx_ph_sal_bill_dtl_item_id");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountAfterDiscount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount_after_discount");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.BillDate)
                    .HasColumnType("date")
                    .HasColumnName("bill_date");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(100)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Cgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst");

                entity.Property(e => e.CgstAcCode).HasColumnName("cgst_ac_code");

                entity.Property(e => e.DiscountAcCode).HasColumnName("discount_ac_code");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_value");

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(255)
                    .HasColumnName("exp_date");

                entity.Property(e => e.FromOrderAdhoc)
                    .HasMaxLength(5)
                    .HasColumnName("from_order_adhoc");

                entity.Property(e => e.Igst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst");

                entity.Property(e => e.IgstAcCode).HasColumnName("igst_ac_code");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MfgDate)
                    .HasMaxLength(255)
                    .HasColumnName("mfg_date");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.SalCode).HasColumnName("sal_code");

                entity.Property(e => e.Sgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst");

                entity.Property(e => e.SgstAcCode).HasColumnName("sgst_ac_code");

                entity.Property(e => e.SodtlRecId).HasColumnName("sodtl_rec_id");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WhId).HasColumnName("wh_id");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.PhSalBillDtls)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_bill_dtl_bill_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PhSalBillDtls)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_bill_dtl_item_id");

                entity.HasOne(d => d.SalCodeNavigation)
                    .WithMany(p => p.PhSalBillDtls)
                    .HasForeignKey(d => d.SalCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_bill_dtl_sal_code");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PhSalBillDtls)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_bill_dtl_unit_id");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.PhSalBillDtls)
                    .HasForeignKey(d => d.WhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_bill_dtl_wh_id");
            });

            modelBuilder.Entity<PhSalBillHead>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("PK__ph_sal_b__D706DDB3E7E0FAE1");

                entity.ToTable("ph_sal_bill_head");

                entity.HasIndex(e => e.PatientRegNo, "idx_ph_sal_bill_head_reg_no");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.AccountsAdjAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("accounts_adj_amount");

                entity.Property(e => e.BillDate)
                    .HasColumnType("date")
                    .HasColumnName("bill_date");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(100)
                    .HasColumnName("bill_no");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.CustomerCode).HasColumnName("customer_code");

                entity.Property(e => e.DiscountAcCode).HasColumnName("discount_ac_code");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_value");

                entity.Property(e => e.NetAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("net_amount");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(50)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.PatientType)
                    .HasMaxLength(20)
                    .HasColumnName("patient_type");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.PhSalBillHeads)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_bill_head_ac_code");
            });

            modelBuilder.Entity<PhSalReturnDtl>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK__ph_sal_r__97D3CABDAFD88761");

                entity.ToTable("ph_sal_return_dtl");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountAfterDiscount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("amount_after_discount");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.BillQty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("bill_qty");

                entity.Property(e => e.Cgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("cgst");

                entity.Property(e => e.CgstAcCode).HasColumnName("cgst_ac_code");

                entity.Property(e => e.DiscountAcCode).HasColumnName("discount_ac_code");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_value");

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(255)
                    .HasColumnName("exp_date");

                entity.Property(e => e.Igst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("igst");

                entity.Property(e => e.IgstAcCode).HasColumnName("igst_ac_code");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MfgDate)
                    .HasMaxLength(255)
                    .HasColumnName("mfg_date");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.RetQty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("ret_qty");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.ReturnNo)
                    .HasMaxLength(100)
                    .HasColumnName("return_no");

                entity.Property(e => e.SalBillDtlRecId).HasColumnName("sal_bill_dtl_rec_id");

                entity.Property(e => e.SalReturnCode).HasColumnName("sal_return_code");

                entity.Property(e => e.Sgst)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("sgst");

                entity.Property(e => e.SgstAcCode).HasColumnName("sgst_ac_code");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WhId).HasColumnName("wh_id");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.PhSalReturnDtls)
                    .HasForeignKey(d => d.ReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_return_dtl_return_id");

                entity.HasOne(d => d.SalBillDtlRec)
                    .WithMany(p => p.PhSalReturnDtls)
                    .HasForeignKey(d => d.SalBillDtlRecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_return_dtl_sal_bill_dtl_rec_id");
            });

            modelBuilder.Entity<PhSalReturnHead>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK__ph_sal_r__35C234734163ACF4");

                entity.ToTable("ph_sal_return_head");

                entity.HasIndex(e => e.ReturnNo, "uk_sal_return_head")
                    .IsUnique();

                entity.Property(e => e.ReturnId).HasColumnName("return_id");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.AccountsAdjAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("accounts_adj_amount");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.DiscountAcCode).HasColumnName("discount_ac_code");

                entity.Property(e => e.DiscountPerc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_perc");

                entity.Property(e => e.DiscountValue)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("discount_value");

                entity.Property(e => e.NetAmount)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("net_amount");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(50)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.PatientType).HasColumnName("patient_type");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.ReturnNo)
                    .HasMaxLength(100)
                    .HasColumnName("return_no");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.PhSalReturnHeads)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sal_return_head_ac_code");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.PhSalReturnHeads)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ph_sal_re__bill___190BB0C3");
            });

            modelBuilder.Entity<PhTaxMaster>(entity =>
            {
                entity.HasKey(e => e.TaxId)
                    .HasName("PK__ph_tax_m__129B86706E17F543");

                entity.ToTable("ph_tax_master");

                entity.Property(e => e.TaxId).HasColumnName("tax_id");

                entity.Property(e => e.AcCode).HasColumnName("ac_code");

                entity.Property(e => e.Perc)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("perc");

                entity.Property(e => e.Sign).HasColumnName("sign");

                entity.Property(e => e.TaxCode).HasColumnName("tax_code");

                entity.Property(e => e.TaxName).HasColumnName("tax_name");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.PhTaxMasters)
                    .HasForeignKey(d => d.AcCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ph_accledger_ac_code");
            });

            modelBuilder.Entity<PhUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("PK__ph_unit__D3AF5BD73DF75F38");

                entity.ToTable("ph_unit");

                entity.HasIndex(e => e.UnitName, "uk_ph_unit_unique")
                    .IsUnique();

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(100)
                    .HasColumnName("deleted_by");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("date")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(3)
                    .HasColumnName("is_deleted");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unit_name");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("date")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<PhWarehouse>(entity =>
            {
                entity.HasKey(e => e.WhId)
                    .HasName("PK__PH_WAREH__AF6EA2ACDAD4912B");

                entity.ToTable("PH_WAREHOUSE");

                entity.HasIndex(e => e.WhName, "UK_PH_WH_WH_NAME")
                    .IsUnique();

                entity.Property(e => e.WhId).HasColumnName("WH_ID");

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .HasColumnName("ADD1");

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .HasColumnName("ADD2");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("CITY");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.IsDefault)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IS_DEFAULT");

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .HasColumnName("STATE");

                entity.Property(e => e.WhName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WH_NAME");

                entity.Property(e => e.Zip)
                    .HasMaxLength(100)
                    .HasColumnName("ZIP");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PhWarehouses)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_PH_WAREHOUSE_LOC_ID");
            });

            modelBuilder.Entity<PrescribedMedicine>(entity =>
            {
                entity.ToTable("Prescribed_Medicine");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.PrescribedMedicine1).HasColumnName("PrescribedMedicine");

                entity.Property(e => e.Purchased).HasMaxLength(3);

                entity.Property(e => e.RegNo).HasColumnName("Reg_No");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.PrescribedMedicines)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK__Prescribe__DocId__1F04813B");
            });

            modelBuilder.Entity<SaveO2>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__SaveO2__B773C99909168B06");

                entity.ToTable("SaveO2");

                entity.HasOne(d => d.AcCodeNavigation)
                    .WithMany(p => p.SaveO2s)
                    .HasForeignKey(d => d.AcCode)
                    .HasConstraintName("FK_AccLedger_SaveO2_AcCode");
            });

            modelBuilder.Entity<SisterLogin>(entity =>
            {
                entity.HasKey(e => e.SisterIdNo)
                    .HasName("PK__SisterLo__937AF30213545169");

                entity.ToTable("SisterLogin");

                entity.Property(e => e.SisterIdNo).ValueGeneratedNever();

                entity.HasOne(d => d.SisterIdNoNavigation)
                    .WithOne(p => p.SisterLogin)
                    .HasForeignKey<SisterLogin>(d => d.SisterIdNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SisterLogin_SisterIdNo");
            });

            modelBuilder.Entity<SisterNotification>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__SisterNo__B773C99952636785");

                entity.ToTable("SisterNotification");

                entity.Property(e => e.FromSatatus).HasMaxLength(255);

                entity.Property(e => e.NotificationDate).HasColumnType("date");

                entity.Property(e => e.NotificationStatus).HasMaxLength(100);

                entity.Property(e => e.NotificationTime).HasMaxLength(10);

                entity.Property(e => e.PatientRegNo).HasMaxLength(255);

                entity.Property(e => e.ToStatus).HasMaxLength(255);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__States__B773C9999FF03645");

                entity.HasIndex(e => e.Name, "uk_states_Name")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<StockDtl>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__stock_dt__0148B38413BEC926");

                entity.ToTable("stock_dtl");

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.BarcodeNo)
                    .HasMaxLength(20)
                    .HasColumnName("barcode_no");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(100)
                    .HasColumnName("doc_no");

                entity.Property(e => e.DtlRecId).HasColumnName("dtl_rec_id");

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(255)
                    .HasColumnName("exp_date");

                entity.Property(e => e.InQty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("in_qty");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.MfgDate)
                    .HasMaxLength(255)
                    .HasColumnName("mfg_date");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.OutQty)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("out_qty");

                entity.Property(e => e.PartyCode).HasColumnName("party_code");

                entity.Property(e => e.PatientRegNo)
                    .HasMaxLength(50)
                    .HasColumnName("patient_reg_no");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.WhId).HasColumnName("wh_id");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.StockDtls)
                    .HasForeignKey(d => d.WhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_stock_dtl_wh_id");
            });

            modelBuilder.Entity<SummarizeTestResult>(entity =>
            {
                entity.ToTable("Summarize_Test_Result");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Created_On");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("Delivery_date");

                entity.Property(e => e.RegNo).HasColumnName("Reg_No");

                entity.Property(e => e.SampleDate).HasColumnType("date");

                entity.Property(e => e.TestStatus)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.UpdatedBy).HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("Updated_On");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.SummarizeTestResults)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK__Summarize__DocId__0DD9F539");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.SummarizeTestResults)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK__Summarize__TestI__0ECE1972");
            });

            modelBuilder.Entity<SystemVariable>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__system_v__225E74CD6D68FFCC");

                entity.ToTable("system_variables");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TestUnit>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__TestUnit__B773C99969B9E35D");

                entity.ToTable("TestUnit");

                entity.Property(e => e.TestUnit1).HasColumnName("TestUnit");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__users__F3DBC573A4F925A3");

                entity.ToTable("users");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username");

                entity.Property(e => e.IsAdmin)
                    .HasMaxLength(3)
                    .HasColumnName("is_admin")
                    .HasDefaultValueSql("('No')");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<UsersModulesMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users_modules_mapping");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .HasColumnName("category");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .HasColumnName("module_name");

                entity.Property(e => e.PermissionType)
                    .HasMaxLength(100)
                    .HasColumnName("permission_type");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username");

                entity.HasOne(d => d.ModuleNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ModuleName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_module_mapping_module_name");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_module_mapping_username");
            });

            modelBuilder.Entity<WardMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__WardMast__B773C9991FC95649");

                entity.ToTable("WardMaster");

                entity.HasIndex(e => e.Name, "uk_WardMaster_Name")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<WardSisterMaster>(entity =>
            {
                entity.HasKey(e => e.IdNo)
                    .HasName("PK__ward_sis__0148B3847E60B42D");

                entity.ToTable("ward_sister_master");

                entity.HasIndex(e => e.SisterName, "uk_ward_sister_master_sister_name")
                    .IsUnique();

                entity.Property(e => e.IdNo).HasColumnName("id_no");

                entity.Property(e => e.SisterName)
                    .HasMaxLength(255)
                    .HasColumnName("sister_name");
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.ToTable("year");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FinYear)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("fin_year");

                entity.Property(e => e.FinYearFrom)
                    .HasColumnType("date")
                    .HasColumnName("fin_year_from");

                entity.Property(e => e.FinYearTo)
                    .HasColumnType("date")
                    .HasColumnName("fin_year_to");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
