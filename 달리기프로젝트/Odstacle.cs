
using Newtonsoft.Json;

namespace 달리기프로젝트
{
    public record class Odstacle
    {

        [JsonProperty("Speed")] public int Speed;
        [JsonProperty("Name")] public string Name;
        [JsonProperty("Y ")] public int Y;
        int moveTick;
        int x;
         
        public void Start()
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
            renderer.Print(x, Y, Name);
        }
        public void Hit(Player player, ref int currentscore)
        {

            if (x == player.x && Y == player.y)
            {

                player.Die();

                
            }
        }
    };
}