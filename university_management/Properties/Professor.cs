using System;
using System.Collections.Generic;

namespace university_management.Properties
{
    class Professor : Faculty, Management
    {
        Readline rl = new Readline();
        string subject;
        int control;
        private string departement;//학과       
        private List<string> lecture_subject = new List<string>();//강의과목
        private List<string> students = new List<string>();

        public string Departement { get { return departement; } set { departement = value; } }
        public List<string> Lecture_subject { get { return lecture_subject; } set { lecture_subject = value; } }
        public List<string> Students { get { return students; } set { students = value; } }


        public void Add()
        {
            Console.Write("이름:");
            this.Name = rl.readline(Name, "이름:");
            Console.Write("전화번호:");
            this.Phonenum = rl.readline(Phonenum, "전화번호:");
            Console.Write("이메일:");
            this.Email = rl.readline(Email, "이메일:");
            Console.Write("사번:");
            this.Employee_number = rl.readline(Employee_number, "사번:");
            Console.Write("급여:");
            this.Pay = rl.readline(Pay, "급여:");
            Console.Write("입사일:");
            this.Join_date = rl.readline(Join_date, "입사일:");
            Console.Write("직급:");
            this.Rank = rl.readline(Rank, "직급:");
            Console.Write("학과:");
            this.Departement = rl.readline(Departement, "학과:");
            
            
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("강의 과목: 1.추가 2.종료");
                        Console.Write("선택해주십시오 :");
                        control = int.Parse(Console.ReadLine());
                        if (1 <= control && control <= 2)
                        {
                            break;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("잘못 입력하셨습니다 다시 입력해주세요");
                        continue;
                    }
                }
                if (control == 1)
                {
                    Console.Write("강의과목:");
                    subject = rl.readline(subject, "강의과목:");
                    this.Lecture_subject.Add(subject);
                }
                else
                {
                    break;
                }
            }
            
        }

        public void Change()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
        public void Print()
        {
            Console.WriteLine(" 소속 학과: " + departement + " 강의 과목: " + lecture_subject);
        }
        public void Print_subject()
        {
            Console.Write(" 강의 과목: ");
            foreach (var item in lecture_subject)
            {
                Console.Write(item+",");
            }
        }
        public void Print_student()
        {
            Console.Write("수강 학생 이름: ");
            foreach (var item in students)
            {
                Console.Write(item + ",");
            }
        }
    }

}
