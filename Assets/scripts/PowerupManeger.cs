using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupmaneger : MonoBehaviour {
	public Movement PlayerMovment;
	public PowerJump powerjump;

	public bool isInfJumpActive = false;
	public float PU1Timer = 10;
	// Use this for initialization
	public bool getInfJumpActive(){
		return isInfJumpActive;
	}
	public void setInfJumpActive(bool infJump){
        isInfJumpActive = infJump;
    }
	
	// Update is called once per frame
	void Update () {
	Debug.Log(PU1Timer);
	if (PU1Timer <= 0f){
		isInfJumpActive = false;
		PU1Timer = 10f;
		
	}
	if (isInfJumpActive == true && PU1Timer != 0f){
		PU1Timer -= Time.deltaTime;
		PlayerMovment.SetGrounded(true);
	}
	// ==================================================================================	
	}
	
	public void PU1Power ()
	{
		if (isInfJumpActive == true){
			PlayerMovment.SetGrounded(true);
			
			 
			if (PU1Timer <= 0f)	
			{
				PlayerMovment.SetGrounded(true);
				isInfJumpActive = false;
				
				
			}

		}
	}
	// ==================================================================================


}
