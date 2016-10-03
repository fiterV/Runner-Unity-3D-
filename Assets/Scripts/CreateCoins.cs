using UnityEngine;
using System.Collections;

public class CreateCoins : MonoBehaviour {
	public GameObject FOR_GEN;
	public float Plane_Width;
	private GameObject Plane1, Plane2, Plane3;
	// Use this for initialization
	void Start () {
		
		Plane1 = GameObject.Find("Plane1");
		Plane2 = GameObject.Find("Plane2");
		Plane3 = GameObject.Find("Plane3");
	}
	
	void generate_coins(){
		
		int val = Random.Range(1, 3);
		Vector3 Position = gameObject.transform.position;
		while (val>0){
		  int gt = Random.Range(10, 15);
		  int random_plane = Random.Range (1, 4);
		  Vector3 pos2 = new Vector3(Position.x, Position.y, Position.z+gt);
		 if (random_plane==1) pos2.x=Plane1.transform.position.x; else
		 if (random_plane==2) pos2.x=Plane2.transform.position.x; else
				pos2.x=Plane3.transform.position.x;
		  //pos2.x-=1;
		 Instantiate(FOR_GEN, pos2, new Quaternion(0, 0, 0, 0));
		  
		  val--;	
		}
	}
	
	// Update is called once per frame
	void Update () {
	   if ((int)System.DateTime.Now.Ticks % 50==0) {
			generate_coins();
			//delete_coins();
		}
		
	}
}
