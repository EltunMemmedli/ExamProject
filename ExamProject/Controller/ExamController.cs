using ExamProject.Model;
using ExamProject.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Controller
{
    public class ExamController
    {
        ArrayList Exams;

        QuestionController questions = new();

        public ExamController()
        {
            Exams = new ArrayList();
        }

        public void AddExams(Exam imtahan)
        {
            Exams.Add(imtahan);
        }


        public void ShowExams()
        {

            foreach (Exam exam in Exams)
            {
                Console.WriteLine($"Imtahan Tarixi: {exam.Date},\n" +
                                  $"Imtahan ID-si: {exam.ID},\n" +
                                  $"Imtahan categoriyasi: {exam.Category}");
            }
        }

        public void ShowResult(string category, string name, string surname, string email)
        {
            ArrayList exams = questions.GetQuestion();
            int a = 0;
            int s = 0;
            foreach (Question sual in exams)
            {

                if (sual.Category.ToString().ToLower() == category.ToLower())
                {

                    Console.WriteLine($"{sual.Suallar}");

                    string cavab = Console.ReadLine();

                    if (cavab.ToLower() == sual.DuzgunCavab.ToLower())
                    {
                        a++;
                    }
                    else
                    {
                        s++;
                    }
                }
            }

            int total = a + s;
            double resultPercentage = total > 0 ? (double)a / total * 100 : 0; // Faiz hesablanır
            string netice = resultPercentage >= 50 ? "İmtahandan keçib!" : "İmtahandan keçməyib.";

            Console.WriteLine($"Netice: {resultPercentage}% {netice}");

            // Nəticəni Result obyektinə doldurmaq
            Result result = new Result
            {
                Name = name,
                Surname = surname,
                Email = email,
                DuzgunCavablar = a,
                SehvCavablar = s,
                ImtahanFaizi = resultPercentage,
                Netice = netice
            };

            // Fayla yazmaq üçün FileService istifadə etmək
            FileService fileService = new FileService();
            fileService.WriteResultToFile(result);
        }

    }
}
