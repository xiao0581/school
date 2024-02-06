using School;
using System.Diagnostics;

namespace school
{
    public class teacher : Person, Iteacher
    {

        public double Salary { get; set; }
        public List<String> Class { get; set; } = new List<string>();


        public override string ToString() =>
            $"{Id},{Name},{Salary}";

        public void ValidateName()
        {
            base.ValidateName();

        }

        public void ValidateSalary()
        {

            if (Salary <= 0)
            {
                throw new ArgumentOutOfRangeException("Salary is zero og less");
            }
        }
        public void GeneralValidator()
        {

            ValidateSalary();
            ValidateName();

        }

        public override bool Equals(object? obj)
        {
            return obj is teacher teacher &&
                   Id == teacher.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}