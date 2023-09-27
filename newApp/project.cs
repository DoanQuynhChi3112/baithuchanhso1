//DOAN THI QUYNH CHI - 20201050114
using NewApp.Models;

public class project{   
     public static void Main(String[] args){
     Fruit frt = new Fruit();
       string FruitName ="Orange";
       int b = 30000 ;
       
       Console.WriteLine("{0}  thanh tien la: {1} ", FruitName, frt.ThanhTien(b));
    }
}
