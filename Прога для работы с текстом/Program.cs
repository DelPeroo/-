using System.Linq;
using System.Collections.Generic;
Console.WriteLine("Привет введи строку для вывода ее свойств\n");
string Stroka = Console.ReadLine();

int Long = Stroka.Length;
Console.WriteLine($"Кол-во символов в вашей строке {Long}");

string[] words = Stroka.Split(' ');
string Stroka1 = Stroka.Replace(" ", "");
int Long1 = Stroka1.Length;
Console.WriteLine($"Кол-во символов в вашей строке без пробелов {Long1}");

int WordsColvo = words.Length;
Console.WriteLine($"Кол-во слов в вашей строке {WordsColvo}");

Dictionary<string, int> wordsCounts = new Dictionary<string, int>();
foreach (string word in words)
{
    string loverWord = word.ToLower();
    if (wordsCounts.ContainsKey(loverWord))
    {
        wordsCounts[loverWord]++;
    }
    else
    {
        wordsCounts.Add(loverWord, 1);
    }

}

var topWords = wordsCounts.OrderByDescending(x => x.Value).Take(3);


foreach (var item in topWords)
{
    Console.WriteLine($"{item.Key}: {item.Value} раз");
}
foreach (string word in words)
{
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    Console.Write(new string(chars) + " ");
}
// проверка работы с комитом
//Еще одна проерка, теперь называю комит латиницей