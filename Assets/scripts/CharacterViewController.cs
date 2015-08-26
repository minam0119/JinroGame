using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using JinroGame;

public class CharacterViewController : MonoBehaviour {

	public Text talkLabel;
	public bool dead;
	public int role,actRole;
	public PlayerViewController player;
	public GameObject talkCameraObj;
	string talkContent;

	public void LoadTalk(string talks){
		StartCoroutine(SetText(talkLabel,talks));
	}

	IEnumerator SetText(Text label,string text){
		for(int i=0;i<text.Length;i++){
			label.text = text.Substring(0,i);
			yield return new WaitForSeconds(0.04f);
		}
	}
}