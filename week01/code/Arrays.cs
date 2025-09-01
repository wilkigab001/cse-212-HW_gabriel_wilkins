public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        //Need to create a new array that is the length of the variable length. 
        //Then I need to do a for loop or a while loop for while I < length
        //Then we add to the for loop each iteration, at [i] the returned array should have the number times the iteration plus one, since we started at 0;
        // TODO Problem 1 Start
        var toReturn = new double[length];

        for (int i = 0; i < length; i++)
        {
            toReturn[i] = number * (i + 1);
        }
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        return toReturn; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //The data is a list, I need to get the length of the data.
        //From there I can extract the amount by using get range.
        //Then I can create a new array using those numbers,  that used the get range

        int n = data.Count;

        amount = amount % n;
        if (amount == 0) return;


        int indexOfTail = n - amount;

        var tail = data.GetRange(indexOfTail, amount);
        data.RemoveRange(indexOfTail, amount);
        data.InsertRange(0, tail);

    }
}
