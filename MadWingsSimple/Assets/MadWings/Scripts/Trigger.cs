using UnityEngine;

namespace RainbowWhale
{
	public class Trigger : MonoBehaviour
    {
	    public ActorType actorType;
	    private Gun gun;
	    private SpriteRenderer sprite;

		private Health health;

		private void Awake()
	    {
		    health = GetComponent<Health>();
		    //gun = GetComponent<Gun>();
		    sprite = GetComponentInChildren<SpriteRenderer>();
	    }

		public void OnTriggerEnter2D(Collider2D outsideActor)
	    {
		    switch (actorType)
		    {
			    case ActorType.Player:
				    if (outsideActor.CompareTag("Enemy"))
				    {
					    health.GetDamage(outsideActor.GetComponent<Actor>().damage);
				    }

				    if (outsideActor.CompareTag("BulletEnemy"))
				    {
					    health.GetDamage(outsideActor.GetComponent<Actor>().damage);
				    }

				    if (outsideActor.CompareTag("Bonus"))
				    {
					    var bonus = outsideActor.GetComponent<Bonus>();

						if (bonus.bonusType == BonusType.EnchantBullet)
					    {
							//устанавливаем плееру урон и цвет пули
							//gun.guns[0].bulletType.GetComponentInChildren<SpriteRenderer>().color = bonus.EnchantBullet.color;
							//gun.guns[0].bulletType.GetComponent<Actor>().damage = bonus.EnchantBullet.damage;
							sprite.color = bonus.EnchantBullet.color;

					    }
				    }
				    break;

				case ActorType.Enemy:
				    if (outsideActor.CompareTag("BulletPlayer")) 
					    health.GetDamage(outsideActor.GetComponent<Actor>().damage);
				    break;
		    }
	    }

		public void OnTriggerExit2D(Collider2D outsideActor)
		{
			if (actorType == ActorType.DestructionArea)
			{
				if (outsideActor.CompareTag("BulletPlayer"))
					ManagerPool.Instance.Despawn(outsideActor.GetComponent<Actor>().poolType, outsideActor.gameObject);

				if (outsideActor.CompareTag("BulletEnemy"))
					ManagerPool.Instance.Despawn(outsideActor.GetComponent<Actor>().poolType, outsideActor.gameObject);
			}
		}
	}
}
