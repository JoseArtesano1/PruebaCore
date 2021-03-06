﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaCore.modelo;

namespace PruebaCore.Migrations
{
    [DbContext(typeof(PostDbContext))]
    partial class PostDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PruebaCore.modelo.Alumnos", b =>
                {
                    b.Property<int>("IdAlumno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CursoIdCurso")
                        .HasColumnType("int");

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdAlumno");

                    b.HasIndex("CursoIdCurso");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("PruebaCore.modelo.Cursos", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("IdProfesor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ProfesorIdProfesor")
                        .HasColumnType("int");

                    b.HasKey("IdCurso");

                    b.HasIndex("ProfesorIdProfesor");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("PruebaCore.modelo.Profesores", b =>
                {
                    b.Property<int>("IdProfesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdProfesor");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("PruebaCore.modelo.Alumnos", b =>
                {
                    b.HasOne("PruebaCore.modelo.Cursos", "Curso")
                        .WithMany("Alumnos")
                        .HasForeignKey("CursoIdCurso");
                });

            modelBuilder.Entity("PruebaCore.modelo.Cursos", b =>
                {
                    b.HasOne("PruebaCore.modelo.Profesores", "Profesor")
                        .WithMany("Cursos")
                        .HasForeignKey("ProfesorIdProfesor");
                });
#pragma warning restore 612, 618
        }
    }
}
