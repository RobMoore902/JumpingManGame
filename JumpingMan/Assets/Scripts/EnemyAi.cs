// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour {
	Transform target; //the enemy's target
	Random random = new Random();
	public int moveSpeed= 5; //move speed
	int rotationSpeed= 3; //speed of turning
	bool seenPlayer = false;
	 
	Transform myTransform; //current transform data of this enemy
	 
	void  Awake (){
	    myTransform = transform;
	}
	 
	void  Update (){
		
	    //rotate to look at the player
		target = GameObject.FindWithTag("Player").transform;
		
		var dist = Vector3.Distance(target.position, myTransform.position);
		
		if(dist < 15){
			seenPlayer = true;
		}
		if(seenPlayer){	
		   	myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;  
		}
	}
}
