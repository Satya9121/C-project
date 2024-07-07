Console.Title ="Average";

int boys;
int girls;                                                       //integers are must be denoted
int teachers;

Console.Write("Total number of boys:");
boys = Convert.ToInt32(Console.ReadLine());

Console.Write("Total number of girls:");
girls = Convert.ToInt32(Console.ReadLine());

Console.Write("Total number of teachers:");
teachers = Convert.ToInt32(Console.ReadLine());

int average = (boys + girls + teachers)/3;                      //Anything would be calculated in the form of result or something
Console.WriteLine("You're class average is:" + average);        //State must be denoted 

Console.ReadKey();