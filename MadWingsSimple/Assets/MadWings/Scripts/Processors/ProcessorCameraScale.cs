using System;
using UnityEngine;

public class ProcessorCameraScale : IProcessor
{
	public ProcessorCameraScale(DataCamera dataCamera)
	{
		this.data = dataCamera;
	}

	private readonly DataCamera data;

	public void Run()
	{
		var data = this.data;

		var height = Mathf.RoundToInt(data.pixelsPerWidth / Screen.width * Screen.height);

		var pixelsPerUnits = data.pixelsPerWidth / data.unitsPerWidth;

		data.mCamera.orthographicSize = height / pixelsPerUnits / 2;
	}
}
