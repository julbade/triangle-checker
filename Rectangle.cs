using System;

class Triangle
{
  public int Sides1;
  public int Sides2;
  public int Sides3;

  public bool IsEquilateral()
  {
    if (Sides1 == Sides2 && Sides2 == Sides3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
 public bool IsIsosceles()
    {
      if (Sides1 == Sides2 || Sides2 == Sides3 || Sides1 == Sides3)
      {
        return true;
      }
      else
      {
        return false;
      }
  }
  public bool IsScalene()
  {
    if (Sides1 != Sides2 && Sides2 != Sides3 && Sides1 != Sides3)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Triangle myTriangle = new Triangle();

    Console.WriteLine("Enter the side 1: ");
    string stringSides1 = Console.ReadLine();
    int mySides1 = int.Parse(stringSides1);
    myTriangle.Sides1 = mySides1;

    Console.WriteLine("Enter the side 2: ");
    string stringSides2 = Console.ReadLine();
    int mySides2 = int.Parse(stringSides2);
    myTriangle.Sides2 = mySides2;

    Console.WriteLine("Enter the side 3: ");
    string stringSides3 = Console.ReadLine();
    int mySides3 = int.Parse(stringSides3);
    myTriangle.Sides3 = mySides3;



    if (myTriangle.IsEquilateral())
    {
      Console.WriteLine("Equilateral!");
    }
    if(myTriangle.IsIsosceles())
    {
      Console.WriteLine("Isosceles");
    }
    if (myTriangle.IsScalene())
    {
      Console.WriteLine("Scalene");
    }
  }
}
