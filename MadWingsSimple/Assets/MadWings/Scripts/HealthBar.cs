using System;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
	public Transform bar;
	public float health;
	public float maxHealth;
	public Color low;
	public Color high;

	private TextMeshPro text;

	private SpriteRenderer barSprite;
	private float healthNormalized;
	private const float minHealth = 0f;

	private void Awake()
	{
		if (bar != null)
		{
			barSprite = bar.GetComponent<SpriteRenderer>();
		}
		else
		{
			bar = transform.Find("bar");
			barSprite = bar.GetComponent<SpriteRenderer>();
		}

		text = GetComponentInChildren<TextMeshPro>();
	}

	private void Update()
	{
		//AnimateBar(health, maxHealth);
	}

	public void AnimateBar(float hp, float maxHp)
	{
		healthNormalized = Mathf.InverseLerp(minHealth, maxHp, hp);
		bar.localScale = new Vector3(healthNormalized, bar.transform.localScale.y);
		barSprite.color = Color.Lerp(low, high, hp / maxHp);
		text.text = Mathf.Round(hp) + $"/{maxHp}";
	}
}
