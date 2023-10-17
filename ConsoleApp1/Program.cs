using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Reqem daxil edin: ");                                            //Task 2
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} Tek: {number.IsOdd()}"); 

            // IsEven method
            Console.Write("Reqem daxil edin: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} Cut: {number.IsEven()}"); 

            // HasDigit method
            Console.Write("Metn daxil edin: ");
            string text = Console.ReadLine();
            Console.WriteLine($"'{text}' Reqem: {text.HasDigit()}"); 

            // CheckPassword method
            Console.Write("Shifre daxil edin: ");
            string password = Console.ReadLine();
            Console.WriteLine($"'{password}' Shifre: {password.CheckPassword()}"); 

            // Capitalize method
            Console.Write("metn daxil edin: ");
            text = Console.ReadLine();
            Console.WriteLine($"Capitalizde: {text.Capitalize()}"); 
        }

    }
    public static class Helper
    {
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool HasDigit(this string value)
        {
            return value.Any(char.IsDigit);
        }

        public static bool CheckPassword(this string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return false;
            }

            // Regex ile kontrol
            bool hasUpper = Regex.IsMatch(password, "[A-Z]");
            bool hasLower = Regex.IsMatch(password, "[a-z]");
            bool hasDigit = Regex.IsMatch(password, "[0-9]");

            return hasUpper && hasLower && hasDigit;
        }

        public static string Capitalize(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }
    }

}






















        // Task1            
        //        string name, surname;

        //        Console.Write("Ad daxil edin: ");
        //        name = Console.ReadLine();
        //        Console.Write("Soyad daxil edin: ");
        //        surname = Console.ReadLine();

        //        if (Student.CheckName(name) && Student.CheckName(surname))
        //        {
        //            Student student = new Student(name, surname);
        //            Console.WriteLine($"Telebe yaradildi {student.Name} {student.Surname}  ID: {student.Id}  Email: {student.CodeEmail}");

        //            StudentUtils.ShowStudentCount();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Yanlsih");
        //        }

        //public interface ICodeAcademy
        //{
        //    string CodeEmail { get; }
        //    void GenerateEmail();
        //}

        //public class Student : ICodeAcademy
        //{
        //    public static int Count { get; private set; }
        //    public int Id { get; private set; }
        //    public string Name { get; private set; }
        //    public string Surname { get; private set; }
        //    public string CodeEmail { get; private set; }

        //    public Student(string name, string surname)
        //    {
        //        if (!CheckName(name) || !CheckName(surname))
        //        {
        //            throw new ArgumentException();
        //        }

        //        Count++;
        //        Id = Count;
        //        Name = name;
        //        Surname = surname;

        //        GenerateEmail();
        //    }

        //    public static bool CheckName(string name)
        //    {
        //        if (string.IsNullOrEmpty(name) || name.Length < 3 || name.Length > 25)
        //        {
        //            return false;
        //        }

        //        return !Regex.IsMatch(name, @"[^a-zA-Z]");
        //    }

        //    public void GenerateEmail()
        //    {
        //        CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
        //    }
        //}

        //public static class StudentUtils
        //{
        //    public static void ShowStudentCount()
        //    {
        //        Console.WriteLine( Student.Count);
        //    }
        //}