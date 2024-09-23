using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTry.Model
{
	public class Category
	{
		[Key]
		[Column("CategoryID", TypeName =  "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

		[Column("CategoryName", TypeName = "varchar(250)")]
        public string CategoryName { get; set; }
    }
}

