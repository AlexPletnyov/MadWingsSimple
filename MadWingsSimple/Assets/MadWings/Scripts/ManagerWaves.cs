using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    public class ManagerWaves : MonoBehaviour
	{
		[HideInInspector]
		public bool isEndWaves;

		private List<GameObject> enemys;
		private Loader loader;
		private GameObject activeWave;
		private int numberWaves;
		private int currentWave;
		private bool isStartWaves;
		private bool isSpawned;

		private void Awake()
		{
			loader = GetComponent<Loader>();
			enemys = new List<GameObject>();
			numberWaves = loader.poolObjects.waves.Length;
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.A))
			{
				isStartWaves = true;
			}

			if (isStartWaves)
			{
				WavesSequencer();
			}
		}

		private void WavesSequencer()
		{
			if (!isSpawned)
			{
				activeWave = ManagerPool.Instance.Spawn(PoolType.Wave, loader.poolObjects.waves[currentWave]);
				GetEnemyList(activeWave);
				isSpawned = true;
			}

			foreach (Transform child in activeWave.transform)
			{
				if (!child.gameObject.activeSelf)
				{
					enemys.Remove(child.gameObject);
				}
			}

			if (enemys.Count == 0)
			{
				ManagerPool.Instance.Despawn(PoolType.Wave, activeWave);
				isSpawned = false;

				if (currentWave < numberWaves - 1)
				{
					currentWave += 1;
				}
				else
				{
					isStartWaves = false;
					currentWave = 0;
					ManagerPool.Instance.Despawn(PoolType.Wave, activeWave);
					enemys.Clear();
					isEndWaves = true;
				}
			}
		}

		private void GetEnemyList(GameObject wave)
		{
			foreach (Transform child in wave.transform)
			{
				if (child.gameObject.activeSelf)
				{
					enemys.Add(child.gameObject);
				}
			}
		}
	}
}
