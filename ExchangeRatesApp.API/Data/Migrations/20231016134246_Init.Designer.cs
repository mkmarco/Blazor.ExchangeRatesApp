﻿// <auto-generated />
using ExchangeRatesApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExchangeRatesApp.API.Data.Migrations
{
    [DbContext(typeof(ExchangeRatesAppDbContext))]
    [Migration("20231016134246_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExchangeRatesApp.API.Entities.CurrencyRates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EffectiveDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Table")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurrencyRates");
                });

            modelBuilder.Entity("ExchangeRatesApp.API.Entities.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrencyRatesId")
                        .HasColumnType("int");

                    b.Property<double>("Mid")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyRatesId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("ExchangeRatesApp.API.Entities.Rate", b =>
                {
                    b.HasOne("ExchangeRatesApp.API.Entities.CurrencyRates", "CurrencyRates")
                        .WithMany("Rates")
                        .HasForeignKey("CurrencyRatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrencyRates");
                });

            modelBuilder.Entity("ExchangeRatesApp.API.Entities.CurrencyRates", b =>
                {
                    b.Navigation("Rates");
                });
#pragma warning restore 612, 618
        }
    }
}
