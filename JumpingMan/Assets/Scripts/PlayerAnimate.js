#pragma strict

var AT;

function Start () {

}

//Add in extra movements here.
function Update () {
	var AT = gameObject.GetComponent(AnimateTexture);
	if(Input.GetKey("a")){//Player moves left
		AT.rowNumber = 1;//Changes to running animation
	} else if(Input.GetKey("d")){//Player moves right.
		AT.rowNumber = 1;//Changes to running animation
	} else {//Player is not moving
		AT.rowNumber = 0;//Changes to idle animation
	}
}