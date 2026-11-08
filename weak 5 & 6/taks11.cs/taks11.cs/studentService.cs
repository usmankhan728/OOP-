using System;
using System.Collections.Generic;
using System.Text;

namespace taks11.cs
{
    internal class studentService
    {
        studentRepository repo = new studentRepository();

        public void AddStudent(studentModel s)
        {
            if (s.Marks >= 50)
                repo.Save(s);
        }
    }
}
