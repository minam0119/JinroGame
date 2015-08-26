using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerViewController : MonoBehaviour {
	int[] TalkPerson;
	int[] ToldPerson;
	public List<CharacterViewController> character = new List<CharacterViewController>();
	GameObject[] charas; 

	[HideInInspector]
	public CharacterViewController talkChar;

	void Start(){
		charas = GameObject.FindGameObjectsWithTag("Character");
		for(int i=0; i<charas.Length; i++){
			character.Add(new CharacterViewController());
			character[i] = charas[i].GetComponent<CharacterViewController>();
		}
	}

	void Update(){
		if(Input.GetKeyDown("enter") && talkChar!= null){
			talkChar.talkCameraObj.SetActive(false);
		}
	}

	//Characterタグのやつに当たったらカメラを切り替える
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Character"){
			talkChar = other.gameObject.GetComponent<CharacterViewController>();
			talkChar.talkCameraObj.SetActive(true);
		}
	}


}
