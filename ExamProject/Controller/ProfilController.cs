using ExamProject.Enums;
using ExamProject.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Controller
{
    public class ProfilController
    {
        ArrayList Profils;

        ArrayList newUser = new ArrayList();


        public ProfilController()
        {
            Profils = new ArrayList();
        }

        public bool AddProfil(Profile profil)
        {
            Profils.Add(profil);
            return true;
        }

        public void ShowAllUser()
        {
            
            foreach (Profile profil in Profils)
            {
                if(profil.Category == ProfilCategory.User)
                {
                   

                    Console.WriteLine($"\nUser ID: {profil.ID},\n" +
                                      $"Ad: {profil.Name},\n" +
                                      $"Soyad: {profil.Surname},\n");

                }
            }
        }

        public ArrayList GetProfils()
        {
            return Profils;
        }

        public bool SignIn(string email, string password)
        {
            bool valid = false;
            foreach(Profile profil in Profils) 
            {
                if(email == profil.Email && password == profil.Password)
                {
                    valid = true;
                }
            }
            return valid;
        }

        public bool RemoveProfil(int ID)
        {
            Profils.RemoveAt(ID);
            return true;
        }

        public void AddUser(string email)
        {
            foreach (Profile item in Profils)
            {
                if(email.ToLower() == item.Email.ToLower())
                {
                    newUser.Add(item);
                }
            }
        }

        public void ShowUserWhichGiveExam()
        {
            foreach(Profile item in newUser)
            {
                Console.WriteLine($"UserID: {item.ID}\n" +
                                  $"UserName: {item.Name},\n" +
                                  $"UserEmail: {item.Email}\n");
            }
        }

        public bool SignUp(Profile newProfile)
        {
            Profils.Add(newProfile);
            return true;
        }

    }
}
