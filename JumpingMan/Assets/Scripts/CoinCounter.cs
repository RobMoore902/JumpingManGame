using UnityEngine;
using System.Collections;

public class CoinCounter : MonoBehaviour {
	
	void  OnTriggerEnter ( Collider other  ){
		if(other.tag == "Coin")
		{
			Controller.coinCount ++;
		}
	}
}
