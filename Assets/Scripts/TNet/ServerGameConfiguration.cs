using UnityEngine;
using System;

public struct ServerGameConfiguration {

	public enum ServerGameMode {

		FFA = 0,
		TDM = 1,
		CTF = 2

	}

	public string mapname;
	public ServerGameMode gamemode;

	public ServerGameConfiguration(string mapName, ServerGameMode gameMode){

		mapname = mapName;
		gamemode = gameMode;

	}

	public bool IsValid(){

		//ToDo: Check with ContentManager to check if map exists
		return true;

	}

}

