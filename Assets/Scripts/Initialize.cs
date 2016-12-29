using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour {
	void Awake() {
		if(!PlayerPrefs.HasKey("ViewModelsEnabled"))
			PlayerPrefs.SetInt("ViewModelsEnabled", 1);
		if(!PlayerPrefs.HasKey("Volume"))
			PlayerPrefs.SetFloat("Volume", 100);
		if(!PlayerPrefs.HasKey("FieldOfView"))
	 		PlayerPrefs.SetFloat("FieldOfView", 65);
		if(!PlayerPrefs.HasKey("PlayerName"))
	 		PlayerPrefs.SetString("PlayerName", "Player");
	}
}
