using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
	public GameObject scoreText;
	public static int theScore;
	public static int maxCoins = 8; //numarul maxim de obiecte Coin ce poate fi colectat

	void Update()
	{
		scoreText.GetComponent<Text>().text = "SCORE: " + theScore + " / " + maxCoins; //afisarea scorului pe ecran
	}
}
