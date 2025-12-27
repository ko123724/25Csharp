using Newtonsoft.Json;
using 달리기프로젝트;

string folderpath = "C:\\Users\\Administrator\\Desktop\\25Csharp\\달리기프로젝트";
string Filename = "jelly.json";

string fullpath = Path.Combine(folderpath, Filename);

string folderpath2 = "C:\\Users\\Administrator\\Desktop\\25Csharp\\달리기프로젝트";
string Filename2 = "obs.json";

string fullpath2 = Path.Combine(folderpath2, Filename2);




// 2 파일을 읽어오기

string text = File.ReadAllText(fullpath);
string text2 = File.ReadAllText(fullpath2);

Console.WriteLine(text);

var jellys = JsonConvert.DeserializeObject<List<Jelly>>(text);
var obstacles = JsonConvert.DeserializeObject<List<Odstacle>>(text2);

foreach (var j in jellys)
{
    Console.WriteLine(j);
}
//string P_shape = "p";

//int p_x= 5;
//int p_y = 7;]
Player player = new Player();
int score_x=50;
int score_y=2;
int currentscore = 0;

int cursor = 5;

Console.WriteLine("Press Any Key to Play");
Console.Clear();
while(true)
{
    Console.CursorVisible = false;


    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.DownArrow)
        {
            cursor++;

            if (cursor >= 7)
            {
                cursor = 5;
            }
        }
        else if (key == ConsoleKey.UpArrow)
        {
            cursor--;
            if (cursor <= 4)
            {

                cursor = 6;
            }
        }
        else if (key == ConsoleKey.Enter) 
        {
            if (cursor == 5)
            {
                currentscore = GamePlay(jellys, obstacles, player, score_x, score_y, currentscore);
            }
            else
            {

                break;
            
            
            }





        }








        Console.Clear();
        Console.SetCursorPosition(0,10);
        Console.WriteLine("    _             _     _ _                \r\n   / \\__   _____ (_) __| (_)_ __   __ _    \r\n  / _ \\ \\ / / _ \\| |/ _` | | '_ \\ / _` |   \r\n / ___ \\ V / (_) | | (_| | | | | | (_| |   \r\n/_/__ \\_\\_/ \\___/|_|\\__,_|_|_| |_|\\__, |   \r\n / _ \\| |__  ___| |_ __ _  ___| | |___/___ \r\n| | | | '_ \\/ __| __/ _` |/ __| |/ _ \\/ __|\r\n| |_| | |_) \\__ \\ || (_| | (__| |  __/\\__ \\\r\n \\___/|_.__/|___/\\__\\__,_|\\___|_|\\___||___/");

        Console.SetCursorPosition(30, 5);
        Console.WriteLine("게임시작");
        Console.SetCursorPosition(30, 6);
        Console.WriteLine("게임 종료");
        Console.SetCursorPosition(28, cursor);
        Console.WriteLine("▶");
    }












    //Console.WriteLine("1입력시 게임시작");
    //int input = int.Parse(Console.ReadLine());
    //if (input ==1 )
    //{
    //    currentscore = GamePlay(jellys, obstacles, player, score_x, score_y, currentscore);
    //}
    //else
    //{
    //    break;
    //
    //}

   




}



static int GamePlay(List<Jelly> jellys, List<Odstacle>? obstacles, Player player, int score_x, int score_y, int currentscore)
{ 
    currentscore = 0;
    player.Start();
    foreach(var jelly in jellys)
    {
        jelly.start();
    }
    foreach (var obs in obstacles)
    {
        obs.Start();
    }
    






    using (var reader = new ConsoleRenderer(80, 50))
    {
        player.isDeath = false;

        jellys[0].y = 5;
            jellys[1].y = 6;
            jellys[2].y = 7;


        
           


        while (true)
        {
            //1. 플레이어의 입력
            player.Update();

            //2 플레이어 이외의 오브젝트의 기능을 구현
            jellys[0].y = 5;
            jellys[1].y = 6;
            jellys[2].y = 7;
            jellys[0].Update();
            jellys[1].Update();
            jellys[2].Update();


            foreach (var obs in obstacles)
            {
                obs.Update();
            }


            reader.Clear();

            jellys[0].GetScore(player, ref currentscore);
            jellys[1].GetScore(player, ref currentscore);
            jellys[2].GetScore(player, ref currentscore);

            foreach (var obs in obstacles)
            {
                obs.Hit(player, ref currentscore);
            }


            jellys[0].Draw(reader);
            jellys[1].Draw(reader);
            jellys[2].Draw(reader);

            foreach (var obs in obstacles)
            {
                obs.Draw(reader);
            }


            //3. 그림을 그려줘라
            player.Draw(reader);
            reader.Print(score_x, score_y, $"score : {currentscore}");





            //4.FLiping 해결 -> screen Dou
            reader.Flipping();

            if (player.isDeath)
            {
                break;
            }

            Thread.Sleep(33);
        }
    }

    return currentscore;
}

