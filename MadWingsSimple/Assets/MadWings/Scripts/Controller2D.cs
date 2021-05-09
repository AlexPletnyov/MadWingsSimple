using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
	[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
    public class Controller2D : MonoBehaviour
    {
	    [HideInInspector]
	    public float speed;

	    private Rigidbody2D rb2d;

	    private void Awake()
	    {
		    rb2d = GetComponent<Rigidbody2D>();
	    }

	    #region Types of moving

		public void MovePosition(Vector2 direction)
	    {
		    rb2d.MovePosition(direction);
	    }

	    public void MoveRotation(Quaternion angle)
	    {
		    rb2d.MoveRotation(angle);
	    }

	    public void MoveAxisX()
	    {
		    rb2d.velocity = transform.right * speed;
	    }

	    public void MoveAxisY()
	    {
		    rb2d.velocity = transform.up * speed;
	    }

	    #endregion
	}
}
