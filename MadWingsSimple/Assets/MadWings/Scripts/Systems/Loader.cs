using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PoolObject
{
	public GameObject prefab;
	public int amount;
}

public class Loader : MonoBehaviour
{
	[Header("[POOLS]")]
	public PoolObject[] bullets;
	public GameObject[] waves;

	private void Awake()
	{
		LoadBullets();
		if (waves != null)
		{
			LoadWaves();
		}
	}

	private void LoadBullets()
	{
		foreach (var bullet in bullets)
		{
			GetPool(PoolType.Bullet, bullet.prefab, bullet.amount);
		}
	}

	private void LoadWaves()
	{
		foreach (var wave in waves)
		{
			GetPool(PoolType.Wave, wave, 1);
		}
	}

	private void GetPool(PoolType poolType, GameObject obj, int amount)
	{
		ManagerPool.Instance.AddPool(poolType).PopulateWith(obj, amount);
	}
}
