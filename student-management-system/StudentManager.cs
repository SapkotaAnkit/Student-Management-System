using System.Security.Cryptography.X509Certificates;
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
        Console.Write("Enter Name: ");
        string Name = Console.ReadLine();

        //Enter Age

        Console.Write("Enter Age: ");
        int Age = Convert.ToInt32(Console.ReadLine());

        //Enter Course

        Console.Write("Enter Course: ");
        string Course = Console.ReadLine();

        // Enter Marks
        System.Console.Write("Enter Marks: ");
        int Marks = Convert.ToInt32(Console.ReadLine());

        //object creation
        Student student = new Student(ID, Name, Age, Course, Marks);

        // add student to the list
        students.Add(student);

        DisplayStudents(ID);

        System.Console.WriteLine("=================================");
    }
    public void DisplayStudents(string ID)
    {
        Student student = students.Find(s => s.ID == ID);


        //if student is null
        if (student == null)
        {
            Console.WriteLine("Error: No student found with that ID.");
            return;
        }

        Console.WriteLine("The student is: ");
        Console.WriteLine("Name: " + student.Name);
    }
    public void RemoveStudent(string ID)
    {
        Student studentToRemove = students.Find(s => s.ID == ID);
        bool isDelete = students.Remove(studentToRemove);
        if (isDelete)
        {
            System.Console.WriteLine("It is deleted successfully");
        }
        else
        {
            System.Console.WriteLine("ID not Found!! ");
        }
    }
    public void UpdateStudent(string ID)
    {
        Student studentToUpdate = students.Find(s => s.ID == ID);
        if (studentToUpdate != null)
        {


            System.Console.WriteLine("Enter the number you want to change: " + "\n1.Name " + "\n2.Age " + "\n3.Course " + "\n4.Marks");
            string updateChoice = Console.ReadLine();
            System.Console.WriteLine("===============================================");
            if (updateChoice == "1")
            {
                System.Console.WriteLine("Enter the new Name of the student: ");
                string newName = Console.ReadLine();
                if (newName == null)
                {
                    System.Console.WriteLine("WTF Nigga enter the damn name!");
                    return;

                }
                studentToUpdate.Name = newName;

            }
            else if (updateChoice == "2")
            {
                System.Console.WriteLine("Enter the Age of the student you want to update: ");
                int newAge = Convert.ToInt32(Console.ReadLine());
                if (newAge == null)
                {
                    System.Console.WriteLine("WTF Nigga enter the damn Age!!");
                    return;
                }

            }
            else if (updateChoice == "3")
            {
                System.Console.WriteLine("Enter the course of the student you want to update: ");
                string newCourse = Console.ReadLine();
                if (newCourse == null)
                {
                    Console.WriteLine("WTF Nigga enter the damn course");
                    return;
                }
            }
            else if (updateChoice == "4")
            {
                System.Console.WriteLine("Enter new marks of the student: ");
                int newMarks= Convert.ToInt32(Console.ReadLine());
                if (newMarks == null)
                {
                    System.Console.WriteLine("WTF Nigga enter the damn Marks");
                    return;
                }
            }
            
            System.Console.WriteLine("Student updated successfully!!");
        }
        else
        {
            System.Console.WriteLine("Student not found!!");
        }
        
    }
    public void SearchStudent(string ID)
    {
        Student searchStudent =students.Find(s=> s.ID==ID); 
        if (searchStudent != null)
                {
                    System.Console.WriteLine("The student is: ");
                    System.Console.WriteLine("Name: " + searchStudent.Name);
                    System.Console.WriteLine("Course: " + searchStudent.Course);
                    return;
                }    

    }
}