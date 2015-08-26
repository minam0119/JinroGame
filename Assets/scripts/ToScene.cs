using UnityEngine;
using System.Collections;

public class ToScene : MonoBehaviour {

	public void LoadScene(string sceneName){
		Application.LoadLevel(sceneName);
	}

	public void ToStage01(){
		Application.LoadLevel("Stage01");
	}
}
