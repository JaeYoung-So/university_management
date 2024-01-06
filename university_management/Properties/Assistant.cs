using System;
namespace university_management.Properties
{
    class Assistant : Faculty, Management
    {
        Readline rl = new Readline();
        private string affiliated_department;//소속부서
        private string dividend_subjcet;//배당 과목

        public string Affilated_departement { get { return affiliated_department; } set { affiliated_department = value; } }
        public string Dividend_subject { get { return dividend_subjcet; } set { dividend_subjcet = value; } }

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
            Console.Write("소속 부서:");
            this.Affilated_departement = rl.readline(Affilated_departement, "소속 부서:");
            Console.Write("배당 과목:");
            this.Dividend_subject = rl.readline(dividend_subjcet, "배당 과목:");
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
            Console.Write(" 소속 부서: " + affiliated_department + " 배당 과목: " + dividend_subjcet);
        }

    }
}
