using UnityEngine;
using System.Collections;

public class level1splash : MonoBehaviour {

	
	public float delayTime = 2;
	public int level = 1;
	
	IEnumerator Start() {
			
		yield return new WaitForSeconds(delayTime);
		
		Application.LoadLevel(level);
			
	}
}
