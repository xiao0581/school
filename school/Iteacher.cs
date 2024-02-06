namespace school
{
    public interface Iteacher
    {
        List<string> Class { get; set; }
        double Salary { get; set; }

        bool Equals(object? obj);
        void GeneralValidator();
        int GetHashCode();
        string ToString();
        void ValidateName();
        void ValidateSalary();
    }
}