using UnityEngine;
using System.Collections;

public class CoinTurn : MonoBehaviour {
     public float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 //  gameObject.transform.Rotate(Speed*Time.deltaTime, 0, 0);
		gameObject.transform.Rotate(0, Speed*Time.deltaTime, 0);
	}
}
