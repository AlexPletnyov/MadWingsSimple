using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float bodyDamage;
	public HealthBar healthBar;

	private Health health;
	private float maxHp;

	private void Awake()
	{
		health = GetComponent<Health>();
		maxHp = health.point;
	}

	private void Update()
	{
		healthBar.AnimateBar(health.point, maxHp);
	}
}
