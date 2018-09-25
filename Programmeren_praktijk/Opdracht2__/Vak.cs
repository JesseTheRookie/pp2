using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2__
{
    struct Subject
    {
        public string subjectName;
        public float theoryGrade;
        public Rating practicum;

        public bool IsBehaald()
        {
            //Value uit enum practicum halen voor if statement            
           // int practValue = (int)practicum;

            if((theoryGrade >= 55) && (practicum >= Rating.Voldoende))
            {
                return true;
            }

            return false;
        }
        public bool IsCumLaude()
        {   
            if ((theoryGrade >= 80) && (practicum >= Rating.Goed))
            {
                return true;
            }

            return false;
        }
    }
}
