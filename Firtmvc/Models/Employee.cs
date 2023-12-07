using System.ComponentModel.DataAnnotations;

namespace Firtmvc.Models{
    public class Employee {
        [Key]
        public string EmployeeID { get; set; }
        public string FullName {get; set;}
        public int  Age  { get; set; }
    }
}