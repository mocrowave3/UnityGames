#pragma strict

var pan:boolean;
var time:int;
var runOnce:boolean;

function Start () 
{
	runOnce = true;
	pan = true;
}

function Update () 
{
	if(pan) // camera panning
	{
		if(runOnce)
		{
			runOnce = false;
			time = Time.time;
		}
		transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3(0, 0.75, 0.25), (Time.time - time)/2);
		transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, Vector3(10, 0, 0), (Time.time - time)/2);
	}
}