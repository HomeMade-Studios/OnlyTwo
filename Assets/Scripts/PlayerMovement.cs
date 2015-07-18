using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	

	void Update () {
		Move ();
	}

	void Move () {
		transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
	}
}
