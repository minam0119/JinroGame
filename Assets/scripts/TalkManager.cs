using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TalkManager : MonoBehaviour {

	public TextAsset 	csv_villagerA;
	public Text 		villagerA_Text;
	public string[,] 	talks_villagerA;

	public TextAsset 	csv_villagerB;
	public Text 		villagerB_Text;
	public string[,] 	talks_villagerB;

	public TextAsset 	csv_villagerC;
	public Text 		villagerC_Text;
	public string[,] 	talks_villagerC;

	public TextAsset 	csv_villagerD;
	public Text 		villagerD_Text;
	public string[,] 	talks_villagerD;

	public TextAsset 	csv_augurA;
	public Text 		augurA_Text;
	public string[,] 	talks_augurA;

	public TextAsset 	csv_augurB;
	public Text 		augurB_Text;
	public string[,] 	talks_augurB;





	// Use this for initialization
	void Start () {
		csv_villagerA = Resources.Load("csv_villagerA") as TextAsset;
		csv_villagerB = Resources.Load("csv_villagerB") as TextAsset;
		csv_villagerC = Resources.Load("csv_villagerC") as TextAsset;
		csv_villagerD = Resources.Load("csv_villagerD") as TextAsset;
		csv_augurA = Resources.Load("csv_augurA") as TextAsset;
		csv_augurB = Resources.Load("csv_augurB") as TextAsset;

		talks_villagerA = CSVReader.SplitCsvGrid(csv_villagerA.text);
		/*
		talks_villagerB = CSVReader.SplitCsvGrid(csv_villagerB.text);
		talks_villagerC = CSVReader.SplitCsvGrid(csv_villagerC.text);
		talks_villagerD = CSVReader.SplitCsvGrid(csv_villagerD.text);
		talks_augurA = CSVReader.SplitCsvGrid(csv_augurA.text);
		talks_augurB = CSVReader.SplitCsvGrid(csv_augurB.text);
		*/
	}

	string SplitNewLine(string talk){
		string[] bunkatu = talk.Split(':');
		string kaigyou = "";
		for(int i=0; i<bunkatu.Length; i++){
			kaigyou += bunkatu[i] + "\n";
		}
		return kaigyou;
	}
}
