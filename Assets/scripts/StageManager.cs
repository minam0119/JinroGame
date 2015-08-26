using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JinroGame;

public class StageManager : MonoBehaviour {
	static List<int> deadCharcteNum = new List<int>();
	static List<Character> actors = new List<Character>();
	public int date = 0;
	public int rest;
	TextAsset scenario;
	CharacterViewController[] character;

	void Awake(){

	}
}
