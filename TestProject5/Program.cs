// int currentAssigments = 5;

// string[] studentName = new string[]{"Sophia", "Andrew", "Emma", "Logan"};

// int[][] studentScore  = 
// { 
//     new int[]{ 90, 86, 87, 98, 100 }, 
//     new int[]{ 92, 89, 81, 96, 90 }, 
//     new int[]{ 90, 85, 87, 98, 68 }, 
//     new int[]{ 90, 95, 87, 88, 96 } 
// };

// int[] studentScoreTotal = { 0, 0, 0, 0 };
// decimal[] studentScoreAverage  = { 0.0m, 0.0m, 0.0m, 0.0m};

// for (int i=0; i < studentName.Length; i++)
// {
//     foreach (int score in studentScore[i])
//     {
//         studentScoreTotal[i] += score;
//     }
//     studentScoreAverage[i] = (decimal)studentScoreTotal[i] / currentAssigments;
// }

// Console.WriteLine("Student Name\tTotal Score\tAverage Score\tGrade");
// Console.WriteLine("------------\t-----------\t-------------");

// for (int i=0; i < studentName.Length; i++)
// {
//     Console.Write("{0}\t\t{1}\t\t{2}", studentName[i], studentScoreTotal[i], studentScoreAverage[i]);
//     if (studentScoreAverage[i] < 60)
//     {
//         Console.WriteLine("\t\tF");
//     }
//     else if (studentScoreAverage[i] >= 60 && studentScoreAverage[i] < 63)
//     {
//         Console.WriteLine("\t\tD-");
//     }
//     else if (studentScoreAverage[i] >= 63 && studentScoreAverage[i] < 67)
//     {
//         Console.WriteLine("\t\tD");
//     }
//     else if (studentScoreAverage[i] >= 67 && studentScoreAverage[i] < 70)
//     {
//         Console.WriteLine("\t\tD+");
//     }
//     else if (studentScoreAverage[i] >= 70 && studentScoreAverage[i] < 73)
//     {
//         Console.WriteLine("\t\tC-");
//     }
//     else if (studentScoreAverage[i] >= 73 && studentScoreAverage[i] < 77)
//     {
//         Console.WriteLine("\t\tC");
//     }
//     else if (studentScoreAverage[i] >= 77 && studentScoreAverage[i] < 80)
//     {
//         Console.WriteLine("\t\tC+");
//     }
//     else if (studentScoreAverage[i] >= 80 && studentScoreAverage[i] < 83)
//     {
//         Console.WriteLine("\t\tB-");
//     }
//     else if (studentScoreAverage[i] >= 83 && studentScoreAverage[i] < 87)
//     {
//         Console.WriteLine("\t\tB");
//     }
//     else if (studentScoreAverage[i] >= 87 && studentScoreAverage[i] < 90)
//     {
//         Console.WriteLine("\t\tB+");
//     }
//     else if (studentScoreAverage[i] >= 90 && studentScoreAverage[i] < 93)
//     {
//         Console.WriteLine("\t\tA-");
//     }
//     else if (studentScoreAverage[i] >= 93 && studentScoreAverage[i] <= 97)
//     {
//         Console.WriteLine("\t\tA");
//     }
//     else if (studentScoreAverage[i] >= 97 && studentScoreAverage[i] <= 100)
//     {
//         Console.WriteLine("\t\tA+");
//     }
// }
public class Program
{
    public class Student
    {
        public string? Name { get; set; }
        public int[]? Scores { get; set; }
        public int TotalScore { get; set; }
        public decimal AverageScore { get; set; }
        public string? Grade { get; set; }

    }
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "Sophia", Scores = new[] { 90, 86, 87, 98, 100 } },
            new Student { Name = "Andrew", Scores = new[] { 92, 89, 81, 96, 90 } },
            new Student { Name = "Emma", Scores = new[] { 90, 85, 87, 98, 68 } },
            new Student { Name = "Logan", Scores = new[] { 90, 95, 87, 88, 96 } }
        };

        foreach (var student in students)
        {
            student.TotalScore = student.Scores?.Sum() ?? 0;
            student.AverageScore = (decimal)student.TotalScore / (student.Scores?.Length ?? 0);
            student.Grade = CalculateGrade(student.AverageScore);
        }

        Console.WriteLine("Student Name\tTotal Score\tAverage Score\tGrade");
        Console.WriteLine("------------\t-----------\t-------------");

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}\t\t{student.TotalScore}\t\t{student.AverageScore}\t\t{student.Grade}");
        }
    }

    public static string CalculateGrade(decimal averageScore)
    {
        var gradeBoundaries = new List<(int Lower, int Upper, string Grade)>
        {
            (0, 60, "F"),
            (60, 63, "D-"),
            (63, 67, "D"),
            (67, 70, "D+"),
            (70, 73, "C-"),
            (73, 77, "C"),
            (77, 80, "C+"),
            (80, 83, "B-"),
            (83, 87, "B"),
            (87, 90, "B+"),
            (90, 93, "A-"),
            (93, 97, "A"),
            (97, 100, "A+")
        };

        foreach (var boundary in gradeBoundaries)
        {
            if (averageScore >= boundary.Lower && averageScore < boundary.Upper)
            {
                return boundary.Grade;
            }
        }

        return string.Empty;
    }
}