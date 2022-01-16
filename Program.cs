//Time Machine 

Timer timer;
DateTime DateTime;

 void TikTak()
{
 timer = new Timer(TimerCallback, null,0,1000);
}

 void TimerCallback(object state)
 {
    Console.Clear();
    DateTime = DateTime.Now;
    Console.WriteLine("Timer");
    Console.WriteLine(DateTime);
 }

TikTak();

Console.Read();