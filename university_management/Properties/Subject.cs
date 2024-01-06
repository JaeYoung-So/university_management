using System;
using System.Collections.Generic;

namespace university_management.Properties
{
    class Subject : Department, Management
    {
        Readline rl = new Readline();
        private string subjectname;//과목
        private List<string> studentlist = new List<string>();
        private string professorname;//담당교수
        private string lecture_room;

        public string Subjectname { get => subjectname; set => subjectname = value; }
        public List<string> Studentlist { get => studentlist; set => studentlist = value; }
        public string Professorname { get => professorname; set => professorname = value; }
        public string Lecture_room { get => lecture_room; set => lecture_room = value; }


        public void Add()
        {
            Console.Write("개설 과목명:");
            this.Subjectname = rl.readline(Subjectname, "과목명:");
            
        }
        public void Add_professor()
        {
            Console.Write("담당교수:");
            this.Professorname = rl.readline(Professorname, "담당교수:");
            
        }
        public void Add_lecture()
        {
            Console.Write("강의실:");
            this.Lecture_room = rl.readline(Lecture_room, "강의실:");
        }
        public void Control_Student()
        {
            Console.WriteLine("추가 및 제거중 원하는걸 선택하십시오");
            int control;
            string name;
            while (true)
            {
                try
                {
                    Console.WriteLine("학생 관리 : 1.추가 2.제거");
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
            if (control == 1)//추가
            {
                Console.Write("추가 할 학생의 이름을 입력하십시오:");
                name = rl.readline(Professorname, "이름:");
                this.Studentlist.Add(name);
            }
            else
            {
                Console.Write("삭제 할 학생의 이름을 입력하십시오:");
                name = rl.readline(Professorname, "이름:");
                this.studentlist.Remove(name);
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
            Console.WriteLine("과목명: "+Subjectname+" 담당교수: "+Professorname+" 강의실: "+Lecture_room);

            Console.Write("수강학생:");
            foreach (var item in Studentlist)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
        }
    }
}
