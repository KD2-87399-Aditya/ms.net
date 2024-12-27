using System;

//Assignment 2 Q1 and Q2


namespace Students
{
    public struct Student
    {
        private char _div;
        private bool _male;
        private string _name;
        private int _age;
        private int _std;
        private double _marks;

        
        public Student(string name, int age, bool male, int std, char div, double marks)
        {
            _div = div;
            _male = male;
            _name = name;
            _age = age;
            _std = std;
            _marks = marks;
        }

        
        public double Marks { get => _marks; set => _marks = value; }
        public int Std { get => _std; set => _std = value; }
        public char Div { get => _div; set => _div = value; }
        public bool Male { get => _male; set => _male = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        
        public string PrintDetails()
        {
            return $"{Name} {Std} {Age} {(Male ? "Male" : "Female")} {Div} {Marks}";
        }

        
        public void AcceptDetails()
        {
            Console.Write("Enter Student Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Gender (true for Male, false for Female): ");
            Male = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Standard: ");
            Std = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Division: ");
            Div = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Marks: ");
            Marks = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Program
    {
        
        public static Student[] CreateArray()
        {
            Console.Write("Enter the number of students: ");
            int size = Convert.ToInt32(Console.ReadLine());
            return new Student[size];
        }

        
        public static void AcceptInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nEntering details for Student {i + 1}:");
                students[i].AcceptDetails();
            }
        }

        
        public static void PrintInfo(Student[] students)
        {
            Console.WriteLine("\nStudent Information:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.PrintDetails());
            }
        }

       
        public static Student[] ReverseArray(Student[] students)
        {
            int size = students.Length;
            Student[] reversed = new Student[size];
            for (int i = 0; i < size; i++)
            {
                reversed[i] = students[size - i - 1];
            }
            return reversed;
        }

        
        static void Main(string[] args)
        {
            
            Student[] students = CreateArray();

            
            AcceptInfo(students);

            
            PrintInfo(students);

            
            Student[] reversedStudents = ReverseArray(students);

            
            Console.WriteLine("\nReversed Student Information:");
            PrintInfo(reversedStudents);
        }
    }
}
