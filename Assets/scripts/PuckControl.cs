using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuckControl : MonoBehaviour 
{
	int myCount; 
	int oppCount;
	public int maxSpeed;
	Rigidbody rb;
	public Text Scores;
	Vector3 originalPlayerPos;
	Vector3 originalOpponentPos;

	// Use this for initialization
	void Start ()
	{
		originalPlayerPos = GameObject.FindGameObjectWithTag ("player").transform.position;
		originalOpponentPos = GameObject.FindGameObjectWithTag ("opp").transform.position;
		myCount = 0;
		oppCount = 0;
		SetScores ();
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		if (rb.velocity.magnitude > maxSpeed)
			rb.velocity = rb.velocity.normalized * maxSpeed;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("playerGoal")) 
		{
			myCount++;
		} 
		else if (other.gameObject.CompareTag ("opponentGoal")) 
		{
			oppCount++;
		}

		SetScores ();
		resetPositions ();

	}
	void resetPositions()
	{
		this.transform.position = Vector3.zero;
		rb.velocity = Vector3.zero;
		GameObject.FindGameObjectWithTag ("player").transform.position = (originalPlayerPos);
		GameObject.FindGameObjectWithTag ("opp").transform.position = (originalOpponentPos);
	}

	void SetScores()
	{
		Scores.text = "Me: " + myCount.ToString () + "\t" + "Enemy: " + oppCount.ToString ();
	}
		
}
