using System;

namespace _2_1
{
    class Program
    {
        static string FindStudentById(int id)
        {
            string student;
            switch (id)
            {
                case 1:
                    {
                        return student = "Pavlo Osadchuk"; 
                    }
                case 2:
                    {
                        return student = "Anna Antipenko";
                    }
                case 3:
                    {
                        return student = "Igor Grusyuk";
                    }
                case 4:
                    {
                        return student = "Liza Legeza";
                    }
                case 5:
                    {
                        return student = "Hrystyna Stavkova";
                    }
                case 6:
                    {
                        return student = "Mykyta Ryabov";
                    }
                case 7:
                    {
                        return student = "Nadia Roman";
                    }
                case 8:
                    {
                        return student = "Bohdan Hrushkivskiy";
                    }
                case 9:
                    {
                        return student = "Dima Kalinyuk";
                    }
                case 10:
                    {
                        return student = "Vlad Lyakh";
                    }
                default:
                    {
                        Console.WriteLine("Неправильне число!");
                        return null;

                    }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число від 1 до 10");
            int id = int.Parse(Console.ReadLine());
            string student = FindStudentById(id);
            if (student == null)
            {
                return;
            }
            else 
            {
                Console.WriteLine("Student's name and surname are " + student);
            }
        }
    }
}
