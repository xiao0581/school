using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School
{
    public class Student : Person, IStudent
    {

        public int Semester { get; set; }

        public override string ToString() =>
                $"{Id},{Name},{Semester}";


        public void ValidateName()
        {
            base.ValidateName();

        }
        public void ValidateSemester()
        {
            if (Semester <= 1 || Semester >= 8)
            {
                throw new ArgumentOutOfRangeException("semester out of boundary");
            }

        }
        public void GeneralValidator()
        {
            ValidateName();
            ValidateSemester();

        }

    }


}
