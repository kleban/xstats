﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XStats.Core;

#nullable disable

namespace XStats.Core.Migrations
{
    [DbContext(typeof(XStatsContext))]
    partial class XStatsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                            Id = "caae8c45-b5fa-44ee-86de-4b34ed037814",
                            ConcurrencyStamp = "5402a323-a370-4b59-be86-bec4c6e353a6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "003e7c5f-9829-41b7-bea6-0b773f96d09e",
                            ConcurrencyStamp = "fe17c5f8-ac10-462c-8626-e01dfcac95dd",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d3ce8aca-55c4-47ca-ae20-cd2e3213081b",
                            RoleId = "caae8c45-b5fa-44ee-86de-4b34ed037814"
                        },
                        new
                        {
                            UserId = "d5715b28-0319-4888-9111-611ee87b6e92",
                            RoleId = "caae8c45-b5fa-44ee-86de-4b34ed037814"
                        },
                        new
                        {
                            UserId = "d5715b28-0319-4888-9111-611ee87b6e92",
                            RoleId = "003e7c5f-9829-41b7-bea6-0b773f96d09e"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("XStats.Core.DailyLosses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("DailyLosses");
                });

            modelBuilder.Entity("XStats.Core.EquipmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FileTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EquipmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FileTitle = "aircraft",
                            IconPath = "Images\\eq\\aircraft.png",
                            Order = 1,
                            Title = "Літаки"
                        },
                        new
                        {
                            Id = 2,
                            FileTitle = "helicopter",
                            IconPath = "Images\\eq\\helicopter.png",
                            Order = 2,
                            Title = "Гвинтокрили"
                        },
                        new
                        {
                            Id = 3,
                            FileTitle = "drone",
                            IconPath = "Images\\eq\\drone.png",
                            Order = 3,
                            Title = "Дрони"
                        },
                        new
                        {
                            Id = 4,
                            FileTitle = "anti-aircraft warfare",
                            IconPath = "Images\\eq\\anti-aircraft-warfare.png",
                            Order = 5,
                            Title = "ППО"
                        },
                        new
                        {
                            Id = 5,
                            FileTitle = "cruise missiles",
                            IconPath = "Images\\eq\\cruise-missiles.png",
                            Order = 5,
                            Title = "Крилаті ракети"
                        },
                        new
                        {
                            Id = 6,
                            FileTitle = "tank",
                            IconPath = "Images\\eq\\tank.png",
                            Order = 6,
                            Title = "Танки"
                        },
                        new
                        {
                            Id = 7,
                            FileTitle = "APC",
                            IconPath = "Images\\eq\\apc.png",
                            Order = 7,
                            Title = "БТР"
                        },
                        new
                        {
                            Id = 8,
                            FileTitle = "field artillery",
                            IconPath = "Images\\eq\\field-artillery.png",
                            Order = 8,
                            Title = "Артилерія"
                        },
                        new
                        {
                            Id = 9,
                            FileTitle = "MLP",
                            IconPath = "Images\\eq\\mlr.png",
                            Order = 9,
                            Title = "РСЗВ"
                        },
                        new
                        {
                            Id = 10,
                            FileTitle = "vehicles and fuel tanks",
                            IconPath = "Images\\eq\\vehicles-and-fuel-tanks.png",
                            Order = 10,
                            Title = "Техніка і цистерни з ПММ"
                        },
                        new
                        {
                            Id = 11,
                            FileTitle = "naval ship",
                            IconPath = "Images\\eq\\naval-ship.png",
                            Order = 11,
                            Title = "Морські кораблі"
                        },
                        new
                        {
                            Id = 12,
                            FileTitle = "special equipment",
                            IconPath = "Images\\eq\\special-equipment.png",
                            Order = 12,
                            Title = "Спец. обладнання"
                        });
                });

            modelBuilder.Entity("XStats.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = "d3ce8aca-55c4-47ca-ae20-cd2e3213081b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f276ace3-43a4-4596-ba75-2c568c113340",
                            Email = "admin@xstats.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@XSTATS.COM",
                            NormalizedUserName = "ADMIN@XSTATS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFz70pJEXpmJTRYoz6jwLpx/xjgC7PDVp0y0Ph5/3qSNJYt477dHZ8mLaAwuqbychg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "322c6395-1194-40cc-9869-309c4db93eea",
                            TwoFactorEnabled = false,
                            UserName = "admin@xstats.com"
                        },
                        new
                        {
                            Id = "d5715b28-0319-4888-9111-611ee87b6e92",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "90f5bc73-81d7-4683-b3f7-ec9f52fed10f",
                            Email = "user@xstats.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@XSTATS.COM",
                            NormalizedUserName = "USER@XSTATS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEH0mjB6l3+D/tOiG4dX4jVCP50K3o+4AAwrzHsP1r9iJyQk9XDmKyWupEhTBNMulUQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ff0182d2-248d-47ac-917a-6b4bdce2735d",
                            TwoFactorEnabled = false,
                            UserName = "user@xstats.com"
                        });
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
                    b.HasOne("XStats.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("XStats.Core.User", null)
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

                    b.HasOne("XStats.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("XStats.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XStats.Core.DailyLosses", b =>
                {
                    b.HasOne("XStats.Core.EquipmentType", "Type")
                        .WithMany("Losses")
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("XStats.Core.EquipmentType", b =>
                {
                    b.Navigation("Losses");
                });
#pragma warning restore 612, 618
        }
    }
}
