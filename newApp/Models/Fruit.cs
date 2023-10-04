namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public int weight {get; set;}
       

        
       public void NhapThongTin()
       {

        System.Console.Write("Fruitname = ");
        FruitName = Console.ReadLine();
        System.Console.Write("weight = ");
       
        // try...catch -Fruit
        try{
            weight = Convert.ToInt16(Console.ReadLine());
        } catch(Exception e)
        {
            weight = 0;
        }

    }
    public void HienThi()
    {
        System.Console.WriteLine("{0} + {1} " , FruitName, weight);
    }
}
 }