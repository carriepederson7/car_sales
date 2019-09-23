using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  //creates new constructor
  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  //function to id if price is less than max
  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }
}

public class Program
{
  //create instances of constructor,
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
    Car amc = new Car("1976 AMC Pacer", 400, 198000);


    //instantiates a built-in constructor List named Car(automobile is the placeholder for the cars in this list)
    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    //creates a new list call CarsMatchingSearch, empty list
    List<Car> CarsMatchingSearch = new List<Car>(0);

    //pushes automobiles to CarsMatchingSearch based on WorthBuying method
    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
    //
        CarsMatchingSearch.Add(automobile);
      }
    }

    //writes automobiles in CarsMatchingSerch
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}
