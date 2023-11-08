using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//2021050114
namespace Firtmvc.Models{
    [Table("Person")]
    public class Person{
        [Key]
        public String PersonID { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        
    }
}
