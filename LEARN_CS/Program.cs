// 1 폴더에서 파일 경로 가져오기
using LEARN_CS;
using Newtonsoft.Json;

string folderpath = "C:\\Users\\Administrator\\Desktop\\25Csharp\\LEARN_CS";
string Filename = "Item.json";

string fullpath = Path.Combine(folderpath, Filename);
string folderpath2 = "C:\\Users\\Administrator\\Desktop\\25Csharp\\LEARN_CS";
string Filename2 = "Item2.json";

string fullpath2 = Path.Combine(folderpath2, Filename2);

Console.WriteLine(fullpath);

Console.WriteLine(fullpath);
// 2 파일을 읽어오기

string text = File.ReadAllText(fullpath);
Console.WriteLine(text);

// 3 파일을 테이터로 해석하기 => class 만들기
// 10개. 1000원. 어떤 아이템을 사겠다.
// 시작 아이템을 랜덤으로 주는 기능 구현.

// json파일을 클래스로 변환해줘. nuget- Newtonsoft 다운받은 것
var ItemDB = JsonConvert.DeserializeObject<List<ltem>>(text);
ltem select = ItemDB[6];
Console.WriteLine($"LABEL : {select.LABEL}"
    + $"아이템 이름 : {select.ITEMNAME}"
    + $"스탯 이름 : {select.STATNAME}"
    );





