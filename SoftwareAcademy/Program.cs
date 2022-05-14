using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array of 10 humans that contains 5 backend and 5 frontend
            Programme[] humans = { Programme.Frontend,Programme.Backend, Programme.Frontend, Programme.Backend, Programme.Frontend,
                Programme.Backend, Programme.Frontend, Programme.Backend, Programme.Frontend, Programme.Backend };
            
            // an array of week days
            Day[] weekDays = { Day.Monday, Day.Wednesday };
           
            // A frontend academy object
            Academy frontend = new Academy(Programme.Frontend);

            // A backend academy object
            Academy backend = new Academy(Programme.Backend);
          
            // A loop to check if the human belongs to either frontend or backend 
            // and checks if the week days is the possible weekdays for the programme
            for (int i = 0; i < humans.Length; i++)
            {
                //checks if the human belongs to the frontend programme
                if (frontend.Programme == humans[i])
                {
                    /// prints outs the human programme
                    Console.WriteLine($"{humans[i]}");
                    //checks if the week day is the possible weekday for frontend programme
                    CheckProgrammeWeekDay(frontend.Days, weekDays,0);

                }
                else
                {
                   /// prints outs the human programme
                   Console.WriteLine($"{humans[i]}");
                   //checks if the week day is the possible weekday for backend programme
                   CheckProgrammeWeekDay(backend.Days, weekDays,0);
                }
            }
        }


        //This recursion function checks if the weekdays is the possible weekdays for the programme.
        public static void CheckProgrammeWeekDay(List<Day> days,Day[] weekDay,int n)
        {
             
            //This condition checks if the length is less than 2
            if (n < 2)
            {   
                /// prints outs the weekday
                Console.WriteLine($"{weekDay[n]}");

                //Check if the week day is possible weekdays for the programme
                if (days.Contains(weekDay[n]))
                {
                    Console.WriteLine("The host will let you in shortly");
                    //Delay for 5 seconds or 5000 milliseconds
                    Task.Delay(5000);
                    Console.WriteLine("You are in!");
                }
                else
                {
                    Console.WriteLine("No class Today");
                }
                CheckProgrammeWeekDay(days, weekDay, n + 1);
            }     
        }
        
    }
}
