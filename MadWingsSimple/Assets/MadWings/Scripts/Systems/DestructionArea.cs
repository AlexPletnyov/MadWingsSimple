using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class DestructionArea : MonoBehaviour
{
	public static BoxCollider2D colllider;
	public float offsetX = 2f;
	public float offsetY = 1.5f;

	private Bounds colBounds;

	private void Awake()
	{
		colllider = GetComponent<BoxCollider2D>();
	}

	private void Start()
	{
		SetColliderSize();
	}

	private void SetColliderSize()
	{
		var colSize = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)) * 2;

		colSize.x *= offsetX;
		colSize.y *= offsetY;

		colllider.size = colSize;
		colBounds = colllider.bounds;
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;

		Gizmos.DrawLine(new Vector2(colBounds.min.x, colBounds.min.y), new Vector2(colBounds.max.x, colBounds.min.y));
		Gizmos.DrawLine(new Vector2(colBounds.min.x, colBounds.min.y), new Vector2(colBounds.min.x, colBounds.max.y));
		Gizmos.DrawLine(new Vector2(colBounds.min.x, colBounds.max.y), new Vector2(colBounds.max.x, colBounds.max.y));
		Gizmos.DrawLine(new Vector2(colBounds.max.x, colBounds.max.y), new Vector2(colBounds.max.x, colBounds.min.y));
	}
}
