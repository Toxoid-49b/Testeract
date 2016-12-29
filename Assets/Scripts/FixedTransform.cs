using UnityEngine;
using System.Collections;

public class FixedTransform : MonoBehaviour {
	public float moveX = 0;
	public float moveY = 0;
	public float moveZ = 0;
	public float moveXLocal = 0;
	public float moveYLocal = 0;
	public float moveZLocal = 0;
	public float rotX = 0;
	public float rotY = 0;
	public float rotZ = 0;
	public float rotXLocal = 0;
	public float rotYLocal = 0;
	public float rotZLocal = 0;
	public float scaleXincLocal = 0;
	public float scaleYincLocal = 0;
	public float scaleZincLocal = 0;
	
	void FixedUpdate(){
		//Rotate.
		this.transform.position += new Vector3 (moveX, moveY, moveZ);
		this.transform.localPosition += new Vector3 (moveXLocal, moveYLocal, moveZLocal);
		this.transform.Rotate(new Vector3 (rotX, rotY, rotZ), Space.World);
		this.transform.Rotate(new Vector3 (rotXLocal, rotYLocal, rotZLocal), Space.Self);
		this.transform.localScale += new Vector3 (scaleXincLocal, scaleYincLocal, scaleZincLocal);
	}
}
