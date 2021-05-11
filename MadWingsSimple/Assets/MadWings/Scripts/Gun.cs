using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
	[Serializable]
	public class GunType
	{
		public GameObject bulletType;
		public PoolType poolType;
		public ShotType shotType;
		public GameObject[] spawnPoints;
	}

    public class Gun : Spawner
    {
	    public GunType[] guns;
		[Range(0, 100)]
	    public int type;

	    public float fireRate = 1f;
	    private float nextFire = 0f;
		private GameObject gunType;

	    private void Update()
	    {
		    if (Time.time > nextFire)
		    {
			    nextFire = Time.time + fireRate;
			    Fire();
		    }
	    }

	    private void Fire()
	    {

		    //foreach (var spawnPoint in guns[type].spawnPoints)
		    //{
			   // Spawn(guns[type].bulletType.GetComponent<Actor>().poolType, guns[type].bulletType, spawnPoint, 0);
		    //}

		    switch (guns[type].shotType)
		    {
			    case ShotType.One:
				    Spawn(guns[type].poolType, guns[type].bulletType, guns[type].spawnPoints[0], 0);
				    break;
				case ShotType.Double:
					Spawn(guns[type].poolType, guns[type].bulletType, guns[type].spawnPoints[0], 0);
					Spawn(guns[type].poolType, guns[type].bulletType, guns[type].spawnPoints[2], 0);
					break;
		    }
		}
    }

    public enum ShotType
    {
		One,
		Double
    }
}
