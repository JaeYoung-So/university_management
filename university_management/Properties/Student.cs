using System;
using System.Collections.Generic;

namespace university_management.Properties
{
    class Student : Person, Management
    {
        Readline rl = new Readline();


        private int student_id;//학번        
        private string affiliated_department;//소속학과        
        private string scholarship;//장학금

        public int Student_id
        {
            get { return student_id; }
            set
            {
                if (value > 0)
                {
                    student_id = value;
                }
                else
                {
                    Console.WriteLine("0보다 큰 값을 입력하십시오.");
                    Console.Write("학번:");
                    this.Student_id = rl.readline(Student_id, "학번:");
                }
            }
        }
        public string Affiliated_department { get { return affiliated_department; } set { affiliated_department = value; } }
        public string Scholarship { get { return scholarship; } set { scholarship = value; } }
        public List<SubjcetEnd_List> subjcetEnd_Lists = new List<SubjcetEnd_List>();
        SubjcetEnd_List subjcetEnd_List = new SubjcetEnd_List();

        public struct SubjcetEnd_List
        {

            private string subject;//들은과목
            private string professor;//담당교수
            private double grades;//성적

            public string Subject { get { return subject; } set { subject = value; } }
            public string Professor { get { return professor; } set { professor = value; } }
            public double Grades
            {
                get => grades;
                set
                {
                    if (0 <= value && value <= 4.5)
                    {
                        grades = value;
                    }
                    else
                    {
                        Console.WriteLine("0~4.5사이의 값을 입력하십시오.");
                        grades = -1;
                    }
                }
            }
        }

        public void Add()
        {
            Console.Write("이름:");
            this.Name = rl.readline(Name, "이름:");
            Console.Write("전화번호:");
            this.Phonenum = rl.readline(Phonenum, "전화번호:");
            Console.Write("이메일:");
            this.Email = rl.readline(Email, "이메일:");
            Console.Write("학번:");
            this.Student_id = rl.readline(Student_id, "학번:");
            Console.Write("소속학과:");
            this.Affiliated_department = rl.readline(Affiliated_department, "소속학과:");
            Console.Write("장학금:");
            this.Scholarship = rl.readline(Affiliated_department, "장학금:");
        }

        public void Change()
        {

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
        public void Add_endlist()
        {
            Console.WriteLine("수강 완료 과목 추가:");


            Console.Write("수강완료 과목: ");
            subjcetEnd_List.Subject = rl.readline(subjcetEnd_List.Subject, "수강완료 과목: ");
            Console.Write("담당 교수: ");
            subjcetEnd_List.Professor = rl.readline(subjcetEnd_List.Professor, "담당 교수: ");
            while (subjcetEnd_List.Grades <= 0 || subjcetEnd_List.Grades >= 4.5)
            {
                Console.Write("성적: ");
                subjcetEnd_List.Grades = rl.readline(subjcetEnd_List.Grades, "성적: ");
            }
            subjcetEnd_Lists.Add(subjcetEnd_List);
        }
        public void Print()
        {
            Console.WriteLine(" 학번: " + student_id + " 소속 학과: " + affiliated_department + " 장학금: " + Scholarship);
        }
        public void printstudent_endlist()
        {
            Console.WriteLine("학생의 수강 완료 목록");
            foreach (var item in subjcetEnd_Lists)
            {
                Console.WriteLine("수강 완료 과목: " + item.Subject + " 담당 교수: " + item.Professor + " 성적: " + item.Grades);
            }
        }
    }
}
