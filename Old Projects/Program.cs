using System;

namespace Treehouse.FitnessFrog {
    class Program {
      
        static void Main(){
          bool keepGoing = true; 
          
          double runningTotal = 0;
          
          while(keepGoing){ //repeat until user quits
            
            //prompt user for minutes
            Console.Write("Enter number of minutes or type \"quit\" to exit: ");
            string entry = Console.ReadLine();
            
            //add minutes to total
            if (entry.ToLower() == "quit"){break;}
            
            else{
              try{
                double minutes = double.Parse(entry);
                string message = "";
              if (minutes <= 0){
                Console.WriteLine(minutes + "is not an acceptable value.");
                continue;
              }
              
              else if (minutes < 10){
                message = "Better than nothing!";
              }
              
              else{
                message = "Way to go!";
              }
                
              runningTotal += minutes;
              //display total
              Console.WriteLine("You've entered " + runningTotal + " minutes total. " + message);
              }
              catch(FormatException){
                Console.WriteLine("That is not valid input");
                continue;
              }
              
            }
            
            }
           Console.WriteLine("Thanks for using FitnessFrog! Goodbye.");
      }
  }
}