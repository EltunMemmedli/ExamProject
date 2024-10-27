using ExamProject.Enums;
using ExamProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Model
{
    public class Profile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ProfilCategory Category { get; set; }

        public Profile(string name, string surname, string email , string password, ProfilCategory category) 
        {

            if(category == ProfilCategory.User)
            {
                IDs.currentStudentId += 1;
                this.ID = IDs.currentStudentId;
            }
            else
            {
                IDs.currentAdminid += 1;
                this.ID = IDs.currentAdminid;
            }
              
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Category = category;


            
        }
    }
}
