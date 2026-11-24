using Microsoft.Extensions.Options;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment03; 

internal class Program
{
    static void Main(string[] args)
    {

        #region Q1 

     

        double[] arr = [25.5, 40.0, 33.75];
        Console.WriteLine(arr[1]);

        #endregion

        #region Q2
       


        int[,] shelfCopies =
        {
            { 3 , 5} ,
            { 1 , 4 }
        };
        Console.WriteLine(shelfCopies[1,0]);

        #endregion


        #region Q3
     

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        PrintWelcomeMessage();


        #endregion


        #region Q4

         
       

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title : " + title);
        }

        string title = "Clean Code";

        PrintBookTitle(title);
        #endregion


        #region Q5    

        static void AddBonusPages(int pages)
        {
            pages = pages + 50;
        }
        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages);
        // print 400 because it pass by value 


        #endregion

        #region Q6  

        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        double[] prices = [25.5, 40.0];
        ApplyDiscount(prices);
        Console.WriteLine(prices[0]);
        // print 20.5 becouse array (prices) is refrecene type 

        #endregion

        #region Q7  

        static void AddBonusPagesbyref(ref int pagess)
        {
            pagess = pagess + 50;
        }
        int pagess = 400;
        AddBonusPagesbyref(ref pagess);
        Console.WriteLine(pagess);

        //Different here is pass by refrecene but in Q5 is pass by value
        

        #endregion

        #region Q8     

        static void ReplaceArray(ref double[] prices)
        {
            prices = [10.0, 12.5, 15.0];
        }
        double[] oldpages = [20.0, 30.0, 40.0 , 45.5 , 44.99];
        ReplaceArray(ref oldpages);
        Console.WriteLine(oldpages.Length);
        

        #endregion
        
        
        #region Q9        
      
        static bool TryGetPrice(string title, out double price)
        {
            if(title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;

            }
            
        }
       bool b = TryGetPrice("Clean Code" , out double price);
        if(b)
            Console.WriteLine(price);


        #endregion

        #region Q10  

        static void  PrintBookInfo(string title, int pages = 300) {

            Console.WriteLine(title+ " " + pages);
        }

        PrintBookInfo(".NEt");
        PrintBookInfo("C#", 500);




        #endregion

        #region Q11    

        
        PrintBookInfo( pages : 400 ,  title : "PG" );



        #endregion

        #region Q12   

        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
                Console.WriteLine(title);

        }

        PrintAllTitles(".Net" , "C#" , "C++" );

        #endregion


    }
}
