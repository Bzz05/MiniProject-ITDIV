using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTry.Model
{
    public class Register
    {
        [Required]
        [Column("UserName", TypeName = "varchar(250)")]
        public string RegisterName { get; set; }

        [Required]
        [Column("UserEmail", TypeName = "varchar(250)")]
        public string RegisterEmail { get; set; }

        [Required]
        [Column("UserPassword", TypeName = "varchar(250)")]
        public string RegisterPassword { get; set; }
    }
}

