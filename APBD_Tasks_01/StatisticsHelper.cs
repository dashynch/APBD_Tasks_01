namespace APBD_Tasks_01; 

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Count == 0)
        {
            throw new ArgumentException("List cannot be empty");
        }
        return values.Average();
    }
}