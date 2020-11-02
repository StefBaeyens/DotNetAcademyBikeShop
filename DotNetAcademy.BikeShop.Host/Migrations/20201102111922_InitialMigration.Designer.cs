﻿// <auto-generated />
using System;
using DotNetAcademy.BikeShop.Host.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetAcademy.BikeShop.Host.Migrations
{
    [DbContext(typeof(BikeShopDbContext))]
    [Migration("20201102111922_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetAcademy.BikeShop.Host.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DotNetAcademy.BikeShop.Host.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "tuvc4n11",
                            Price = 342.73m
                        },
                        new
                        {
                            Id = 2,
                            Name = "fubvv1wc",
                            Price = 84.31m
                        },
                        new
                        {
                            Id = 3,
                            Name = "yhzamnhx",
                            Price = 410.88m
                        },
                        new
                        {
                            Id = 4,
                            Name = "mhxvvji1",
                            Price = 395.78m
                        },
                        new
                        {
                            Id = 5,
                            Name = "dgtwys2j",
                            Price = 285.85m
                        },
                        new
                        {
                            Id = 6,
                            Name = "rihtbyub",
                            Price = 231.5m
                        },
                        new
                        {
                            Id = 7,
                            Name = "fxbdsgoi",
                            Price = 197.7m
                        },
                        new
                        {
                            Id = 8,
                            Name = "rz13qlcw",
                            Price = 144.59m
                        },
                        new
                        {
                            Id = 9,
                            Name = "o1w05rkl",
                            Price = 403.41m
                        },
                        new
                        {
                            Id = 10,
                            Name = "23xrc3ds",
                            Price = 327.01m
                        },
                        new
                        {
                            Id = 11,
                            Name = "htx4v0jf",
                            Price = 290.68m
                        },
                        new
                        {
                            Id = 12,
                            Name = "lqwimrop",
                            Price = 51.75m
                        },
                        new
                        {
                            Id = 13,
                            Name = "hjenrs3h",
                            Price = 168.78m
                        },
                        new
                        {
                            Id = 14,
                            Name = "nclb4cmp",
                            Price = 272.49m
                        },
                        new
                        {
                            Id = 15,
                            Name = "qwybbigy",
                            Price = 270.16m
                        },
                        new
                        {
                            Id = 16,
                            Name = "1btwkjon",
                            Price = 167.6m
                        },
                        new
                        {
                            Id = 17,
                            Name = "lhn2mg52",
                            Price = 348.57m
                        },
                        new
                        {
                            Id = 18,
                            Name = "nbl0d3g1",
                            Price = 121.52m
                        },
                        new
                        {
                            Id = 19,
                            Name = "22u1ddfs",
                            Price = 213.14m
                        },
                        new
                        {
                            Id = 20,
                            Name = "5yxxfzb1",
                            Price = 374.06m
                        },
                        new
                        {
                            Id = 21,
                            Name = "tid3t5pv",
                            Price = 393.28m
                        },
                        new
                        {
                            Id = 22,
                            Name = "jmcduui1",
                            Price = 204.2m
                        },
                        new
                        {
                            Id = 23,
                            Name = "fpvq4dqh",
                            Price = 459.41m
                        },
                        new
                        {
                            Id = 24,
                            Name = "lcafmzca",
                            Price = 147.83m
                        },
                        new
                        {
                            Id = 25,
                            Name = "r1afst1r",
                            Price = 393.89m
                        },
                        new
                        {
                            Id = 26,
                            Name = "z3q50sp2",
                            Price = 200.73m
                        },
                        new
                        {
                            Id = 27,
                            Name = "lxdphgg4",
                            Price = 5.34m
                        },
                        new
                        {
                            Id = 28,
                            Name = "fyksi4dq",
                            Price = 200.9m
                        },
                        new
                        {
                            Id = 29,
                            Name = "2hbctiw2",
                            Price = 464.29m
                        },
                        new
                        {
                            Id = 30,
                            Name = "req1etdr",
                            Price = 146.9m
                        },
                        new
                        {
                            Id = 31,
                            Name = "o0v1oj33",
                            Price = 459.8m
                        },
                        new
                        {
                            Id = 32,
                            Name = "3f3vbm3v",
                            Price = 353.24m
                        },
                        new
                        {
                            Id = 33,
                            Name = "ac3e304u",
                            Price = 444.5m
                        },
                        new
                        {
                            Id = 34,
                            Name = "scaqjav2",
                            Price = 94.83m
                        },
                        new
                        {
                            Id = 35,
                            Name = "pkikuauc",
                            Price = 59.95m
                        },
                        new
                        {
                            Id = 36,
                            Name = "ikirg41v",
                            Price = 364.57m
                        },
                        new
                        {
                            Id = 37,
                            Name = "gdjejqwz",
                            Price = 390.53m
                        },
                        new
                        {
                            Id = 38,
                            Name = "jowhcqq0",
                            Price = 493.75m
                        },
                        new
                        {
                            Id = 39,
                            Name = "q54co1yc",
                            Price = 225.28m
                        },
                        new
                        {
                            Id = 40,
                            Name = "c3c422cs",
                            Price = 206.33m
                        },
                        new
                        {
                            Id = 41,
                            Name = "npprnlip",
                            Price = 432.51m
                        },
                        new
                        {
                            Id = 42,
                            Name = "n52p0is4",
                            Price = 4.96m
                        },
                        new
                        {
                            Id = 43,
                            Name = "3drxx4zt",
                            Price = 419.37m
                        },
                        new
                        {
                            Id = 44,
                            Name = "sbv4edwp",
                            Price = 249.19m
                        },
                        new
                        {
                            Id = 45,
                            Name = "g1z3ice4",
                            Price = 139.42m
                        },
                        new
                        {
                            Id = 46,
                            Name = "vky44urr",
                            Price = 114.3m
                        },
                        new
                        {
                            Id = 47,
                            Name = "ezeoqptk",
                            Price = 157.37m
                        },
                        new
                        {
                            Id = 48,
                            Name = "c205sau0",
                            Price = 401.22m
                        },
                        new
                        {
                            Id = 49,
                            Name = "n1plltlg",
                            Price = 458.15m
                        },
                        new
                        {
                            Id = 50,
                            Name = "xbn2s04n",
                            Price = 70.04m
                        });
                });

            modelBuilder.Entity("DotNetAcademy.BikeShop.Host.Models.ShoppingBag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShoppingBags");
                });

            modelBuilder.Entity("DotNetAcademy.BikeShop.Host.Models.ShoppingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BagId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DotNetAcademy.BikeShop.Host.Models.ShoppingBag", b =>
                {
                    b.HasOne("DotNetAcademy.BikeShop.Host.Models.Customer", "Customer")
                        .WithMany("Bags")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("DotNetAcademy.BikeShop.Host.Models.ShoppingItem", b =>
                {
                    b.HasOne("DotNetAcademy.BikeShop.Host.Models.ShoppingBag", "Bag")
                        .WithMany("Items")
                        .HasForeignKey("BagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetAcademy.BikeShop.Host.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DotNetAcademy.BikeShop.Host.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DotNetAcademy.BikeShop.Host.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DotNetAcademy.BikeShop.Host.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DotNetAcademy.BikeShop.Host.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}