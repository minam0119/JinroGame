using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JinroGame;

public class StageManager : MonoBehaviour {
	static StageManager singleton;
	static List<int> deadCharcteNum = new List<int>();
	static List<Character> actors = new List<Character>();
	static int date = 0;
	public int rest;
	TextAsset scenario;
	CharacterViewController[] character;

	void Awake(){
		if(singleton != null){
			singleton = this;
			GameObject.DontDestroyOnLoad(this.gameObject);
		}else{
			Destroy(this.gameObject);
		}
	}
}
