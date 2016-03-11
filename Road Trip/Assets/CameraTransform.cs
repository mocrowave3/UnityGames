using UnityEngine;
using System.Collections;

public class CameraTransform : MonoBehaviour 
{

	bool pan;
	float time;
	bool runOnce;

	void Start () 
	{
		runOnce = true;
		pan = true;
	}

	void Update () 
	{
		if(pan) // camera panning
		{
			if(runOnce)
			{
				runOnce = false;
				time = Time.time;
			}
			transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(0, 0.75f, 0.25f), (Time.time - time)/2);
			transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(10, 0, 0), (Time.time - time)/2);
		}
	}
}