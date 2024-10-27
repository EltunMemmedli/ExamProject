using ExamProject.Enums;
using ExamProject.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Model
{
    public class Exam
    {
        public DateTime Date { get; set; }
        public int ID { get; set; }
        public ExamCategory Category { get; set; }
        public ArrayList UserList { get; set; }

        public Exam(DateTime Time, ExamCategory category)
        {
            if(category == ExamCategory.IT)
            {
                ExamID.currentITexamId += 1;
                this.ID = ExamID.currentITexamId;
            }
            else if(category == ExamCategory.Tarix)
            {
                ExamID.currentTarixExamId += 1;
                this.ID = ExamID.currentTarixExamId;
            }
            else if (category == ExamCategory.AzDili)
            {
                ExamID.currentAzDiliExamId += 1;
                this.ID = ExamID.currentAzDiliExamId;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bele bir categorya tapilmadi");
            }

            this.Date = Time;
            this.Category = category;
        }


        public void AddUser(Profile profil)
        {
            UserList.Add(profil);
        }

    }
}
