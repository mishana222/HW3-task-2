using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3_task_2
{
	public class Student
	{
		public Student(string name, string state)
		{
			Name = name;
			State = state;
		}
		public virtual void Study() { }

		public void Relax() { State += "->Relax"; }
		public void Read() { State += "->Read"; }
		public void Write() { State += "->Write"; }
		
		public string Name;
		public string State;

	}
	public class GoodStudent : Student
	{
		public GoodStudent(string name):
			base(name, "Good")
		{ }
		public override void Study()
		{
			Read();
			Write();
			Read();
			Write();
			Relax();
		}
	}
	public class BadStudent : Student
	{
		public BadStudent(string name) :
			base(name, "Bad")
		{ }
		public override void Study()
		{
			Relax();
			Relax();
			Relax();
			Relax();
			Read();
		}
	}
}
