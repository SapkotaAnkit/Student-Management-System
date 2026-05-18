using System.Transactions;

public class StudentManager
{
    //here, students will be stored
    List<Student> students = new List<Student>();

    //This adds students in the list students

    public void AddStudent()
    {
        // Enter ID
        System.Console.Write("Enter ID: ");
        string ID = Console.ReadLine();

        //Enter Name
        System.Console.Write("Enter Name: ");
        string Name = Console.ReadLine();

        //Enter Age

        System.Console.Write("Enter Age: ");
        int Age = Convert.ToInt32(Console.ReadLine());

        //Enter Course

        System.Console.Write("Enter Course: ");
        string Course = Console.ReadLine();

        // Enter Marks
        System.Console.Write("Enter Marks: ");
        int Marks = Convert.ToInt32(Console.ReadLine());

        //object creation
        Student student = new Student(ID, Name, Age, Course, Marks);

        // add student to the list
        students.Add(student);

        Student student1 = students.Find(s => s.ID == ID);

        System.Console.WriteLine("The student is Added successfully\n" + "ID: " + student1.ID + "\nName: " + student1.Name + "\nAge: " + student1.Age + "\nCourse: " + student1.Course + "\nMarks: " + student1.Marks);
    }


}