//Time Machine 
Timer timer;

DateTime DateTime;
 void something()
{
 timer = new Timer(TimerCallback, null,1000,1000);

}



 void TimerCallback(object state)
{
    DateTime = DateTime.Now;
    Console.WriteLine(DateTime);
    GC.Collect();
 
   
}

    Console.WriteLine("Timer");
something();

Console.Read();