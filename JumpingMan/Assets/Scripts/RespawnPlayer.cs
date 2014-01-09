using UnityEngine;
using System.Collections;

public class RespawnPlayer : MonoBehaviour {

private GameObject Character;
public Transform Respawn;


void  OnTriggerEnter ( Collider other  ){
	if(other.tag == "Player")
	{	
		//kill the player
		Destroy(other.gameObject);
		Controller.liveCount -= 1;
		if(Controller.liveCount == 0)
		{
			//reset game stats and return player to splash screen.
			Controller.coinCount = 0;
			Controller.liveCount = 4;
			Application.LoadLevel(0);		
		}
		//create a new player
		GameObject newPlayer = (GameObject)Instantiate(Resources.Load("Character"), Respawn.position, Quaternion.identity);
		newPlayer.tag = "Player";
		//move the target of the camera to the newly created player
		SmoothFollow smooth = Camera.main.GetComponent<SmoothFollow>();
		smooth.target = newPlayer.transform;
	}
}
}
