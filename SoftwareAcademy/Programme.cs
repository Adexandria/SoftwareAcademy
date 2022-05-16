using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public class Programme
    {
        public Programme(AcademyProgramme academyProgramme)
        {
            this.AcademyProgramme = academyProgramme;
            if(this.AcademyProgramme == AcademyProgramme.Frontend)
            {
                this.Days = GetFrontendDays();
            }
            else
            {
                this.Days = GetBackendDays();
            }
        }
        public AcademyProgramme AcademyProgramme { get; set; }
        public List<Student> Students { get; set; }
        public List<Facilitator> Facilitators { get; set; }
        public List<Day> Days { get; set; }
       
        private List<Day> GetFrontendDays()
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
