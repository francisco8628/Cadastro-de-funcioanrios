﻿// <auto-generated />
using System;
using ControleDeFuncionariosMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleDeFuncionariosMVC.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220519060234_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControleDeFuncionariosMVC.Models.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CargoNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CargoId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("ControleDeFuncionariosMVC.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Admissao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Situacao")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("CargoId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ControleDeFuncionariosMVC.Models.Funcionario", b =>
                {
                    b.HasOne("ControleDeFuncionariosMVC.Models.Cargo", "Cargo")
                        .WithMany("Funcionarios")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("ControleDeFuncionariosMVC.Models.Cargo", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
