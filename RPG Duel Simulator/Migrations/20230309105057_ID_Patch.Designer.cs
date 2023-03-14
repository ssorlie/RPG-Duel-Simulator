﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPG_Duel_Simulator.Data;

#nullable disable

namespace RPG_Duel_Simulator.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230309105057_ID_Patch")]
    partial class ID_Patch
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RPG_Duel_Simulator.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<int>("Agl")
                        .HasColumnType("int");

                    b.Property<string>("CharacterDescription")
                        .HasColumnType("VARCHAR(300)");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("End")
                        .HasColumnType("int");

                    b.Property<int>("Equipment")
                        .HasColumnType("int");

                    b.Property<int>("Intl")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Luck")
                        .HasColumnType("int");

                    b.Property<int>("Per")
                        .HasColumnType("int");

                    b.Property<int>("Spd")
                        .HasColumnType("int");

                    b.Property<int>("Str")
                        .HasColumnType("int");

                    b.Property<int>("Wil")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
