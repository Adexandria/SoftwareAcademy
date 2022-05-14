using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public class Academy
    {
        public Academy(Programme programme)
        {
            this.Programme = programme;
            if (this.Programme == Programme.Backend)
            {
                this.Days = GetBackendDays();
            }
            else
            {
                this.Days = GetFrontendDays();
            }
        }
        public Programme Programme { get; set; }
        public List<Day> Days { get; set; }

        private  List<Day> GetFrontendDays()
        {
            List<Day> frontendDays = new List<Day>
            {
                Day.Tuesday,
                Day.Wednesday,
                Day.Thursday
            };
            return frontendDays;
        }
        private List<Day> GetBackendDays()
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
