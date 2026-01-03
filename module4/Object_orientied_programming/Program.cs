public class Car
{
    // Car properties
    public string Model{get; set;}
    public string Make{get; set;}
    public string Colour{get; set;}
    public double Speed{get; set;} // mph

    public void Drive()
    {
        
    }
}

// create instance of class
//Car myCar = new Car(); // this would error on its own, c# doesn't allow code by itself directly outside a class or method

// instead put it in a main method
class Program
{
    static void Main()
    {
        Car myCar = new Car();

        // set properties for myCar
        myCar.Make = "Toyota";
        myCar.Model = "Yaris";
        myCar.Colour = "Black";
        myCar.Speed = 40.5;

        // call method 
        myCar.Drive();
    }
}
