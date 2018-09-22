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
            int practValue = (int)practicum;

            if(theoryGrade > 85)
            {
                return false;
            }
            if((theoryGrade > 55) && (practValue > 2))
            {
                return true;
            }

            return false;
        }
        public bool IsCumLaude()
        {   
            int practValue = (int)practicum;

            if ((theoryGrade > 85) && (practValue == 4))
            {
                return true;
            }

            return false;
        }
    }
}
