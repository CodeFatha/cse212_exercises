using Microsoft.VisualBasic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    public static double[] MultiplesOf(double number, int length)
    {
        //Declare a an list to hold the values as it is dynamic
        List<double> multiples = new();
        //Create a forloop with one as the floor and *length as the ceiling value
        //Iterate through *length times and and multiply *number by index
        for (int i = 1; i <= length; i++)
        {
            //Append the result of each iteration to the List
            multiples.Add(number * i);
        }

        //Convert the list to an array
        return multiples.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //Declare an index
        int index = data.Count - amount;
        // Get target range and store it in a variable
        List<int> targetRange = data.GetRange(index, amount);
        // Remove the target range from the List
        data.RemoveRange(index, amount);
        // Add the range to the end of the List
        data.InsertRange(0, targetRange);
    }
}
