using Task1;

string str = Console.ReadLine();

WordCounter counter = new WordCounter();

int ans = counter.Count(str);

Console.WriteLine(ans);
