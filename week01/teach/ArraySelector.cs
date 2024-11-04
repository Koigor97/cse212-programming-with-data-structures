public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // Step 1: create a index for list1 and list2
        int index1 = 0;
        int index2 = 0;

        // Step 2: create a result array
        var result = new int[select.Length];

        // Step 3: loop through the select array
        for (var i = 0; i < select.Length; i++) 
        {
            // Step 4: if the select value is 1, add the value from list1
            if (select[i] == 1)
                result[i] = list1[index1++];
            // Step 5: if the select value is 2, add the value from list2
            else
                result[i] = list2[index2++];
        }

        // Step 6: return the result
        return result;
    }
}