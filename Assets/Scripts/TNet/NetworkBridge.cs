using UnityEngine;
using System.Collections;

public class NetworkBridge : MonoBehaviour {

	private Server thisServer;
	private Client thisClient;
	private NetworkBridge thisBridge;
	private NetworkView thisNetView;

	void Awake(){

		thisBridge = this;
		thisNetView = GetComponent<NetworkView>();

		if(Network.isServer){
			
			thisServer = GameObject.FindGameObjectWithTag("Server").GetComponent<Server>();
			
		}
		
		if(Network.isClient){
			
			thisClient = GameObject.FindGameObjectWithTag("Client").GetComponent<Client>();
			
		}

	}

	public void SpawnPlayer(TNetworkPlayer playerToSpawn, Vector3 spawnPosition){

		if(Network.isServer){

			thisNetView.RPC("RPCSpawnPlayer", playerToSpawn.netPlayer, spawnPosition);

		}

	}

	[RPC]
	public void RPCSpawnPlayer(Vector3 spawnPos){

		if(Network.isClient){

			thisClient.Spawn(spawnPos);

		}

	}

}
