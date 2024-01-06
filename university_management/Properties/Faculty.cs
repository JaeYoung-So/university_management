using System;
namespace university_management.Properties
{
    class Faculty : Person
    {
        private int employee_number; //사번       
        private int pay; //급여        
        private string join_date;//입사일
        private string rank;//직급

        public int Employee_number { get { return employee_number; } set { employee_number = value; } }
        public int Pay { get { return pay; } set { pay = value; } }
        public string Join_date { get { return join_date; } set { join_date = value; } }
        public string Rank { get { return rank; } set { rank = value; } }

        public void printfaculty()
        {
            Console.Write(" 사번: " + employee_number + " 급여: " + pay + " 입사일: " + join_date + " 직급: " + rank);
        }
    }
}
