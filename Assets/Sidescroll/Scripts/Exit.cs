using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	public GameObject particle1, particle2;

	void OnTriggerEnter2D (Collider2D other) {
		if(other.CompareTag("Ball")) {
			other.gameObject.GetComponent<BallScript>().Respawn();
		}
	}
}
