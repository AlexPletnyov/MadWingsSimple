using System;
using UnityEngine;

namespace RainbowWhale
{
	[Serializable]
	public class PoolObjects
	{
		public GameObject bullet_1;
		public GameObject enemy_1;
	}

	public class Loader : MonoBehaviour
    {
	    public PoolObjects poolObjects;

	    private void Awake()
	    {
		    GetPool(PoolType.Bullets, poolObjects.bullet_1, 50);
		    GetPool(PoolType.Enemys, poolObjects.enemy_1, 50);
	    }

	    private void GetPool(PoolType poolType, GameObject obj, int number)
	    {
		    ManagerPool.Instance.AddPool(poolType).PopulateWith(obj, number);
		}
    }
}