using Newtonsoft.Json;
using 달리기프로젝트;

string folderpath = "C:\\Users\\Administrator\\Desktop\\25Csharp\\달리기프로젝트";
string Filename = "jelly.json";

string fullpath = Path.Combine(folderpath, Filename);

Console.WriteLine(fullpath);

// 2 파일을 읽어오기

string text = File.ReadAllText(fullpath);
Console.WriteLine(text);

var jellys = JsonConvert.DeserializeObject<List<Jelly>>(text);

foreach(var j in jellys)
{
    Console.WriteLine(j);
}
string P_shape = "p";

int p_x= 5;
int p_y = 5;
int score_x=50;
int score_y=2;
int currentscore = 0;
using (var reader = new ConsoleRenderer(80, 50))
{
   
    while (true)
    {
        //1. 플레이어의 입력
        reader.Print(p_x, p_y,P_shape);

        //2 플레이어 이외의 오브젝트의 기능을 구현
        jellys[0].y = 5;
        jellys[1].y = 6;
        jellys[2].y = 7;
        jellys[0].Update();
        jellys[1].Update();
        jellys[2].Update();

       

        reader.Clear();

        jellys[0].GetScore(p_x, p_y,ref currentscore);
        jellys[1].GetScore(p_x, p_y,ref currentscore);
        jellys[2].GetScore(p_x, p_y,ref currentscore);


        jellys[0].Draw(reader);
        jellys[1].Draw(reader);
        jellys[2].Draw(reader);
        


        //3. 그림을 그려줘라
        reader.Print(p_x,p_y,P_shape);
        reader.Print(score_x,score_y, $"score : {currentscore}");





        //4.FLiping 해결 -> screen Dou
        reader.Flipping();

        Thread.Sleep(33);
    }
}









