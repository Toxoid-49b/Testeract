using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Command : MonoBehaviour {
	public void SetMeshVisibility(bool IsVisible){
		this.GetComponent<MeshRenderer>().enabled = IsVisible;
	}
	// USE GameObject.SetActive() instead.
	//public void SetObjectActive(bool IsActive){
	//	this.gameObject.SetActive(IsActive);
	//}
	public void TranslateObject(float moveX, float moveY, float moveZ){
		//Translate.
		this.transform.Translate (new Vector3 (moveX, moveY, moveZ), this.transform);
	}
	public void TranslateObjectX(float moveX){
		//Translate.
		this.transform.Translate (new Vector3 (moveX, 0, 0), this.transform);
	}
	public void TranslateObjectY(float moveY){
		//Translate.		
		this.transform.Translate (new Vector3 (0, moveY, 0), this.transform);
	}
	public void TranslateObjectZ(float moveZ){
		//Translate.
		this.transform.Translate (new Vector3 (0, 0, moveZ), this.transform);
	}
	public void RotateObject(float rotX, float rotY, float rotZ){
		//Rotate.
		this.transform.Rotate (new Vector3 (rotX, rotY, rotZ));
	}
	public void RotateObjectX(float rotX){
		//Rotate.
		this.transform.Rotate (new Vector3 (rotX, 0, 0));
	}
	public void RotateObjectY(float rotY){
		//Rotate.
		this.transform.Rotate (new Vector3 (0, rotY, 0));
	}
	public void RotateObjectZ(float rotZ){
		//Rotate.
		this.transform.Rotate (new Vector3 (0, 0, rotZ));
	}
	public void ScaleObject(float scaleX, float scaleY, float scaleZ) {
		//Scale.
		this.transform.localScale += new Vector3 (scaleX, scaleY, scaleZ);
	}
	public void ScaleObjectX(float scaleX){
		//Scale.
		this.transform.localScale += new Vector3 (scaleX, 0, 0 );
	}
	public void ScaleObjectY(float scaleY){
		//Scale.
		this.transform.localScale += new Vector3 (0, scaleY, 0 );
	}
	public void ScaleObjectZ(float scaleZ){
		//Scale.
		this.transform.localScale += new Vector3 (0, 0, scaleZ);
	}
}