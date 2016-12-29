using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	public static NetworkManager instance;

	public NetworkClient networkClient;

	public void Awake () {
		instance = this;
		DontDestroyOnLoad (this.gameObject);
	}

	public void CreateClient (string ip, int port) {
		networkClient = new NetworkClient ();
		RegisterClientHandlers ();
		networkClient.Connect (ip, port);
	}
		
	public void CreateServer (int port) {
		NetworkServer.Listen (port);
		// Connect to the local server.
		networkClient = ClientScene.ConnectLocalServer ();
		RegisterClientHandlers ();
	}

	private void RegisterClientHandlers() {
		networkClient.RegisterHandler (MsgType.Connect,    OnClientConnect);
		networkClient.RegisterHandler (MsgType.Disconnect, OnClientDisconnect);
		networkClient.RegisterHandler (MsgType.Error,      OnClientError);
		networkClient.RegisterHandler (MsgType.NotReady,   OnClientNotReady);
	}

	// This client had a network error.
	public virtual void OnClientConnect (NetworkMessage msg) {
		Debug.Log("[NETWORKMANAGER] Client: Connected.");
	}

	// This client connected.
	public virtual void OnClientDisconnect (NetworkMessage msg) {
		Debug.Log("[NETWORKMANAGER] Client: Disconnected.");
	}

	// This client had a network error.
	public virtual void OnClientError (NetworkMessage msg) {
		Debug.Log("[NETWORKMANAGER] Client: Network error occurred.");
	}

	// The server said it wasn't ready for this client.
	public virtual void OnClientNotReady (NetworkMessage msg) {
		Debug.Log("[NETWORKMANAGER] Client: Server was not ready.");
	}
}
