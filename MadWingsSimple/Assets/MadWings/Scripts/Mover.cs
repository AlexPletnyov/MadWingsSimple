using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    [RequireComponent(typeof(Controller2D))]
    public class Mover : MonoBehaviour
    {
	    public MoveType moveType;
	    public float speed;

	    private Controller2D controller2D;

	    private void Awake()
	    {
		    controller2D = GetComponent<Controller2D>();
	    }

	    private void FixedUpdate()
	    {
		    switch (moveType)
		    {
				case MoveType.AxisX:
					controller2D.MoveAxisX(speed);
					break;
				case MoveType.AxisY:
					controller2D.MoveAxisY(speed);
					break;
			}
	    }
    }

    public enum MoveType
    {
		AxisX,
		AxisY
    }
}
