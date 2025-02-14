namespace DefaultNamespace;

public class HW1and2
{
    Console.WriteLine("Input 1");
    float inputOne = float.Parse(Console.ReadLine());
    Console.WriteLine("Input 2");
    float inputTwo = float.Parse(Console.ReadLine());
    Console.WriteLine("+ or - or * or / or %");
    string @inputSymbol = string.Parse(Console.ReadLine());

        switch (@inputSymbol)
    {
        case "+":
        Console.WriteLine($"Result of {inputOne} + {inputTwo} = {inputOne + inputTwo}");
        break;
        case "-":
        Console.WriteLine($"Result of {inputOne} - {inputTwo} = {inputOne - inputTwo}");
        break;
        case "*":
        Console.WriteLine($"Result of {inputOne} * {inputTwo} = {inputOne * inputTwo}");
        break;
        case "/":
        Console.WriteLine($"Result of {inputOne} / {inputTwo} = {inputOne / inputTwo}");
        break;
        case "%":
        Console.WriteLine($"Result of {inputOne} % {inputTwo} = {inputOne % inputTwo}");
        break;
        default:
        Console.WriteLine("Invalid Operation!");
        break;
    }

}