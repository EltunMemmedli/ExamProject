using ExamProject.Controller;
using ExamProject.Enums;
using ExamProject.Model;
using ExamProject.Service;
using System.Collections;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

QuestionController Questions = new();
ExamController Exams = new();


#region Profils
Profile Admin = new("Eltun", "Memmedli", "eltun.memmedli.06@gmail.com", "2006", ProfilCategory.Admin);

Profile User_1 = new("Cavid", "Memmedli", "cavid.memmedli.09@gmail.com", "2009", ProfilCategory.User);
Profile User_2 = new("Aylin", "Huseynova", "aylin.huseynova@gmail.com", "2001", ProfilCategory.User);
Profile User_3 = new("Elvin", "Cavadov", "elvin.cavadov@gmail.com", "1999", ProfilCategory.User);
Profile User_4 = new("Narmin", "Aliyeva", "narmin.aliyeva@gmail.com", "2002", ProfilCategory.User);
Profile User_5 = new("Samir", "Valiyev", "samir.valiyev@gmail.com", "1995", ProfilCategory.User);
Profile User_6 = new("Fidan", "Rahimova", "fidan.rahimova@gmail.com", "2000", ProfilCategory.User);
Profile User_7 = new("Rashad", "Muradov", "rashad.muradov@gmail.com", "1998", ProfilCategory.User);
Profile User_8 = new("Javid", "Ahmedov", "javid.ahmedov@gmail.com", "1996", ProfilCategory.User);
Profile User_9 = new("Lala", "Mustafayeva", "lala.mustafayeva@gmail.com", "2003", ProfilCategory.User);
Profile User_10 = new("Ilham", "Ibrahimov", "ilham.ibrahimov@gmail.com", "1997", ProfilCategory.User);


ProfilController Profils = new ProfilController();

Profils.AddProfil(Admin);
Profils.AddProfil(User_1);
Profils.AddProfil(User_2);
Profils.AddProfil(User_3);
Profils.AddProfil(User_4);
Profils.AddProfil(User_5);
Profils.AddProfil(User_6);
Profils.AddProfil(User_7);
Profils.AddProfil(User_8);
Profils.AddProfil(User_9);
Profils.AddProfil(User_10);
#endregion

#region AzDili
Question Sual_1 = new("Azerbaycan dili hansı dil ailesine aiddir?\n" +
                        "A) Ural dili\n" +
                        "B) Turk dili\n" +
                        "C) German dili\n" +
                        "D) Latın dili", "B", ExamCategory.AzDili);

Question Sual_2 = new("\"Men gedirem\" cümlesinde feil hansı şexse ve zamana aiddir?" +
                        "\nA) I şexs, keçmiş zaman\n" +
                        "B) II şexs, indiki zaman\n" +
                        "C) I şexs, indiki zaman\n" +
                        "D) III şexs, gelecek zaman", "C", ExamCategory.AzDili);
Question Sual_3 = new("\"Gözel\" sözü hansı nitq hissesine aiddir?\n" +
                        "A) Feil\n" +
                        "B) İsim\n" +
                        "C) Zerf\n" +
                        "D) Sifet", "D", ExamCategory.AzDili);

Questions.AddQuestion(Sual_1);
Questions.AddQuestion(Sual_2);
Questions.AddQuestion(Sual_3);
#endregion

#region Tarix
Question Sual_4 = new("Azerbaycan Demokratik Respublikası hansı ilde qurulmuşdur?\n" +
                        "A) 1915\n" +
                        "B) 1918\n" +
                        "C) 1920\n" +
                        "D) 1923", "B", ExamCategory.Tarix);
Question Sual_5 = new("Qafqaz İslam Ordusu Bakını işgaldan azad etmek üçün Bakıya hansı ilde daxil olmuşdur?\n" +
                        "A) 1915\n" +
                        "B) 1918\n" +
                        "C) 1920\n" +
                        "D) 1923", "B", ExamCategory.Tarix);
Question Sual_6 = new("Azerbaycan ilk defe müsteqilliyini hansı ilden sonra itirmişdir?\n" +
                        "A) 1918\n" +
                        "B) 1920\n" +
                        "C) 1945\n" +
                        "D) 1991", "B", ExamCategory.Tarix);
Questions.AddQuestion(Sual_4);
Questions.AddQuestion(Sual_5);
Questions.AddQuestion(Sual_6);
#endregion

#region IT
Question Sual_7 = new("RAM yaddaşı hansı meqsedle istifade olunur?\n" +
                        "A) Melumatları qalıcı olaraq saxlamaq\n" +
                        "B) Qısa müddetli melumat saxlamaq və işlenmek üçün\n" +
                        "C) Kompüterin fiziki yerini artırmaq\n" +
                        "D) İnternete qoşulmaq üçün", "B", ExamCategory.IT);
Question Sual_8 = new("Esas kompüter proqramlaşdırma dillerinden biri hansıdır?\n" +
                        "A) HTML\n" +
                        "B) C++\n" +
                        "C) CSS\n" +
                        "D) SQL", "B", ExamCategory.IT);
Question Sual_9 = new("Hansı emeliyyat sistemi açıq menbe kodludur?\n" +
                        "A) Windows\n" +
                        "B) MacOS\n" +
                        "C) Linux\n" +
                        "D) iOS", "C", ExamCategory.IT);
Questions.AddQuestion(Sual_7);
Questions.AddQuestion(Sual_8);
Questions.AddQuestion(Sual_9);
#endregion



Secim:
Console.WriteLine("Bir secenek secin:\n" +
                  "1.Sign In,\n" +
                  "2.Sign Up\n" +
                  "--------------------");
string secim = Console.ReadLine();
int Secim;
if(int.TryParse(secim, out Secim) && Secim < 3 && Secim > 0)
{
    if (Secim == 1)
    {
        Console.Clear();
    email:
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        Regex regex = new Regex(pattern);


        Console.WriteLine("Emailinizi daxil edin");
        string email = Console.ReadLine();
        Console.Clear();

        bool Ismatch = regex.IsMatch(email);

        if (!(string.IsNullOrEmpty(email)) && Ismatch)
        {
            Console.Clear();
        Pssword:
            Console.WriteLine("Sifrenizi daxil edin");
            string password = Console.ReadLine();
            if (!(string.IsNullOrEmpty(password)))
            {
                bool valid = Profils.SignIn(email, password);
                if (valid is false)
                {
                    Console.Clear();
                    Console.WriteLine("Email ve ya password sehvdir!");
                    goto email;
                }
                else
                {
                    if (email.ToLower() == Admin.Email)
                    {
                        Console.Clear();
                        Menu:
                        Console.WriteLine("Xos gelmisiniz!\n" +
                                          "1.Istifadecileri gormek\n" +
                                          "2.Yeni istifadeci elave etmek,\n" +
                                          "3.Istifadeci silmek,\n" +
                                          "4.Suallari categoriyaya esasen gormek,\n" +
                                          "5.Suallari yenilemek,\n" +
                                          "6.Yeni sual elave etmek,\n" +
                                          "7.Imtahanlari idare etmek\n" +
                                          "8.Imtahan veren telebeleri gormek\n" +
                                          "---------------------------------");
                        string option = Console.ReadLine();
                        int Option;
                        if (int.TryParse(option, out Option) && Option > 0 && Option < 9)
                        {
                            if(Option == 1)
                            {
                                Console.Clear();
                                Profils.ShowAllUser();
                            AnaMenuKecini:
                                Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                string AnaMenu = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                {
                                    Console.Clear();
                                    goto Menu;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                    goto AnaMenuKecini;
                                }
                            }

                            else if (Option == 2)
                            {
                                Console.Clear();
                                name:
                                Console.WriteLine("Yeni istifadecinin adini daxil edin");
                                string name = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(name)))
                                {
                                    Console.Clear();
                                    surname:
                                    Console.WriteLine("Yeni istifadecinin soyadini daxil edin");
                                    string surname = Console.ReadLine();
                                    if (!(string.IsNullOrEmpty(surname)))
                                    {
                                        Console.Clear();
                                    Email:
                                        string Pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
                                        Regex Regex = new Regex(pattern);


                                        Console.WriteLine("Yeni istifadecinin emailini daxil edin");
                                        string Email = Console.ReadLine();
                                        Console.Clear();

                                        bool IsMatch = regex.IsMatch(email);
                                        if(!(string.IsNullOrEmpty(Email)) && IsMatch)
                                        {
                                            Console.Clear();
                                            Password:
                                            Console.WriteLine("Yeni istifadecinin sifresini daxil edin");
                                            string Password = Console.ReadLine();
                                            if (!(string.IsNullOrEmpty(Password)))
                                            {
                                                Profile newProfil = new(name, surname, Email, Password, ProfilCategory.User);
                                                bool valid_ = Profils.AddProfil(newProfil);
                                                if(valid_ is false)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Melumatlar duzgun deyil");
                                                    goto name;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Istifadeci ugurla elave olunmusdur!");

                                                    AnaMenuKecini:
                                                    Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                    string AnaMenu = Console.ReadLine();
                                                    if(!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                    {
                                                        Console.Clear();
                                                        goto Menu;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                        goto AnaMenuKecini;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Sifreni duzgun daxil edin!");
                                                goto Password;
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Emaili duzgun daxil edin!");
                                            goto Email;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Soyadi duzgun daxil edin!");
                                        goto surname;
                                    }
                                }
                                else 
                                {
                                    Console.Clear();
                                    Console.WriteLine("Adi duzgun daxil edin!");
                                    goto name;
                                }
                            }

                            else if(Option == 3)
                            {
                                ArrayList NewList = Profils.GetProfils();                               
                                int a = NewList.Count;
                                Console.Clear();
                                ID:
                                Profils.ShowAllUser();
                                Console.WriteLine("\nSilmek istediyiniz istifadecinin ID-sini daxil edin");
                                string id = Console.ReadLine();
                                int ID;
                                if(int.TryParse(id, out ID) && ID < a+1 && ID > 0)
                                {
                                    bool valid_1 = Profils.RemoveProfil(ID);
                                    if(valid_1 is false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Melumatlari duzgun daxil edin!");
                                        goto ID;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Istifadeci muveqqetiyyetle silindi");
                                    AnaMenuKecini:
                                        Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                        string AnaMenu = Console.ReadLine();
                                        if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                        {
                                            Console.Clear();
                                            goto Menu;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                            goto AnaMenuKecini;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("ID duzgun daxil edin!");
                                    goto ID;
                                }
                            }

                            else if(Option == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Categoriyani daxil edin(AzDili, IT, Tarix)");
                                string category = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(category)))
                                {
                                    Console.Clear();
                                    Questions.ShowByCategory(category);
                                AnaMenuKecini:
                                    Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                    string AnaMenu = Console.ReadLine();
                                    if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                    {
                                        Console.Clear();
                                        goto Menu;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                        goto AnaMenuKecini;
                                    }
                                }

                            }

                            else if(Option == 5)
                            {
                                ArrayList question = Questions.GetQuestion();
                                int s = 0;
                                foreach (Question sual in question)
                                {
                                    if(sual.Category == ExamCategory.IT)
                                    {
                                        s++;
                                    }
                                    else if(sual.Category == ExamCategory.AzDili)
                                    {
                                        s++;
                                    }
                                    else if(sual.Category == ExamCategory.Tarix)
                                    {
                                        s++;
                                    }
                                }

                                Console.Clear();
                                category:
                                Console.WriteLine("Categoriyani daxil edin(AzDili, Tarix, IT)");
                                string category = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(category)))
                                {
                                    ArrayList list = new();
                                    foreach (Question sual in question)
                                    {
                                        if(sual.Category.ToString().ToLower() == category.ToLower())
                                        {
                                            list.Add(sual.Suallar);
                                        }
                                    }
                                    Console.Clear();
                                    Questions.ShowByCategory(category);

                                    ID:
                                    Console.WriteLine("\nSualin ID-ni daxil edin");
                                    string id = Console.ReadLine();
                                    int ID;
                                    if(int.TryParse(id, out ID) && ID < s && ID > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"sual: {list[ID - 1]}");

                                        newQuestion:
                                        Console.WriteLine("\nYeni suali daxil edin");
                                        string newQuestion = Console.ReadLine();
                                        if (!(string.IsNullOrEmpty(newQuestion)))
                                        {
                                            duzgunvariant:
                                            Console.WriteLine("Duzgun cavabi daxil edin");
                                            string variant = Console.ReadLine();
                                            if (!(string.IsNullOrEmpty(variant)))
                                            {
                                                if(category.ToLower() == ExamCategory.AzDili.ToString().ToLower())
                                                {
                                                    Question Updated = new(newQuestion, variant, ExamCategory.AzDili);
                                                    Questions.UpdateQuestion(category, ID, Updated);
                                                AnaMenuKecini:
                                                    Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                    string AnaMenu = Console.ReadLine();
                                                    if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                    {
                                                        Console.Clear();
                                                        goto Menu;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                        goto AnaMenuKecini;
                                                    }

                                                }
                                                else if(category.ToLower() == ExamCategory.Tarix.ToString().ToLower())
                                                {
                                                    Question Updated = new(newQuestion, variant, ExamCategory.Tarix);
                                                    Questions.UpdateQuestion(category, ID, Updated);
                                                AnaMenuKecini:
                                                    Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                    string AnaMenu = Console.ReadLine();
                                                    if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                    {
                                                        Console.Clear();
                                                        goto Menu;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                        goto AnaMenuKecini;
                                                    }

                                                }
                                                else if(category.ToLower() == ExamCategory.IT.ToString().ToLower())
                                                {
                                                    Question Updated = new(newQuestion, variant, ExamCategory.IT);
                                                    Questions.UpdateQuestion(category, ID, Updated);
                                                AnaMenuKecini:
                                                    Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                    string AnaMenu = Console.ReadLine();
                                                    if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                    {
                                                        Console.Clear();
                                                        goto Menu;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                        goto AnaMenuKecini;
                                                    }

                                                }

                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Duzgun daxil edin");
                                                goto duzgunvariant;
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Duzgun daxil edin");
                                            goto newQuestion;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear() ;
                                        Console.WriteLine("Duzgun daxil edin!");
                                        goto ID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Duzgun daxil edin!");
                                    goto category;
                                }
                            }

                            else if(Option == 6)
                            {
                                Console.Clear();
                                category:
                                Console.WriteLine("Categoriyani daxil edin");
                                string category = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(category)))
                                {
                                    Console.Clear();
                                    YeniSual:
                                    Console.WriteLine("Suali daxil edin");
                                    string Question = Console.ReadLine();
                                    if (!(string.IsNullOrEmpty(Question)))
                                    {
                                        Console.Clear();
                                    DuzgunVariant:
                                        Console.WriteLine("Duzgun varianti daxil edin");
                                        string CorrectVariant = Console.ReadLine();
                                        if (!(string.IsNullOrEmpty(CorrectVariant)))
                                        {
                                            if (category.ToLower() == ExamCategory.AzDili.ToString().ToLower())
                                            {
                                                Question NewQuestion = new(Question, CorrectVariant, ExamCategory.AzDili);
                                                Questions.AddQuestion(NewQuestion);
                                            AnaMenuKecini:
                                                Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                string AnaMenu = Console.ReadLine();
                                                if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                {
                                                    Console.Clear();
                                                    goto Menu;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                    goto AnaMenuKecini;
                                                }
                                            }
                                            else if (category.ToLower() == ExamCategory.Tarix.ToString().ToLower())
                                            {
                                                Question NewQuestion = new(Question, CorrectVariant, ExamCategory.Tarix);
                                                Questions.AddQuestion(NewQuestion);
                                            AnaMenuKecini:
                                                Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                string AnaMenu = Console.ReadLine();
                                                if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                {
                                                    Console.Clear();
                                                    goto Menu;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                    goto AnaMenuKecini;
                                                }
                                            }
                                            else if(category.ToLower() == ExamCategory.IT.ToString().ToLower())
                                            {
                                                Question NewQuestion = new(Question, CorrectVariant, ExamCategory.IT);
                                                Questions.AddQuestion(NewQuestion);
                                            AnaMenuKecini:
                                                Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                string AnaMenu = Console.ReadLine();
                                                if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                {
                                                    Console.Clear();
                                                    goto Menu;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                    goto AnaMenuKecini;
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Bele kateqoriya tapilmadi");
                                                goto category;
                                            AnaMenuKecini:
                                                Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                                string AnaMenu = Console.ReadLine();
                                                if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                                {
                                                    Console.Clear();
                                                    goto Menu;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                                    goto AnaMenuKecini;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Duzgun daxil edin");
                                            goto DuzgunVariant;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Duzgun daxil edin");
                                        goto YeniSual;
                                    }

                                }
                                else 
                                {
                                    Console.Clear();
                                    Console.WriteLine("Duzgun daxil edin");
                                    goto category;
                                }
                            }

                            else if (Option == 7)
                            {
                                Console.Clear();
                                Exams.ShowExams();
                            AnaMenuKecini:
                                Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                string AnaMenu = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                {
                                    Console.Clear();
                                    goto Menu;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                    goto AnaMenuKecini;
                                }
                            }
                            
                            else if(Option == 8)
                            {
                                Console.Clear();
                                Profils.ShowUserWhichGiveExam();
                            AnaMenuKecini:
                                Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                string AnaMenu = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                {
                                    Console.Clear();
                                    goto Menu;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");
                                    goto AnaMenuKecini;
                                }
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Duzgun secim daxil edin!");
                            goto Menu;
                        }
                    }

                    else
                    {
                        Console.Clear();
                        UserMenu:
                        Console.WriteLine("Welcome!\n" +
                                            "1.Imtahana basla\n" +
                                            "3.Result" +
                                            "2.Cixis\n" +
                                            "------------------");
                        string Option = Console.ReadLine();
                        int option;
                        if(int.TryParse(Option, out option) && option > 0 && option < 4)
                        {
                            if(option == 1)
                            {
                                Console.Clear();
                                Profils.AddUser(email);
                                ArrayList newList = Profils.GetProfils();

                                
                            Category:
                                Console.WriteLine("Imtahanin categoriyasini daxil edin");
                                string category = Console.ReadLine();
                                if (!(string.IsNullOrEmpty(category)))
                                {
                                    if (category.ToLower() == ExamCategory.AzDili.ToString().ToLower())
                                    {
                                        Console.Clear();
                                        Exam newEXAM = new(DateTime.Now, ExamCategory.AzDili);
                                        Exams.AddExams(newEXAM);
                                        Console.WriteLine($"Tarix: {newEXAM.Date},\n" +
                                                          $"Imtahan Categoriyasi: {newEXAM.Category},\n" +
                                                          $"Imtahan ID: {newEXAM.ID},");
                                        foreach (Profile list in newList)
                                        {
                                            if (list.Email == email)
                                            {
                                                Console.WriteLine($"User ID: {list.ID}");
                                            }
                                        }


                                        Questions.StartTheExam(category);
                                    AnaMenuKecini:
                                        Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                        string AnaMenu = Console.ReadLine();
                                        if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                        {
                                            Console.Clear();
                                            goto UserMenu;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                                        }
                                    }
                                    else if (category.ToLower() == ExamCategory.Tarix.ToString().ToLower())
                                    {
                                        Console.Clear();
                                        Exam newEXAM = new(DateTime.Now, ExamCategory.Tarix);
                                        Exams.AddExams(newEXAM);
                                        Console.WriteLine($"Tarix: {newEXAM.Date},\n" +
                                                          $"Imtahan Categoriyasi: {newEXAM.Category},\n" +
                                                          $"Imtahan ID: {newEXAM.ID}");
                                        foreach (Profile list in newList)
                                        {
                                            if (list.Email == email)
                                            {
                                                Console.WriteLine($"User ID: {list.ID}");
                                            }
                                        }

                                        Questions.StartTheExam(category);
                                    AnaMenuKecini:
                                        Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                        string AnaMenu = Console.ReadLine();
                                        if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                        {
                                            Console.Clear();
                                            goto UserMenu;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                                        }
                                    }
                                    else if (category.ToLower() == ExamCategory.IT.ToString().ToLower())
                                    {
                                        Console.Clear();
                                        Exam newEXAM = new(DateTime.Now, ExamCategory.IT);
                                        Exams.AddExams(newEXAM);
                                        Console.WriteLine($"Tarix: {newEXAM.Date},\n" +
                                                          $"Imtahan Categoriyasi: {newEXAM.Category},\n" +
                                                          $"Imtahan ID: {newEXAM.ID}");
                                        foreach (Profile list in newList)
                                        {
                                            if (list.Email == email)
                                            {
                                                Console.WriteLine($"User ID: {list.ID}");
                                            }
                                        }

                                        Questions.StartTheExam(category);

                                    AnaMenuKecini:
                                        Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                        string AnaMenu = Console.ReadLine();
                                        if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                        {
                                            Console.Clear();
                                            goto UserMenu;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Bele bir categoriya tapilmadir");
                                        goto Category;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Duzgun daxil edin");
                                    goto Category;
                                }
                            }

                            else if(option == 2)
                            {
                                Console.Clear();
                                Secim_1:
                                Console.WriteLine("Cixis etmekden eminmisiniz?(1 - beli, 2 - xeyr)");
                                string Choose = Console.ReadLine();
                                int choose;
                                if(int.TryParse(Choose, out choose) && choose > 0 && choose < 3)
                                {
                                    if(choose == 1)
                                    {
                                        Console.Clear();
                                        goto Secim;
                                    }
                                    else if (choose == 2)
                                    {
                                        goto UserMenu;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Duzgun daxil edin");
                                    goto Secim_1;
                                }
                            }


                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Duzgun daxil edin");
                            goto UserMenu;
                        }
                    }
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Emaili duzgun daxil edin!");
            goto email;
        }
    }

    else if(Secim == 2)
    {
        Console.Clear();
        name:
        Console.WriteLine("Adinizi daxil edin");
        string name = Console.ReadLine();
        if (!(string.IsNullOrEmpty(name)))
        {
            Console.Clear();
            Soyad:
            Console.WriteLine("Soyadinizi daxil edin");
            string surname = Console.ReadLine();
            if (!(string.IsNullOrEmpty(surname)))
            {
                Console.Clear();
            email:
                string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
                Regex regex = new Regex(pattern);


                Console.WriteLine("Please, enter your email");
                string email = Console.ReadLine();
                Console.Clear();

                bool Ismatch = regex.IsMatch(email);

                if (!(string.IsNullOrEmpty(email)) && Ismatch)
                {
                    Console.Clear();
                Password:
                    Console.WriteLine("Sifreni daxil edin");
                    string password = Console.ReadLine();
                    if (!(string.IsNullOrEmpty(password)))
                    {
                        Profile NewProfile = new(name, surname, email, password, ProfilCategory.User);
                        bool valid = Profils.AddProfil(NewProfile);
                        if(valid is false)
                        {
                            Console.Clear();
                            Console.WriteLine("Duzgun daxil edin");
                            goto name;
                        }
                        else
                        {
                            Console.Clear();
                        menu_2:
                            Console.WriteLine("Welcome!\n" +
                                                "1.Imtahana basla\n" +
                                                "2.Cixis\n" +
                                                "------------------");
                            string Option = Console.ReadLine();
                            int option;
                            if (int.TryParse(Option, out option) && option > 0 && option < 3)
                            {
                                if (option == 1)
                                {
                                    Console.Clear();
                                    Profils.AddUser(email);
                                    ArrayList newList = Profils.GetProfils();


                                Category:
                                    Console.WriteLine("Imtahanin categoriyasini daxil edin");
                                    string category = Console.ReadLine();
                                    if (!(string.IsNullOrEmpty(category)))
                                    {
                                        if (category.ToLower() == ExamCategory.AzDili.ToString().ToLower())
                                        {
                                            Console.Clear();
                                            Exam newEXAM = new(DateTime.Now, ExamCategory.AzDili);
                                            Exams.AddExams(newEXAM);
                                            Console.WriteLine($"Tarix: {newEXAM.Date},\n" +
                                                              $"Imtahan Categoriyasi: {newEXAM.Category},\n" +
                                                              $"Imtahan ID: {newEXAM.ID},");
                                            foreach (Profile list in newList)
                                            {
                                                if (list.Email == email)
                                                {
                                                    Console.WriteLine($"User ID: {list.ID}");
                                                }
                                            }


                                            /*Questions.StartTheExam(category);*/
                                            Exams.ShowResult(category, name, surname, email);
                                        AnaMenuKecini:
                                            Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                            string AnaMenu = Console.ReadLine();
                                            if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                            {
                                                Console.Clear();
                                                goto Secim;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                                            }
                                        }
                                        else if (category.ToLower() == ExamCategory.Tarix.ToString().ToLower())
                                        {
                                            Console.Clear();
                                            Exam newEXAM = new(DateTime.Now, ExamCategory.Tarix);
                                            Exams.AddExams(newEXAM);
                                            Console.WriteLine($"Tarix: {newEXAM.Date},\n" +
                                                              $"Imtahan Categoriyasi: {newEXAM.Category},\n" +
                                                              $"Imtahan ID: {newEXAM.ID}");
                                            foreach (Profile list in newList)
                                            {
                                                if (list.Email == email)
                                                {
                                                    Console.WriteLine($"User ID: {list.ID}");
                                                }
                                            }

                                            Questions.StartTheExam(category);


                                        AnaMenuKecini:
                                            Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                            string AnaMenu = Console.ReadLine();
                                            if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                            {
                                                Console.Clear();
                                                goto Secim;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                                            }
                                        }
                                        else if (category.ToLower() == ExamCategory.IT.ToString().ToLower())
                                        {
                                            Console.Clear();
                                            Exam newEXAM = new(DateTime.Now, ExamCategory.IT);
                                            Exams.AddExams(newEXAM);
                                            Console.WriteLine($"Tarix: {newEXAM.Date},\n" +
                                                              $"Imtahan Categoriyasi: {newEXAM.Category},\n" +
                                                              $"Imtahan ID: {newEXAM.ID}");
                                            foreach (Profile list in newList)
                                            {
                                                if (list.Email == email)
                                                {
                                                    Console.WriteLine($"User ID: {list.ID}");
                                                }
                                            }

                                            Questions.StartTheExam(category);

                                        AnaMenuKecini:
                                            Console.WriteLine("\nAna Menuya qayitmaq ucun 'f' duymesine basin");
                                            string AnaMenu = Console.ReadLine();
                                            if (!(string.IsNullOrEmpty(AnaMenu)) && AnaMenu.ToLower() == "F".ToLower())
                                            {
                                                Console.Clear();
                                                goto Secim;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Duzgun duymeye basdiginizdan emin olun!");


                                            }

                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Bele bir categoriya tapilmadir");
                                            goto Category;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Duzgun daxil edin");
                                        goto Category;
                                    }
                                }

                                else if (option == 2)
                                {
                                    Console.Clear();
                                Secim_1:
                                    Console.WriteLine("Cixis etmekden eminmisiniz?(1 - beli, 2 - xeyr)");
                                    string Choose = Console.ReadLine();
                                    int choose;
                                    if (int.TryParse(Choose, out choose) && choose > 0 && choose < 3)
                                    {
                                        if (choose == 1)
                                        {
                                            Console.Clear();
                                            goto Secim;
                                        }
                                        else if (choose == 2)
                                        {
                                            goto menu_2;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Duzgun daxil edin");
                                        goto Secim_1;
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Duzgun daxil edin");
                                goto menu_2;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Duzgun daxil edin");
                        goto Password;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun daxil edin");
                    goto email;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Duzgun daxil edin");
                goto Soyad;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Duzgun daxil edin");
            goto name;
        }
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Duzgun secim edin!");
    goto Secim;
}








// file service ile yazilmali olanlar \
// student imtahani bitirdikden sonra resultu results.txt icerisine yazmaq lazimdir 
// result classi yaradirsan MODEL ICERISINDE 
// result classinin propertileri BUNLARDIR 
// name ,surname ,email , duzgun cavablarin sayi ,sehv cavablarin sayi , birdeki imtahanin faizi ekranda gorsensin 
// bundan ELAVE eyer imtahan faizi 50% i kecibse yazsinki imtahandan kecib !!
// eks halda imtahannan kecmediyini bildir !


/*
    
        []
    
 */