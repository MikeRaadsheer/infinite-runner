using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerJump : MonoBehaviour {
	public Movement PlayerMovment;
	public PowerupManager PUM;
	
	
	// Use this for initialization
	void Start () {
		//GameObject g = GameObject.FindGameObjectWithTag (Playr);
		GameObject player = GameObject.Find("player");
		GameObject PUObject = GameObject.Find("PUManeger");

		PlayerMovment = player.GetComponent<Movement> ();
		//PUM = player.GetComponent<powerupmaneger> ();

		
	}

	
	// Update is called once per frame
	void Update () {
	
		

	}
	void OnTriggerEnter2D(Collider2D col)
    {
		PUM.PU1Power();
       PUM.setInfJumpActive(true);
		Destroy (this.gameObject);
    }

}
