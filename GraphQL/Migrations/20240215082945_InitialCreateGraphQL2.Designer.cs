﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StoreMarket.Contexts;

#nullable disable

namespace StoreMarket.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20240215082945_InitialCreateGraphQL2")]
    partial class InitialCreateGraphQL2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProductStore", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.Property<int>("StoresId")
                        .HasColumnType("integer");

                    b.HasKey("ProductsId", "StoresId");

                    b.HasIndex("StoresId");

                    b.ToTable("ProductStore");
                });

            modelBuilder.Entity("StoreMarket.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id")
                        .HasName("cotegory_pkey");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cotegories", (string)null);
                });

            modelBuilder.Entity("StoreMarket.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id")
                        .HasName("product_pkey");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("StoreMarket.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("store_pkey");

                    b.ToTable("Stores", (string)null);
                });

            modelBuilder.Entity("ProductStore", b =>
                {
                    b.HasOne("StoreMarket.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreMarket.Models.Store", null)
                        .WithMany()
                        .HasForeignKey("StoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreMarket.Models.Product", b =>
                {
                    b.HasOne("StoreMarket.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("StoreMarket.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
