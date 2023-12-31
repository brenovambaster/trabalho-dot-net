﻿// <auto-generated />
using CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD.Migrations.VeiculoDb
{
    [DbContext(typeof(VeiculoDbContext))]
    partial class VeiculoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("CRUD.Data.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ano_fabricacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Chassi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Anofabricacao = "10-12-2201",
                            Chassi = "12345678901234567",
                            Cor = "Azul",
                            Modelo = "Fusca",
                            Placa = "ABC-1234"
                        },
                        new
                        {
                            Id = 1002,
                            Anofabricacao = "10-12-2201",
                            Chassi = "1241234kc21c243c421",
                            Cor = "Vermelho",
                            Modelo = "Fusca",
                            Placa = "CDC-3213"
                        },
                        new
                        {
                            Id = 1003,
                            Anofabricacao = "10-12-2201",
                            Chassi = "124134kc24421",
                            Cor = "Prata",
                            Modelo = "Hilux 2.0",
                            Placa = "PUB-3213"
                        },
                        new
                        {
                            Id = 1004,
                            Anofabricacao = "10-12-2201",
                            Chassi = "1241234kc21c243c421",
                            Cor = "Vermelho",
                            Modelo = "Corola",
                            Placa = "PWD-2313"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
