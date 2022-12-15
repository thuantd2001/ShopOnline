﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(ShopOnlineContext))]
    partial class ShopOnlineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("backend.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("backend.Data.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("backend.Data.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountPercent")
                        .HasColumnType("float");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifitedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("backend.Data.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DiscountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("StatusId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("backend.Data.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage", (string)null);
                });

            modelBuilder.Entity("backend.Data.Quantity", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOfProduct")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ColorId", "SizeId");

                    b.HasIndex("ColorId");

                    b.HasIndex("SizeId");

                    b.ToTable("Quatity", (string)null);
                });

            modelBuilder.Entity("backend.Data.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorName")
                        .HasColumnType("int");

                    b.Property<int>("SizeCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SizeCategoryId");

                    b.ToTable("Size", (string)null);
                });

            modelBuilder.Entity("backend.Data.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("backend.Data.Color", b =>
                {
                    b.HasOne("backend.Data.Product", "Product")
                        .WithMany("Colors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("backend.Data.Product", b =>
                {
                    b.HasOne("backend.Data.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Data.Discount", "Discount")
                        .WithMany("Products")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Data.Status", "Status")
                        .WithMany("Products")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Discount");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("backend.Data.ProductImage", b =>
                {
                    b.HasOne("backend.Data.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("backend.Data.Quantity", b =>
                {
                    b.HasOne("backend.Data.Color", "Color")
                        .WithMany("Quantities")
                        .HasForeignKey("ColorId")
                        .IsRequired()
                        .HasConstraintName("FK_Quantity_Color");

                    b.HasOne("backend.Data.Product", "Product")
                        .WithMany("Quantities")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("FK_Quantity_Product");

                    b.HasOne("backend.Data.Size", "Size")
                        .WithMany("Quantities")
                        .HasForeignKey("SizeId")
                        .IsRequired()
                        .HasConstraintName("FK_Quantity_Size");

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("backend.Data.Size", b =>
                {
                    b.HasOne("backend.Data.Category", "SizeCategory")
                        .WithMany("Sizes")
                        .HasForeignKey("SizeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SizeCategory");
                });

            modelBuilder.Entity("backend.Data.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Sizes");
                });

            modelBuilder.Entity("backend.Data.Color", b =>
                {
                    b.Navigation("Quantities");
                });

            modelBuilder.Entity("backend.Data.Discount", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("backend.Data.Product", b =>
                {
                    b.Navigation("Colors");

                    b.Navigation("ProductImages");

                    b.Navigation("Quantities");
                });

            modelBuilder.Entity("backend.Data.Size", b =>
                {
                    b.Navigation("Quantities");
                });

            modelBuilder.Entity("backend.Data.Status", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
