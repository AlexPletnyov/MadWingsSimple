using System;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
	[Serializable]
	public class PoolObject
	{
		public GameObject prefab;
		public int number;
	}

	public class Loader : MonoBehaviour
    {
		[Header("[POOLS]")]
	    public PoolObject[] objects;
	    public GameObject[] waves;

	    private void Awake()
	    {
		    foreach (var obj in objects)
			{
				GetPool(obj.prefab.GetComponent<Actor>().poolType, obj.prefab, obj.number);
			}

		    foreach (var wave in waves)
		    {
				GetPool(PoolType.Wave, wave.gameObject, 1);
			}
	    }

	    private void GetPool(PoolType poolType, GameObject obj, int number)
	    {
		    ManagerPool.Instance.AddPool(poolType).PopulateWith(obj, number);
		}
    }
}
