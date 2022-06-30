using System;

class Solution
{
    public int[] solution(int[] A, int K)
    {
        int last_value = 0;
        int[] newArray = new int[A.Length];
        A.CopyTo(newArray, 0);
        if (A.Length > 1)
        {
            for (int i = 0; i < K; i++)
            {
                last_value = newArray[newArray.Length - 1];
                Array.Copy(newArray, 0, newArray, 1, newArray.Length - 1); // right shift
                //Array.Copy(newArray, 1, newArray, 0, newArray.Length - 1); // left shift
                newArray[0] = last_value;
                //Console.WriteLine($"{string.Join(", ", newArray)}");
            }
        }
        return newArray;
    }

    public List<int> solution2(List<int> A, int K)
    {
        int last_value = 0;
        List<int> newlist = A.GetRange(0, A.Count);
        if (A.Count > 1)
        {
            for (int i = 0; i < K; i++)
            {
                last_value = newlist[newlist.Count - 1];
                newlist = newlist.GetRange(0, newlist.Count - 1);
                newlist.Insert(0, last_value);
                Console.WriteLine($"{string.Join(", ", newlist)}");
            }
        }        
        return newlist;
    }



    static void Main()
    {
        // Array example
        int[] input = new int[] { 3, 8, 9, 7, 6 };
        //int[] input = new int[] { 1,2,3,4 };
        //int[] input = new int[] { };
        //int[] input = new int[] { 4 };
        Console.WriteLine($"{string.Join(", ", input)}");

        Solution so = new Solution();
        int[] expected = so.solution(input, 4);

        Console.WriteLine($"{string.Join(", ", expected)}");
        Console.WriteLine();

        // List example
        List<int> inputList = new List<int>() { 3, 8, 9, 7, 6 };
        Console.WriteLine($"{string.Join(", ", inputList)}");

        List<int> expectedlist = so.solution2(inputList, 4);

        Console.WriteLine($"{string.Join(", ", expectedlist)}");
    }
}
