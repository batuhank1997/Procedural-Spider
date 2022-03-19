using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BKLib
{
	public static class ListExt
	{
        public static void Shuffle<T>(this IList<T> list)
        {
            for (var i = list.Count - 1; i > 1; i--)
            {
                var j = Random.Range(0, i + 1);
                var value = list[j];
                list[j] = list[i];
                list[i] = value;
            }
        }

        public static T PickRandom<T>(this IList<T> list)
        {
            if (list.Count == 0) throw new System.IndexOutOfRangeException("Cannot select a random item from an empty list");
            return list[UnityEngine.Random.Range(0, list.Count)];
        }

        public static T RemoveRandom<T>(this IList<T> list)
        {
            if (list.Count == 0) throw new System.IndexOutOfRangeException("Cannot remove a random item from an empty list");
            int index = UnityEngine.Random.Range(0, list.Count);
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        public static List<T> GetEveryOther<T>(this IList<T> list)
		{
            List<T> newList = new List<T>();
			for (int i = 0; i < list.Count; i++)
			{
                if (i % 2 == 0)
                    newList.Add(list[i]);
			}

            return newList;
		}
    }
}

