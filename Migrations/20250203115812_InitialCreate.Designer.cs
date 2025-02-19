﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250203115812_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("API.Entity.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerId")
                        .HasColumnType("TEXT");

                    b.HasKey("CartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("API.Entity.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("API.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Apple Watch Series",
                            ImageUrl = "1.jpg",
                            IsActive = true,
                            Name = "Apple Watch Series 1",
                            Price = 70000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            Description = "Samsung's flagship smartphone",
                            ImageUrl = "2.jpg",
                            IsActive = true,
                            Name = "Samsung Galaxy S21",
                            Price = 150000m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 3,
                            Description = "Apple's latest iPhone",
                            ImageUrl = "3.jpg",
                            IsActive = true,
                            Name = "iPhone 14 Pro",
                            Price = 200000m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 4,
                            Description = "High performance at an affordable price",
                            ImageUrl = "4.jpg",
                            IsActive = true,
                            Name = "Xiaomi Mi 11",
                            Price = 100000m,
                            Stock = 70
                        },
                        new
                        {
                            Id = 5,
                            Description = "Foldable smartphone with cutting-edge design",
                            ImageUrl = "5.jpg",
                            IsActive = true,
                            Name = "Samsung Galaxy Z Fold 4",
                            Price = 250000m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 6,
                            Description = "Compact and powerful",
                            ImageUrl = "6.jpg",
                            IsActive = true,
                            Name = "iPhone SE (2023)",
                            Price = 80000m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 7,
                            Description = "Google's AI-powered smartphone",
                            ImageUrl = "7.jpg",
                            IsActive = true,
                            Name = "Google Pixel 7",
                            Price = 140000m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 8,
                            Description = "Fast and smooth flagship experience",
                            ImageUrl = "8.jpg",
                            IsActive = true,
                            Name = "OnePlus 11",
                            Price = 130000m,
                            Stock = 60
                        },
                        new
                        {
                            Id = 9,
                            Description = "Compact and professional-grade camera",
                            ImageUrl = "9.jpg",
                            IsActive = true,
                            Name = "Sony Xperia 5 IV",
                            Price = 120000m,
                            Stock = 25
                        },
                        new
                        {
                            Id = 10,
                            Description = "Affordable mid-range smartphone",
                            ImageUrl = "10.jpg",
                            IsActive = true,
                            Name = "Samsung Galaxy A53",
                            Price = 50000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 11,
                            Description = "Budget-friendly with great features",
                            ImageUrl = "11.jpg",
                            IsActive = true,
                            Name = "Xiaomi Redmi Note 12",
                            Price = 45000m,
                            Stock = 120
                        },
                        new
                        {
                            Id = 12,
                            Description = "Flagship performance for gamers",
                            ImageUrl = "12.jpg",
                            IsActive = true,
                            Name = "Realme GT Neo 3",
                            Price = 110000m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 13,
                            Description = "Ultimate gaming phone",
                            ImageUrl = "13.jpg",
                            IsActive = true,
                            Name = "Asus ROG Phone 6",
                            Price = 180000m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 14,
                            Description = "Compact and powerful Apple device",
                            ImageUrl = "14.jpg",
                            IsActive = true,
                            Name = "iPhone 13 Mini",
                            Price = 130000m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 15,
                            Description = "Fan Edition with flagship features",
                            ImageUrl = "15.jpg",
                            IsActive = true,
                            Name = "Samsung Galaxy S20 FE",
                            Price = 70000m,
                            Stock = 90
                        },
                        new
                        {
                            Id = 16,
                            Description = "Flagship photography and design",
                            ImageUrl = "16.jpg",
                            IsActive = true,
                            Name = "Huawei P50 Pro",
                            Price = 160000m,
                            Stock = 35
                        },
                        new
                        {
                            Id = 17,
                            Description = "Stylish design with top-notch performance",
                            ImageUrl = "17.jpg",
                            IsActive = true,
                            Name = "Oppo Find X5 Pro",
                            Price = 140000m,
                            Stock = 45
                        },
                        new
                        {
                            Id = 18,
                            Description = "High performance and sleek design",
                            ImageUrl = "18.jpg",
                            IsActive = true,
                            Name = "Motorola Edge 30 Ultra",
                            Price = 135000m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 19,
                            Description = "Budget-friendly performance device",
                            ImageUrl = "19.jpg",
                            IsActive = true,
                            Name = "Xiaomi Poco F4",
                            Price = 50000m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 20,
                            Description = "Classic Apple smartphone",
                            ImageUrl = "20.jpg",
                            IsActive = true,
                            Name = "iPhone 12",
                            Price = 100000m,
                            Stock = 70
                        },
                        new
                        {
                            Id = 21,
                            Description = "Ultimate productivity device",
                            ImageUrl = "21.jpg",
                            IsActive = true,
                            Name = "Samsung Galaxy Note 20 Ultra",
                            Price = 170000m,
                            Stock = 25
                        },
                        new
                        {
                            Id = 22,
                            Description = "Camera-centric flagship smartphone",
                            ImageUrl = "22.jpg",
                            IsActive = true,
                            Name = "Vivo X80 Pro",
                            Price = 150000m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 23,
                            Description = "Rugged and durable smartphone",
                            ImageUrl = "23.jpg",
                            IsActive = true,
                            Name = "Nokia XR20",
                            Price = 60000m,
                            Stock = 80
                        },
                        new
                        {
                            Id = 24,
                            Description = "Affordable Google experience",
                            ImageUrl = "24.jpg",
                            IsActive = true,
                            Name = "Google Pixel 6a",
                            Price = 70000m,
                            Stock = 90
                        },
                        new
                        {
                            Id = 25,
                            Description = "Premium design and performance",
                            ImageUrl = "25.jpg",
                            IsActive = true,
                            Name = "Honor Magic 4 Pro",
                            Price = 150000m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 26,
                            Description = "Gaming smartphone with powerful features",
                            ImageUrl = "26.jpg",
                            IsActive = true,
                            Name = "Xiaomi Black Shark 5",
                            Price = 120000m,
                            Stock = 50
                        });
                });

            modelBuilder.Entity("API.Entity.CartItem", b =>
                {
                    b.HasOne("API.Entity.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("API.Entity.Cart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
