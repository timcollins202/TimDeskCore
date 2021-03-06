// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimDeskCore.Models;

namespace TimDeskCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210614013542_SeedClientDatabaseFirstAttempt")]
    partial class SeedClientDatabaseFirstAttempt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimDeskCore.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSolution")
                        .HasColumnType("bit");

                    b.Property<int?>("TechnicianId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TechnicianId");

                    b.HasIndex("TicketId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("TimDeskCore.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "3341 University Ave",
                            City = "Utica",
                            Email = "charles@xavierschool.edu",
                            FirstName = "Charles",
                            LastName = "Xavier",
                            PhoneNumber = "332-333-1399",
                            State = "NY",
                            ZipCode = "10108"
                        });
                });

            modelBuilder.Entity("TimDeskCore.Models.Technician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Technicians");
                });

            modelBuilder.Entity("TimDeskCore.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedTechnicianId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RequestedById")
                        .HasColumnType("int");

                    b.Property<string>("TicketStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignedTechnicianId");

                    b.HasIndex("RequestedById");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TimDeskCore.Models.Activity", b =>
                {
                    b.HasOne("TimDeskCore.Models.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId");

                    b.HasOne("TimDeskCore.Models.Ticket", null)
                        .WithMany("Activities")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Technician");
                });

            modelBuilder.Entity("TimDeskCore.Models.Ticket", b =>
                {
                    b.HasOne("TimDeskCore.Models.Technician", "AssignedTechnician")
                        .WithMany()
                        .HasForeignKey("AssignedTechnicianId");

                    b.HasOne("TimDeskCore.Models.Client", "RequestedBy")
                        .WithMany()
                        .HasForeignKey("RequestedById");

                    b.Navigation("AssignedTechnician");

                    b.Navigation("RequestedBy");
                });

            modelBuilder.Entity("TimDeskCore.Models.Ticket", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
