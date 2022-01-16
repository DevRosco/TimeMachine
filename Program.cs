//Time Machine 
Timer timer;

 void something()
{
 timer = new Timer(TimerCallback, null,1000,1000);

}



 void TimerCallback(object o)
{
    Console.WriteLine("hello world");
    GC.Collect();
 
   
}

    Console.WriteLine("where what");
something();

Console.Read();