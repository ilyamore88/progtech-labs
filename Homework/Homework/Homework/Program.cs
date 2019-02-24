using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        public static Person CurrentUser = null;

        static void Main(string[] args)
        {
            Console.SetWindowSize(55, 30);
            Laboratory lab1 = new Laboratory("Лаборатория 1");
            while (true)
            {
                PrintMenu();
                MakeChoice(ref lab1);
            }
        }

        static void AddStudent(ref Laboratory laboratory)
        {
            Console.Clear();
            if (CurrentUser != null && (CurrentUser.CurrentPermissions == Person.Permissions.admin || CurrentUser.CurrentPermissions == Person.Permissions.manager))
            {
                Console.Write("Введите ID студента: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Введите фамилию студента: ");
                string lastname = Console.ReadLine();
                Console.Write("Введите имя студента: ");
                string firstname = Console.ReadLine();
                Console.Write("Введите дату рождения студента (dd.MM.yyyy): ");
                string birthdateS = Console.ReadLine();
                DateTime birthdate = DateTime.ParseExact(birthdateS, "dd.MM.yyyy", null);
                string username = id.ToString();
                string password = "firstpassword";
                Console.Write("Введите факультет студента: ");
                string faculty = Console.ReadLine();
                Console.Write("Введите учебную группу студента: ");
                string group = Console.ReadLine();
                laboratory.AddStudent(new Student(id, lastname, firstname, birthdate, username, password, faculty, group));
                Console.WriteLine("Студент успешно добавлен!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("У Вас недостаточно прав!");
                Console.ReadKey();
            }
        }

        static void AddTeacher(ref Laboratory laboratory)
        {
            Console.Clear();
            if (CurrentUser != null && (CurrentUser.CurrentPermissions == Person.Permissions.admin || CurrentUser.CurrentPermissions == Person.Permissions.manager))
            {
                Console.Write("Введите ID преподавателя: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Введите фамилию преподавателя: ");
                string lastname = Console.ReadLine();
                Console.Write("Введите имя преподавателя: ");
                string firstname = Console.ReadLine();
                Console.Write("Введите дату рождения преподавателя (dd.MM.yyyy): ");
                string birthdateS = Console.ReadLine();
                DateTime birthdate = DateTime.ParseExact(birthdateS, "dd.MM.yyyy", null);
                string username = id.ToString();
                string password = "firstpassword";
                Console.Write("Введите стаж работы: ");
                int workExperience = int.Parse(Console.ReadLine());
                Console.Write("Введите факультет преподавателя: ");
                string faculty = Console.ReadLine();
                Console.Write("Введите должность преподавателя: ");
                string post = Console.ReadLine();
                laboratory.AddTeacher(new Teacher(id, lastname, firstname, birthdate, username, password, workExperience, faculty, post));
                Console.WriteLine("Преподаватель успешно добавлен!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("У Вас недостаточно прав!");
                Console.ReadKey();
            }
        }

        static void AddManager(ref Laboratory laboratory)
        {
            Console.Clear();
            if (CurrentUser != null && (CurrentUser.CurrentPermissions == Person.Permissions.admin || CurrentUser.CurrentPermissions == Person.Permissions.manager))
            {
                Console.Write("Введите ID менеджера: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Введите фамилию менеджера: ");
                string lastname = Console.ReadLine();
                Console.Write("Введите имя менеджера: ");
                string firstname = Console.ReadLine();
                Console.Write("Введите дату рождения менеджера (dd.MM.yyyy): ");
                string birthdateS = Console.ReadLine();
                DateTime birthdate = DateTime.ParseExact(birthdateS, "dd.MM.yyyy", null);
                string username = id.ToString();
                string password = "firstpassword";
                Console.Write("Введите факультет менеджера: ");
                string faculty = Console.ReadLine();
                Console.Write("Введите должность менеджера: ");
                string post = Console.ReadLine();
                laboratory.AddManager(new Manager(id, lastname, firstname, birthdate, username, password, faculty, post));
                Console.WriteLine("Менеджер успешно добавлен!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("У Вас недостаточно прав!");
                Console.ReadKey();
            }
        }

        static Person Login(ref Laboratory laboratory)
        {
            Console.Clear();
            bool IsLoginCorrect = false;
            bool IsPasswordCorrect = false;
            bool IsExit = false;
            Person currPerson = null;
            while (!IsLoginCorrect && !IsExit)
            {
                Console.Write("Логин (exit - выход в главное меню): ");
                string username = Console.ReadLine();
                if (username == "exit")
                {
                    IsExit = true;
                    return null;
                }
                else
                {
                    foreach (Person person in laboratory.GetPeople())
                    {
                        if (person.Username == username)
                        {
                            currPerson = person;
                            IsLoginCorrect = true;
                        }
                    }
                    if (!IsLoginCorrect)
                    {
                        Console.WriteLine("Неверный логин! Попробуйте снова.");
                    }
                }
            }
            if (currPerson.Password == "firstpassword")
            {
                Console.Write("Кажется, Вы входите в первый раз. \nВведите свой новый пароль: ");
                string newPassword = Console.ReadLine();
                currPerson.ChangePassword(newPassword);
            }
            while (!IsPasswordCorrect)
            {
                Console.Write("{0}, введите Ваш пароль: ", currPerson.Firstname);
                string password = Console.ReadLine();
                if (currPerson.Password == password)
                {
                    IsPasswordCorrect = true;
                    return currPerson;
                }
                else
                {
                    Console.WriteLine("Неверный пароль! Попробуйте снова.");
                }
            }
            return null;
        }

        static void Logout()
        {
            CurrentUser = null;
        }

        static void PrintMenu()
        {
            Console.Clear();
            if (CurrentUser == null)
            {
                Console.WriteLine("1 - Вход в систему");
                Console.WriteLine("\n0 - Выход");
            }
            else
            {
                Console.WriteLine("Здравствуйте, {0}\n", CurrentUser.Firstname);
                Console.WriteLine("1 - Посмотреть информацию о себе");
                Console.WriteLine("2 - Посмотреть информацию о лаборатории");
                Console.WriteLine("3 - Рассчитать свою з/п");
                if (CurrentUser.CurrentPermissions == Person.Permissions.teacher)
                {
                    Console.WriteLine("\n4 - Выставить оценки студенту");
                }
                if (CurrentUser.CurrentPermissions == Person.Permissions.manager || CurrentUser.CurrentPermissions == Person.Permissions.admin)
                {
                    Console.WriteLine("\n4 - Добавить учителя");
                    Console.WriteLine("5 - Удалить учителя");
                    Console.WriteLine("6 - Добавить студента");
                    Console.WriteLine("7 - Удалить студента");
                }
                if (CurrentUser.CurrentPermissions == Person.Permissions.admin)
                {
                    Console.WriteLine("\n8 - Добавить менеджера");
                    Console.WriteLine("9 - Удалить менеджера");
                }
                Console.WriteLine("\n0 - Выход из системы");
            }
        }

        static void MakeChoice(ref Laboratory laboratory)
        {
            int choice = int.Parse(Console.ReadLine());
            bool isCorrect = false;
            if (CurrentUser == null)
            {
                switch (choice)
                {
                    case 1:
                        isCorrect = true;
                        CurrentUser = Login(ref laboratory);
                        break;
                    case 0:
                        isCorrect = true;
                        Environment.Exit(0);
                        break;
                    default:
                        if (!isCorrect)
                        {
                            Console.WriteLine("Некорректный ввод! \nНажмите любую клавишу и попробуйте снова.");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        isCorrect = true;
                        Console.Clear();
                        CurrentUser.Print();
                        Console.ReadKey();
                        break;
                    case 2:
                        isCorrect = true;
                        laboratory.PrintInfoAboutLaboratory();
                        break;
                    case 3:
                        isCorrect = true;
                        //Рассчитать свою з/п
                        break;
                    case 0:
                        isCorrect = true;
                        Logout();
                        break;
                    default:
                        if (CurrentUser.CurrentPermissions == Person.Permissions.teacher)
                        {
                            switch (choice)
                            {
                                case 4:
                                    isCorrect = true;
                                    //Добавить оценки студенту
                                    break;
                            }
                        }
                        else if (CurrentUser.CurrentPermissions == Person.Permissions.manager || CurrentUser.CurrentPermissions == Person.Permissions.admin)
                        {
                            switch (choice)
                            {
                                case 4:
                                    isCorrect = true;
                                    AddTeacher(ref laboratory);
                                    break;
                                case 5:
                                    isCorrect = true;
                                    //Удалить учителя
                                    break;
                                case 6:
                                    isCorrect = true;
                                    AddStudent(ref laboratory);
                                    break;
                                case 7:
                                    isCorrect = true;
                                    //Удалить студента
                                    break;
                                default:
                                    if (CurrentUser.CurrentPermissions == Person.Permissions.admin)
                                    {
                                        switch (choice)
                                        {
                                            case 8:
                                                isCorrect = true;
                                                AddManager(ref laboratory);
                                                break;
                                            case 9:
                                                isCorrect = true;
                                                //Удалить менеджера
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                            }
                        }
                        if (!isCorrect)
                        {
                            Console.WriteLine("Некорректный ввод! \nНажмите любую клавишу и попробуйте снова.");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
