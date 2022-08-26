
int i = 10000;
int sum = 0;

while(i > 0)
{
    sum += i;
    i--;
}
Console.WriteLine($"Sum of numbers 1 to 100 is {sum}");




//var stateCode = "IN";
//var city = "Cincinnati";
//string salesperson = string.Empty;
//
////Switch Expression -can only be one variable.
//
//salesperson = stateCode switch
//{
//    "OH" => "Karl",
//    "KY" => "Sam",
//    "IN" => "Ian",
//    _ => "Greg"  //default by using underscore
//};


//Switch Statement


//switch(stateCode)
//{
//    case "OH":
//        Console.WriteLine("Ohio");
//        break;
//    case "KY":
//        Console.WriteLine("Kentucky");
//        break;
//    case "IN":
//        Console.WriteLine("Indiana");
//        break;
//    default:
//        Console.WriteLine("It is not a tristate state");
//        break;
//}



/*
if(state == "OH")
{
    Console.WriteLine("State is Ohio");
    if (city == "Cincinnati")
    {
        Console.WriteLine("City is Cincinnati");
    } 
    else if (city == "Columbus")
    {
        Console.WriteLine("City is Columbus");
    } 
    else
    {
        Console.WriteLine("City is Cleveland");
    }
} 
else if (state == "KY")
    {
        Console.WriteLine("State is Kentucky");
} 
else
    {
        Console.WriteLine("State is not Ohio or Kentucky");
    }
*/

/*
//=============
var boolean = true;

if(boolean)
{
    Console.WriteLine("Boolean is true!");
} else
{
    Console.WriteLine("Boolean is false!");
}
*/