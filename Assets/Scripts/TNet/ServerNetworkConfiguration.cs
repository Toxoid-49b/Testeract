using UnityEngine;
using System;

public struct ServerNetworkConfiguration {

	public int maxplayers, serverport;
	public bool useNAT;

	public ServerNetworkConfiguration(int maxPlayers, int serverPort){

		useNAT = !Network.HavePublicAddress();
		maxplayers = maxPlayers;
		serverport = serverPort;

	}

	public bool IsValid(){
		
		if (serverport >= 1023 && serverport <= 65535 && maxplayers > 1){

			return true;

		}

		return false;

	}

}

