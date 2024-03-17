namespace Class.Models;

public class Group
{
    public int GroupNo;
    public int Limit;
    private Student[] Students;

    public Group(int groupNo,int limit)
    {
        GroupNo = groupNo;
        Limit = limit;
        Students  = new Student[0];
    }
    public void AddStudents(Student student)
    {
        if(Students.Length > Limit) Console.WriteLine($"Group {GroupNo} is full.");
        Array.Resize(ref Students, Students.Length+1);
        Students[Students.Length-1] = student;
    }
    public Student[] GetStudents()
    {
        return Students;
    }
}
