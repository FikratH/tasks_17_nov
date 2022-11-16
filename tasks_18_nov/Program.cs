#region 1 Task: Check if a given number is a power of 2.
//Console.WriteLine("This is the application of the first task: checking if a given number is a power of 2!\n");
//firstTask:
//Console.WriteLine("Enter the number:");
//int number = Convert.ToInt32(Console.ReadLine());
//int power = 2;
//int total = 1;
//while (total < number)
//{
//    total *= power;
//}
//if (total == number && number != 1)
//{
//    Console.WriteLine("The given number is a power of " + power + ".");
//}
//else
//{
//    Console.WriteLine("The given number is not a power of " + power + ".");
//}
//Console.WriteLine("______________\n");
//goto firstTask;
#endregion
#region 2 Task: Write all the numbers between given two ##developed.
//Console.WriteLine("This is the application of the second task: writing all the numbers between given two!\n");
//secondTask:
//Console.WriteLine("Enter the first number:");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the second number:");
//int secondNum = Convert.ToInt32(Console.ReadLine());
//if (firstNum < secondNum)
//{
//    if (firstNum == secondNum - 1)
//    {
//        Console.WriteLine("There are no numbers between " + firstNum + " and " + secondNum + ".");
//    }
//    else if (firstNum == secondNum - 2)
//    {
//        Console.Write("The number between " + firstNum + " and " + secondNum + " is " + ++firstNum + ".");
//    }
//    else
//    {
//        Console.Write("The numbers between " + firstNum + " and " + secondNum + " are ");
//        while (firstNum < secondNum - 1)
//        {
//            firstNum++;
//            if (firstNum == secondNum - 1)
//            {
//                Console.Write(firstNum + ".");
//            }
//            else if (firstNum == secondNum - 2)
//            {
//                Console.Write(firstNum + " and ");
//            }
//            else
//            {
//                Console.Write(firstNum + ", ");
//            }
//        }
//    }
//}
//else if (secondNum < firstNum)
//{
//    if (secondNum == firstNum - 1)
//    {
//        Console.WriteLine("There are no numbers between " + firstNum + " and " + secondNum + ".");
//    }
//    else if (secondNum == firstNum - 2)
//    {
//        Console.Write("The number between " + firstNum + " and " + secondNum + " is " + ++secondNum + ".");
//    }
//    else
//    {
//        Console.Write("The numbers between " + firstNum + " and " + secondNum + " are ");
//        while (secondNum < firstNum - 1)
//        {
//            secondNum++;
//            if (secondNum == firstNum - 1)
//            {
//                Console.Write(secondNum + ".");
//            }
//            else if (secondNum == firstNum - 2)
//            {
//                Console.Write(secondNum + " and ");
//            }
//            else
//            {
//                Console.Write(secondNum + ", ");
//            }
//        }
//    }
//}
//else
//{
//    Console.WriteLine("There are no numbers between " + firstNum + " and " + secondNum + ".");
//}
//Console.WriteLine();
//Console.WriteLine("______________\n");
//goto secondTask;
#endregion
#region 3 Task: If the given number is more than 70, output the triple of their difference. If not, output the difference itself.
//Console.WriteLine("This is the application of the third task:\nIf the given number is more than 70, output the triple of their difference. If not, output the difference itself!\n");
//thirdTask:
//Console.WriteLine("Enter the number:");
//int number = Convert.ToInt32(Console.ReadLine());
//int initialNum = 70;
//if (number > initialNum)
//{
//    Console.WriteLine("The triple of the difference between " + number + " and " + initialNum + " is " + (number - initialNum) * 3 + ".");
//}
//else
//{
//    Console.WriteLine("The difference between " + initialNum + " and " + number + " is " + (initialNum - number) + ".");
//}
//Console.WriteLine("______________\n");
//goto thirdTask;
#endregion
#region 4 Task: Find the greatest number of 3 given numbers ##developed.
//Console.WriteLine("This is the application of the fourth task: finding the greatest number of 3 given numbers!\n");
//fourthTask:
//Console.WriteLine("Enter the first number:");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the second number:");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the third number:");
//int z = Convert.ToInt32(Console.ReadLine());
//if (x > y && x > z)
//{
//    Console.WriteLine(x + " is the greatest number among " + x + ", " + y + " and " + z + ".");
//}
//else if (x > y && x == z)
//{
//    Console.WriteLine(x + " is the greatest number among " + x + ", " + y + " and " + z + ".");
//}
//else if (y > x && x > z)
//{
//    Console.WriteLine(y + " is the greatest number among " + x + ", " + y + " and " + z + ".");
//}
//else if (y > x && x == z)
//{
//    Console.WriteLine(y + " is the greatest number among " + x + ", " + y + " and " + z + ".");
//}
//else
//{
//    Console.WriteLine(z + " is the greatest number among " + x + ", " + y + " and " + z + ".");
//}
//Console.WriteLine("______________\n");
//goto fourthTask;
#endregion
#region 5 Task: Find the amount of odd numbers between given two.
Console.WriteLine("This is the application of the fifth task: finding the amount of odd numbers between given two!\n");
fifthTask:
Console.WriteLine("Enter the first number:");
int firstNumInit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int firstNum = firstNumInit;
int secondNumInit = Convert.ToInt32(Console.ReadLine());
int secondNum = secondNumInit;
int count = 0;
if (firstNum > secondNum)
{
    while (secondNum < firstNum - 1)
    {
        secondNum++;
        if (secondNum % 2 == 1)
        {
            count++;
        }
    }
    Console.WriteLine("The amount of odd numbers between " + firstNumInit + " and " + secondNumInit + " is " + count + ".");
}
else
{
    while (firstNum < secondNum - 1)
    {
        firstNum++;
        if (firstNum % 2 == 1)
        {
            count++;
        }
    }
    Console.WriteLine("The amount of odd numbers between " + firstNumInit + " and " + secondNumInit + " is " + count + ".");
}
Console.WriteLine("______________\n");
goto fifthTask;
#endregion