
using Class.Models;


#region TASK-1
Book[] books = new Book[10];

string name;
int pageCount;
for (int i = 0; i< books.Length; i++)
{
    Console.WriteLine("Enter book details :");
    do
    {
        Console.Write("Name : ");
        name = Console.ReadLine();
        if (name.Length<3) Console.WriteLine("Name should be at least 3 characters long. Please try again.");
    }
    while (name.Length < 3);

    do
    {
        Console.WriteLine("Page Count : ");
        pageCount = int.Parse(Console.ReadLine());
        if (pageCount < 10) Console.WriteLine("Page count must be greater than 10. Please try again.");
    }
    while (pageCount <10);

    books[i] = new Book(name, pageCount);
}

for (int i = 0; i<books.Length; i++)
{
    Console.WriteLine($"{i+1}.Book Name : {books[i].Name} \n  Page Count : {books[i].PageCount}\n");
}
#endregion


#region TASK-2
//Console.WriteLine("Enter Group Number : ");
//int GroupNo = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter Group Limit : ");
//int GroupLimit = int.Parse(Console.ReadLine());

//Group group = new(GroupNo, GroupLimit);


//while (true)
//{
//    Console.WriteLine("\nEnter Student Details : ");
//    Console.Write("Name: ");
//    string name = Console.ReadLine();
//    Console.Write("Surname: ");
//    string surname = Console.ReadLine();

//    Student student = new(name, surname);
//    group.AddStudents(student);

//    if (group.GetStudents().Length == GroupLimit)
//    {
//        break;
//    }
//}
//Student[] students = group.GetStudents();
//foreach (Student student in students)
//{
//    Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}");
//}
#endregion
