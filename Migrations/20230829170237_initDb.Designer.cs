﻿// <auto-generated />
using System;
using Hamburger_MVC.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hamburger_MVC.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20230829170237_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hamburger_MVC.Models.Adres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Burger", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 100L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("UrunFotografı")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("VeganMi")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Burgerler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Burger_IcMalzeme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BurgerID")
                        .HasColumnType("int");

                    b.Property<int>("IcMalzemeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BurgerID");

                    b.HasIndex("IcMalzemeID");

                    b.ToTable("Burger_IcMalzemeler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.Icecek_Custom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IcecekID")
                        .HasColumnType("int");

                    b.Property<int?>("SepetID")
                        .HasColumnType("int");

                    b.Property<decimal>("ToplamFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IcecekID");

                    b.HasIndex("SepetID");

                    b.HasIndex("UserID");

                    b.ToTable("Icecek_Customs");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.Menu_IcMalzeme_Custom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int?>("IcMalzemeID")
                        .HasColumnType("int");

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int?>("SepetID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IcMalzemeID");

                    b.HasIndex("MenuID");

                    b.HasIndex("SepetID");

                    b.HasIndex("UserID");

                    b.ToTable("Menu_IcMalzeme_Customs");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.Sos_Custom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SepetID")
                        .HasColumnType("int");

                    b.Property<int?>("SosID")
                        .HasColumnType("int");

                    b.Property<decimal>("ToplamFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SepetID");

                    b.HasIndex("SosID");

                    b.HasIndex("UserID");

                    b.ToTable("Sos_Customs");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.YanUrun_Custom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SepetID")
                        .HasColumnType("int");

                    b.Property<decimal>("ToplamFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("YanUrunId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SepetID");

                    b.HasIndex("UserID");

                    b.HasIndex("YanUrunId");

                    b.ToTable("YanUrun_Customs");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Icecek", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 200L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("UrunFotografı")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Icecekler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.IcMalzeme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 300L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<bool>("VeganMi")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("IcMalzemeler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Boyut")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<int>("BurgerID")
                        .HasColumnType("int");

                    b.Property<int>("IcecekID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<int>("SatisAdedi")
                        .HasColumnType("integer");

                    b.Property<int?>("ToplamKalori")
                        .HasColumnType("integer");

                    b.Property<string>("UrunFotografı")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("BurgerID")
                        .IsUnique();

                    b.HasIndex("IcecekID");

                    b.ToTable("Menuler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "57b1357a-f45b-42c7-89bc-b9cbc37fff97",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "de528e00-6f08-475d-b41f-24668a01d731",
                            Name = "Uye",
                            NormalizedName = "UYE"
                        });
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Sepet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<decimal>("ToplamFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("UserID");

                    b.ToTable("Sepetler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Siparis", b =>
                {
                    b.Property<int>("SiparisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiparisID"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.Property<string>("OdemeTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("SiparisDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<string>("SiparisDurumu")
                        .IsRequired()
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("ToplamFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("SiparisID");

                    b.HasIndex("UserID");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Sos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 400L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("UrunFotografı")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("VeganMi")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Soslar");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Hamburger_MVC.Models.YanUrun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 500L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime");

                    b.Property<string>("UrunFotografı")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("VeganMi")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("YanUrunler");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Adres", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.User", "User")
                        .WithMany("Adresler")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Burger_IcMalzeme", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Burger", "Burger")
                        .WithMany("BurgerinIcMalzemeleri")
                        .HasForeignKey("BurgerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hamburger_MVC.Models.IcMalzeme", "IcMalzeme")
                        .WithMany("IcMalzemeninBurgerleri")
                        .HasForeignKey("IcMalzemeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("IcMalzeme");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.Icecek_Custom", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Icecek", "Icecek")
                        .WithMany("Icecek_Customs")
                        .HasForeignKey("IcecekID");

                    b.HasOne("Hamburger_MVC.Models.Sepet", "Sepet")
                        .WithMany("Icecek_Customs")
                        .HasForeignKey("SepetID");

                    b.HasOne("Hamburger_MVC.Models.User", "User")
                        .WithMany("Icecek_Customs")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Icecek");

                    b.Navigation("Sepet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.Menu_IcMalzeme_Custom", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.IcMalzeme", "IcMalzeme")
                        .WithMany("MenuIcMalzemeCustom")
                        .HasForeignKey("IcMalzemeID");

                    b.HasOne("Hamburger_MVC.Models.Menu", "Menu")
                        .WithMany("MenuIcMalzemeCustom")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hamburger_MVC.Models.Sepet", "Sepet")
                        .WithMany("MenuIcMalzemeCustom")
                        .HasForeignKey("SepetID");

                    b.HasOne("Hamburger_MVC.Models.User", "User")
                        .WithMany("MenuIcMalzemeCustom")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IcMalzeme");

                    b.Navigation("Menu");

                    b.Navigation("Sepet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.Sos_Custom", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Sepet", "Sepet")
                        .WithMany("Sos_Customs")
                        .HasForeignKey("SepetID");

                    b.HasOne("Hamburger_MVC.Models.Sos", "Sos")
                        .WithMany("Sos_Customs")
                        .HasForeignKey("SosID");

                    b.HasOne("Hamburger_MVC.Models.User", "User")
                        .WithMany("Sos_Customs")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sepet");

                    b.Navigation("Sos");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Customs.YanUrun_Custom", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Sepet", "Sepet")
                        .WithMany("YanUrun_Customs")
                        .HasForeignKey("SepetID");

                    b.HasOne("Hamburger_MVC.Models.User", "User")
                        .WithMany("YanUrun_Customs")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hamburger_MVC.Models.YanUrun", "YanUrun")
                        .WithMany("YanUrun_Customs")
                        .HasForeignKey("YanUrunId");

                    b.Navigation("Sepet");

                    b.Navigation("User");

                    b.Navigation("YanUrun");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Menu", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Burger", "Burger")
                        .WithOne("Menu")
                        .HasForeignKey("Hamburger_MVC.Models.Menu", "BurgerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hamburger_MVC.Models.Icecek", "Icecek")
                        .WithMany("MenudekiIcecek")
                        .HasForeignKey("IcecekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Icecek");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Sepet", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Menu", "Menu")
                        .WithMany("Sepetler")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hamburger_MVC.Models.User", "User")
                        .WithMany("Sepetler")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Siparis", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.User", "User")
                        .WithMany("Siparisler")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hamburger_MVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Hamburger_MVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Burger", b =>
                {
                    b.Navigation("BurgerinIcMalzemeleri");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Icecek", b =>
                {
                    b.Navigation("Icecek_Customs");

                    b.Navigation("MenudekiIcecek");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.IcMalzeme", b =>
                {
                    b.Navigation("IcMalzemeninBurgerleri");

                    b.Navigation("MenuIcMalzemeCustom");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Menu", b =>
                {
                    b.Navigation("MenuIcMalzemeCustom");

                    b.Navigation("Sepetler");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Sepet", b =>
                {
                    b.Navigation("Icecek_Customs");

                    b.Navigation("MenuIcMalzemeCustom");

                    b.Navigation("Sos_Customs");

                    b.Navigation("YanUrun_Customs");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.Sos", b =>
                {
                    b.Navigation("Sos_Customs");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.User", b =>
                {
                    b.Navigation("Adresler");

                    b.Navigation("Icecek_Customs");

                    b.Navigation("MenuIcMalzemeCustom");

                    b.Navigation("Sepetler");

                    b.Navigation("Siparisler");

                    b.Navigation("Sos_Customs");

                    b.Navigation("YanUrun_Customs");
                });

            modelBuilder.Entity("Hamburger_MVC.Models.YanUrun", b =>
                {
                    b.Navigation("YanUrun_Customs");
                });
#pragma warning restore 612, 618
        }
    }
}
