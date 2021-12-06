//script ce va fi asociat obiectelor Coin din aplicatie

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public AudioSource collectSound; 

	void OnTriggerEnter(Collider other) //functie apelata in cazul intersectarii jucatorului cu o un obiect Coin
	{
		if(other.gameObject.tag == "Player") //daca jucatorul intersecteaza un obiect Coin
		{	
			//collectSound.Play(); //se declanseaza un efect sonor
			ScoringSystem.theScore += 1; //scorului i se adauga 1 punct
			Destroy(gameObject); //obiectul Coin dispare (a fost colectat)
		}
	}
}