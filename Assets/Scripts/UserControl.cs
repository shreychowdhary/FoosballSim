using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour {

	public GameObject goalieRod;

	public float slideFactor;
	public float rotateFactor;

	private float horizontal, vertical;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		horizontal = Input.GetAxis("Horizontal");
		vertical = Input.GetAxis("Vertical");
		

	}

	void FixedUpdate () {
		Vector3 targetPos = new Vector3(goalieRod.transform.position.x+vertical*slideFactor*Time.fixedDeltaTime, goalieRod.transform.position.y, goalieRod.transform.position.z);
		goalieRod.transform.position = Vector3.MoveTowards(goalieRod.transform.position, targetPos, Time.fixedDeltaTime * slideFactor);
		goalieRod.transform.Rotate(transform.parent.up*horizontal*rotateFactor*Time.fixedDeltaTime);
	}
}
