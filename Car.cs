using System;

public class Car
{
    //private fields for brand, year,price
    private string brand;
    private int year;
    private float price;

    //Constructor that initializes the brand, year,price properties
    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }

    //private fields accessed through public properties
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public float Price
    {
        get { return price; }
        set { price = value; }
    }
}
