using System;
using System.Collections.Generic;
using System.Collections;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // create hash of each to get only unique numbers
        HashSet<int> hs1 = new HashSet<int>(list1);
        HashSet<int> hs2 = new HashSet<int>(list2);

        List<int> ans = new List<int>();
        hs1.SymmetricExceptWith(hs2);

        foreach (int i in hs1)
        {
            ans.Add(i);
        }
        ans.Sort();
        return ans;
    }
}