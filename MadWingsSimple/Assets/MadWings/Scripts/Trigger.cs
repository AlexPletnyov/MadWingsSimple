using UnityEngine;

namespace RainbowWhale
{
	public class Trigger : MonoBehaviour
    {
	    public ActorType actorType;

		private Health health;

		private void Awake()
	    {
		    health = GetComponent<Health>();
	    }

		public void OnTriggerEnter2D(Collider2D outsideActor)
	    {
		    switch (actorType)
		    {
			    case ActorType.Player:
				    if (outsideActor.CompareTag("Enemy")) 
					    health.GetDamage(outsideActor.GetComponent<Actor>().damage);

				    if (outsideActor.CompareTag("BulletEnemy")) 
					    health.GetDamage(outsideActor.GetComponent<Actor>().damage);

					break;

			    case ActorType.Enemy:
				    if (outsideActor.CompareTag("BulletPlayer")) 
					    health.GetDamage(outsideActor.GetComponent<Actor>().damage);

				    break;
		    }
	    }

		public void OnTriggerExit2D(Collider2D outsideActor)
		{
			switch (actorType)
			{
				case ActorType.DestructionArea:
					if (outsideActor.CompareTag("BulletPlayer"))
						ManagerPool.Instance.Despawn(PoolType.Bullets, outsideActor.gameObject);

					if (outsideActor.CompareTag("BulletEnemy"))
						ManagerPool.Instance.Despawn(PoolType.Bullets, outsideActor.gameObject);

					break;
			}
		}
	}
}
