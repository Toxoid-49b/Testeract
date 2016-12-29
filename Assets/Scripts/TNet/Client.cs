using UnityEngine;
using System.Collections;

public class Client : MonoBehaviour {

	public static Client thisClient;
	public GameObject playerPrefab;

	private GameObject currentPlayerObject;

	void Awake(){

		thisClient = this;

		Network.Connect("127.0.0.1", 25777);

	}

	/// <summary>
	/// Called by the server to spawn the player at a designated spawn point
	/// </summary>
	public void Spawn(Vector3 spawnPosition){

		if(currentPlayerObject == null){

			currentPlayerObject = Network.Instantiate(playerPrefab, spawnPosition, Quaternion.identity, 0) as GameObject;

		} else {

			currentPlayerObject.transform.position = spawnPosition;
			currentPlayerObject.GetComponent<TPlayer>().Spawn();

		}

	}

}
