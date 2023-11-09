using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firtmvc.Models{
    [Table("Daily")]
    public class Daily : HeThongPhanPhoi{
      
        public String MaDaily { get; set; }
        public String TenDaily { get; set; }
        public String DiaChi { get; set; }
        public String NguoiDaiDien { get; set; }
        public String DienThoai { get; set; }
         public String MaHTPP { get; set; }
    }
}