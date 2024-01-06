using System;
using System.Collections;
using System.Collections.Generic;
using university_management.Properties;

namespace university_management
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            int login, control;
            string inputdata;
            Readline rl = new Readline();
            List<Department> university = new List<Department>(); 
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("1.학교 admin 로그인 2.학과 admin 로그인 3.교수 로그인 4.학생 로그인 5.종료");
                        Console.Write("로그인을 해 주십시오 :");
                        login = int.Parse(Console.ReadLine());
                        if (1 <= login && login <= 5)
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
                if (login == 1)//학교관리자
                {
                    while (true)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("현재 로그인 된 계정은 학교 관리자 계정입니다!");
                                Console.WriteLine("1.학과 관리 2.교수 관리 3.학생 관리 4.교과목 관리 5.전체 정보 출력 6.로그아웃");
                                Console.Write("선택해주십시오 :");
                                control = int.Parse(Console.ReadLine());
                                if (1 <= control && control <= 6)
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
                        if (control == 1)//학과관리
                        {
                            Department department = new Department();
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("학과 관리 : 1.추가 2.변경 3.출력");
                                    Console.Write("선택해주십시오 :");
                                    control = int.Parse(Console.ReadLine());
                                    if (1 <= control && control <= 3)
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
                                department.Add_department();
                            }
                            else if (control == 2)//변경
                            {
                                Console.WriteLine("수정 할 학과를 입력하십시오:");
                                inputdata = rl.readline("", "test");
                                foreach (var item in university)
                                {
                                    if (item is Department)
                                    {
                                        if (((Department)item).Departement_Name == inputdata)
                                        {
                                            ((Department)item).Change_depatment();
                                        }
                                    }
                                }
                            }
                            else//출력
                            {
                                Console.WriteLine("학과 리스트");
                                foreach (var item in university)
                                {
                                    if (item is Department)
                                    {
                                        Console.Write("학과명:" + ((Department)item).Departement_Name);
                                    }
                                }
                            }
                        }
                        else if (control == 2)//교수관리
                        {
                            Professor professor = new Professor();
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("교수 관리 : 1.추가 2.변경 3.삭제 4.출력");
                                    Console.Write("선택해주십시오 :");
                                    control = int.Parse(Console.ReadLine());
                                    if (1 <= control && control <= 4)
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
                            if (control == 1)//교수추가
                            {
                                professor.Add();
                                university.Add(professor);
                            }
                            else if (control == 2)//교수변경
                            {
                                foreach (var item in university)
                                {
                                    Console.Write("변경할 교수의 이름 입력:");
                                    inputdata = Console.ReadLine();
                                    if (item is Professor)
                                    {
                                        if (((Professor)item).Name == inputdata)
                                        {
                                            ((Professor)item).Change();
                                        }
                                    }
                                }
                            }
                            else if (control == 3)//교수삭제
                            {
                                foreach (var item in university)
                                {
                                    Console.Write("삭제할 교수의 이름 입력:");
                                    inputdata = Console.ReadLine();
                                    if (item is Professor)
                                    {
                                        if (((Professor)item).Name == inputdata)
                                        {
                                            university.Remove(professor);
                                        }
                                    }
                                }
                            }
                            else//교수데이터들 출력
                            {
                                foreach (var item in university)
                                {
                                    if (item is Professor)
                                    {
                                        ((Person)item).printperson();
                                        ((Faculty)item).printfaculty();
                                        ((Professor)item).Print();
                                    }
                                }
                            }
                        }
                        else if (control == 3)//학생관리
                        {
                            Student student = new Student();
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("학생 관리 : 1.추가 2.변경 3.삭제 4.출력");
                                    Console.Write("선택해주십시오 :");
                                    control = int.Parse(Console.ReadLine());
                                    if (1 <= control && control <= 4)
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
                            if (control == 1)//학생추가
                            {

                                student.Add();
                                university.Add(student);

                            }
                            else if (control == 2)//학생변경
                            {
                                Console.WriteLine("정보 변경을 할 학생의 이름을 입력하십시오:");
                                inputdata = rl.readline("", "학생명:");
                                foreach (var item in university)
                                {
                                    if (item is Student)
                                    {
                                        if (((Student)item).Name == inputdata)
                                        {
                                            ((Student)item).Change();
                                        }
                                    }
                                }
                            }
                            else if (control == 3)//학생삭제
                            {
                                Console.WriteLine("삭제 할 학생의 이름을 입력하십시오:");
                                inputdata = rl.readline("", "test");
                                foreach (var item in university)
                                {
                                    if (item is Student)
                                    {
                                        if (((Student)item).Name == inputdata)
                                        {
                                            university.Remove(student);
                                        }
                                    }
                                }
                            }
                            else//학생들출력
                            {
                                foreach (var item in university)
                                {
                                    if (item is Student)
                                    {
                                        ((Person)item).printperson();
                                        ((Student)item).Print();
                                        ((Student)item).printstudent_endlist();
                                    }
                                }

                            }
                        }
                        else if (control == 4)//교과목관리
                        {
                            Subject subject = new Subject();
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("교과목 관리 : 1.과목 생성 2.과목 삭제 3.과목 수정 4.과목 출력");
                                    Console.Write("선택해주십시오 :");
                                    control = int.Parse(Console.ReadLine());
                                    if (1 <= control && control <= 4)
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
                            if (control == 1)//과목 생성
                            {
                                subject.Add();
                                university.Add(subject);
                            }
                            else if (control == 2)//과목 삭제
                            {
                                Console.WriteLine("삭제 할 과목을 입력하십시오:");
                                inputdata = rl.readline("", "test");
                                foreach (var item in university)
                                {
                                    if (item is Subject)
                                    {
                                        if (((Subject)item).Subjectname == inputdata)
                                        {
                                            university.Remove(subject);
                                        }
                                    }
                                }
                            }
                            else if (control == 3)//과목 수정
                            {
                                Console.WriteLine("수정 할 과목을 입력하십시오:");
                                inputdata = rl.readline("", "test");
                                foreach (var item in university)
                                {
                                    if (item is Subject)
                                    {
                                        if (((Subject)item).Subjectname == inputdata)
                                        {
                                            ((Subject)item).Change();
                                        }
                                    }
                                }
                            }
                            else//과목리스트출력
                            {
                                foreach (var item in university)
                                {
                                    if (item is Subject)
                                    {
                                        ((Subject)item).Print();
                                    }
                                }
                            }
                        }
                        else if (control == 5)//학교 정보 전체출력
                        {
                            Console.WriteLine("학과 정보:");
                            foreach (var item in university)
                            {
                                if (item is Department)
                                {
                                    ((Department)item).Print_Department();
                                }
                            }
                            Console.WriteLine("교수 정보:");
                            foreach (var item in university)
                            {
                                if (item is Professor)
                                {
                                    ((Person)item).printperson();
                                    ((Faculty)item).printfaculty();
                                    ((Professor)item).Print();
                                }
                            }
                            Console.WriteLine("조교 정보:");
                            foreach (var item in university)
                            {
                                if (item is Assistant)
                                {
                                    ((Person)item).printperson();
                                    ((Faculty)item).printfaculty();
                                    ((Assistant)item).Print();
                                }
                            }
                            Console.WriteLine("학생 정보:");
                            foreach (var item in university)
                            {
                                if (item is Student)
                                {
                                    ((Person)item).printperson();
                                    ((Student)item).Print();
                                    ((Student)item).printstudent_endlist();
                                }
                            }
                            Console.WriteLine("과목 정보:");
                            foreach (var item in university)
                            {
                                if (item is Subject)
                                {
                                    ((Subject)item).Print();
                                }
                            }
                            Console.WriteLine("직원 정보:");
                            foreach (var item in university)
                            {
                                if (item is Staff)
                                {
                                    ((Person)item).printperson();
                                    ((Faculty)item).printfaculty();
                                    ((Staff)item).Print();
                                }
                            }

                        }
                        else//로그아웃
                        {
                            break;
                        }
                    }

                }

                else if (login == 2)//학과관리자
                {
                    while (true)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("현재 로그인 된 계정은 학과 관리자 계정입니다!");
                                Console.WriteLine("1.교수 관리 2.학생 관리 3.수강 관리 4.학과 정보 전체 출력 5.로그아웃");
                                Console.Write("선택해주십시오 :");
                                control = int.Parse(Console.ReadLine());
                                if (1 <= control && control <= 5)
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
                        if (control == 1)//교수관리
                        {
                            foreach (var item in university)
                            {
                                Console.Write("변경할 교수의 이름 입력:");
                                inputdata = Console.ReadLine();
                                if (item is Professor)
                                {
                                    if (((Professor)item).Name == inputdata)
                                    {
                                        ((Professor)item).Change();
                                    }
                                }
                            }
                        }

                        else if (control == 2)//학생관리
                        {
                            Console.WriteLine("정보 변경을 할 학생의 이름을 입력하십시오:");
                            inputdata = rl.readline("", "학생명:");
                            foreach (var item in university)
                            {
                                if (item is Student)
                                {
                                    if (((Student)item).Name == inputdata)
                                    {
                                        ((Student)item).Change();
                                    }
                                }
                            }
                        }

                        else if (control == 3)//수강관리
                        {
                            Subject subject = new Subject();

                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("수강 관리 : 1.과목 개설 2.과목 수정");
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
                                while (true)
                                {
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("과목 개설: 1.과목 배정 2.교수 배정 3.강의실 변경 4.학생 수강 등록 및 제거 5.저장하기");
                                            Console.Write("선택해주십시오 :");
                                            control = int.Parse(Console.ReadLine());
                                            if (1 <= control && control <= 5)
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
                                    if (control == 1)//과목 개설
                                    {
                                        subject.Add();
                                    }
                                    else if (control == 2)//교수배정
                                    {
                                        subject.Add_professor();
                                    }
                                    else if (control == 3)//강의실 변경
                                    {
                                        subject.Add_lecture();
                                    }
                                    else if (control == 4)//학생 수강 등록 및 제거
                                    {
                                        subject.Control_Student();
                                    }
                                    else
                                    {
                                        university.Add(subject);
                                    }
                                }

                            }
                            else
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("과목 수정:1.과목명 2.교수 3.강의실 4.학생");
                                        Console.Write("선택해주십시오 :");
                                        control = int.Parse(Console.ReadLine());
                                        if (1 <= control && control <= 4)
                                        {
                                            Console.WriteLine("수정할 과목 이름을 적어주십시오.");
                                            inputdata = rl.readline("과목명", "과목명:");
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
                                    foreach (var item in university)
                                    {
                                        if (item is Subject)
                                        {
                                            if (((Subject)item).Subjectname == inputdata)
                                            {
                                                ((Subject)item).Add();
                                            }
                                        }
                                    }
                                }
                                else if (control == 2)
                                {
                                    foreach (var item in university)
                                    {
                                        if (item is Subject)
                                        {
                                            if (((Subject)item).Subjectname == inputdata)
                                            {
                                                ((Subject)item).Add_professor();
                                            }
                                        }
                                    }
                                }
                                else if (control == 3)
                                {
                                    foreach (var item in university)
                                    {
                                        if (item is Subject)
                                        {
                                            if (((Subject)item).Subjectname == inputdata)
                                            {
                                                ((Subject)item).Add_lecture();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (var item in university)
                                    {
                                        if (item is Subject)
                                        {
                                            if (((Subject)item).Subjectname == inputdata)
                                            {
                                                ((Subject)item).Control_Student();
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else if (control == 4)//학과정보출력
                        {
                            foreach (var item in university)
                            {
                                if (item is Department)
                                {
                                    ((Department)item).Print_Department();
                                }
                            }
                        }
                        else//로그아웃
                        {
                            break;
                        }
                    }
                }
                else if (login == 3)//교수
                {
                    while (true)
                    {
                        Console.WriteLine("로그인 할 교수 이름을 적어주십시오");
                        inputdata = Console.ReadLine();
                        foreach (var item in university)
                        {
                            if (item is Professor)
                            {
                                if (((Professor)item).Name == inputdata)
                                {
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("현재 로그인 된 계정은 교수 계정입니다!");
                                            Console.WriteLine("1.본인 정보 변경 2.강의 과목 관리 3.로그아웃");
                                            Console.Write("선택해주십시오 :");
                                            control = int.Parse(Console.ReadLine());
                                            if (1 <= control && control <= 3)
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
                                    if (control == 1)//본인정보변경
                                    {
                                        ((Professor)item).Change();
                                    }
                                    else if (control == 2)//강의과목관리
                                    {
                                        while (true)
                                        {
                                            try
                                            {
                                                Console.WriteLine("강의과목 관리 : 1.강의 과목 확인 2.수강생 정보 확인 3.과목별 성적 기입 4.학생별 성적 기입");
                                                Console.Write("선택해주십시오 :");
                                                control = int.Parse(Console.ReadLine());
                                                if (1 <= control && control <= 4)
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
                                        if (control == 1)//강의 과목 확인
                                        {
                                            ((Professor)item).Print_subject();
                                        }
                                        else if (control == 2)//수강생 정보 확인
                                        {
                                            //교수가 강의하는 과목을 수강하는 학생리스트 출력
                                            ((Professor)item).Print_student();
                                        }
                                        else if (control == 3)//과목별 성적 기입
                                        {
                                            Console.WriteLine("성적을 입력할 과목을 선택하십시오.");
                                            //리스트 출력
                                            //입력

                                        }
                                        else//학생별 성적 기입
                                        {
                                            Console.WriteLine("성적을 입력할 학생을 선택하십시오.");
                                            //리스트 출력
                                            //입력
                                        }
                                    }
                                    else//로그아웃
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }

                }
                else if (login == 4)//학생
                {
                    while (true)
                    {
                        Console.WriteLine("로그인 할 교수 이름을 적어주십시오");
                        inputdata = Console.ReadLine();
                        foreach (var item in university)
                        {
                            if (item is Professor)
                            {
                                if (((Professor)item).Name == inputdata)
                                {
                                    while (true)
                                    {
                                        while (true)
                                        {
                                            try
                                            {
                                                Console.WriteLine("현재 로그인 된 계정은 학생 계정입니다!");
                                                Console.WriteLine("1.본인 정보 변경 2.수강 관리 3.성적 확인 4.로그아웃");
                                                Console.Write("선택해주십시오 :");
                                                control = int.Parse(Console.ReadLine());
                                                if (1 <= control && control <= 4)
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
                                        if (control == 1)//본인정보변경
                                        {
                                            ((Student)item).Change();
                                        }
                                        else if (control == 2)//수강관리
                                        {
                                            while (true)
                                            {
                                                try
                                                {
                                                    Console.WriteLine("수강 관리 : 1.수강 신청 및 변경 2.현재 학기 등록 과목 확인");
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
                                            if (control == 1)//수강 신청 및 변경
                                            {

                                            }

                                            else//현재 학기 등록 과목 확인
                                            {

                                            }
                                        }
                                        else if (control == 3)//성적확인
                                        {
                                            while (true)
                                            {
                                                try
                                                {
                                                    Console.WriteLine("수강 관리 : 1.과거 수강 과목 및 성적 확인 2.평점 평균 확인");
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
                                            if (control == 1)//과거 수강 과목 및 성적 학인
                                            {

                                            }
                                            else//평점 평균 확인
                                            {

                                            }
                                        }
                                        else//로그아웃
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else//종료
                {
                    break;
                }

            }
        }
    }
}
