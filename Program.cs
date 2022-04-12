using System;

namespace productselltask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asagidaki member-lerden ibaret Product class-i yaradin:
//            Name - mehsulun adi
//Price - mehsulun qiymeti
//Count - mehsulun sayi TotalIncome - bu mehsulun satislarindan elde olunan umumi gelir
//Sell() - mehsulun satisi metodu.Bu metod Product classindan yaradilan instance uzerinden
//her defe cagrildiqda bir eded satilmasini ifade edir.Satis bas verdikde Count azalir(productin Count - u
//sifirdisa satis bas vere bilmez) , TotalIncome artir. Name fieldininn value - su teyin olunmamsis bir product
//obyekti yaradila bilinmemelidir.Asagidaki memberlerden ibared Milk class - i yaradin ve Productdan miras verin:
//Volume - Bu xususiyyet Milkin hecmini ifade edir(Litr olaraq)
//FatRate - Bu xususiyyet sudun yagliliq faizini ifade edir(sudun nece faiz yagli oldugunu
            product apple = new product();
            apple.Name = "alma";
            apple.Price = 10;
            apple.Count = 2;
            apple.sell();
           
        }
    }
}
