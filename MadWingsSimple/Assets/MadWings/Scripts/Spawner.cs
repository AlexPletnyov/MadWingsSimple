using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    public class Spawner : MonoBehaviour
    {
		[HideInInspector]
	    public GameObject prefab;
		[HideInInspector]
	    public GameObject point;

	    private PoolType poolType;

	    private void Awake()
	    {
		    //poolType = prefab.GetComponent<Actor>().poolType;
	    }

	    public void Spawn(PoolType poolType, GameObject prefab, GameObject spawnPoint, float rotateAngle)
	    {
		    var obj = ManagerPool.Instance.Spawn(poolType, prefab);
		    obj.transform.position = spawnPoint.transform.position;
		    obj.transform.rotation = Quaternion.Euler(0, 0, rotateAngle);
		}

    }
}
