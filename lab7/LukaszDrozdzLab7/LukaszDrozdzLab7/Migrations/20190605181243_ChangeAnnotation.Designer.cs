﻿// <auto-generated />
using System;
using LukaszDrozdzLab7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LukaszDrozdzLab7.Migrations
{
    [DbContext(typeof(SkiJumpingContest))]
    [Migration("20190605181243_ChangeAnnotation")]
    partial class ChangeAnnotation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LukaszDrozdzLab7.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<float>("Record");

                    b.HasKey("ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("LukaszDrozdzLab7.Models.Jumper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<int>("CountryID");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<float>("Height");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<float>("PersonalBest");

                    b.Property<float>("Weight");

                    b.HasKey("ID");

                    b.HasIndex("CountryID");

                    b.ToTable("Jumpers");
                });

            modelBuilder.Entity("LukaszDrozdzLab7.Models.Jumper", b =>
                {
                    b.HasOne("LukaszDrozdzLab7.Models.Country", "Country")
                        .WithMany("Jumpers")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}