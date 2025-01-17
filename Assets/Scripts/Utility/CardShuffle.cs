using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public static class CardShuffle
{
    private static readonly Random _random = new Random();

    public static void Shuffle<T>(this List<T> list)
    {
        var n = list.Count;
        while (n-- > 1)
        {
            var index = _random.Next(n + 1);
            var value = list[index];
            list[index] = list[n];
            list[n] = value;
        }
    }
}

