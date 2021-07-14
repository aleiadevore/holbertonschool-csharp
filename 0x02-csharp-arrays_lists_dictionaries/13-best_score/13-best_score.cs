using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return null;
        var ordered = myList.OrderByDescending(x => x.Value);
        foreach(KeyValuePair<string, int> elem in ordered)
            return elem.Key;
        return null;
    }
}
