using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public class Academy
    {
        public Academy(string programme,List<Day> days )
        {
            this.Programme = programme;
            this.Days = days;
        }
        public string Programme { get; set; }
        public List<Day> Days { get; set; }

        public static List<Day> GetFrontendDays()
        {
            List<Day> frontendDays = new List<Day>
            {
                Day.Tuesday,
                Day.Wednesday,
                Day.Thursday
            };
            return frontendDays;
        }
        public static List<Day> GetBackendDays()
        {
            List<Day> backendDays = new List<Day>
            {
                Day.Monday,
                Day.Tuesday,
                Day.Thursday
            };
            return backendDays;
        }
    }
}
