namespace StudentApplication
{
	internal class Program
	{
		static void Main(string[] args)
		{
	
			

			int studentId = 0;
			string firstName = string.Empty;
			string lastName = string.Empty;
			decimal loanAmount = 0;
			char gender;
			bool isNew;

            Console.WriteLine("Enter student Id");
			studentId  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter student first name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter student last name");
            lastName = Console.ReadLine();

			Console.WriteLine("Please enter the student loan amount");
			loanAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the student gender");
			gender = Convert.ToChar(Console.ReadLine());

			Console.WriteLine("The student is new (true/fasle)");
			isNew = Convert.ToBoolean(Console.ReadLine());	

			Student stu = new Student(studentId, firstName, lastName, loanAmount, gender, isNew);

           

        }
	}
}