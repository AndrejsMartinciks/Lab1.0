﻿namespace Lab1Library
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentId { get; set; }
        public string StudentGroup { get; set; }
        public string Email { get; set; }

        private Student() { }

        public Student(string studentName, string studentSurname, string studentId, string studentGroup, string email)
        {
            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(studentSurname) || string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(studentGroup) || string.IsNullOrEmpty(email))
            {
                throw new Exception("Invalid student data!");
            }

            StudentName = studentName;
            StudentSurname = studentSurname;
            StudentId = studentId;
            StudentGroup = studentGroup;
            Email = email;
        }

        public override string ToString()
        {
            return $" StudentName:{StudentId} StudentName:{StudentName} StudentSurname:{StudentSurname} StudentGroup:{StudentGroup} Email: {Email}";
        }
    }
}
