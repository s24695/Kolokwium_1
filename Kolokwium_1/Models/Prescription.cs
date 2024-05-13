﻿using System.Security.Principal;
using Microsoft.VisualBasic.CompilerServices;

namespace Kolokwium_1.Models;

public class Prescription
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public int IdPatient { get; set; }
    public int IdDoctor { get; set; }
}