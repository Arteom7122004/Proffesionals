using System;
using System.Collections.Generic;

namespace MIS;

public partial class Patient
{
    public byte[]? Photo { get; set; }

    public string Name { get; set; } = null!;

    public string? Surname { get; set; }

    public string Lastname { get; set; } = null!;

    public string PassportNumberAndSeries { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string? Address { get; set; }

    public int? Phone { get; set; }

    public string? Email { get; set; }

    public string MedicalCardNumber { get; set; } = null!;

    public DateTime DataOnTheIssuanceOfAMedicalCard { get; set; }

    public DateOnly? DateOfLastAccess { get; set; }

    public DateOnly? DateOfNextScheduledVisit { get; set; }

    public string InsurancePolicyNumber { get; set; } = null!;

    public DateOnly DataOnTerminationOfInsurancePolicy { get; set; }

    public string? Diagnosis { get; set; }

    public string? DiseaseHistory { get; set; }

    public int Id { get; set; }

    public string? Sex { get; set; }
}
