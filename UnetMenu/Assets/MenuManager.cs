using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	//0-MAIN, 1-LOGIN, 2-REGISTER, 3-LOADING, 4-GAMEMODE, 5-LAN, 6-LANC
	public int state = 0;
	//These are the GameObjects which are parents of groups of UI elements.
	//The objects are enabled and disabled to show and hide the UI elements.
	public GameObject mainMenuParent;
	public GameObject loginMenuParent;
	public GameObject registerMenuParent;
	public GameObject loadingMenuParent;
	public GameObject gameModeMenuParent;
	public GameObject LANMenuParent;
	public GameObject LANConfigMenuParent;

	void Start () {

	}

	void UpdateMenu(){
		mainMenuParent.SetActive				(state == 0);
		loginMenuParent.SetActive				(state == 1);
		registerMenuParent.SetActive		(state == 2);
		loadingMenuParent.SetActive			(state == 3);
		gameModeMenuParent.SetActive		(state == 4);
		LANMenuParent.SetActive					(state == 5);
		LANConfigMenuParent.SetActive		(state == 6);
	}

	//ButtonsCallbacks

}
