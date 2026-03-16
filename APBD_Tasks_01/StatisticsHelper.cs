namespace APBD_Tasks_01; 

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.length == 0)
        {
            throw new ArgumentException("Array cannot be empty");
        }
        return values.Average();
    }
}