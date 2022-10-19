//Griffin Parker
//October 18, 2022
//Mini Challenge #6 Remastered - Odd or Even
//This program takes a user's input, makes sure it's a number, and then tells the user if the number is odd or even

string num;
string loop;
int validNum;
int repeat = 1;
string space = "                ";
bool numTest;
bool check = true;

while(repeat == 1){
Console.Clear();
Console.WriteLine("Please input a number!");
num = Console.ReadLine();
if (numTest = Int32.TryParse(num, out validNum)){
    if(validNum % 2 == 0)
    {
    for(int i = space.Length - 1; i >= 0; i--)   
    { 
    Console.Clear();    
    Even(space);
    Thread.Sleep(100);
    space = space.Remove(i);
    }                         
    }
    else
    {
    for(int i = space.Length - 1; i >= 1; i--)   
    { 
    Console.Clear();    
    Odd(space);
    Thread.Sleep(100);
    space = space.Remove(i - 1);
    }          
    }
    space = "                "; 
    Console.WriteLine();
    check = true;
    while (check == true){


    Console.WriteLine("Do you want to test another number? (Type \"yes\" to try again or \"no\" to quit!)");
    loop = Console.ReadLine();
    loop = loop.ToLower();
    if (loop == "no")
    {
        repeat++;
        check = false;
    }
    if (loop == "yes")
    {
        check = false;
    }
    }
}
static void Even(string space)
{
        Console.WriteLine("             This number is");
        Console.WriteLine($"▀███▀▀▀███"); 
        Console.WriteLine($"  ██    ▀█");
        Console.WriteLine($"  ██   █ {space}  ▀██▀   ▀██▀{space} ▄▄█▀██ {space} ▄██████▄");
        Console.WriteLine($"  ██████ {space}    ██   ▄█{space}  ▄█▀   ██{space} ██    ██");
        Console.WriteLine($"  ██   █  ▄ {space}  ██ ▄█ {space}  ██▀▀▀▀▀▀{space} ██    ██");
        Console.WriteLine($"  ██     ▄█ {space}   ███ {space}   ██▄    ▄{space} ██    ██");
        Console.WriteLine($"▄██████████ {space}    █  {space}    ▀█████▀ {space}██    ██▄"); 
        Console.WriteLine();
}
static void Odd(string space)
{
        Console.WriteLine("          This number is  ");
        Console.WriteLine($"             {space}       ▄▄  {space}       ▄▄");
        Console.WriteLine($"  ▄▄█▀▀██▄   {space}     ▀███  {space}     ▀███");
        Console.WriteLine($"▄██▀    ▀██▄ {space}       ██  {space}       ██");
        Console.WriteLine($"██▀      ▀██ {space}  ▄█▀▀███  {space}  ▄█▀▀███");
        Console.WriteLine($"██        ██ {space}▄██    ██  {space}▄██    ██");
        Console.WriteLine($"██▄      ▄██ {space}███    ██  {space}███    ██");
        Console.WriteLine($"▀██▄    ▄██▀ {space}▀██    ██  {space}▀██    ██");
        Console.WriteLine($"  ▀▀████▀▀   {space} ▀████▀███▄{space} ▀████▀███▄"); 
}
}