//Griffin Parker
//October 19, 2022
//Mini Challenge #6 Remastered - Odd or Even
//This program takes a user's input, makes sure it's a number, and then tells the user if the number is odd or even
//Peer review by Carlos Felipe: This program is nutty. I'm seeing animations in the terminal?! what is this Wizard craft?! Amazing project, all inputs 
//are accounted for using data validation and I can play this amazing project as many times as I want. 10/10 would definitely play again once or twice.

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
    Even(space, validNum);
    Thread.Sleep(100);
    space = space.Remove(i);
    }                         
    }
    else
    {
    for(int i = space.Length - 1; i >= 1; i--)   
    { 
    Console.Clear();    
    Odd(space, validNum);
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
static void Even(string space, int validNum)
{
        Console.WriteLine($"            The number {validNum} is");
        Console.WriteLine();
        Console.WriteLine($"▀███▀▀▀███"); 
        Console.WriteLine($"  ██    ▀█");
        Console.WriteLine($"  ██   █ {space}  ▀██▀   ▀██▀{space} ▄▄█▀██ {space} ▄██████▄");
        Console.WriteLine($"  ██████ {space}    ██   ▄█{space}  ▄█▀   ██{space} ██    ██");
        Console.WriteLine($"  ██   █  ▄ {space}  ██ ▄█ {space}  ██▀▀▀▀▀▀{space} ██    ██");
        Console.WriteLine($"  ██     ▄█ {space}   ███ {space}   ██▄    ▄{space} ██    ██");
        Console.WriteLine($"▄██████████ {space}    █  {space}    ▀█████▀ {space}██    ██▄"); 
        Console.WriteLine();
}
static void Odd(string space, int validNum)
{
        Console.WriteLine($"          The number {validNum} is  ");
        Console.WriteLine($"             {space}       ▄▄  {space}       ▄▄");
        Console.WriteLine($"  ▄▄█▀▀██▄   {space}     ▀███  {space}     ▀███");
        Console.WriteLine($"▄██▀    ▀██▄ {space}       ██  {space}       ██");
        Console.WriteLine($"██▀      ▀██ {space}  ▄█▀▀███  {space}  ▄█▀▀███");
        Console.WriteLine($"██        ██ {space}▄██    ██  {space}▄██    ██");
        Console.WriteLine($"██▄      ▄██ {space}███    ██  {space}███    ██");
        Console.WriteLine($"▀██▄    ▄██▀ {space}▀██    ██  {space}▀██    ██");
        Console.WriteLine($"  ▀▀████▀▀   {space} ▀████▀███▄{space} ▀████▀███▄"); 
        Console.WriteLine();
}
}
