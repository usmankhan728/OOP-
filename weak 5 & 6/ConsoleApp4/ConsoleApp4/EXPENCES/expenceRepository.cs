using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.EXPENCES
{
    internal class expenceRepository
    {
        private string filePath = "expenses.txt";
        public void SaveToFile(List<expenceModel> expenses)
        {
            List<string> lines = new List<string>();
            foreach (var e in expenses)
            {
                lines.Add($"{e.title},{e.amount}");
            }
            File.WriteAllLines(filePath, lines);
        }
        public List<expenceModel> ReadFromFile()
        {
            List<expenceModel> expenses = new List<expenceModel>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        expenceModel e = new expenceModel();
                        e.title = parts[0];
                        e.amount = int.Parse(parts[1]);
                        expenses.Add(e);
                    }
                }
            }
            return expenses;
        }
    }
}
