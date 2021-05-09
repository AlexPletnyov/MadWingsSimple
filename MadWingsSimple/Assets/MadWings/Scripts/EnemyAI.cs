using PathCreation;
using UnityEngine;

namespace RainbowWhale
{
	[RequireComponent(typeof(Controller2D))]
    public class EnemyAI : MonoBehaviour
    {
	    public PathCreator pathPrefab;
	    public EndOfPathInstruction pathEndingType;
	    public float moveSpeed = 5;
	    [HideInInspector]
	    public Quaternion moveAngle;

		private float distance;
		private Vector2 moveDirection;
		private Controller2D controller;

	    private void Awake()
	    {
		    controller = GetComponent<Controller2D>();
	    }

	    private void FixedUpdate()
	    {
		    GetPath();
		    SetMovePosition();
	    }

	    private void GetPath()
	    {
		    if (pathPrefab != null)
		    {
			    distance += moveSpeed * Time.deltaTime;

			    moveDirection = pathPrefab.path.GetPointAtDistance(distance, pathEndingType);

			    moveAngle.z = pathPrefab.path.GetRotationAtDistance(distance, pathEndingType).z;
			    moveAngle.w = pathPrefab.path.GetRotationAtDistance(distance, pathEndingType).w;
		    }
		    else
		    {
			    Debug.Log("Path prefab is null");
		    }
	    }

	    private void SetMovePosition()
	    {
		    controller.MovePosition(moveDirection);
		    controller.MoveRotation(moveAngle);
		}
	}
}
