using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int speed= 5;
	public float damage = 25f;

	private Transform frontCheck;
	private float facingRight = -1f;
	public LayerMask layerMask;
	
	void Start () {
		frontCheck = transform.Find("FrontCheck");
	}
	
	void Update () {

		transform.Translate(new Vector3(-1f,0f,0f)*speed*Time.deltaTime); // Vilket håll ska detta gameObject åka åt?
		if(Physics2D.OverlapPoint(frontCheck.position, layerMask)){
			facingRight *= -1f;
			transform.localScale = new Vector3(transform.localScale.y * -facingRight, transform.localScale.y, transform.localScale.z);
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if(other.CompareTag("Player")){
			other.GetComponent<PlayerVariables>().Harm(20f);
		}
	}

	public IEnumerator Die(){
		GetComponent<Collider2D>().enabled = false;
		enabled = false;
		GetComponent<Rigidbody2D>().AddForce(new Vector2(2f,13f),ForceMode2D.Impulse);
		transform.localScale = new Vector3(transform.localScale.x, -transform.localScale.y, transform.localScale.z);

		yield return new WaitForSeconds(2);
		Destroy(gameObject);
		
	}
}
