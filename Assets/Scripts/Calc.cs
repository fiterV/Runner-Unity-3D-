using UnityEngine;
using System.Collections;

public class Calc : MonoBehaviour {
	public float updatePeriod, nextUpdate, frames, fps;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  frames++;
	  if (Time.time>nextUpdate) {
			fps = Mathf.Round (frames/updatePeriod);
			
			gameObject.guiText.text="FPS : " + fps.ToString();
			nextUpdate = Time.time + updatePeriod;
			frames=0;
		}
	}
}
