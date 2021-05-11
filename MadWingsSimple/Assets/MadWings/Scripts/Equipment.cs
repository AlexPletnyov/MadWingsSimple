using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    public class Equipment : MonoBehaviour
    {
		[SerializeField]
	    public Dictionary<int, GameObject> shields;

	    public GameObject[] enchantsBullet;
	    public GameObject[] drones;
	    public GameObject[] typesShot;
	    public GameObject[] typesBullet;
	    public GameObject[] trajectorysBullet;

	    public GameObject currentShield;
	    public GameObject currentEnchantBullet;
	    public GameObject currentDrone;
	    public GameObject currentTypeShot;
	    public GameObject currentTypeBullet;
	    public GameObject currentTrajectoryBullet;

		public float ratesShots;
	    public float damageBullet;


    }
}
