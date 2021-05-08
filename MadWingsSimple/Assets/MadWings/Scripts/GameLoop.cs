using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
	public List<IProcessor> Processors;
	private SceneData get;

	private void Awake()
	{
		Processors = new List<IProcessor>();

		get = GetComponent<SceneData>();

		StartProcessors();

		get.dataCamera.mCamera = GameObject.Instantiate(get.dataCamera.mCamera);
	}

	void Update()
    {
	    foreach (var Processor in Processors)
	    {
		    Processor.Run();
	    }
    }

	private void StartProcessors()
	{
		Add(new ProcessorCameraScale(get.dataCamera));
	}

	private void Add(IProcessor IProcessor)
	{
		Processors.Add(IProcessor);
	}
}