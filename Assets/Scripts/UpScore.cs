using UnityEngine;
using System.Collections;

public class UpScore : MonoBehaviour {
	int Score;
	public GUIText GUI_TEXT;
	public int One_Coin_Cost;
	public string s = "";
	// Use this for initialization
	void Start () {
	  Score=0;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other) {
		//int gp = ((int)System.DateTime.Now.Ticks);
		//GUI_TEXT.guiText.text = other.gameObject.tag+gp.ToString();
		//return;
		if (other.gameObject.tag=="Coin") {
			s = GUI_TEXT.guiText.text;
		    int x=0;
			foreach(char c in s) 
				x = x*10 + (int)c-48;
			Score = x+One_Coin_Cost;
		    GUI_TEXT.guiText.text = Score.ToString();
			Destroy(other.gameObject);
		}
	}
	

	

}
