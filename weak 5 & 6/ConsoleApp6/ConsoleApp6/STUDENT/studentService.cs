using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.STUDENT
{
    internal class studentService
    {
        studentRepository repo = new studentRepository();
        public void add(studentModel s)
        {
            repo.addstu(s);
        }

        public List<studentModel> data()
        {
            return repo.fetch();
        }

        public bool check(int cid,List<studentModel> students)
        {
            foreach(studentModel s in students)
            {
                if(cid == s.id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
