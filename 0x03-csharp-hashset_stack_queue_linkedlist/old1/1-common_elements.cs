using System;
using System.Collections.Generic;
using System.Collections;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // create hash of each to get only unique numbers
        HashSet<int> hs1 = new HashSet<int>(list1);
        HashSet<int> hs2 = new HashSet<int>(list2);

        List<int> ans = new List<int>();

        // if element in hash 1 also in hash 2, add to new list
        foreach (int item in hs1)
        {
            Console.WriteLine(hs2.Contains(item));
            if (hs2.Contains(item));
            {
                ans.Add(item);
            }
        }

        // return new list
        return ans;
    }
}
