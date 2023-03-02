﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationApi.Models;

public class Student
{
    public int Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; } = string.Empty;

    [StringLength(2)]
    public string State { get; set; } = string.Empty;

    public int? SAT { get; set; }

    [Column(TypeName = "decimal(3,2)")]
    public decimal GPA { get; set; } 

    public int MajorId { get; set; }
    public virtual Major? Major { get; set; } 

}
