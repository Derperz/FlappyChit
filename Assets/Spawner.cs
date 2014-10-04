using UnityEngine;
using System.Collections;
using System.Timers; 

public class Spawner : MonoBehaviour
{
	public Rigidbody2D Ball;
	public Transform Ceiling;
	float timeLeft = 0f;
	float timeprev=0f;
	int pos;

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}



	void CreateBall() 
	{

		Rigidbody2D BallInstance;
		BallInstance = Instantiate(Ball, new Vector2(Ceiling.position.x, Ceiling.position.y+Random.Range(-4, 7)), Ceiling.rotation) as Rigidbody2D;
		BallInstance.AddForce(Ceiling.right*-1500);
	}
	
	void Update ()
	{ 
		timeLeft += Time.deltaTime;
		if(timeLeft > (timeprev+.5))
		{
			timeprev = timeLeft;
			CreateBall ();
		}

	}
}