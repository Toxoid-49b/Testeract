using UnityEngine;
using System.Collections;

public class HideLockCursor : MonoBehaviour {
	// Hide and lock cursor
	void Start () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
}
