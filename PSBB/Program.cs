using System;
					
public class Program
{
    public static void Main()
	{
        // User Input
        Console.Write("Input the number of families : ");
        int numFam = int.Parse(Console.ReadLine());
        Console.Write("Input the number of members in the family \n(seperated by a space) : ");
        string memberFamily = Console.ReadLine();

        string[] memberFamilyArray = memberFamily.Split(' ');

        List<int> memberFamilyList = new List<int>();

        foreach (string numberStr in memberFamilyArray)
        {
            if (int.TryParse(numberStr, out int number))
            {
                memberFamilyList.Add(number); // List of Family Members
            }
            else
            {
                Console.WriteLine($"{numberStr}' is not integer.");
            }
        }

        if (memberFamilyList.Count != numFam )
        {
            Console.WriteLine("Input must be equal with count of family");
            return;
        }

        // Bus Count
        int totalPassenger = 0;
        foreach (int number in memberFamilyList)
        {
            totalPassenger += number;
        }
        int totalBus = (int)Math.Ceiling((double)totalPassenger / 4);

        Console.WriteLine($"\nMinimum bus required is : {totalBus}");
    }
}