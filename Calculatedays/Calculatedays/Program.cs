using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class Program
   {
      // Display date using short date string.
      //Console.WriteLine(dateOnly.ToString("d"));

      static void Main(string[] args)
      {
         //get a date past from the user
         Console.WriteLine("Enter the date you bought your vehicle.");
         Console.WriteLine("Use this formate, 01/01/2011.");
         DateTime whenBought = Convert.ToDateTime(Console.ReadLine());//this will give you the date AND the time
         Console.WriteLine();
         DateTime boughtDateOnly = whenBought.Date;//so create an obj to extract just the date
         Console.WriteLine("Vehicle was bought on {0}.", boughtDateOnly.ToString("d"));//how to display only the date
       
         //get the current date on the local machine                  
         DateTime Today = DateTime.Today;
         DateTime dateOnly = Today.Date;
         Console.WriteLine("Today's date is {0}.", dateOnly.ToString("d"));

         TimeSpan daysGoneBy = DateTime.Today.Subtract(whenBought);
         

   
         
         Console.WriteLine("The number of days elapsed since the vehicle was bought is: {0}.", daysGoneBy);

         Console.ReadKey();
      }//end Main method
   }

