using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademy
{
    public class Human
    {
        public Human(AcademyProgramme academyProgramme)
        {
            this.AcademyProgramme = academyProgramme;
        }
        public AcademyProgramme AcademyProgramme { get; set; }
        
    }
}
