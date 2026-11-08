using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.EXPENCES
{
    internal class expenceService
    {
        expenceRepository repo = new expenceRepository();
        List<expenceModel> data = new List<expenceModel>();

        public void add(expenceModel e)
        {
            data.Add(e);
            repo.SaveToFile(data);
        }

        public List<expenceModel> view()
        {
            data = repo.ReadFromFile();
            return data;
        }
    }
}
