using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.STUDENT
{
    internal class studentModel
    {
        public int id;
        public string name;
        public double feepaid;
        
        public studentModel() { }
        public studentModel(int id, string name, double feepaid)
        {
            this.id = id;
            this.name = name;
            this.feepaid = feepaid;
        }
        public override string ToString()
        {
            return $"id : {id} Name : {name} feeStatus {feepaid}";
        }
    }
}
