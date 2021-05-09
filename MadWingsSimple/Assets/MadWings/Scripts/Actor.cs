using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    [RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D), typeof(Health))]
    public class Actor : MonoBehaviour, IPoolable
    {
	    public PoolType poolType;
	    public int damage;

	    public void OnSpawn()
	    {
		    
	    }

	    public void OnDespawn()
	    {
		    
	    }
    }
}
