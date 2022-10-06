void cat(){
Console.WriteLine("\\    /\\");
Console.WriteLine(" )  ( ')");
Console.WriteLine("(  /  )");
Console.WriteLine(" \\(__)|");}

string input(){
    string input1 = Console.ReadLine();
    string input2 = Console.ReadLine();
    return input1 + " " + input2;}

int addition(int num1, int num2){
    return num1 + num2;
}

int subtraction(int num1, int num2){
    return num1 - num2;
}

int multiplication(int num1, int num2){
    return num1 * num2;
}

float division(float num1, float num2){
    return num1 / num2;
}
Console.WriteLine("Here is a cat!");
cat();

Console.WriteLine("Enter two words to add together:");
Console.WriteLine(input());

Console.WriteLine("Please enter the opperator you would like to preform(either +,=,*, or /).");
switch(Console.ReadLine()){
    case "+":
        Console.WriteLine("Enter two numbers to add together:");
        Console.WriteLine(addition(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        break;

    case "-":
        Console.WriteLine("Enter two numbers to subtract:");
        Console.WriteLine(subtraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        break;

    case "*":
        Console.WriteLine("Enter two numbers to multiply:");
        Console.WriteLine(multiplication(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        break;

    case "/":
        Console.WriteLine("Enter two numbers to divide:");
        Console.WriteLine(division(Single.Parse(Console.ReadLine()), Single.Parse(Console.ReadLine())));
        break;
}
