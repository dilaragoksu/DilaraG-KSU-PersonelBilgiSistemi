using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiSistemiDAL
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MaxLength(11)]
        //[Index(IsUnique = true)]
        public string TCIndentityNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; } 
        public string Cinsiyet { get; set; }
        public string OgrenimDurumu { get; set; }
        public decimal? Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public Department DepartmentName { get; set; }
    }
}
