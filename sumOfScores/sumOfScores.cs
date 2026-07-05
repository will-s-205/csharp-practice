using System;

public class Program
{
    public static void Main()
    {
        // initialize variables - graded assignments 
        int currentAssignments = 5;

        // Sohpia scores for each assignment
        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;
        // Nicolas scores for each assignment
        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;
        // Zahirah scores for each assignment
        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;
        // Jeong scores for each assignment
        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        // sum of scores for each student
        int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        // divide the sum of assignment scores by the total number of assignments
        decimal sophiaScore = sophiaSum / (decimal)currentAssignments;
        decimal nicolasScore = nicolasSum / (decimal)currentAssignments;
        decimal zahirahScore = zahirahSum / (decimal)currentAssignments;
        decimal jeongScore = jeongSum / (decimal)currentAssignments;

        // console output to show avarege score of students
        Console.WriteLine("Sophia: " + sophiaScore + " A");
        Console.WriteLine("Nicolas: " + nicolasScore + " B");
        Console.WriteLine("Zahirah: " + zahirahScore + " B");
        Console.WriteLine("Jeong: " + jeongScore + " A");

        // format output as aligned columns of text 
        // \n - new line
        // \t - insert a tab between the text items
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
        Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
        Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
        Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
    }
}
