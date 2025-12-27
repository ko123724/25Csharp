using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace 달리기프로젝트
{
    public record class Jelly
    {

        [JsonProperty("Speed")] public int Speed;
        [JsonProperty("Name")] public string Name;
        [JsonProperty("Score ")] public int Score;
        int moveTick;
        int x;
        public int y;

        public void start()
        {
            moveTick = 0;
            x = 50;

        }

        public void Update()
        {
            moveTick++; //mo

            if (Speed <= moveTick)
            {
                x--;
                if (x <= 0)
                {

                    x = 50;
                }
                moveTick = 0;
            }
        }

        public void Draw(ConsoleRenderer renderer)
        {
            renderer.Print(x, y, Name);
        }
        public void GetScore(Player player,ref int currentscore)
        {

            if (x == player.x&& y == player.y)
            {

                currentscore += Score;

                x = 50;
            }
        }
    };
}
