using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCommand : MonoBehaviour {
	public void ExitGame() {
		Application.Quit();
	}
	public void SetLevel(string SceneName) {
		SceneManager.LoadScene(SceneName);
	}
}
