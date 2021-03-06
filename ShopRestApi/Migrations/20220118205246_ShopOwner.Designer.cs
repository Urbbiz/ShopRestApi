// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopRestApi.Data;

#nullable disable

namespace ShopRestApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220118205246_ShopOwner")]
    partial class ShopOwner
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopRestApi.Enteties.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.ShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopItems");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.ShopOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShopOwner");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.ShopOwnerShop", b =>
                {
                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<int>("ShopOwnerId")
                        .HasColumnType("int");

                    b.HasKey("ShopId", "ShopOwnerId");

                    b.HasIndex("ShopOwnerId");

                    b.ToTable("ShopOwnerShop");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.ShopItem", b =>
                {
                    b.HasOne("ShopRestApi.Enteties.Shop", "Shop")
                        .WithMany("ShopItems")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.ShopOwnerShop", b =>
                {
                    b.HasOne("ShopRestApi.Enteties.Shop", "Shop")
                        .WithMany("ShopOwners")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopRestApi.Enteties.ShopOwner", "ShopOwner")
                        .WithMany("Shops")
                        .HasForeignKey("ShopOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");

                    b.Navigation("ShopOwner");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.Shop", b =>
                {
                    b.Navigation("ShopItems");

                    b.Navigation("ShopOwners");
                });

            modelBuilder.Entity("ShopRestApi.Enteties.ShopOwner", b =>
                {
                    b.Navigation("Shops");
                });
#pragma warning restore 612, 618
        }
    }
}
