using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour {

	public GameObject Cube;
	public int MoveAmount = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Debug.Log ("right pressed down");
			Cube.transform.position += new Vector3 (-MoveAmount, 0, 0);
		} else {
			Debug.Log ("false");
		}


			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				Debug.Log (" Left Works");
				Cube.transform.position += new Vector3 (MoveAmount, 0, 0);
			} else {
				Debug.Log (" False");

	
				}

			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				Debug.Log ("down works");
				Cube.transform.position += new Vector3 (0, 0, MoveAmount);
			} else {

				Debug.Log ("false");
			}

			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				Debug.Log (" up works");
				Cube.transform.position += new Vector3 (0, 0, -MoveAmount);
			} else {
				Debug.Log (" False");
			}


}

}
