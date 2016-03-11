using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GUIToGame : MonoBehaviour {

	public void ChangeToScene(string sceneToChangeTo) 
	{
		Application.LoadLevel(sceneToChangeTo);
	}

}
