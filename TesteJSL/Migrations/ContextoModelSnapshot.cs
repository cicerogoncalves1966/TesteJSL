﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using TesteJSL.Models;

#nullable disable

namespace TesteJSL.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TesteJSL.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Id");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ativo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Ativo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("TesteJSL.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Id");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DataPedido");

                    b.Property<int>("ClienteId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ClienteId");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Status");

                    b.Property<float>("TotalPedido")
                        .HasColumnType("BINARY_FLOAT")
                        .HasColumnName("TotalPedido");

                    b.HasKey("Id");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("TesteJSL.Models.PedidoProdutos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Id");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PedidoId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("PedidoId");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ProdutoId");

                    b.Property<int>("Quantidade")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Quantidade");

                    b.Property<float>("ValorProduto")
                        .HasColumnType("BINARY_FLOAT")
                        .HasColumnName("ValorProduto");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("BINARY_FLOAT")
                        .HasColumnName("ValorTotal");

                    b.HasKey("Id");

                    b.ToTable("PedidoProdutos");
                });

            modelBuilder.Entity("TesteJSL.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("Id");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ativo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Ativo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("Nome");

                    b.Property<float>("ValorProduto")
                        .HasColumnType("BINARY_FLOAT")
                        .HasColumnName("ValorProduto");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
