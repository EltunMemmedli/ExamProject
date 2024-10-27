using ExamProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamProject.Service
{
    public class FileService
    {
        private string filePath = "results.txt";

        public void WriteResultToFile(Result result)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Name: {result.Name}");
                writer.WriteLine($"Surname: {result.Surname}");
                writer.WriteLine($"Email: {result.Email}");
                writer.WriteLine($"Düzgün Cavablar: {result.DuzgunCavablar}");
                writer.WriteLine($"Səhv Cavablar: {result.SehvCavablar}");
                writer.WriteLine($"İmtahan Faizi: {result.ImtahanFaizi}%");
                writer.WriteLine($"Nəticə: {result.Netice}");
                writer.WriteLine("------------------------------");
            }
        }
    }
}
