using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InputText : MonoBehaviour {

	IEnumerator SetText(Text label,string text){
		for(int i=0;i<text.Length;i++){
			label.text = text.Substring(0,i);
			yield return new WaitForSeconds(0.04f);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
