using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuckControl : MonoBehaviour 
{
	int myCount; 
	int oppCount;
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
		GameObject.FindGameObjectWithTag ("player").transform.position = (originalPlayerPos);
		GameObject.FindGameObjectWithTag ("opp").transform.position = (originalOpponentPos);
	}

	void SetScores()
	{
		Scores.text = "Me: " + myCount.ToString () + "\t" + "Enemy: " + oppCount.ToString ();
	}
		
}
