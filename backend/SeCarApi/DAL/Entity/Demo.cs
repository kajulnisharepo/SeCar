using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace SeCarApi.DAL.Entity
{
    [Table ("demo")]
    public class Demo
    {
        [Key,Required]
        public long Id { get; set; }

        [Required]
        [NotNull]
        public string Name { get; set; } = default!;

        public bool IsComplete { get; set; } = false;
    }
}