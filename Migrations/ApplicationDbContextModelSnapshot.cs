﻿// <auto-generated />
using System;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecommerce.Models.AppUser", b =>
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("Ecommerce.Models.Brand", b =>
                {
                    b.Property<int>("brand_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("brand_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("brand_ID");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            brand_ID = 1,
                            brand_Name = "Apple"
                        },
                        new
                        {
                            brand_ID = 2,
                            brand_Name = "Samsung"
                        },
                        new
                        {
                            brand_ID = 3,
                            brand_Name = "Xiaomi"
                        },
                        new
                        {
                            brand_ID = 4,
                            brand_Name = "Oppo"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Categories", b =>
                {
                    b.Property<int>("categories_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categories_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categories_ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            categories_ID = 1,
                            categories_Name = "Điện thoại"
                        },
                        new
                        {
                            categories_ID = 2,
                            categories_Name = "Phụ kiện"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Comment", b =>
                {
                    b.Property<int>("comment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comment_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("comment_CreateOnDay")
                        .HasColumnType("datetime2");

                    b.Property<int?>("customer_ID")
                        .HasColumnType("int");

                    b.Property<int?>("product_ID")
                        .HasColumnType("int");

                    b.HasKey("comment_ID");

                    b.HasIndex("customer_ID");

                    b.HasIndex("product_ID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Ecommerce.Models.Customer", b =>
                {
                    b.Property<int>("customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customer_AddressShip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("customer_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Ecommerce.Models.DeliveryCost", b =>
                {
                    b.Property<int>("deliverycost_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("deliverycost_AreaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("deliverycost_Cost")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("deliverycost_ID");

                    b.ToTable("DeliveryCosts");

                    b.HasData(
                        new
                        {
                            deliverycost_ID = 1,
                            deliverycost_AreaName = "Nội thành",
                            deliverycost_Cost = 20000m
                        },
                        new
                        {
                            deliverycost_ID = 6,
                            deliverycost_AreaName = "Ngoại thành",
                            deliverycost_Cost = 50000m
                        },
                        new
                        {
                            deliverycost_ID = 7,
                            deliverycost_AreaName = "Miền Bắc",
                            deliverycost_Cost = 100000m
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.HeDieuHanh", b =>
                {
                    b.Property<int>("hdh_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hdh_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hdh_ID");

                    b.ToTable("HeDieuHanhs");

                    b.HasData(
                        new
                        {
                            hdh_ID = 1,
                            hdh_Name = "iOS"
                        },
                        new
                        {
                            hdh_ID = 2,
                            hdh_Name = "Android"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Order", b =>
                {
                    b.Property<int>("order_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("customer_ID")
                        .HasColumnType("int");

                    b.Property<int?>("deliverycost_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("order_CreateOnDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("order_PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("order_PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("order_Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("promotion_ID")
                        .HasColumnType("int");

                    b.HasKey("order_ID");

                    b.HasIndex("customer_ID");

                    b.HasIndex("deliverycost_ID");

                    b.HasIndex("promotion_ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ecommerce.Models.OrderDetail", b =>
                {
                    b.Property<int>("orderdetail_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("order_ID")
                        .HasColumnType("int");

                    b.Property<int>("orderdetail_Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("product_ID")
                        .HasColumnType("int");

                    b.HasKey("orderdetail_ID");

                    b.HasIndex("order_ID");

                    b.HasIndex("product_ID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.Property<int>("product_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("brand_ID")
                        .HasColumnType("int");

                    b.Property<int?>("categories_ID")
                        .HasColumnType("int");

                    b.Property<int?>("hdh_ID")
                        .HasColumnType("int");

                    b.Property<string>("product_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("product_Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("product_Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("supplier_ID")
                        .HasColumnType("int");

                    b.HasKey("product_ID");

                    b.HasIndex("brand_ID");

                    b.HasIndex("categories_ID");

                    b.HasIndex("hdh_ID");

                    b.HasIndex("supplier_ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            product_ID = 1,
                            brand_ID = 1,
                            categories_ID = 1,
                            hdh_ID = 1,
                            product_Description = "iPhone 11 - 64GB",
                            product_Image = "iphone-11.png",
                            product_Name = "iPhone 11",
                            product_Price = 1200m,
                            product_Quantity = 100,
                            supplier_ID = 1
                        },
                        new
                        {
                            product_ID = 2,
                            brand_ID = 1,
                            categories_ID = 1,
                            hdh_ID = 1,
                            product_Description = "iPhone 12 - 64GB",
                            product_Image = "iphone-12.png",
                            product_Name = "iPhone 12",
                            product_Price = 1290m,
                            product_Quantity = 100,
                            supplier_ID = 1
                        },
                        new
                        {
                            product_ID = 3,
                            brand_ID = 1,
                            categories_ID = 1,
                            hdh_ID = 1,
                            product_Description = "iPhone 12 - 64GB",
                            product_Image = "iphone-12-pro.png",
                            product_Name = "iPhone 12 Pro",
                            product_Price = 1400m,
                            product_Quantity = 100,
                            supplier_ID = 1
                        },
                        new
                        {
                            product_ID = 4,
                            brand_ID = 2,
                            categories_ID = 1,
                            hdh_ID = 2,
                            product_Description = "Samsung Galaxy S20 - New 100% fullbox",
                            product_Image = "samsung-galaxy-s20.png",
                            product_Name = "Samsung Galaxy S20",
                            product_Price = 1350m,
                            product_Quantity = 100,
                            supplier_ID = 2
                        },
                        new
                        {
                            product_ID = 5,
                            brand_ID = 4,
                            categories_ID = 1,
                            hdh_ID = 2,
                            product_Description = "Oppo A93 - New 100% fullbox",
                            product_Image = "oppo-a93.png",
                            product_Name = "Oppo A93",
                            product_Price = 1000m,
                            product_Quantity = 100,
                            supplier_ID = 2
                        },
                        new
                        {
                            product_ID = 6,
                            brand_ID = 3,
                            categories_ID = 1,
                            hdh_ID = 2,
                            product_Description = "Xiaomi Mi 10T Pro 64GB - New 100% fullbox",
                            product_Image = "xiaomi-mi-10t-pro.png",
                            product_Name = "Xiaomi Mi 10T Pro",
                            product_Price = 1100m,
                            product_Quantity = 100,
                            supplier_ID = 1
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Promotion", b =>
                {
                    b.Property<int>("promotion_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("promotion_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("promotion_Percent")
                        .HasColumnType("int");

                    b.HasKey("promotion_ID");

                    b.ToTable("Promotions");

                    b.HasData(
                        new
                        {
                            promotion_ID = 1,
                            promotion_Name = "Chiết khấu mặc định",
                            promotion_Percent = 0
                        },
                        new
                        {
                            promotion_ID = 2,
                            promotion_Name = "Giảm 10% cho sản phẩm",
                            promotion_Percent = 10
                        },
                        new
                        {
                            promotion_ID = 3,
                            promotion_Name = "Giảm 15% đơn hàng",
                            promotion_Percent = 15
                        },
                        new
                        {
                            promotion_ID = 4,
                            promotion_Name = "Giảm 50% cho mỗi đơn hàng",
                            promotion_Percent = 50
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.Supplier", b =>
                {
                    b.Property<int>("supplier_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("supplier_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("supplier_ID");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            supplier_ID = 1,
                            supplier_Name = "FPT Telecom"
                        },
                        new
                        {
                            supplier_ID = 2,
                            supplier_Name = "Thế Giới Di Động"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = "4d5ab53a-900c-4658-bd5d-55280e9eea20",
                            ConcurrencyStamp = "aaf79e53-18d1-4d8f-87e5-45baba18b95c",
                            Name = "Adminstrator",
                            NormalizedName = "ADMINSTRATOR"
                        });
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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ecommerce.Models.Comment", b =>
                {
                    b.HasOne("Ecommerce.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("customer_ID");

                    b.HasOne("Ecommerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_ID");
                });

            modelBuilder.Entity("Ecommerce.Models.Order", b =>
                {
                    b.HasOne("Ecommerce.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("customer_ID");

                    b.HasOne("Ecommerce.Models.DeliveryCost", "DeliveryCost")
                        .WithMany("Orders")
                        .HasForeignKey("deliverycost_ID");

                    b.HasOne("Ecommerce.Models.Promotion", "Promotion")
                        .WithMany()
                        .HasForeignKey("promotion_ID");
                });

            modelBuilder.Entity("Ecommerce.Models.OrderDetail", b =>
                {
                    b.HasOne("Ecommerce.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("order_ID");

                    b.HasOne("Ecommerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_ID");
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.HasOne("Ecommerce.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("brand_ID");

                    b.HasOne("Ecommerce.Models.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("categories_ID");

                    b.HasOne("Ecommerce.Models.HeDieuHanh", "HeDieuHanh")
                        .WithMany("Products")
                        .HasForeignKey("hdh_ID");

                    b.HasOne("Ecommerce.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("supplier_ID");
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
                    b.HasOne("Ecommerce.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ecommerce.Models.AppUser", null)
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

                    b.HasOne("Ecommerce.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ecommerce.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
