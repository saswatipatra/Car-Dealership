using System;
using System.Collections.Generic;


namespace Dealership.Models
{
  class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public static string MakeSound(string sound)
        {
            return "Our cars sound like " + sound;
        }
  }
}
