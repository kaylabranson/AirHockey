using System.Collections;
using UnityEngine;

public class OpponentControl : MonoBehaviour {
	public float speed;
	public float skill;
	private Rigidbody rb;



	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float randomX = Random.Range (-15, 15);
		float randomZ = Random.Range(-15,15);
		Vector3 movement = new Vector3 (randomX, 0.0f, randomZ);

		if (Random.value <= .1)
			movement = Vector3.MoveTowards(this.transform.position, GameObject.FindGameObjectWithTag ("puck").transform.position, 30);

		else if (Random.value <= .1)
			movement = Vector3.MoveTowards (this.transform.position, Vector3.zero, 30);
		else if (Random.value <= .1)
			movement = new Vector3 (Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

		rb.AddForce (movement * speed);
	}
}
