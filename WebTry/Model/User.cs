using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTry.Model
{
	public class User
	{
		[Key]
		[Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserID { get; set; }

		[Required]
		[Column("UserName", TypeName = "varchar(250)")]
		public string UserName { get; set; }

		[Required]
        [Column("UserEmail", TypeName = "varchar(250)")]
        public string UserEmail { get; set; }

		[Required]
        [Column("UserPassword", TypeName = "varchar(250)")]
        public string UserPassword { get; set; }
	}
}

