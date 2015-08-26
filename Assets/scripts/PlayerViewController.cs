using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerViewController : MonoBehaviour {
	int[] TalkPerson;
	int[] ToldPerson;
	TalkManager talkManager;
	StageManager stageManager;
	public List<CharacterViewController> character = new List<CharacterViewController>();
	GameObject[] charas;
	FirstPersonController fpController;

	int col;
	string pushTalk;


	[HideInInspector]
	public CharacterViewController talkChar;

	void Start() {
		talkManager = GameObject.Find("TalkManager").GetComponent<TalkManager>();
		stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
		charas = GameObject.FindGameObjectsWithTag("Character");
		fpController = GetComponent<FirstPersonController>();
		for(int i=0; i<charas.Length; i++){
			character.Add(new CharacterViewController());
			character[i] = charas[i].GetComponent<CharacterViewController>();
		}
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Return) && talkChar!= null){
			talkChar.talkCameraObj.SetActive(false);
			GetComponent<FirstPersonController>().enabled = true;
		}
	}

	//Characterタグのやつに当たったらカメラを切り替える
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Character"){
			talkChar = other.gameObject.GetComponent<CharacterViewController>();
			talkChar.talkCameraObj.SetActive(true);
			if (talkChar.actRole == 0) {
				pushTalk = talkManager.talks_villagerA[col, stageManager.date];
			} else if (talkChar.actRole == 1) {
				pushTalk = talkManager.talks_villagerB[col, stageManager.date];
			}
			talkChar.ShowTalk(pushTalk);
			GetComponent<FirstPersonController>().enabled = false;	
		}
	}


}
