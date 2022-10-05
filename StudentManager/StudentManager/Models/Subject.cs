﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManager.Models;

[Table("Subject")]
public class Subject
{
    [Key] public int Id { get; set; }

    public int? StudentId { get; set; }

    public string Title { get; set; }
}