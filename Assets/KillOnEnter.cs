using UnityEngine;
using System.Collections;

public class KillOnEnter : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Destroy(other.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
