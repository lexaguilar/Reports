﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace Clinicavalle.DbModels.Clinica
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

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<App> Apps { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<BillPaymentMethod> BillPaymentMethods { get; set; }
        public virtual DbSet<BillPaymentType> BillPaymentTypes { get; set; }
        public virtual DbSet<BillType> BillTypes { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ContactLense> ContactLenses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<GraduationContactLense> GraduationContactLenses { get; set; }
        public virtual DbSet<IdentificationType> IdentificationTypes { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemPrice> ItemPrices { get; set; }
        public virtual DbSet<ItemProperty> ItemProperties { get; set; }
        public virtual DbSet<ItemPropertyValue> ItemPropertyValues { get; set; }
        public virtual DbSet<ItemProvider> ItemProviders { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<ItemTypeProperty> ItemTypeProperties { get; set; }
        public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; }
        public virtual DbSet<Prism> Prisms { get; set; }
        public virtual DbSet<Profession> Professions { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Refraction> Refractions { get; set; }
        public virtual DbSet<RefractionsCycloplegic> RefractionsCycloplegics { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolResource> RolResources { get; set; }
        public virtual DbSet<SentMessage> SentMessages { get; set; }
        public virtual DbSet<Sex> Sexs { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<ToroidalContact> ToroidalContacts { get; set; }
        public virtual DbSet<TwoFactorEntry> TwoFactorEntries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<vwFacturasPendientes> vwFacturasPendientes { get; set; }
        public virtual DbSet<vwRecords> vwRecords { get; set; }
        public virtual DbSet<vwBills> vwBills { get; set; }
        public virtual DbSet<vwItems> vwItems { get; set; }
        public virtual DbSet<vwIntentario> vwIntentario { get; set; }
        public virtual DbSet<vwValoracionAlmacen> vwValoracionAlmacen { get; set; }
        public virtual DbSet<vwCompras> vwCompras { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<App>(entity =>
            {
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

                entity.Property(e => e.QuoteExpirationDays).HasDefaultValueSql("((15))");

                entity.Property(e => e.Slogan)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointments_Activities");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointments_Clients");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointments_Doctors");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.Property(e => e.CreateAt).HasColumnType("datetime");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_Clients");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Bills_Quote");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_Bills_BillPaymentMethods");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_BillPaymentTypes");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bills_BillTypes");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Import).HasColumnType("money");

                entity.Property(e => e.Iva)
                    .HasColumnType("money")
                    .HasColumnName("IVA");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillDetails_Bills");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillDetails_Items");
            });

            modelBuilder.Entity<BillPaymentMethod>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillPaymentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => e.Identification).HasName("IX_Clients_Identification");

                entity.HasIndex(e => e.Name).HasName("IX_Clients_Name");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberWork)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Clients_Cities");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Clients_Departments");

                entity.HasOne(d => d.IdentificationType)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdentificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clients_IdentificationTypes");

                entity.HasOne(d => d.Nacionality)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.NacionalityId)
                    .HasConstraintName("FK_Clients_Countries");

                entity.HasOne(d => d.Profession)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ProfessionId)
                    .HasConstraintName("FK_Clients_Professions");
            });

            modelBuilder.Entity<ContactLense>(entity =>
            {
                entity.Property(e => e.Axis)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCurve)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Convertion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cylinder)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Diameter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Eye)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ReChange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sphere)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.GraduationContactLens)
                    .WithMany(p => p.ContactLenses)
                    .HasForeignKey(d => d.GraduationContactLensId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactLenses_GraduationContactLenses");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.StatuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctors_Status");
            });

            modelBuilder.Entity<GraduationContactLense>(entity =>
            {
                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NextDateRecord).HasColumnType("date");

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ResumenOd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ResumenOD");

                entity.Property(e => e.ResumenOi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ResumenOI");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GraduationContactLenses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GraduationContactLenses_Clients");
            });

            modelBuilder.Entity<IdentificationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.IdentificationTypes)
                    .HasForeignKey(d => d.StatuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdentificationTypes_Status");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Markup).IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio1).HasColumnType("money");

                entity.Property(e => e.Precio2).HasColumnType("money");

                entity.Property(e => e.Precio3).HasColumnType("money");

                entity.Property(e => e.Precio4).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SizeUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_ItemTypes");
            });

            modelBuilder.Entity<ItemPrice>(entity =>
            {
                entity.HasKey(e => new { e.PriceId, e.ItemId });

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPrices)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemPrices_Items");
            });

            modelBuilder.Entity<ItemProperty>(entity =>
            {
                entity.Property(e => e.CatalogName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemPropertyValue>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.ItemId, e.PropertyId });

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPropertyValues)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemPropertyValues_Items");

                entity.HasOne(d => d.ItemTypeProperty)
                    .WithMany(p => p.ItemPropertyValues)
                    .HasForeignKey(d => new { d.TypeId, d.PropertyId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemPropertyValues_ItemTypeProperties");
            });

            modelBuilder.Entity<ItemProvider>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ProviderId });

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemProviders)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemProviders_Items");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ItemProviders)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemProviders_Providers");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemTypeProperty>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.PropertyId });

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.ItemTypeProperties)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemTypeProperties_ItemProperties");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ItemTypeProperties)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemTypeProperties_ItemTypes");
            });

            modelBuilder.Entity<NotificationTemplate>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prism>(entity =>
            {
                entity.Property(e => e.Axis)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Base)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Eye)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PrismId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.Prisms)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prisms_Records");
            });

            modelBuilder.Entity<Profession>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RUC");

                entity.Property(e => e.Web)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receipts_Bills");
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NextDateRecord).HasColumnType("date");

                entity.Property(e => e.Observation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ResumenOd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ResumenOD");

                entity.Property(e => e.ResumenOi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ResumenOI");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Records_Clients");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.Records)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Records_Users");
            });

            modelBuilder.Entity<Refraction>(entity =>
            {
                entity.Property(e => e.Addition)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Avcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AVCC");

                entity.Property(e => e.Avsc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AVSC");

                entity.Property(e => e.Axis)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cylinder)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dpc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DPC");

                entity.Property(e => e.Dpl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DPL");

                entity.Property(e => e.Eye)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Sphere)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.Refractions)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Refractions_Records");
            });

            modelBuilder.Entity<RefractionsCycloplegic>(entity =>
            {
                entity.Property(e => e.Av)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AV");

                entity.Property(e => e.Axis)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cylinder)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Eye)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Sphere)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.RefractionsCycloplegics)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefractionsCycloplegics_Records");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolResource>(entity =>
            {
                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.RolResources)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolResources_Resources");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolResources)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolResources_Rols");
            });

            modelBuilder.Entity<SentMessage>(entity =>
            {
                entity.HasIndex(e => e.ClientId).HasName("IX_SentMessagesClientId");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SendBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentAt).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SentMessages)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SentMessages_Clients");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToroidalContact>(entity =>
            {
                entity.HasKey(e => new { e.Sphere, e.Cilinder })
                    .HasName("PK_ToroidalContact_1");

                entity.Property(e => e.Sphere).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Cilinder).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TwoFactorEntry>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiredOn).HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.TwoFactorEntries)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TwoFactorEntries_Users");
            });

           

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

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

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Rols");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Observation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.StatuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vendors_Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}