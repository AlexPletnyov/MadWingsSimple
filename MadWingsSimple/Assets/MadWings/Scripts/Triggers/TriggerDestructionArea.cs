using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TriggerDestructionArea : MonoBehaviour
{
	public void OnTriggerExit2D(Collider2D outsideActor)
	{
		if (outsideActor.CompareTag("BulletPlayer") || outsideActor.CompareTag("BulletEnemy"))
		{
			ManagerPool.Instance.Despawn(PoolType.Bullet, outsideActor.gameObject);
		}
	}
}
