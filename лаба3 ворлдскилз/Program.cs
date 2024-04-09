internal class Program
{
    private static void Main(string[] args)
    {
        Student[] student = new Student[7]
        {
            new Student { Name = "Иванов И.И.", Group = "1", Evaluations = new int[] { 4, 5, 4, 5, 5, } },
            new Student { Name = "Петров П.П.", Group = "1", Evaluations = new int[] { 4, 4, 4, 5, 5, } },
            new Student { Name = "Андреев А.А.", Group = "1", Evaluations = new int[] { 3, 5, 5, 3, 5, } },
            new Student { Name = "Сергеев С.С.", Group = "1", Evaluations = new int[] { 2, 5, 5, 5, 4, } },
            new Student { Name = "Данилов Д.Д", Group = "1", Evaluations = new int[] { 4, 5, 4, 3, 5, } },
            new Student { Name = "Егоров Е.Е", Group = "1", Evaluations = new int[] { 3, 4, 3, 5, 4, } },
            new Student { Name = "Максимов М.М.", Group = "1", Evaluations = new int[] { 5, 5, 5, 5, 5, } }
        };
        Array.Sort(student, (x, y) => x.Average_score().CompareTo(y.Average_score()));
        foreach (var st in student)
        {
            Console.WriteLine($"{st.Name}, Группа: {st.Group}, Средний балл: {st.Average_score()}");
        }
    }
}

public struct Student
{
    public string Name;
    public string Group;
    public int[] Evaluations;

    public double Average_score()
    {
         return Evaluations.Average(); 
    }
}

