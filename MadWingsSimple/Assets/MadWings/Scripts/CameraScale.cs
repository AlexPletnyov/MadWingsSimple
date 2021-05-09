using System;
using UnityEngine;

namespace RainbowWhale
{
	public class CameraScale : MonoBehaviour
	{
		public Camera mCamera;
		public float pixelsPerWidth;
		public float unitsPerWidth;

		private void Update()
		{
			SetScale();
		}

		private void SetScale()
		{
			var height = Mathf.RoundToInt(pixelsPerWidth / Screen.width * Screen.height);
			var pixelsPerUnits = pixelsPerWidth / unitsPerWidth;
			mCamera.orthographicSize = height / pixelsPerUnits / 2;
		}
	}
}