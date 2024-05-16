namespace SDKnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many student records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Student>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
               
                HonorStudent testStudent = new HonorStudent();

                Console.WriteLine("Enter the student's name:  ");
                testStudent.studentName = Console.ReadLine();
                Console.WriteLine("Enter the student's age:  ");
                testStudent.studentAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student's courses:  ");
                Console.WriteLine("When done adding courses, type 'done' ");
                string input = "";
                while ((input = Console.ReadLine()) != "done")
                {
                    testStudent.studentCourses.Add(input);
                }

                Console.WriteLine("Enter the student's mom's name:  ");
                testStudent.studentMomName = Console.ReadLine();
                Console.WriteLine("Enter the student's dad's name:  ");
                testStudent.studentDadName = Console.ReadLine();
                Console.WriteLine("Enter the student's required honors classes:  ");
                Console.WriteLine("When done adding courses, type 'done' ");

                while ((input = Console.ReadLine()) != "done")
                {
                    testStudent.RequiredHonorsClasses.Add(input);
                }

                Console.WriteLine("Enter the student's completed honors classes:  ");
                Console.WriteLine("When done adding courses, type 'done' ");

                while ((input = Console.ReadLine()) != "done")
                {
                    testStudent.CompletedHonorsClasses.Add(input);
                }

                recordList.Add(testStudent);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var record in recordList)
            {
                Console.WriteLine(record.ToString());
            }
        }
    }
}
