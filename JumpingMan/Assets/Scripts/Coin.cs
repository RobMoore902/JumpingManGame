using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

void  OnTriggerEnter ( Collider other  ){
	if(other.tag == "Player")
	{	
		Destroy(this.gameObject);
		//increment count. 
		//if count == 10 load next level.
	}
}
}
