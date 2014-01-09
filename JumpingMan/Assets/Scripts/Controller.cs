using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public static int coinCount = 0;
	public static int liveCount = 4;
	public int level = 1;
	
	void OnGUI()
	{
		string coinText = "Coins: " + coinCount + "/10";
		string liveText = "Lives: " + liveCount;
		
		GUI.Box(new Rect(Screen.width - 150,20,130,20), coinText);
		GUI.Box(new Rect(Screen.width-300,20,130,20), liveText);
		
		if(Controller.coinCount == 10)
		{
			Controller.coinCount = 0;
			Application.LoadLevel(this.level);
		}
	}
}
