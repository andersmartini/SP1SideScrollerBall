using UnityEngine;
using System.Collections;

public class TossCoinScript : MonoBehaviour {
	float timeToNextCoin;
	
	// Use this for initialization
	void Start () {
	timeToNextCoin = Random.Range(15,30);
	}
	
	// Update is called once per frame
	void Update () {
	timeToNextCoin -= Time.deltaTime;

	}
}
