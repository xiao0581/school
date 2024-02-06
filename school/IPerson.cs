﻿namespace School
{
    public interface IPerson
    {
        GenderType Gender { get; set; }
        int Id { get; set; }
        string Name { get; set; }

        string ToString();
        void ValidateName();
    }
}