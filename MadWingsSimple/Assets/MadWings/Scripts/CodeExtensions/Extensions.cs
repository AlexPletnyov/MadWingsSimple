using System;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
	private static System.Random _r = new System.Random();
	private static int charsPoolName = 5;

	public static T ToEnum<T>(this string value)
	{
		return (T)Enum.Parse(typeof(T), value, true);
	}

	public static PoolType GetPoolType(this PoolType poolType, GameObject gameObject)
	{
		var parent = gameObject.transform.parent;
		var parentName = parent.gameObject.name;

		//if (parentName.Substring(0, charsPoolName) != "Pool:")
		//{
		//	return PoolType.None;
		//}

		return poolType = parentName.Substring(charsPoolName).ToEnum<PoolType>();
	}

	public static T Random<T>(this List<T> list)
	{
		var val = list[UnityEngine.Random.Range(0, list.Count)];
		return val;
	}

	public static T RandomByChance<T>(this List<T> vals) where T : IRandom
	{
		var total = 0f;
		var probs = new float[vals.Count];

		for (var i = 0; i < probs.Length; i++)
		{
			probs[i] = vals[i].returnChance;
			total += probs[i];
		}

		var randomPoint = (float) _r.NextDouble() * total;

		for (var i = 0; i < probs.Length; i++)
		{
			if (randomPoint < probs[i])
			{
				return vals[i];
			}

			randomPoint -= probs[i];
		}

		return vals[0]; //minimum chance
	}
}