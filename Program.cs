//Time Machine 

Timer timer;
DateTime DateTime = DateTime.Now;

//resources that are or will be saved in database

//Pull the info from database
string file = System.IO.File.ReadAllText(@"C:\Users\rosco\source\repos\TimeMachine\TextFile1.txt");


// split the info
string[] splitFile = file.Split(',');



int num1 = Convert.ToInt32(splitFile[0]);
int num2 = Convert.ToInt32(splitFile[1]);
int num3 = Convert.ToInt32(splitFile[2]);
int num4 = Convert.ToInt32(splitFile[3]);
DateTime savedTime =Convert.ToDateTime(splitFile[4]);

//seconds are to cover for lost time
var seconds = System.Math.Abs((DateTime - savedTime).TotalSeconds);
num1 = num1 + Convert.ToInt32(seconds);
num2 = num2 + Convert.ToInt32(seconds);
num3 = num3 + Convert.ToInt32(seconds);
num4 = num4 + Convert.ToInt32(seconds);
void TikTak()
{
 timer = new Timer(TimerCallback, null,0,1000);
   
}

 void TimerCallback(object state)
 {
    file = System.IO.File.ReadAllText(@"C:\Users\rosco\source\repos\TimeMachine\TextFile1.txt");
    Console.Clear();
    DateTime = DateTime.Now;
    Console.WriteLine("Timer");
    Console.WriteLine(DateTime);
    //i am reading all from this file so i need to change it to read only the resources value and not the time
    Console.WriteLine(file);
    Console.WriteLine(Convert.ToInt32(seconds));
    num1++;
    num2++;
    num3++;
    num4++;
    
    string message = String.Format(" {0}, {1}, {2}, {3}, {4}", num1, num2, num3, num4, DateTime);
    System.IO.File.WriteAllText(@"C:\Users\rosco\source\repos\TimeMachine\TextFile1.txt", message);
    
        
        }

TikTak();


//Just Playing with this now
//so the plan is to add database - just a text file
//save to file and read from file


Console.Read();