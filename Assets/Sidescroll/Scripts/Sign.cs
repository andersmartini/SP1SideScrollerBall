﻿using UnityEngine;
using System.Collections;

public class Sign : MonoBehaviour {

	public GameObject textGO;
		
	void OnTriggerEnter2D (Collider2D other) {
		if(other.CompareTag("Player")) {
			textGO.SetActive(true);
		}
	}

	// Det finns, som ni ser över här, en funktion som heter OnTriggerEnter2D. Det finns även en funktion som heter OnTriggerExit2D. 
	// Skriv en sådan med SetActive(false); för att få skylten att stängas. 

}
