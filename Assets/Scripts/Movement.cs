using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float MaxSpeed;
	public float AddSpeed;
	public float Speed=0;
	public float StartSpeed=0;
	public float MapLen=100;
	public GameObject sky;
	public string s;
	
	private Vector3 Position;
	// Use this for initialization
	void Start () {
	  Speed = StartSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		Position = gameObject.transform.position;
		Speed = Mathf.Min (MaxSpeed, Speed+AddSpeed);
		Position.z+=Speed*Time.deltaTime;
		if (Position.z>=(-195+MapLen)) {
			//zanovo
			//sky.material.SetTextureScale("Tiling", new Vector2(10, 30));
			//sky.gameObject.renderer.material.SetTextureScale("Tiling", new Vector2(10, 30));
			//sky.renderer.material.color = new Color(0, 0, 0, 0);	
			Vector2 gt = sky.renderer.material.mainTextureScale;
			sky.renderer.material.mainTextureScale = new Vector2(gt.x, gt.y+1);
			//s = (x.x).ToString() + " " + (x.y).ToString();
			Position.z=-195;
			
		}
		
		float move = 2;
		if (Input.GetKeyDown(KeyCode.A)) Position.x-=move;
		if (Input.GetKeyDown(KeyCode.D)) Position.x+=move;
		/*
		 
		if (Input.GetAxis("Horizontal")>0.0) Position.x-=move; else
		if (Input.GetAxis("Horizontal")<0.0) Position.x+=move;
		  
		    */
		Position.x = Mathf.Max (Position.x, -2);
		Position.x = Mathf.Min (Position.x, 2);
		
		gameObject.transform.position = Position;
	
	}
}
