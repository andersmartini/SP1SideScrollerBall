using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if(other.CompareTag("Player")) {
			other.GetComponent<PlayerVariables>().Respawn();
			// Spelaren har en funktion som heter Respawn i scriptet PlayerVariables. Anropa denna funktion för att få spelaren att börja om från sin startposition.

		}
		else {
			Destroy(other);
			// Om det inte är en spelare som kolliderar med denna trigger bör vi ta bort det objektet.

		}
	}
}
