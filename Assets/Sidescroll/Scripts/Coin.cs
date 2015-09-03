using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	float timeToExpire=5;
	public void Start(){

	}
	public void Update(){
		timeToExpire-=Time.deltaTime;
		if(timeToExpire<=0){
			Destroy(this);
		}
	}
}
