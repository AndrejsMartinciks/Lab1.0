using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab1Library
{
    public class StudentsData
    {
        public List<Student> Students { get; private set; } = new List<Student>();
        public static readonly string DefaultFilename = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "student.xml");

        public void Add(Student newStud)
        {
            if (newStud != null)
                Students.Add(newStud);
        }

        public void Save(string filename = "")
        {
            if (string.IsNullOrEmpty(filename))
                filename = DefaultFilename;

            using (var data = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                var serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(data, Students);
            }
        }

        public void Load(string filename = "")
        {
            if (string.IsNullOrEmpty(filename))
                filename = DefaultFilename;

            using (var data = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                var serializer = new XmlSerializer(typeof(List<Student>));
                Students = (List<Student>)serializer.Deserialize(data);
            }

        }
    }
}