using ExamProject.Enums;
using ExamProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Model
{
    public class Question
    {
        public string Suallar{ get; set; }
        public int ID { get; set; }
        public string DuzgunCavab { get; set; }
        public ExamCategory Category { get; set; }

        public Question(string suallar, string duzguncavab, ExamCategory category)
        {
            if(category == ExamCategory.AzDili)
            {
                QuestionID.currentAzDiliQuestionId += 1;
                this.ID = QuestionID.currentAzDiliQuestionId;
            }
            else if(category == ExamCategory.IT)
            {
                QuestionID.currentITquestionId += 1;
                this.ID = QuestionID.currentITquestionId;
            }
            else if (category == ExamCategory.Tarix)
            {
                QuestionID.currentTarixQuestionId += 1;
                this.ID = QuestionID.currentTarixQuestionId;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Bele bir categorya tapilmadir!");
            }
            this.Suallar = suallar;
            this.DuzgunCavab = duzguncavab;
            this.Category = category;
        }
    }
}
