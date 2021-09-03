using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReportsClinicaValle.DbModels
{
    public partial class ClinicaContext : DbContext
    {
        public ClinicaContext()
        {
        }

        public ClinicaContext(DbContextOptions<ClinicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admissions> Admissions { get; set; }
        public virtual DbSet<AdmissionTypes> AdmissionTypes { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Apps> Apps { get; set; }
        public virtual DbSet<AreaProductStocks> AreaProductStocks { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<AreaServices> AreaServices { get; set; }
        public virtual DbSet<Beneficiaries> Beneficiaries { get; set; }
        public virtual DbSet<BeneficiaryStatus> BeneficiaryStatus { get; set; }
        public virtual DbSet<BillDetails> BillDetails { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<BillTypes> BillTypes { get; set; }
        public virtual DbSet<Cie10> Cie10 { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomerStatus> CustomerStatus { get; set; }
        public virtual DbSet<CustomerTypes> CustomerTypes { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<DoctorTimes> DoctorTimes { get; set; }
        public virtual DbSet<Families> Families { get; set; }
        public virtual DbSet<Follows> Follows { get; set; }
        public virtual DbSet<FollowsPrivates> FollowsPrivates { get; set; }
        public virtual DbSet<InPutProductDetails> InPutProductDetails { get; set; }
        public virtual DbSet<InPutProducts> InPutProducts { get; set; }
        public virtual DbSet<InPutProductStates> InPutProductStates { get; set; }
        public virtual DbSet<InPutProductTypes> InPutProductTypes { get; set; }
        public virtual DbSet<OutPutProductDetails> OutPutProductDetails { get; set; }
        public virtual DbSet<OutPutProducts> OutPutProducts { get; set; }
        public virtual DbSet<OutPutProductStates> OutPutProductStates { get; set; }
        public virtual DbSet<OutPutProductTypes> OutPutProductTypes { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<Percapitas> Percapitas { get; set; }
        public virtual DbSet<Presentations> Presentations { get; set; }
        public virtual DbSet<PrivateCustomers> PrivateCustomers { get; set; }
        public virtual DbSet<PrivateCustomerStats> PrivateCustomerStats { get; set; }
        public virtual DbSet<PrivateCustomerTypes> PrivateCustomerTypes { get; set; }
        public virtual DbSet<PrivateWorkOrderDetails> PrivateWorkOrderDetails { get; set; }
        public virtual DbSet<PrivateWorkOrders> PrivateWorkOrders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductStates> ProductStates { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<ProviderStates> ProviderStates { get; set; }
        public virtual DbSet<Rates> Rates { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<Relationships> Relationships { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<RolResources> RolResources { get; set; }
        public virtual DbSet<Rols> Rols { get; set; }
        public virtual DbSet<SendTestDetails> SendTestDetails { get; set; }
        public virtual DbSet<SendTests> SendTests { get; set; }
        public virtual DbSet<ServiceDetails> ServiceDetails { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServiceTestBaarDetails> ServiceTestBaarDetails { get; set; }
        public virtual DbSet<ServiceTestCultiveAntiBiotics> ServiceTestCultiveAntiBiotics { get; set; }
        public virtual DbSet<ServiceTestCultiveFrescs> ServiceTestCultiveFrescs { get; set; }
        public virtual DbSet<ServiceTestCultives> ServiceTestCultives { get; set; }
        public virtual DbSet<ServiceTestDetails> ServiceTestDetails { get; set; }
        public virtual DbSet<ServiceTests> ServiceTests { get; set; }
        public virtual DbSet<Sexs> Sexs { get; set; }
        public virtual DbSet<Specialties> Specialties { get; set; }
        public virtual DbSet<Subsidies> Subsidies { get; set; }
        public virtual DbSet<TraslateDetails> TraslateDetails { get; set; }
        public virtual DbSet<Traslates> Traslates { get; set; }
        public virtual DbSet<TraslateStages> TraslateStages { get; set; }
        public virtual DbSet<TraslateStates> TraslateStates { get; set; }
        public virtual DbSet<UnitOfMeasures> UnitOfMeasures { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WorkOrderDetails> WorkOrderDetails { get; set; }
        public virtual DbSet<WorkOrders> WorkOrders { get; set; }
        public virtual DbSet<WorkPreOrderDetails> WorkPreOrderDetails { get; set; }
        public virtual DbSet<WorkPreOrders> WorkPreOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LEX-PC\\PCLEX;Database=ClinicalCare ;User Id=sa;Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admissions>(entity =>
            {
                entity.HasIndex(e => e.AreaId)
                    .HasName("IX_Admissions_Area");

                entity.HasIndex(e => e.BeneficiaryId)
                    .HasName("IX_Admissions_Beneficiario");

                entity.HasIndex(e => e.CreateAt);

                entity.HasIndex(e => e.CreateBy);

                entity.HasIndex(e => e.Identification);

                entity.HasIndex(e => e.Inss);

                entity.HasIndex(e => e.NumberOfDay);

                entity.HasIndex(e => e.SpecialtyId)
                    .HasName("IX_Admissions_Specialty");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_Admissions_Type");

                entity.Property(e => e.Cie10Id)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Identification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motive)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admissions_Areas");

                entity.HasOne(d => d.Beneficiary)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.BeneficiaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admissions_Beneficiaries");

                entity.HasOne(d => d.Cie10)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.Cie10Id)
                    .HasConstraintName("FK_Admissions_CIE10");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admissions_Users");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admissions_Specialties");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admissions_AdmissionTypes");
            });

            modelBuilder.Entity<AdmissionTypes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasIndex(e => e.BeneficiaryId)
                    .HasName("IX_Appointments_Beneficiario");

                entity.HasIndex(e => e.DateAppointment);

                entity.HasIndex(e => e.DoctorId)
                    .HasName("IX_Appointments_Doctors");

                entity.HasIndex(e => e.Identification);

                entity.HasIndex(e => e.Inss)
                    .HasName("IX_Appointments_inss");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAppointment).HasColumnType("datetime");

                entity.Property(e => e.Identification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_Appointments_Areas");

                entity.HasOne(d => d.Beneficiary)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.BeneficiaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointments_Beneficiaries");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointments_Users");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointments_Doctors");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointments_Specialties");
            });

            modelBuilder.Entity<Apps>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Slogan)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaProductStocks>(entity =>
            {
                entity.HasKey(e => new { e.AreaId, e.ProductId });

                entity.Property(e => e.CostAvg)
                    .HasColumnName("CostAVG")
                    .HasColumnType("money");

                entity.Property(e => e.CostReal).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AreaProductStocks)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaProductStocks_Areas");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.AreaProductStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaProductStocks_Products");
            });

            modelBuilder.Entity<Areas>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaServices>(entity =>
            {
                entity.HasIndex(e => new { e.AreaId, e.ServiceId })
                    .HasName("IX_AreaServices_AreaServices");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AreaServices)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaServices_Areas");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.AreaServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaServices_Services");
            });

            modelBuilder.Entity<Beneficiaries>(entity =>
            {
                entity.HasIndex(e => e.FirstName);

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Beneficiaries_Identification");

                entity.HasIndex(e => e.Inss)
                    .HasName("IX_Beneficiaries");

                entity.HasIndex(e => e.LastName);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Identification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModificationAt).HasColumnType("datetime");

                entity.Property(e => e.LastModificationBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BeneficiaryStatus)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.BeneficiaryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaries_BeneficiaryStatus");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaries_Cities");

                entity.HasOne(d => d.InssNavigation)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.Inss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaries_Customers");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaries_Regions");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaries_Relationships");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.SexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaries_Sexs");
            });

            modelBuilder.Entity<BeneficiaryStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillDetails>(entity =>
            {
                entity.HasIndex(e => e.ServiceId)
                    .HasName("IX_BillDetails_Product");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillDetails_Bills");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_BillDetails_Products");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_BillDetails_Services");
            });

            modelBuilder.Entity<Bills>(entity =>
            {
                entity.HasIndex(e => e.AreaId)
                    .HasName("IX_Bills_Area");

                entity.HasIndex(e => e.PrivateCustomerId)
                    .HasName("IX_Bills_CustomerPrivateId");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameCustomer)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_Areas");

                entity.HasOne(d => d.BillType)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.BillTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_BillTypes");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_Currencies");

                entity.HasOne(d => d.PrivateCustomer)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.PrivateCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_CustomersPrivates");
            });

            modelBuilder.Entity<BillTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cie10>(entity =>
            {
                entity.ToTable("CIE10");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contracts>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.Inss);

                entity.HasIndex(e => e.Identification);

                entity.Property(e => e.Inss).ValueGeneratedNever();

                entity.Property(e => e.DateAdd).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Identification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatronalId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerStatus)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_CustomerStatus");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_CustomerTypes");
            });

            modelBuilder.Entity<CustomerStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MinsaCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctors_Specialties");
            });

            modelBuilder.Entity<DoctorTimes>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.Property(e => e.DoctorId).ValueGeneratedNever();

                entity.Property(e => e.Days)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StartHour).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithOne(p => p.DoctorTimes)
                    .HasForeignKey<DoctorTimes>(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorTimes_Doctors");
            });

            modelBuilder.Entity<Families>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Follows>(entity =>
            {
                entity.HasIndex(e => e.AdmissionId)
                    .HasName("IX_Follows");

                entity.HasIndex(e => e.AreaSourceId)
                    .HasName("IX_Follows_AreaSource");

                entity.HasIndex(e => e.AreaTargetId)
                    .HasName("IX_Follows_AreaTarget");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Admission)
                    .WithMany(p => p.Follows)
                    .HasForeignKey(d => d.AdmissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Follows_Admissions");

                entity.HasOne(d => d.AreaSource)
                    .WithMany(p => p.FollowsAreaSource)
                    .HasForeignKey(d => d.AreaSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Follows_Areas_Origen");

                entity.HasOne(d => d.AreaTarget)
                    .WithMany(p => p.FollowsAreaTarget)
                    .HasForeignKey(d => d.AreaTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Follows_Areas_Destino");
            });

            modelBuilder.Entity<FollowsPrivates>(entity =>
            {
                entity.HasIndex(e => e.AreaSourceId)
                    .HasName("IX_FollowsPrivates_AreaSource");

                entity.HasIndex(e => e.AreaTargetId)
                    .HasName("IX_FollowsPrivates_AreaTarget");

                entity.HasIndex(e => e.BillId)
                    .HasName("IX_FollowsPrivates_Bill");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.AreaSource)
                    .WithMany(p => p.FollowsPrivatesAreaSource)
                    .HasForeignKey(d => d.AreaSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FollowsPrivates_AreasSource");

                entity.HasOne(d => d.AreaTarget)
                    .WithMany(p => p.FollowsPrivatesAreaTarget)
                    .HasForeignKey(d => d.AreaTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FollowsPrivates_AreasTarget");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.FollowsPrivates)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FollowsPrivates_Bills");
            });

            modelBuilder.Entity<InPutProductDetails>(entity =>
            {
                entity.HasIndex(e => e.InPutProductId)
                    .HasName("IX_InPutProductDetails_InPutProduct");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_InPutProductDetails_Product");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CostAvg)
                    .HasColumnName("CostAVG")
                    .HasColumnType("money");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Import).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.InPutProduct)
                    .WithMany(p => p.InPutProductDetails)
                    .HasForeignKey(d => d.InPutProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InPutProductDetails_InPutProducts");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InPutProductDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InPutProductDetails_Products");
            });

            modelBuilder.Entity<InPutProducts>(entity =>
            {
                entity.HasIndex(e => e.AreaId)
                    .HasName("IX_InPutProducts_Area");

                entity.HasIndex(e => e.Number);

                entity.HasIndex(e => e.Reference);

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_InPutProducts_TypeInputProduct");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Import).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Observation).HasMaxLength(500);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Reference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.InPutProducts)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InPutProducts_Areas");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.InPutProducts)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InPutProducts_Currencies");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.InPutProducts)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_InPutProducts_Providers");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.InPutProducts)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InPutProducts_InPutProductStates");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.InPutProducts)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InPutProducts_InPutProductTypes");
            });

            modelBuilder.Entity<InPutProductStates>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InPutProductTypes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutPutProductDetails>(entity =>
            {
                entity.HasIndex(e => e.OutPutProductId)
                    .HasName("IX_OutPutProductDetails_OutPutProduct");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_OutPutProductDetails_Product");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CostAvg)
                    .HasColumnName("CostAVG")
                    .HasColumnType("money");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Import).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.OutPutProduct)
                    .WithMany(p => p.OutPutProductDetails)
                    .HasForeignKey(d => d.OutPutProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutPutProductDetails_OutPutProducts");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OutPutProductDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutPutProductDetails_Products");
            });

            modelBuilder.Entity<OutPutProducts>(entity =>
            {
                entity.HasIndex(e => e.AreaId)
                    .HasName("IX_OutPutProducts_Area");

                entity.HasIndex(e => e.Number);

                entity.HasIndex(e => e.Reference);

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_OutPutProducts_TypeOutPutProduct");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Import).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Observation).HasMaxLength(500);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Reference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.OutPutProducts)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutPutProducts_Areas");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.OutPutProducts)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutPutProducts_Currencies");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.OutPutProducts)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutPutProducts_OutPutProductStates");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.OutPutProducts)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutPutProducts_OutPutProductTypes");
            });

            modelBuilder.Entity<OutPutProductStates>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutPutProductTypes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parameters>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Percapitas>(entity =>
            {
                entity.HasIndex(e => new { e.Year, e.Month })
                    .HasName("IX_Percapitas");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Adscription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdd).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Identification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatronalId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rason)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Presentations>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrivateCustomers>(entity =>
            {
                entity.HasIndex(e => e.FirstName)
                    .HasName("IX_PrivateCustomers_FN");

                entity.HasIndex(e => e.LastName)
                    .HasName("IX_PrivateCustomers_LN");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Identification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModificationAt).HasColumnType("datetime");

                entity.Property(e => e.LastModificationBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.PrivateCustomers)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_PrivateCustomers_Contracts");

                entity.HasOne(d => d.PrivateCustomerStatus)
                    .WithMany(p => p.PrivateCustomers)
                    .HasForeignKey(d => d.PrivateCustomerStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrivateCustomers_PrivateCustomerStats");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.PrivateCustomers)
                    .HasForeignKey(d => d.SexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrivateCustomers_Sexs");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PrivateCustomers)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrivateCustomers_PrivateCustomerTypes");
            });

            modelBuilder.Entity<PrivateCustomerStats>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrivateCustomerTypes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrivateWorkOrderDetails>(entity =>
            {
                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.PrivateWorkOrder)
                    .WithMany(p => p.PrivateWorkOrderDetails)
                    .HasForeignKey(d => d.PrivateWorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrivateWorkOrderDetails_PrivateWorkOrders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PrivateWorkOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PrivateWorkOrderDetails_Products");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.PrivateWorkOrderDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_PrivateWorkOrderDetails_Services");
            });

            modelBuilder.Entity<PrivateWorkOrders>(entity =>
            {
                entity.HasIndex(e => e.DoctorId)
                    .HasName("IX_PrivateWorkOrders_Doctor");

                entity.HasIndex(e => e.FollowsPrivateId)
                    .HasName("IX_PrivateWorkOrders_FollowPrivate");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PrivateWorkOrders)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrivateWorkOrders_Doctors");

                entity.HasOne(d => d.FollowsPrivate)
                    .WithMany(p => p.PrivateWorkOrders)
                    .HasForeignKey(d => d.FollowsPrivateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrders_FollowsPrivate");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.FamilyId)
                    .HasName("IX_ProductsFamily");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_ProductsName");

                entity.HasIndex(e => e.PresentationId)
                    .HasName("IX_ProductsPresentation");

                entity.HasIndex(e => e.StateId)
                    .HasName("IX_ProductsStatus");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HasIva).HasColumnName("HasIVA");

                entity.Property(e => e.LastDateModificationAt).HasColumnType("datetime");

                entity.Property(e => e.LastModificationBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockMin).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Currencies");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.FamilyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Families");

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Presentations");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_ProductStates");

                entity.HasOne(d => d.UnitOfMeasure)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.UnitOfMeasureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_UnitOfMeasures");
            });

            modelBuilder.Entity<ProductStates>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Providers_1");

                entity.HasIndex(e => e.Ruc)
                    .HasName("IX_Providers");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDateModificationAt).HasColumnType("datetime");

                entity.Property(e => e.LastModificationBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .HasColumnName("RUC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Providers)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Providers_ProviderStates");
            });

            modelBuilder.Entity<ProviderStates>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rates>(entity =>
            {
                entity.HasIndex(e => e.Date)
                    .HasName("IX_Rates")
                    .IsUnique();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Value).HasColumnType("money");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Relationships>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rule).HasMaxLength(350);
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolResources>(entity =>
            {
                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.RolResources)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolResources_Resource");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolResources)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolResources_Rols");
            });

            modelBuilder.Entity<Rols>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SendTestDetails>(entity =>
            {
                entity.HasIndex(e => e.SendTestId)
                    .HasName("IX_SendTestDetails_SentTest");

                entity.HasIndex(e => e.Serviceid)
                    .HasName("IX_SendTestDetails_Service");

                entity.HasOne(d => d.SendTest)
                    .WithMany(p => p.SendTestDetails)
                    .HasForeignKey(d => d.SendTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SendTestDetails_SendTests");
            });

            modelBuilder.Entity<SendTests>(entity =>
            {
                entity.HasIndex(e => e.DoctorId)
                    .HasName("IX_SendTests_Doctor");

                entity.HasIndex(e => e.FollowId)
                    .HasName("IX_SendTests_Follow");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.SendTests)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SendTests_Doctors");

                entity.HasOne(d => d.Follow)
                    .WithMany(p => p.SendTests)
                    .HasForeignKey(d => d.FollowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SendTests_Follows");
            });

            modelBuilder.Entity<ServiceDetails>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Um)
                    .IsRequired()
                    .HasColumnName("UM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Services")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceCalculate)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Currencies");
            });

            modelBuilder.Entity<ServiceTestBaarDetails>(entity =>
            {
                entity.HasIndex(e => e.ServiceTestId)
                    .HasName("IX_ServiceTestBaarDetails_ServiceTest");

                entity.Property(e => e.Appearance)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppearanceBio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObservationBk)
                    .HasColumnName("ObservationBK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceTestBaarDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestBaarDetails_Services");

                entity.HasOne(d => d.ServiceTest)
                    .WithMany(p => p.ServiceTestBaarDetails)
                    .HasForeignKey(d => d.ServiceTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestBaarDetails_ServiceTests");
            });

            modelBuilder.Entity<ServiceTestCultiveAntiBiotics>(entity =>
            {
                entity.HasIndex(e => e.ServiceTestCultiveId)
                    .HasName("IX_ServiceTestCultiveAntiBiotics_CultiveTest");

                entity.Property(e => e.TestId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ServiceTestCultive)
                    .WithMany(p => p.ServiceTestCultiveAntiBiotics)
                    .HasForeignKey(d => d.ServiceTestCultiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestCultiveAntiBiotics_ServiceTestCultives");
            });

            modelBuilder.Entity<ServiceTestCultiveFrescs>(entity =>
            {
                entity.HasIndex(e => e.ServiceTestCultiveId)
                    .HasName("IX_ServiceTestCultiveFrescs_CultiveTest");

                entity.Property(e => e.ResultId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ServiceTestCultive)
                    .WithMany(p => p.ServiceTestCultiveFrescs)
                    .HasForeignKey(d => d.ServiceTestCultiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestCultiveFrescs_ServiceTestCultives");
            });

            modelBuilder.Entity<ServiceTestCultives>(entity =>
            {
                entity.HasIndex(e => e.ServiceId)
                    .HasName("IX_ServiceTestCultives_Service");

                entity.HasIndex(e => e.ServiceTestId)
                    .HasName("IX_ServiceTestCultives_ServiceTest");

                entity.Property(e => e.Gram)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Isolated)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mycologycal)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TestDate).HasColumnType("datetime");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceTestCultives)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestCultives_Services");

                entity.HasOne(d => d.ServiceTest)
                    .WithMany(p => p.ServiceTestCultives)
                    .HasForeignKey(d => d.ServiceTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestCultives_ServiceTests");
            });

            modelBuilder.Entity<ServiceTestDetails>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ResultJson).IsUnicode(false);

                entity.Property(e => e.Um)
                    .IsRequired()
                    .HasColumnName("UM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ServiceDetail)
                    .WithMany(p => p.ServiceTestDetails)
                    .HasForeignKey(d => d.ServiceDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestDetails_ServiceDetails");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceTestDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestDetails_Services");

                entity.HasOne(d => d.ServiceTest)
                    .WithMany(p => p.ServiceTestDetails)
                    .HasForeignKey(d => d.ServiceTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTestDetails_ServiceTests");
            });

            modelBuilder.Entity<ServiceTests>(entity =>
            {
                entity.HasIndex(e => e.DoctorId)
                    .HasName("IX_ServiceTests_Doctor");

                entity.HasIndex(e => e.FollowId)
                    .HasName("IX_ServiceTests_Follow");

                entity.HasIndex(e => e.SendTestId)
                    .HasName("IX_ServiceTests_SendTest");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ServiceTests)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTests_Doctors");

                entity.HasOne(d => d.Follow)
                    .WithMany(p => p.ServiceTests)
                    .HasForeignKey(d => d.FollowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTests_Follows");

                entity.HasOne(d => d.SendTest)
                    .WithMany(p => p.ServiceTests)
                    .HasForeignKey(d => d.SendTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTests_SendTests");
            });

            modelBuilder.Entity<Sexs>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specialties>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subsidies>(entity =>
            {
                entity.HasIndex(e => e.BeneficiaryId)
                    .HasName("IX_Subsidies_Beneficiary");

                entity.HasIndex(e => e.Identification);

                entity.HasIndex(e => e.Inss);

                entity.HasIndex(e => e.Reference)
                    .HasName("IX_Subsidies_Referencia");

                entity.Property(e => e.Cie10Id)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.Identification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Subsidies)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subsidies_Areas");

                entity.HasOne(d => d.Beneficiary)
                    .WithMany(p => p.Subsidies)
                    .HasForeignKey(d => d.BeneficiaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subsidies_Beneficiaries");

                entity.HasOne(d => d.Cie10)
                    .WithMany(p => p.Subsidies)
                    .HasForeignKey(d => d.Cie10Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subsidies_CIE10");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Subsidies)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subsidies_Doctors");
            });

            modelBuilder.Entity<TraslateDetails>(entity =>
            {
                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_TraslateDetails_Product");

                entity.HasIndex(e => e.TraslateId)
                    .HasName("IX_TraslateDetails_Traslate");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CostAvg)
                    .HasColumnName("CostAVG")
                    .HasColumnType("money");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Import).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TraslateDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraslateDetails_Products");

                entity.HasOne(d => d.Traslate)
                    .WithMany(p => p.TraslateDetails)
                    .HasForeignKey(d => d.TraslateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraslateDetails_Traslates");
            });

            modelBuilder.Entity<Traslates>(entity =>
            {
                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Import).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.LastDateModificationAt).HasColumnType("datetime");

                entity.Property(e => e.LastModificationBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation).HasMaxLength(500);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.AreaSource)
                    .WithMany(p => p.TraslatesAreaSource)
                    .HasForeignKey(d => d.AreaSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traslates_AreasSource");

                entity.HasOne(d => d.AreaTarget)
                    .WithMany(p => p.TraslatesAreaTarget)
                    .HasForeignKey(d => d.AreaTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traslates_AreasTarget");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Traslates)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traslates_Currencies");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.Traslates)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traslates_TraslateStages");
            });

            modelBuilder.Entity<TraslateStages>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TraslateStates>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitOfMeasures>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Areas");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Rols");
            });

            modelBuilder.Entity<WorkOrderDetails>(entity =>
            {
                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_WorkOrderDetails_Product");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("IX_WorkOrderDetails_Service");

                entity.HasIndex(e => e.WorkOrderId)
                    .HasName("IX_WorkOrderDetails_WorkOrder");

                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WorkOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_WorkOrderDetails_Products");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.WorkOrderDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_WorkOrderDetails_Services");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.WorkOrderDetails)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrderDetails_WorkOrders");
            });

            modelBuilder.Entity<WorkOrders>(entity =>
            {
                entity.HasIndex(e => e.FollowId)
                    .HasName("IX_WorkOrders_Follows");

                entity.HasIndex(e => e.Reference)
                    .HasName("IX_WorkOrders");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrders_Doctors");

                entity.HasOne(d => d.Follow)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.FollowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkOrders_Follows");
            });

            modelBuilder.Entity<WorkPreOrderDetails>(entity =>
            {
                entity.Property(e => e.Costo).HasColumnType("money");

                entity.Property(e => e.Presentation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Um)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WorkPreOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkPreOrderDetails_Products");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.WorkPreOrderDetails)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkPreOrderDetails_WorkPreOrders");
            });

            modelBuilder.Entity<WorkPreOrders>(entity =>
            {
                entity.HasIndex(e => e.FollowId)
                    .HasName("IX_WorkPreOrders_Follow");

                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.WorkPreOrders)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkPreOrders_Doctors");

                entity.HasOne(d => d.Follow)
                    .WithMany(p => p.WorkPreOrders)
                    .HasForeignKey(d => d.FollowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkPreOrders_Follows");
            });
        }
    }
}
