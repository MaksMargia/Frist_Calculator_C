
double firstValue, secondValue;
string action;

 Console.WriteLine("Введи число 1");
 firstValue = double.Parse(Console.ReadLine());

 Console.WriteLine("Введи число 2");
 secondValue = double.Parse(Console.ReadLine());

Console.WriteLine("Веберите операцию: '+' '-' '*' '/' " );
action = Console.ReadLine();
switch (action)
{

    case "+":
      Console.WriteLine(firstValue + secondValue);
       break;
     case "-":  
      Console.WriteLine(firstValue - secondValue);
      break;
     case "*":  
      Console.WriteLine(firstValue * secondValue);
     break;
     case "/": 
     if (secondValue == 0)
     Console.WriteLine(0); 
      Console.WriteLine(firstValue / secondValue);
      break;
    default:
    Console.WriteLine("Ошибка!");
      break;
}


