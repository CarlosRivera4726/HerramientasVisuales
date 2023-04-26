using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;



// programacion asincrona
Stopwatch sw = new Stopwatch();

sw.Start();
// codigo, tasks, etc:


// Tasks 1
var task1 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();

    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();

    Console.WriteLine($"Task1: {crono.Elapsed.ToString()}");
});

var task2 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();

    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();

    Console.WriteLine($"Task2: {crono.Elapsed.ToString()}");
});

var task3 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();

    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();

    Console.WriteLine($"Task3: {crono.Elapsed.ToString()}");
});

task1.Start();
task2.Start();
task3.Start();

await task1;
await task2;
await task3;




var str = await RandomAsync();
Console.WriteLine(str);

sw.Stop();
Console.WriteLine($"MAIN: {sw.Elapsed.ToString()}");

static async Task<string> RandomAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    sw.Stop();
    return num.ToString() + Environment.NewLine +sw.Elapsed;
    
}
