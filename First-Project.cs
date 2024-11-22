using System;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("My First Project Using C#");

        // let's build a Mark sheet of a Student;
        Console.WriteLine("Please Enter Your SQL Marks");
        int subject_1 = GetMarks();

       Console.WriteLine("Please Enter Your JavaScript Marks");
        int subject_2 = GetMarks();

        Console.WriteLine("Please Enter Your C# Marks");
        int subject_3 = GetMarks();

        // Coverting string into integer using Parse Method C#
        //int subject_three = int.Parse(Input_3);
        //Console.WriteLine(subject_three);

        Console.WriteLine("Please Enter Your React js Marks");
        int subject_4 = GetMarks();


        Console.WriteLine("Please Enter Your Node Js Marks");
        int subject_5 = GetMarks();


        // sub-total of subject marks
        int totalMarks = subject_1 + subject_2 + subject_3 + subject_4 + subject_5;

        // Printing total Marks
        Console.WriteLine("The Total Marks You Obtained are: " + totalMarks);

        int pass = 0, fail = 0;


        if (subject_1 >= 45) pass++; else fail++;
        if (subject_2 >= 45) pass++; else fail++;
        if (subject_3 >= 45) pass++; else fail++;
        if (subject_4 >= 45) pass++; else fail++;
        if (subject_5 >= 45) pass++; else fail++;

        Console.WriteLine("Subject You pass {0}, Subjects You Fail {1}",  pass, fail);
    }

    static int GetMarks()
    {
        while (true)
        {
            string Input = Console.ReadLine();
            if (int.TryParse(Input, out int marks))
            {
                return marks;
            } else
            {
                Console.WriteLine("The Number your Enter is not a valid Integer. Please Provide a Valid Input Integer");
            }
        }
    }
    
}