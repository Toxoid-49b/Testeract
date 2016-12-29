using UnityEngine;

public class MouseControl : MonoBehaviour {
	// Control this object with the mouse.

	// Default unity names for mouse axes
	public string mouseHorizontalAxisName = "Mouse X";
	public string mouseVerticalAxisName = "Mouse Y";
	public float xSensitivity = 4;	
	public float ySensitivity = 4;
	public bool enableX = true;
	public bool enableY = true;
	
	void LateUpdate () {
		float rotationX = Input.GetAxis(mouseHorizontalAxisName) * xSensitivity;
		Debug.Log ("Yaw:"+rotationX);
		float rotationY = Input.GetAxis(mouseVerticalAxisName) *ySensitivity;
		Debug.Log ("P:"+-rotationY);
		
		transform.eulerAngles += new Vector3(enableY ? -rotationY : 0, enableX ? rotationX : 0, 0);
	}
	
}