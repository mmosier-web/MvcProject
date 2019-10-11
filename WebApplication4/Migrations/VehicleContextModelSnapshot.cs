﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcProject;

namespace MvcProject.Migrations
{
    [DbContext(typeof(VehicleContext))]
    partial class VehicleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcProject.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Image");

                    b.Property<string>("Make");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<string>("Title");

                    b.Property<string>("Year");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 1, Category = "Sports Car", Image = "/Images/mclaren-570s-spider-design-edition.jpg", Make = "McLaren", Manufacturer = "McLaren Automotives", Model = "570 Spyder", Title = "McLaren 570 Spyder", Year = "2015 - Present" },
                        new { ID = 2, Category = "Pick Up Truck", Image = "/Images/ram.jpg", Make = "Ram", Manufacturer = "Fiat Chrysler Automobiles", Model = "1500", Title = "Ram 1500", Year = "1981 - Present" },
                        new { ID = 3, Category = "Sports Car", Image = "/Images/mustang.jpg", Make = "Ford", Manufacturer = "Ford Motor Company", Model = "Mustang", Title = "Ford Mustang", Year = "1964 - Present" },
                        new { ID = 4, Category = " Muscle Car", Image = "/Images/camero.jpg", Make = "Chevrolet", Manufacturer = "General Motors", Model = "Camaro", Title = "Chevy Camaro", Year = "1966 - Present" },
                        new { ID = 5, Category = "90's Ricer Dream", Image = "/Images/prelude.jpg", Make = "Honda", Manufacturer = "Honda Motor Company Ltd.", Model = "Prelude", Title = "Honda Prelude", Year = "1978 - 2001" }
                    );
                });

            modelBuilder.Entity("MvcProject.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<string>("Image");

                    b.Property<int>("ProductID");

                    b.Property<int>("Rating");

                    b.Property<string>("Title");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { ID = 1, Content = "This Car Is Super Fast", Image = "/Images/mclaren-570s-spider-design-edition.jpg", ProductID = 1, Rating = 5, Title = "McLaren 570 Spyder", UserName = "SpyderMan" },
                        new { ID = 2, Content = "Very Expensive", Image = "/Images/mclaren-570s-spider-design-edition.jpg", ProductID = 1, Rating = 1, Title = "McLaren 570 Spyder", UserName = "Janitor" },
                        new { ID = 3, Content = "Guts, Glory, Ram", Image = "/Images/ram.jpg", ProductID = 2, Rating = 3, Title = "Ram 1500", UserName = "Truck Fan" },
                        new { ID = 4, Content = "It's a good truck. Good gas mileage.", Image = "/Images/ram.jpg", ProductID = 2, Rating = 3, Title = "Ram 1500", UserName = "Tater.Mpeg" },
                        new { ID = 5, Content = "Unparralled Performace", Image = "/Images/mustang.jpg", ProductID = 3, Rating = 4, Title = "Ford Mustang", UserName = "Horse Breeder" },
                        new { ID = 6, Content = "Doesn't fit taller people.", Image = "/Images/mustang.jpg", ProductID = 3, Rating = 2, Title = "Ford Mustang", UserName = "Too Tall For Life" },
                        new { ID = 7, Content = "This car puts the thrill in every ride", Image = "/Images/camero.jpg", ProductID = 4, Rating = 4, Title = "Chevy Camaro", UserName = "Bumblebee" },
                        new { ID = 8, Content = "This car has transformed my life.", Image = "/Images/camero.jpg", ProductID = 4, Rating = 5, Title = "Chevy Camaro", UserName = "Optimus Prime" },
                        new { ID = 9, Content = "Sporty Coupe!", Image = "/Images/prelude.jpg", ProductID = 5, Rating = 3, Title = "Honda Prelude", UserName = "Father Time" },
                        new { ID = 10, Content = "This was my first car. It brings back memories.", Image = "/Images/prelude.jpg", ProductID = 5, Rating = 5, Title = "Honda Prelude", UserName = "Nostalgia" }
                    );
                });

            modelBuilder.Entity("MvcProject.Models.Review", b =>
                {
                    b.HasOne("MvcProject.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
