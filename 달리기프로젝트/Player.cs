using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace 달리기프로젝트
{
    public class Player
    {

        string shape = "p";
        public int x = 5;
        public int y = 7;
        public bool isDeath;

        public void Start()
        {
            y = 7;
            x= 5;

        }
        public void Update()
        {
            //땅의 좌표와 다르면(점프 중력 중력을 받으세요
            if (GroundCheck() == false)
            {
                y = y + 1;

            }





            //space버튼을 입력했을 때
            if (Console.KeyAvailable && GroundCheck())
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    y = y - 2;
                }
            }

        }

        public bool GroundCheck()
        {

            return y >= 7;


        }








        public void Draw(ConsoleRenderer renderer)
        {
            renderer.Print(x, y, shape);
        }

        public void Die()
        {
            isDeath = true;
        }

        
    };
}
