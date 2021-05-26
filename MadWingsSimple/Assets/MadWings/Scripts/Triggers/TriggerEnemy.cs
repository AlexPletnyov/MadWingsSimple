using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TriggerEnemy : MonoBehaviour
{
	private Health health;

	private void Awake()
	{
		health = GetComponent<Health>();
	}

	public void OnTriggerEnter2D(Collider2D outsideActor)
	{
		if (outsideActor.CompareTag("BulletPlayer"))
		{
			health.GetDamage(outsideActor.GetComponent<Bullet>().damage);
		}
	}
}
