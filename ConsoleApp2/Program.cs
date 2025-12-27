using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//야구게임 만들기
//플레이어는  숫자3개를 입력
//중복이면 말해주기



namespace ConsoleApp2
{
    internal class Program
    {
        public int hp;
        public char name;
        public int att;
     
        static void Main()
        {
            
            Console.WriteLine("스테이터스창");
            Console.WriteLine("이름 플레이어");
            Console.WriteLine("체력 : 30");
            Console.WriteLine("공격력 : 2");
            Console.ReadLine();
            while(true)
            {
                int a=0;
                
                ConsoleKeyInfo key = Console.ReadKey();
                if (a == 1)
                {
                    Console.WriteLine("몬스터와 싸운다");
                }
                else 
                        {
                    Console.WriteLine("잘못된 입력입니다");
                }
            }
        }

    }
}
