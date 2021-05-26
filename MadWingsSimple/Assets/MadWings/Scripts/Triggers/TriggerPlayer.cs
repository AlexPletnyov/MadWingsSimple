using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TriggerPlayer : MonoBehaviour
{
	private Health health;

	private void Awake()
	{
		health = GetComponent<Health>();
	}

	public void OnTriggerEnter2D(Collider2D outsideActor)
	{
		if (outsideActor.CompareTag("Enemy"))
		{
			health.GetDamage(outsideActor.GetComponent<Enemy>().bodyDamage);
		}
		else if (outsideActor.CompareTag("BulletEnemy"))
		{
			health.GetDamage(outsideActor.GetComponent<Bullet>().damage);
		}
		else if (outsideActor.CompareTag("Bonus"))
		{

		}
	}
}
