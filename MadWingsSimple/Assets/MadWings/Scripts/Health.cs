using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    public class Health : MonoBehaviour
    {
	    public float point;

	    private Actor actor;

	    private void Awake()
	    {
		    actor = GetComponent<Actor>();
	    }

	    public void GetDamage(float damage)
	    {
		    point -= damage;

		    if (point <= 0)
		    {
			    Destruction();
		    }
		}

	    public void Destruction()
	    {
		    if (actor.isPoolObject)
		    {
				ManagerPool.Instance.Despawn(actor.poolType, gameObject);
			}
		    else
		    {
			    Destroy(gameObject);
		    }
		    
		}
    }
}
