using System;

namespace LabatoryString;

class Labaratory
{
    static void Main(string[] args)
    {
        //Part 1
        string fname, lname, course, section;
        int yrlevel;

        Console.WriteLine("----------------Part 1----------------\n");

        //Input the user First Name
        Console.WriteLine("Enter your First Name: ");
        fname = Console.ReadLine();

        //Input the user Last Name
        Console.WriteLine("Enter your Last Name: ");
        lname = Console.ReadLine();

        //Input the user Course
        Console.WriteLine("Enter your Course: ");
        course = Console.ReadLine();

        //Input the user Year Level
        Console.WriteLine("Enter your Year Level: ");
        yrlevel = Convert.ToInt32(Console.ReadLine());

        //Input the user Section
        Console.WriteLine("Enter your Section: ");
        section = Console.ReadLine();

        //Display all the details in Part 1 using interpolation
        string inter_fname = $"First Name: {fname}";
        string inter_lname = $"Last Name: {lname}";
        string inter_course = $"Course: {course}";
        string inter_yrlevel = $"Year Level: {yrlevel}";
        string inter_section = $"Section: {section}";
    
        Console.WriteLine("\n----------------Part 1----------------");
        Console.WriteLine(inter_fname);
        Console.WriteLine(inter_lname);
        Console.WriteLine(inter_course);
        Console.WriteLine(inter_yrlevel);
        Console.WriteLine(inter_section);
        Console.WriteLine("--------------------------------------\n");

        Console.WriteLine("-----------------------Part 2-----------------------\n");

        //Combining the fname and lname using Concatination
        string fullname = fname + lname;
        
        //Display the combine of fname and lname
        Console.WriteLine($"Full Name: {fullname}");

        //Display the fullname in Upper Case
        Console.WriteLine($"Full Name (Upper Case): {fullname.ToUpper()}");

        //Display the fullname in Lower Case
        Console.WriteLine($"Full Name (Lower Case): {fullname.ToLower()}");

        //Display the fullname Lenght
        Console.WriteLine($"Full Name Length : {fullname.Length}");

        //Display the fist Character of fname
        Console.WriteLine($"First character of fname: {fname[0]}");
        Console.WriteLine("----------------------------------------------------\n");
        
        //Part 3
        Console.WriteLine("-----------------------Part 3-----------------------\n");
    
        //Enter your subject
        Console.WriteLine("Enter your subject: ");
        string subject = Console.ReadLine();

        //Enter your grades
        Console.WriteLine("Enter your numerical grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        //Display if the grade is greater than or equal than 98 and less than or equal than 100
        if (grade >= 98 && grade <= 100)
        {
            Console.WriteLine($"Your grade on the subject {subject} is {grade}");
            Console.WriteLine("Excellent");
        }

        //Display if the grade is greater than or equal than 95 and less than or equal than 97
        else if (grade >= 95 && grade <= 97)
        {
            Console.WriteLine($"Your grade on the subject {subject} is {grade}");
            Console.WriteLine("Outstanding");
        }

        //Display if the grade is greater than or equal than 90 and less than or equal than 94
        else if (grade >= 90 && grade <= 94)
        {
            Console.WriteLine($"Your grade on the subject {subject} is {grade}");
            Console.WriteLine("Very Good");
        }

        //Display if the grade is greater than or equal than 85 and less than or equal than 89
        else if (grade >= 85 && grade <= 89)
        {
            Console.WriteLine($"Your grade on the subject {subject} is {grade}");
            Console.WriteLine("Good");
        }

        //Display if the grade is greater than or equal than 80 and less than or equal than 84
        else if (grade >= 80 && grade <= 84)
        {
            Console.WriteLine($"Your grade on the subject {subject} is {grade}");
            Console.WriteLine("Satisfactory");
        }

        //Display if the grade is greater than or equal than 75 and less than or equal than 79
        else if (grade >= 75 && grade <= 79)
        {
            Console.WriteLine($"Your grade on the subject {subject} is {grade}");
            Console.WriteLine("Passed");
        }

        //Display if the grade is less than 75
        else if (grade < 75)
        {
            Console.WriteLine($"Your grade on the subject {subject} is {grade}");
            Console.WriteLine("Failed");
        }

        //Display if the grade is greater than 100
        else
        {
            Console.WriteLine("Please enter a grade between 100 and below!!!");
        }
        Console.WriteLine("\n----------------------------------------------------\n");
    }
}