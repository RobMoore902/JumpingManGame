using UnityEngine;
using System.Collections;

public class End_game : MonoBehaviour {

	
	public float delayTime = 3;
	
	IEnumerator Start() {
			
		yield return new WaitForSeconds(delayTime);
		
		Application.Quit();
			
	}
}
