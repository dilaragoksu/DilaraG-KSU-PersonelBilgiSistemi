using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiSistemiDAL
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required]       
        //[IndexAttribute(IsUnique=true)]
        public string DepartmentName { get; set; }
        public string Explanation { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
