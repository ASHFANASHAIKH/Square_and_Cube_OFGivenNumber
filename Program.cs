using System;
public class SquareCube
{
    public static void Main(string[] args)
    {
        int num = 26, Square, Cube;
        Square = num * num;
        Cube = num * num * num;
        Console.Write("number is :" + num);
        Console.Write("\nSquare of " + num + " is : " +Square); 
        Console.Write("\nCube of " + num + " is : " +Cube);
        Console.ReadLine();
    }
}
