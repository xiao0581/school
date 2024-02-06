namespace School
{
    public interface IStudent
    {
        int Semester { get; set; }

        void GeneralValidator();
        string ToString();
        void ValidateName();
        void ValidateSemester();
    }
}