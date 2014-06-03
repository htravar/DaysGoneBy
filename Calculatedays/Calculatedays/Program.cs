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
         //store user input in a DateTime variable
         DateTime whenBought = Convert.ToDateTime(Console.ReadLine());//this will give you the date AND the time
         Console.WriteLine();
         DateTime boughtDateOnly = whenBought.Date;//create new DateTime obj to be able to get just the date
         Console.WriteLine("Vehicle was bought on {0}.", boughtDateOnly.ToString("d"));//use "d" to display only date
       
         //get the current date on the local machine                  
         DateTime Today = DateTime.Today;//Today is a property of the DateTime struct
         DateTime todayDateOnly = Today.Date;//create new obj to be able to get just the date
         Console.WriteLine("Today's date is {0}.", todayDateOnly.ToString("d"));//use "d" to display only date

         TimeSpan daysGoneBy = todayDateOnly.Subtract(boughtDateOnly);//now subtract user date from current date with TimeSpan
         string output;
         output = "The number of days elapsed since the vehicle was bought: " + daysGoneBy.ToString("%d");
         Console.WriteLine(output);
         Console.WriteLine();

         Console.WriteLine("This is the result if you don't create a new object.");
         Console.WriteLine("Today's date: {0}.", DateTime.Today);

         Console.ReadKey();
      }//end Main method
   }

