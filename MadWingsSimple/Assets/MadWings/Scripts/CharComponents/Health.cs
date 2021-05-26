using System;
using UnityEngine;

public class Health : MonoBehaviour
{
	public float point;

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
		gameObject.SetActive(false);
	}
}