using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    public class Health : MonoBehaviour
    {
	    public int point;

	    private Actor actor;

	    private void Awake()
	    {
		    actor = GetComponent<Actor>();
	    }

	    public void GetDamage(int damage)
	    {
		    point -= damage;

		    if (point <= 0)
		    {
			    Destruction();
		    }
		}

	    public void Destruction()
	    {
		    ManagerPool.Instance.Despawn(actor.poolType, gameObject);
		}
    }
}
