// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace razor_review.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("razor_review.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("razor_review.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Province")
                        .HasColumnType("longtext");

                    b.Property<string>("StreetName")
                        .HasColumnType("longtext");

                    b.Property<int?>("StreetNumber")
                        .HasColumnType("int");

                    b.HasKey("SchoolId");

                    b.ToTable("School");
                });

            modelBuilder.Entity("razor_review.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("First")
                        .HasColumnType("longtext");

                    b.Property<string>("Last")
                        .HasColumnType("longtext");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("razor_review.Models.Class", b =>
                {
                    b.HasOne("razor_review.Models.School", "School")
                        .WithMany("AvailableClasses")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("razor_review.Models.School", b =>
                {
                    b.Navigation("AvailableClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
