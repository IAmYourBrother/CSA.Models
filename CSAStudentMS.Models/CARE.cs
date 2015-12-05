using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAStudentMS.Models
{
    //CARE (Challenging Academically at Risk through Empowerment)
    public class CARE : Student
    {
        private string studentStatus;
        public CARE(int idnum) :base(idnum)
        {
        }

        public string StudentStatus
        {
            get { return studentStatus; }
            set { studentStatus = value; }
        }

    }
}
