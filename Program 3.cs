using ConsoleApp16;

class Program
{
    public static void Main()
    {
        Student[] students = new Student[7]
        {
            new Student { Name = "Ермолаев М.Ю.", GroupNumber = 2235, Grades = new int[] { 5, 4, 4, 3, 5 } },
            new Student { Name = "Володин В.О.", GroupNumber = 1915, Grades = new int[] { 3, 3, 4, 4, 2 } },
            new Student { Name = "Сорокин В.Г.", GroupNumber = 2235, Grades = new int[] { 4, 5, 5, 4, 5 } },
            new Student { Name = "Акбаров Д.П.", GroupNumber = 2317, Grades = new int[] { 4, 4, 4, 3, 5 } },
            new Student { Name = "Фешкин И.А.", GroupNumber = 2319, Grades = new int[] { 5, 5, 5, 4, 5 } },
            new Student { Name = "Зйцев М.А.", GroupNumber = 2020, Grades = new int[] { 3, 4, 4, 3, 3 } },
            new Student { Name = "Игнатов Ф.М.", GroupNumber = 2015, Grades = new int[] { 5, 4, 5, 5, 5 } }
        };

        Array.Sort(students, (x, y) => x.AverageGrade.CompareTo(y.AverageGrade));

        Console.WriteLine("Отсортированный список студентов по возрастанию среднего балла: \n------------------------------------------------");
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.Name}, Группа: {student.GroupNumber}, Средний балл: {student.AverageGrade}");
        }
    }
}