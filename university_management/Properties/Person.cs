using System;
namespace university_management.Properties
{
    class Person : Department
    {
        private string name;
        private string phonenum;
        private string email;

        public string Name { get { return name; } set { name = value; } }
        public string Phonenum { get { return phonenum; } set { phonenum = value; } }
        public string Email { get { return email; } set { email = value; } }
        public void printperson()
        {
            Console.Write("이름:" + name + " 전화번호:" + phonenum + " 이메일:" + email);
        }
    }
}
