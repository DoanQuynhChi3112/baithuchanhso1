using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firtmvc.Models{
    [Table("STD")]
    public class STD{
        [Key]
        public string STDID { get; set; }
        public string Name { get; set; }
        public string Add { get; set; } 
        
     }     

}
