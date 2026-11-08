using System;
using System.Collections.Generic;
using System.Text;

namespace taks11.cs
{
    internal class studentRepository
    {
        string path = "student.txt";

        public void Save(studentModel s)
        {
            File.WriteAllText(path, s.Name);
        }
    }
}
