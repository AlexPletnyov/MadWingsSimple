using UnityEngine;

[RequireComponent(typeof(Controller2D))]
public class InputPlayer : MonoBehaviour
{
	public float moveSpeed;

	private Touch touch;
	private Vector2 moveDirection;
	private Transform _transform;
	private Controller2D controller2D;

	private void Awake()
	{
		_transform = GetComponent<Transform>();
		controller2D = GetComponent<Controller2D>();

		GetStartPosition();
	}

	private void Update()
	{
		GetMoveInput();
	}

	private void FixedUpdate()
	{
		SetMovePosition();
	}

	#region Private Methods

	private void GetMoveInput()
	{
		if (Input.touchCount > 0)
		{
			touch = Input.GetTouch(0);

			if (touch.phase == TouchPhase.Moved)
			{
				moveDirection = new Vector2(
					_transform.position.x + touch.deltaPosition.x * moveSpeed,
					_transform.position.y + touch.deltaPosition.y * moveSpeed);
			}
		}
	}

	private void GetStartPosition()
	{
		moveDirection = _transform.position;
	}

	private void SetMovePosition()
	{
		controller2D.MovePosition(moveDirection);
	}

	#endregion
}
