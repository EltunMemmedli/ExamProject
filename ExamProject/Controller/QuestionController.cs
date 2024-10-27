using ExamProject.Enums;
using ExamProject.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamProject.Controller
{
    public class QuestionController
    {
        ArrayList Questions;

        ArrayList result = new ArrayList();

        public QuestionController()
        {
            Questions = new ArrayList();
        }

        public void AddQuestion(Question suallar)
        {
            Questions.Add(suallar);
        }

        public ArrayList GetQuestion()
        {
            return Questions;
        }

        public ArrayList GetResult()
        {
            return result;
        }

        public void ShowByCategory(string category)
        {
            if (category.ToLower() == ExamCategory.IT.ToString().ToLower())
            {
                foreach (Question sual in Questions)
                {
                    if (sual.Category == ExamCategory.IT)
                    {
                        Console.WriteLine($"Sual ID: {sual.ID},\n" +
                                            $"{sual.Suallar}\n");
                    }
                }
            }
            else if (category.ToLower() == ExamCategory.AzDili.ToString().ToLower()) 
            {
                foreach (Question sual in Questions)
                {
                    if (sual.Category == ExamCategory.AzDili)
                    {
                        Console.WriteLine($"Sual ID: {sual.ID},\n" +
                                            $"{sual.Suallar}\n");
                    }
                }
            }
            else if(category.ToLower() == ExamCategory.Tarix.ToString().ToLower()) 
            {
                foreach (Question sual in Questions)
                {
                    if (sual.Category == ExamCategory.Tarix)
                    {
                        Console.WriteLine($"Sual ID: {sual.ID},\n" +
                                            $"{sual.Suallar}\n");
                    }
                }
            }
        }

        public void UpdateQuestion(string category, int index, Question yenisual)
        {
            int currentIndex = 1; // 1-bazalı indeks
            foreach (Question sual in Questions)
            {
                if (sual.Category.ToString().ToLower() == category.ToLower())
                {
                    if (currentIndex == index) // Tapdığımız indeksi yoxlayırıq
                    {
                        yenisual.ID = sual.ID;
                        Questions[Questions.IndexOf(sual)] = yenisual; // Sualları yeniləyirik

                        Console.WriteLine("Sual güncəlləndi.");
                        return;
                    }
                    currentIndex++;
                }
            }
            Console.WriteLine("Verilən indeks düzgün deyil.");
        }

        public void StartTheExam(string category)
        {
            int a = 0;
            int s = 0;
            foreach(Question sual in Questions)
            {
                
                if (sual.Category.ToString().ToLower() == category.ToLower())
                {
                    
                    Console.WriteLine($"{sual.Suallar}");

                    string cavab = Console.ReadLine();

                    if(cavab.ToLower() == sual.DuzgunCavab.ToLower())
                    {
                        a++;
                    }
                    else
                    {
                        s++;
                    }
                }
            }
            double netice = (double)a / (a + s) * 100;
            Console.WriteLine($"Netice: {netice}%");

        }
    }
}
