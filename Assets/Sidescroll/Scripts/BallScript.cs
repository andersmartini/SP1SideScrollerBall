using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
	Vector2 startPos;
	float speed;

	Vector2 velocity; 


	// Use this for initialization
	void Start () {
		startPos = transform.position;
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {

	/*	IEnumerator OnTriggerEnter2D (Collider2D other) {
			if(other.CompareTag("Finnish")){
				this.Respawn();
			}
		}*/
		}

	public void Respawn () {
		transform.position=startPos;
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f,5f);
		transform.localScale = new Vector3(transform.localScale.x, 1f, 1f);
	}
}
