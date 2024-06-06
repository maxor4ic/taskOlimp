using task;

TeleWord teleWord = new TeleWord();
var data = teleWord.Tele("7325189087", new List<string> { "it", "your", "reality", "real", "our" });

foreach (var item in data)
{
    Console.Write(item  + " ");
}

data = teleWord.Tele("4294967296", new List<string> { "it", "your", "reality", "real", "our" });