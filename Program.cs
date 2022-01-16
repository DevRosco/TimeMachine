//Time Machine 

Timer timer;
DateTime DateTime;
int num1 = 10;
int num2 = 20;

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

string message = String.Format("New Values {0}, {1}", num1, num2);

//Just Playing with this now
//so the plan is to add database - just a text file
//save to file and read from file
System.IO.File.WriteAllText(@"C:\Users\rosco\source\repos\TimeMachine\TextFile1.txt", message );

Console.Read();