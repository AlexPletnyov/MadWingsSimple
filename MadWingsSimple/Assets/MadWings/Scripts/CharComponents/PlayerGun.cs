using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : Gun
{
	[Header("[Main Gun]")]
	public GameObject[] fire;
	public GameObject[] frost;
	public GameObject[] poison;
	public GameObject[] stone;
	public GameObject[] spawnPoints;
	[Range(0, 2)] public int power;
	[Range(0, 3)] public int bulletType;
	public MainGunTypes mainGunTypes;
	public float fireRate;

	private float nextFire = 0f;
	private GameObject[][] bullets;

	private void Awake()
	{
		bullets = new[]
		{
			fire,
			frost,
			poison,
			stone
		};
	}

	private void FixedUpdate()
	{
		Fire();
	}

	public override void Fire()
	{
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;

			switch (mainGunTypes)
			{
				case MainGunTypes.Single:
					Spawn(bullets[bulletType][power], spawnPoints[0], 0);
					break;
				case MainGunTypes.Double:
					Spawn(bullets[bulletType][power], spawnPoints[1], 0);
					Spawn(bullets[bulletType][power], spawnPoints[2], 0);
					break;
				case MainGunTypes.Triple:
					Spawn(bullets[bulletType][power], spawnPoints[0], 0);
					Spawn(bullets[bulletType][power], spawnPoints[1], 0);
					Spawn(bullets[bulletType][power], spawnPoints[2], 0);
					break;
				case MainGunTypes.Max:
					Spawn(bullets[bulletType][power], spawnPoints[0], 0);
					Spawn(bullets[bulletType][power], spawnPoints[1], 5);
					Spawn(bullets[bulletType][power], spawnPoints[2], -5);
					Spawn(bullets[bulletType][power], spawnPoints[3], 10);
					Spawn(bullets[bulletType][power], spawnPoints[4], -10);
					break;
			}
		}
	}
}
