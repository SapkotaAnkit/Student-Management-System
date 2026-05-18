class Program
{
    public static void Main(String[] args)
    {
        System.Console.WriteLine("Please Enter the Number on What you want to do: " + "\n1. Add Student" + "\n2. Update Student" + "\n3. Remove Student");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            StudentManager addStudent = new StudentManager();
            addStudent.AddStudent();
        }

    }
}