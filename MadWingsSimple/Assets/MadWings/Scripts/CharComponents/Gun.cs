using UnityEngine;
using System;
using System.Collections.Generic;

public enum GunType
{
	BigGun,
	SuperGun
}

[Serializable]
public class SpawnPoints
{
	public GameObject point;
	public float angle;
}

[Serializable]
public class Guns
{
	public GunType gunType;
	public bool isEnable;
	public GameObject bulletType;
	public float fireRate;
	public SpawnPoints[] spawnPoints;

	[HideInInspector] public float nextFire;
}

public class Gun : MonoBehaviour
{
	[Header("[Other]")] 
	public Guns[] guns;


	private void Update()
	{
		Fire(guns);
	}

	public virtual void Fire()
	{
	}

	private void Fire(Guns[] guns)
	{
		foreach (var gun in guns)
		{
			if (gun.isEnable)
			{
				if (Time.time > gun.nextFire)
				{
					gun.nextFire = Time.time + gun.fireRate;

					foreach (var spawnPoint in gun.spawnPoints)
					{
						Spawn(gun.bulletType, spawnPoint.point, spawnPoint.angle);
					}
				}
			}
		}
	}

	public virtual void Spawn(GameObject bulletType, GameObject point, float angle)
	{
		ManagerPool.SpawnAtPoint(PoolType.Bullet, bulletType, point, angle);
	}
}