using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MIS;

public partial class MisdataBaseContext : DbContext
{
    public MisdataBaseContext()
    {
    }

    public MisdataBaseContext(DbContextOptions<MisdataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2IA1AKE;Database=MISDataBase;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DataOnTerminationOfInsurancePolicy).HasColumnName("Data_on_termination_of_insurance_policy");
            entity.Property(e => e.DataOnTheIssuanceOfAMedicalCard)
                .HasColumnType("datetime")
                .HasColumnName("Data_on_the_issuance_of_a_medical_card");
            entity.Property(e => e.DateOfBirth).HasColumnName("Date_of_birth");
            entity.Property(e => e.DateOfLastAccess).HasColumnName("Date_of_last_access");
            entity.Property(e => e.DateOfNextScheduledVisit).HasColumnName("Date_of_next_scheduled_visit");
            entity.Property(e => e.Diagnosis)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DiseaseHistory)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Disease_history");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.InsurancePolicyNumber)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Insurance_policy_number");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.MedicalCardNumber)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Medical_card_number");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PassportNumberAndSeries)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Passport_number_and_series");
            entity.Property(e => e.Photo).HasColumnType("image");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
