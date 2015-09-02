﻿using UnityEngine;
using System.Collections;

public class Pauser : MonoBehaviour {

	private bool paused = false;
	
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape)){
			paused = !paused;
		}

		if(paused) { 
			Time.timeScale = 0;
		}
		else {
			Time.timeScale = 1;
		}
	}
}
