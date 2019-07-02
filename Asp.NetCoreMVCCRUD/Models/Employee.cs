using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Asp.NetCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [DisplayName("Full Name")]
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field is required.")]
        public string FullName { get; set; }

        [DisplayName("Emp. Code")]
        [Column(TypeName ="varchar(10)")]
        public string EmpCode { get; set; }

        [Column(TypeName ="varchar(100)")]
        public string Position { get; set; }

        [DisplayName("Office Location")]
        [Column(TypeName ="varchar(100)")]
        public string OfficeLocation { get; set; }
    }
}
