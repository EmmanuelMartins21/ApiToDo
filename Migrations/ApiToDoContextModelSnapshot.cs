﻿// <auto-generated />
using ApiToDo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiToDo.Migrations
{
    [DbContext(typeof(ApiToDoContext))]
    partial class ApiToDoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiToDo.Models.Tarefa", b =>
                {
                    b.Property<int>("IdTarefa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Concluido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ConteudoTarefa")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TituloTarefa")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTarefa");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
