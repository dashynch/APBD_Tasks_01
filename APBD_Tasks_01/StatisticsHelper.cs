namespace APBD_Tasks_01; 

public class StatisticsHelper
{
    //Method to calculate Average
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.length == 0)
        {
            throw new ArgumentException("Array cannot be empty");
        }
        return values.Average();
    }
    
    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty");
        }
        return values.Max();
    }
    
    
}