using UnityEngine;
using System.Collections;

public class TextureFlip : MonoBehaviour {


float X;

void  Start (){
	//Capture the default direction character is facing.
	X = transform.localScale.x;
}

void  Update (){
	if(Input.GetKey("a")){
		//Make character face to the left when a is pressed
		Vector3 pos = transform.localScale;
		pos.x = X;
		transform.localScale = pos;
	}else if (Input.GetKey("d")){
		//Make character face to the right when d is pressed
		Vector3 pos = transform.localScale;
		pos.x = -X;
		transform.localScale = pos;
	}
}
}