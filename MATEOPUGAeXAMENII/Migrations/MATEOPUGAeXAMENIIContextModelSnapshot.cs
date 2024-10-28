﻿// <auto-generated />
using MATEOPUGAeXAMENII.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MATEOPUGAeXAMENII.Migrations
{
    [DbContext(typeof(MATEOPUGAeXAMENIIContext))]
    partial class MATEOPUGAeXAMENIIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MATEOPUGAeXAMENII.Models.MPLIBRO", b =>
                {
                    b.Property<int>("MP_LibroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MP_LibroID"));

                    b.Property<string>("MP_Autor")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MP_FechaPublicacion")
                        .HasColumnType("int");

                    b.Property<decimal>("MP_HoraAgregacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MP_NombreLibro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("MP_Nuevo")
                        .HasColumnType("bit");

                    b.HasKey("MP_LibroID");

                    b.ToTable("MPLIBRO");
                });
#pragma warning restore 612, 618
        }
    }
}
