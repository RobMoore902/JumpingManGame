using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {


GameObject Character;
Transform RespawnPoint;


void  OnTriggerEnter ( Collider other  ){
	Destroy(other.gameObject);
	GameObject newPlayer = (GameObject)Instantiate(Character, RespawnPoint.position, Quaternion.identity);
	SmoothFollow smooth = Camera.main.GetComponent<SmoothFollow>();
	smooth.target = newPlayer.transform;
}
}