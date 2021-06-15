﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TuwaiqCVMaker.Models
{
    public class Bill
    {
        public Bill()
        {
            CreatedAt = DateTime.Now;
        }
        
        public int Id { get; set; }
        public DateTime CreatedAt { get; }
        [Required]
        [Column(TypeName = "decimal(19, 4)")]
        public decimal Amount { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Tax { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Total { get; set; }
        [Required] public int UserId { get; set; }
        [JsonIgnore] public ApplicationUser User { get; set; }
    }
}