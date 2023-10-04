using System.Security.Cryptography;

namespace NewApp.Models
 {
 public class Employee {
        public string FullName {get;set;}
        public string Address {get; set;}
        public string EmployeeID {get; set;}
        public int Age{get; set;}

        // phuong thuc co gia tri tra ve-Employee
        public Employee()
        {
            FullName = "Ho Ten ";
            Address ="Dia chi";
            EmployeeID ="Ma nv";
            Age = "Tuoi"
        }
        public void Nhapthongtin()
        {
            System.Console.WriteLine( "Ho ten = ");
            FullName = Console.ReadLine();
            System.Console.WriteLine(" Dia Chi = ");
            Address = Console.ReadLine();
            System.Console.WriteLine(" Ma nv");
            EmployeeID = Console.ReadLine();
            System.Console.WriteLine("Tuoi");
            try{
                Age = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e )
            {
                Age = 0;
            }
            
            }
        
        public int TinhLuong(int LuongCB)
            {
                int Luong = LuongCB + 120000;
                return Luong;
            }
         
    }
 
        