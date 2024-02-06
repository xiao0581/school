using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public enum GenderType
    {
        Male,Female
    }

    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenderType Gender { get; set; }

        public override string ToString() =>
            $"{Id}{Name}";

        public void ValidateName()
        {
            if (Name is null)
            {
                throw new ArgumentNullException("name is null");
            }
            if (Name.Length <= 1)
            {
                throw new ArgumentException("name has to be at least one character ");
            }

        }

    }
}
