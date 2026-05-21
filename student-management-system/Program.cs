class Program
{
    public static void Main(String[] args)
    {
        StudentManager student = new StudentManager();
        while (true)
        {

            System.Console.WriteLine("==========================================");
            System.Console.WriteLine("Please Enter the Number on What you want to do: " + "\n1. Add Student" + "\n2. Update Student" + "\n3. Remove Student " + "\n4. Display Students" + "\n5. Search Student " + "\n6. Exit ");

            System.Console.WriteLine("==========================================");
            System.Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                student.AddStudent();
            }
            else if (choice == 4)
            {
                System.Console.Write("Enter the ID of the student you want to view: ");
                string idChoice = Console.ReadLine();

                if (idChoice == "")
                {
                    Console.WriteLine("ID cannot be Empty!");
                    return;
                }
                student.DisplayStudents(idChoice);
            }

            else if (choice == 6)
            {
                return;
            }

            if (choice == 3)
            {
                System.Console.Write("Enter the ID of the student you want to remove: ");
                string deleteStudentId=Console.ReadLine();
                
                student.RemoveStudent(deleteStudentId);
            }
            if (choice == 2)
            {
                System.Console.WriteLine("===============================================");
                 System.Console.WriteLine("Enter the ID you want to update: ");
                string updateStudent=Console.ReadLine();
                student.UpdateStudent(updateStudent);

            }
            if (choice == 5)
            {
                System.Console.WriteLine("==================================================");
                System.Console.Write("Enter the ID you want to search: ");
                string searchStudent=Console.ReadLine();
                student.SearchStudent(searchStudent);
                
                
            }
        }
    }
}