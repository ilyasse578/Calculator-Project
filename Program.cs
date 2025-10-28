using System;
using System.Collections.Specialized;

class clsCalculator
{
    private float _LastNumber;
    private float _Result = 0;
    private string _LastOperation = "Clear";

    private bool _IsZero(float Number)
    {
        return (Number == 0);
    }
    
   public void Clear()
   {
        _Result = 0;
        _LastNumber = 0;
        _LastOperation = "Clear";
   }

    public void Add(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Adding";
         _Result += Number ;
    }

    public void Subtract(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Subtracting";
        _Result -= Number;
    }

    public bool Divide(int Number)
    {
        bool successed = true;
        _LastOperation = "Dividing";

        if (_IsZero(Number))
        {
            _LastNumber = Number;
            _Result /= 1;
            successed = true;

        }
        else 
        {
            _LastNumber = Number;
            _Result /= Number;
            successed = true;


        }

        return successed;

    }

    public void Multiply(int Number)
    {
        _LastNumber = Number;
        _LastOperation = "Multiplying";
        _Result *= Number;
    }

    public float GetFinalResults()
    {
        return _Result;
    }

    public void PrintResult()
    {
        Console.WriteLine("Result After {0} {1} is : {2}", _LastOperation, _LastNumber, _Result);
    }

}

internal class program
{
    static void Main(string[] args)
    {

        clsCalculator calculator1 = new clsCalculator();

        calculator1.Clear();

        calculator1.Add(10);
        calculator1.PrintResult();

        calculator1.Add(100);
        calculator1.PrintResult();


        calculator1.Subtract(20);
        calculator1.PrintResult();


        calculator1.Divide(0);
        calculator1.PrintResult();

        calculator1.Divide(2);
        calculator1.PrintResult();

        calculator1.Multiply(3);
        calculator1.PrintResult();



        calculator1.Clear();
        calculator1.PrintResult();


    }



}
