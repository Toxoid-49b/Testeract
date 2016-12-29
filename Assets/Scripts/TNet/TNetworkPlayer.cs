using UnityEngine;
using System.Collections;

public struct TNetworkPlayer {

	public NetworkPlayer netPlayer;
	public byte playerHealth;
	public string playerName;

	public TNetworkPlayer(NetworkPlayer basePlayer){

		netPlayer = basePlayer;
		playerHealth = 100;
		playerName = "NoName";

	}

}
