using System;
using System.Collections.Generic;
using ClassLibrary5;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool exit = false;
                while (true)
                {
                    int nom = 0;
                    Console.WriteLine("\n1) Вся информацию о студентах.\n2) Список студентов по инициалам\n3) Список студентов старше 18\n4) Список студентов младше 18\n5) Добавить студента\n6) Удалить студента\n7) Изменить студента\n8) Поиск студентов\n9) Выход\n");
                    while (true)
                    {
                        Console.Write("Выберите номер: ");
                        nom = Convert.ToInt32(Console.ReadLine());
                        if (nom > 10 || nom < 1)
                        {
                            Console.WriteLine("Такого номера нет");
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (nom == 1)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            foreach (Student student in Student.ListStudent)
                            {
                                Student.ExitID(student.IDStudent);
                            }
                        }
                    }
                    else if (nom == 2)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Student.DeleteAllStudent();
                        }
                    }
                    else if (nom == 3)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Console.Clear();
                            foreach (Student student in Student.ListStudent)
                            {
                                if (student.HeightStudent(student.IDStudent) >= 18)
                                {
                                    Student.ExitID(student.IDStudent);
                                }
                            }
                        }
                    }
                    else if (nom == 4)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Console.Clear();
                            foreach (Student student in Student.ListStudent)
                            {
                                if (student.HeightStudent(student.IDStudent) <= 18)
                                {
                                    Student.ExitID(student.IDStudent);
                                }
                            }
                        }
                    }
                    else if (nom == 5)
                    {
                        Console.Write("ФИО студента: ");
                        String FIO = Console.ReadLine().Trim();
                        Console.Write("Группа: ");
                        String Group = Console.ReadLine().Trim();
                        Console.WriteLine("Дата рождения");
                        Console.Write("День: ");
                        String Day = Console.ReadLine();
                        Console.Write("Месяц: ");
                        String Month = Console.ReadLine();
                        Console.Write("Год: ");
                        String Year = Console.ReadLine();
                        Student stud = new Student(FIO, Group, new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Month), Convert.ToInt32(Day)));
                        Student.AddStudent(stud);
                        Console.WriteLine("Данные добавлены");
                    }
                    else if (nom == 6)
                    {
                        Console.WriteLine("Введеите id для удаления: ");
                        int DeleteID = Convert.ToInt32(Console.ReadLine());
                        Student.DeleteStudent(DeleteID);
                        Console.WriteLine("Студент удалён");
                    }
                    else if (nom == 7)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Console.WriteLine("Введете id для изменения студента: ");
                            int idEdit = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите ФИО студента: ");
                            String fioEdit = Console.ReadLine().Trim();
                            Console.Write("Введеите группу студента: ");
                            String groupEdit = Console.ReadLine().Trim();
                            Console.WriteLine("Дата рождения: ");
                            Console.WriteLine("Введите день: ");
                            String dayEdit = Console.ReadLine();
                            Console.WriteLine("Введите месяц: ");
                            String monthEdit = Console.ReadLine();
                            Console.WriteLine("Введите год: ");
                            String yearEdit = Console.ReadLine();
                            Student.EditStudent(fioEdit, groupEdit, new DateTime(Convert.ToInt32(yearEdit), Convert.ToInt32(monthEdit), Convert.ToInt32(dayEdit)), idEdit);
                            Console.WriteLine("Студент изменён");
                        }
                    }
                    else if (nom == 8)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов\n");
                        }
                        else
                        {
                            Console.WriteLine("Поиск студента: ");
                            Console.WriteLine("Введите id студента: ");
                            int idStudent = Convert.ToInt32(Console.ReadLine());
                            Student.ExitID(idStudent);
                        }
                    }
                    else if (nom == 9)
                    {
                        Console.WriteLine("Выход");
                        exit = true;
                    }
                    if (exit == true)
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка!");
            }

        }
    }
}
