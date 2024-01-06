using System;
using System.Collections.Generic;

namespace university_management.Properties
{
    class Department
    {
        private string department_Name;
        private string department_Address;
        private string department_Number;
        private string department_Assistant_name;
        private string department_Head_name;
        private string department_Email;
        private string department_Website;
        private List<string> affiliated_Professor = new List<string>();
        private List<string> affiliated_Student = new List<string>();

        public string Departement_Name { get { return department_Name; } set { department_Name = value; } }
        public string Departement_Adress { get { return department_Address; } set { department_Address = value; } }
        public string Departement_Number { get { return department_Number; } set { department_Number = value; } }
        public string Departement_Assistant_name { get { return department_Assistant_name; } set { department_Assistant_name = value; } }
        public string Departement_Head_name { get { return department_Head_name; } set { department_Head_name = value; } }
        public string Departement_Email { get { return department_Email; } set { department_Email = value; } }
        public string Departement_Website { get { return department_Website; } set { department_Website = value; } }
        public List<string> Affiliated_Professor { get { return affiliated_Professor; } set { affiliated_Professor = value; } }
        public List<string> Affiliated_Student { get { return affiliated_Student; } set { affiliated_Student = value; } }

        public Professor Name { get; internal set; }

        public void Add_department()
        {

        }
        public void Change_depatment()
        {

        }

        public void Print_Department()
        {
            Console.WriteLine("학과이름:"+"학과 주소:"+"학과 번호:");
        }

        internal void Printstudent()
        {
            Console.Write("수강생 목록:");
            foreach(var item in affiliated_Student)
            {
                Console.Write(item+",");
            }
        }
    }
}
