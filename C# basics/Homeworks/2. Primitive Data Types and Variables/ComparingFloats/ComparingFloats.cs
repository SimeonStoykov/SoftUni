using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber =  5.00000001;
        double secondNumber = 5.00000005;
        float precision = 0.000001f;
        bool areEqual = (Math.Abs(firstNumber - secondNumber) < precision);
        Console.WriteLine(areEqual);                
    }
}
        
    

