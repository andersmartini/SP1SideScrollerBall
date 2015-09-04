using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
	Vector2 startPos;
	float speed;
	int touchedLastId;
	Vector2 velocity; 


	// Use this for initialization
	void Start () {
		startPos = transform.position;
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
	}




	void OnTriggerEnter2D (Collider2D other) {
		if(other.CompareTag("Player")){
			touchedLastId = other.gameObject.GetInstanceID();
		}else if(other.CompareTag("Finish")){
			GameObject[] players = FindObjectOfType(PlayerVariables);
			foreach(player in players){
				if(pla)
			}


		}
	}
	public void Respawn () {
		transform.position=startPos;
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f,10f);
		GetComponent<Rigidbody2D>().angularVelocity = 0f;
		//transform.localScale = new Vector3(transform.localScale.x, 1f, 1f);
	}
}
