using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
	public class Student
	{
		int _studentId = 0;
		string _firstName = string.Empty;
		string _lastName = string.Empty;
		decimal _loanAmount = 0;
		char _gender;
		bool _isNew;


        public Student(int studentId, string firstName, string lastName, decimal loanAmount, char gender, bool isNew)
        {
            _studentId = studentId;
			_firstName = firstName;
			_lastName = lastName;
			_loanAmount = loanAmount;
			_gender = gender;
			_isNew = isNew;
        }

		public void UpdateLoanAmount(decimal loanAmount) 
		{
		   _loanAmount = loanAmount;
		}

		public string StudentData()
		{
			string StudentData = $"studentId {_studentId}, first name {_firstName}, loan amount {_loanAmount}";
			return StudentData ;	
		}
    }
}
