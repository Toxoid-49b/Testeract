using UnityEngine;
using System.Collections;

public class CameraSettings : MonoBehaviour {
	// Attach this to the camera to use the set Field of View.

	void FixedUpdate () {
		this.GetComponent<Camera>().fieldOfView = PlayerPrefs.GetFloat("FieldOfView");
	}
}
