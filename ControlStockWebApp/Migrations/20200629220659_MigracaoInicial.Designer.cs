﻿// <auto-generated />
using System;
using ControlStockWebApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlStockWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200629220659_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControlStockWebApp.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cod_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpforCnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("ControlStockWebApp.Models.Entrada", b =>
                {
                    b.Property<int>("EntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cod_Entrada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstoqueId")
                        .HasColumnType("int");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("qtde_Entrada")
                        .HasColumnType("int");

                    b.HasKey("EntradaId");

                    b.HasIndex("EstoqueId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("entradas");
                });

            modelBuilder.Entity("ControlStockWebApp.Models.Estoque", b =>
                {
                    b.Property<int>("EstoqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cod_Estoque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total_Estoque")
                        .HasColumnType("int");

                    b.HasKey("EstoqueId");

                    b.ToTable("estoques");
                });

            modelBuilder.Entity("ControlStockWebApp.Models.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cod_Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpforCnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FornecedorId");

                    b.ToTable("fornecedores");
                });

            modelBuilder.Entity("ControlStockWebApp.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cod_Produto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("ProdutoId");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("ControlStockWebApp.Models.Saida", b =>
                {
                    b.Property<int>("SaidaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Cod_Saida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstoqueId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Qtde_Saida")
                        .HasColumnType("int");

                    b.HasKey("SaidaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstoqueId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("saidas");
                });

            modelBuilder.Entity("ControlStockWebApp.Models.Entrada", b =>
                {
                    b.HasOne("ControlStockWebApp.Models.Estoque", null)
                        .WithMany("Entradas")
                        .HasForeignKey("EstoqueId");

                    b.HasOne("ControlStockWebApp.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlStockWebApp.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControlStockWebApp.Models.Saida", b =>
                {
                    b.HasOne("ControlStockWebApp.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlStockWebApp.Models.Estoque", null)
                        .WithMany("Saidas")
                        .HasForeignKey("EstoqueId");

                    b.HasOne("ControlStockWebApp.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}