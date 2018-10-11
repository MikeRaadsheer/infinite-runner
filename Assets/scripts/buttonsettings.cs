using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsettings : MonoBehaviour {
	public GameObject settings;
	public GameObject menu;

     public void DisableCanvas(bool activate) {
          settings.SetActive(activate);
		  menu.SetActive(!activate);
     }

}
