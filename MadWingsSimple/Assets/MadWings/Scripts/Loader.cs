using System;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
	[Serializable]
	public class PoolObjects
	{
		public GameObject player;
		public GameObject bullet_1;
		public GameObject enemy_1;
		public GameObject[] waves;
	}

	public class Loader : MonoBehaviour
    {
	    public PoolObjects poolObjects;

	    private void Awake()
	    {
		    GetPool(PoolType.Player, poolObjects.player, 1);
			GetPool(PoolType.Bullets, poolObjects.bullet_1, 50);
		    GetPool(PoolType.Enemys, poolObjects.enemy_1, 50);

		    foreach (var wave in poolObjects.waves)
		    {
			    GetPool(PoolType.Wave, wave, 1);
		    }
	    }

	    private void GetPool(PoolType poolType, GameObject obj, int number)
	    {
		    ManagerPool.Instance.AddPool(poolType).PopulateWith(obj, number);
		}
    }
}
