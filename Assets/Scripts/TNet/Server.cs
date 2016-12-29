using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Server : MonoBehaviour {

	public static Server thisServer;
	public GameObject testMap;
	public GameObject playerPrefab;

	private GameObject gameMap;
	private Dictionary<string, TNetworkPlayer> playersInServer = new Dictionary<string, TNetworkPlayer>();

	private NetworkBridge netBridge;

	void Awake () {

		thisServer = this;

		if(NetworkGlobals.serverConfig.IsValid()){

			//Start the server
			Debug.Log(NetworkGlobals.serverConfig.maxplayers.ToString() + " | " + NetworkGlobals.serverConfig.serverport.ToString() + " | " + NetworkGlobals.serverConfig.useNAT.ToString());
			NetworkConnectionError netError = Network.InitializeServer(NetworkGlobals.serverConfig.maxplayers, NetworkGlobals.serverConfig.serverport, NetworkGlobals.serverConfig.useNAT);

			if(netError == NetworkConnectionError.NoError){

				Debug.Log("[TNET] The server started with no errors!");
				ServerInit();

			} else {

				Debug.LogError("[TNET] Server Network Error: " + netError.ToString()); 

			}

		} else {

			Debug.LogError("[TNET] The server configuration is not set or is invalid!");

		}

	}

	private void ServerInit(){

		netBridge = GameObject.FindGameObjectWithTag("NetworkBridge").GetComponent<NetworkBridge>();

		//Just testing this, please ignore for now
		//gameMap = ContentGenerator.GameObjectFromMeshFilter(testMap, "testmap", Vector3.zero, 0.625f);

		gameMap = Network.Instantiate(testMap, Vector3.zero, Quaternion.identity, 0) as GameObject;
		gameMap.name = "Game Map";

		Network.Instantiate(playerPrefab, new Vector3(0, 16, 0), Quaternion.identity, 0);

	}

	void OnPlayerConnected(NetworkPlayer player) {
		
		Debug.Log("[TNET] Client connected from " + player.ipAddress + ":" + player.port);
		playersInServer.Add(player.ipAddress, new TNetworkPlayer(player));

		netBridge.SpawnPlayer(playersInServer[player.ipAddress], new Vector3(0, 16, 0));
		
	}

}