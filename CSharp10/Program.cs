using CSharp10.Model;
using CSharp10.Services;

int i = 10;
int res = 0;
var client = new ServerRequest(new HttpClient());

Func<string> hi = () => "Suck my dick";
var by = () => "Have a nice day";

var rand = int () => new Random().Next(0, 3);
Task<User?>[] tasks = new Task<User?>[10];

while (i > 0)
    tasks[i - 1] = client.GetJson(i--);

Console.WriteLine("Working Now");

var result = await Task.WhenAll(tasks);

var j = 1;

foreach (var user in result) {
    Console.ForegroundColor = (res = rand()) == 0 ? ConsoleColor.Red : res == 1 ? ConsoleColor.Green : ConsoleColor.Yellow;
    Console.WriteLine(new string('.', 15) + (j++) + new string('.', 15));
    Console.WriteLine(user);
    Console.WriteLine(new string('.', 31) + '\n');
    Console.ResetColor();
}


#region Tasks
Console.ResetColor();
var ct = new CancellationTokenSource();

//var mt = new MultyThreading(ct);

//mt.RandomGenerator();


//Console.ReadKey();
//Console.WriteLine("Trying stop all");
//ct.Cancel();
//Console.WriteLine("Stopped");
//Console.ReadKey();
#endregion