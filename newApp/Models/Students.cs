 namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public string StudentID {get; set;}
        
        
   
    // phuong co gia tri tra ve-student
        public Students ()
        {
            Name = "ho ten mac dinh";
            Address =" Phu Tho";
            StudentID ="2021050114";
        }
        public int GetYearOfBirth(int age)
    {
        int yearOfBirth = 2023-age;
        return yearOfBirth;
    }

        // pulic void HienThi()
        //     {
                
        //         System.Console.WriteLine("{0}-{1}-{2} ",Name, Address, StudentID);
        //     }
        //  public void Display2(string ten, int tuoi)
        //     {
                
        //         System.Console.WriteLine("{0}-{1} ",ten, tuoi);
        //     }
    }
 } 