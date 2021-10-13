using System;
using System.Collections.Generic;

namespace HW_3_task_2
{
	public class Group
	{
		public Group(string name)
		{
			GroupName = name;
		}

		public bool AddStudent(Student s)
		{
			if (StudentList.Contains(s))
			{
				Console.WriteLine($"student {s.Name} has already joined the {GroupName} group.");
				return false;
			}
			StudentList.Add(s);
			Console.WriteLine($"student {s.Name} was added to the {GroupName} group.\n");
			return true;
		}
		public void GetInfo()
		{
			Console.Write("===========================================================\n" +
								"GetInfoResult\n" +
						"===========================================================\n");

			Console.WriteLine($"Group: {GroupName}");
			Console.WriteLine("Students:");

			foreach(Student s in StudentList)
			{
				Console.WriteLine(s.Name);
				Console.WriteLine(s.State);
			}

		}

		public string GroupName;
		public List<Student> StudentList = new List<Student>();
	}
	class Program
	{

		static void AddGroup()
		{

		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the group name:");
			string EnteredGroupName = Console.ReadLine();
			Group MyGroup = new Group(EnteredGroupName);

			Console.WriteLine("Do you wish to add a new student to the group (yes/no)");
			string answer = Console.ReadLine();

			while (answer != "yes" && answer != "Yes" && answer != "no" && answer != "No")
			{
				Console.WriteLine("I can`t understand what you`ve entered. Please try again.");
				answer = Console.ReadLine();
			}

			if (answer == "yes" || answer == "Yes")
			{
				Console.WriteLine("Enter the student name:");
				string StudentName = Console.ReadLine();

				int AddedStudent = MyGroup.StudentList.Count;
				var ChoosingStudentState = new Random();
				if (ChoosingStudentState.Next(0, 2) == 1)
				{
					MyGroup.AddStudent(new BadStudent(StudentName));
				}
				else
				{
					MyGroup.AddStudent(new GoodStudent(StudentName));
				}
				MyGroup.StudentList[AddedStudent].Study();
			}
			MyGroup.GetInfo();
		}
	}
}
