﻿using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetUp : NetworkBehaviour {
	[SerializeField]
	Behaviour[] componentsToDisable;

	void Start(){
		if(!isLocalPlayer){
			for(int i=0;i<componentsToDisable.Length;i++){
				componentsToDisable[i].enabled = false;
			}
			
	}
	}	
}
