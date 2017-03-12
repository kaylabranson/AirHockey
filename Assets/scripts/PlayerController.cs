using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
//		originalPlayerPos = this.transform.position;
//		originalOpponentPos = GameObject.FindGameObjectWithTag ("opp").transform.position;
		rb = GetComponent<Rigidbody>();
//		myCount = 0;
//		oppCount = 0;
//		SetMyScore ();
//		SetOppScore ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (-moveVertical, 0.0f, moveHorizontal);

		rb.AddForce (movement * speed);
	}
		
		
		
		
}
