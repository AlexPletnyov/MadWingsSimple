using System;
using UnityEngine;

public class CameraScale : MonoBehaviour
{
	public Camera mCamera;
	public float pixelsPerWidth;
	public float unitsPerWidth;

	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

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