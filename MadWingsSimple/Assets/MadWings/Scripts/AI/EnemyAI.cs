using System;
using PathCreation;
using UnityEngine;

[Serializable]
public class Path
{
	public PathCreator prefab;
	public EndOfPathInstruction pathEndingType;
	public float moveSpeed;
	[HideInInspector]
	public bool isEndPath;
}

[RequireComponent(typeof(Controller2D))]
public class EnemyAI : MonoBehaviour
{
	//   public Path[] path;
	//   public PathCreator pathPrefab;
	//   public EndOfPathInstruction pathEndingType;
	//   public float moveSpeed = 5;
	//   [HideInInspector]
	//   public Quaternion moveAngle;

	//   public Vector3[] currentPoints;

	//private float distance;
	//private Vector2 moveDirection;
	//private Controller2D controller;
	//private float count;
	//private bool isWait;

	private void Awake()
	{
		//controller = GetComponent<Controller2D>();
		//currentPoints = pathPrefab.path.poi;
	}

	private void FixedUpdate()
	{
		//   Move(pathPrefab);
		//Wait(2);
		//StopAtTheEndPoint(pathPrefab);
	}

	//   private void Move(PathCreator pathPrefab)
	//   {
	//    if (isWait)
	//    {
	//		if (pathPrefab != null)
	//		{
	//			distance += moveSpeed * Time.deltaTime;

	//			moveDirection = pathPrefab.path.GetPointAtDistance(distance, pathEndingType);

	//			moveAngle.z = pathPrefab.path.GetRotationAtDistance(distance, pathEndingType).z;
	//			moveAngle.w = pathPrefab.path.GetRotationAtDistance(distance, pathEndingType).w;
	//		}
	//		else
	//		{
	//			Debug.Log("Path prefab is null");
	//		}

	//		controller.MovePosition(moveDirection);
	//		controller.MoveRotation(moveAngle);
	//    }
	//   }

	//   private void Wait(float seconds)
	//   {
	//    if (Time.time > count)
	//    {
	//	    count = Time.time + seconds;
	//	    isWait = true;
	//    }
	//}

	//   private void StopAtTheEndPoint(PathCreator pathPrefab)
	//   {
	//    if (transform.position == pathPrefab.path.GetPoint(1))
	//    {
	//		path[0].isEndPath = true;
	//	}
	//   }
}
