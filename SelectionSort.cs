// Selection Sort
//Selection Sort is quite a simple sorting method in terms of being able to understand how it work. 
// In some cases this method has signifigant preformance advantage when compared to more complex methods
// Overall selection sort is not very stable as it has an average  time complexity of O(n^2) which makes it inefficent with large lists or arrays
// For more information on Selection Sort: https://en.wikipedia.org/wiki/Selection_sort 
// This webpage has a good visual represntation of how how the sort works..

public static void SelectionSort(List<double> l)
{
    for (int i = 0; i < l.Count; i++) //iterates through the items in the list
    {
        // Find the index of the smallest item in the list from the index i to the count of the list - 1
        int minIndex = i;

        for (int j = i+ 1; j < l.Count; j++)
        {
            if (l[j] < l[minIndex])
            // compares the item of the list to 
            {
                minIndex = j;
            }

        }
        // Swap the item at index 'i' with the item 'minIndex' (updating the value of the variable)
        double copy = l[i];
        l[i] = l[minIndex];
        l[minIndex] = copy;
    }

}