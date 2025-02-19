using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Cart> Carts => Set<Cart>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product> {
                new Product { Id = 1, Name = "Apple Watch Series 1", Description = "Apple Watch Series", ImageUrl = "1.jpg", Price = 70000, IsActive = true, Stock = 100 },
                new Product { Id = 2, Name = "Samsung Galaxy S21", Description = "Samsung's flagship smartphone", ImageUrl = "2.jpg", Price = 150000, IsActive = true, Stock = 50 },
                new Product { Id = 3, Name = "iPhone 14 Pro", Description = "Apple's latest iPhone", ImageUrl = "3.jpg", Price = 200000, IsActive = true, Stock = 30 },
                new Product { Id = 4, Name = "Xiaomi Mi 11", Description = "High performance at an affordable price", ImageUrl = "4.jpg", Price = 100000, IsActive = true, Stock = 70 },
                new Product { Id = 5, Name = "Samsung Galaxy Z Fold 4", Description = "Foldable smartphone with cutting-edge design", ImageUrl = "5.jpg", Price = 250000, IsActive = true, Stock = 20 },
                new Product { Id = 6, Name = "iPhone SE (2023)", Description = "Compact and powerful", ImageUrl = "6.jpg", Price = 80000, IsActive = true, Stock = 80 },
                new Product { Id = 7, Name = "Google Pixel 7", Description = "Google's AI-powered smartphone", ImageUrl = "7.jpg", Price = 140000, IsActive = true, Stock = 40 },
                new Product { Id = 8, Name = "OnePlus 11", Description = "Fast and smooth flagship experience", ImageUrl = "8.jpg", Price = 130000, IsActive = true, Stock = 60 },
                new Product { Id = 9, Name = "Sony Xperia 5 IV", Description = "Compact and professional-grade camera", ImageUrl = "9.jpg", Price = 120000, IsActive = true, Stock = 25 },
                new Product { Id = 10, Name = "Samsung Galaxy A53", Description = "Affordable mid-range smartphone", ImageUrl = "10.jpg", Price = 50000, IsActive = true, Stock = 100 },
                new Product { Id = 11, Name = "Xiaomi Redmi Note 12", Description = "Budget-friendly with great features", ImageUrl = "11.jpg", Price = 45000, IsActive = true, Stock = 120 },
                new Product { Id = 12, Name = "Realme GT Neo 3", Description = "Flagship performance for gamers", ImageUrl = "12.jpg", Price = 110000, IsActive = true, Stock = 40 },
                new Product { Id = 13, Name = "Asus ROG Phone 6", Description = "Ultimate gaming phone", ImageUrl = "13.jpg", Price = 180000, IsActive = true, Stock = 30 },
                new Product { Id = 14, Name = "iPhone 13 Mini", Description = "Compact and powerful Apple device", ImageUrl = "14.jpg", Price = 130000, IsActive = true, Stock = 50 },
                new Product { Id = 15, Name = "Samsung Galaxy S20 FE", Description = "Fan Edition with flagship features", ImageUrl = "15.jpg", Price = 70000, IsActive = true, Stock = 90 },
                new Product { Id = 16, Name = "Huawei P50 Pro", Description = "Flagship photography and design", ImageUrl = "16.jpg", Price = 160000, IsActive = true, Stock = 35 },
                new Product { Id = 17, Name = "Oppo Find X5 Pro", Description = "Stylish design with top-notch performance", ImageUrl = "17.jpg", Price = 140000, IsActive = true, Stock = 45 },
                new Product { Id = 18, Name = "Motorola Edge 30 Ultra", Description = "High performance and sleek design", ImageUrl = "18.jpg", Price = 135000, IsActive = true, Stock = 30 },
                new Product { Id = 19, Name = "Xiaomi Poco F4", Description = "Budget-friendly performance device", ImageUrl = "19.jpg", Price = 50000, IsActive = true, Stock = 100 },
                new Product { Id = 20, Name = "iPhone 12", Description = "Classic Apple smartphone", ImageUrl = "20.jpg", Price = 100000, IsActive = true, Stock = 70 },
                new Product { Id = 21, Name = "Samsung Galaxy Note 20 Ultra", Description = "Ultimate productivity device", ImageUrl = "21.jpg", Price = 170000, IsActive = true, Stock = 25 },
                new Product { Id = 22, Name = "Vivo X80 Pro", Description = "Camera-centric flagship smartphone", ImageUrl = "22.jpg", Price = 150000, IsActive = true, Stock = 40 },
                new Product { Id = 23, Name = "Nokia XR20", Description = "Rugged and durable smartphone", ImageUrl = "23.jpg", Price = 60000, IsActive = true, Stock = 80 },
                new Product { Id = 24, Name = "Google Pixel 6a", Description = "Affordable Google experience", ImageUrl = "24.jpg", Price = 70000, IsActive = true, Stock = 90 },
                new Product { Id = 25, Name = "Honor Magic 4 Pro", Description = "Premium design and performance", ImageUrl = "25.jpg", Price = 150000, IsActive = true, Stock = 40 },
                new Product { Id = 26, Name = "Xiaomi Black Shark 5", Description = "Gaming smartphone with powerful features", ImageUrl = "26.jpg", Price = 120000, IsActive = true, Stock = 50 },

            }
        );
    }
}