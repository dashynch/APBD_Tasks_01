namespace APBD_Tasks_01; 
public class Program 
{ 
    public static void Main(string[] args) 
    {
        Console.WriteLine("Hello world");

        List<int> valuesList = new List<int>() { 1, 2, 3, 4, 5, 6, };

        double average = CalculateAverage(valuesList);
		Console.WriteLine($"The AVERAGE IS : {average}");

		double max = CalculateMax(valuesList);
		Console.WriteLine($"The maximum is: {max}");

		double min = CalculateMin(valuesList);
		Console.WriteLine($"The minimum is: {min}");

    }
}

