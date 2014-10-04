#pragma strict

var jumpHeight = 5;
var tecla = KeyCode.A;
var derecha = KeyCode.S;
var izquierda = KeyCode.D;

function Update ()
{
	if (Input.GetKeyDown(tecla))
	{
	rigidbody2D.velocity.y = jumpHeight;
	}
	if (Input.GetKeyDown(derecha))
	{
	rigidbody2D.velocity.x = jumpHeight;
	}
	if (Input.GetKeyDown(izquierda))
	{
	rigidbody2D.velocity.x = -jumpHeight;
	}

}

