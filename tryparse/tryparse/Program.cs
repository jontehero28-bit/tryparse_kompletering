using System.Numerics;
bool correct = false;
string answer = "18";
int results;


Console.WriteLine("How old is Yuriy? In numbers plz:) \nBirthday 2005/04/08");


while (correct == false)
{
   answer = Console.ReadLine();
   correct = int.TryParse(answer, out results);
   
   if (results != 18)
   {
    Console.WriteLine("Wrong Answer, try again");
    
   }
}
bool IsEven(int value)
{
    if (value % 2 == 0)
    {
        return true;
    }
    return false;
}

Console.ReadLine();
