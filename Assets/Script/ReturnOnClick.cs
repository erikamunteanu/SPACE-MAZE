using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOnClick : MonoBehaviour
{
    public GameObject Logo;
	public GameObject NewGameButton;
	public GameObject InstructionsButton;
	public GameObject QuitButton;
	public GameObject Instructions;

	public void ReturnToMenu() 
	{
		Instructions.SetActive(false);
		Logo.SetActive(true);
		NewGameButton.SetActive(true);
		InstructionsButton.SetActive(true);
		QuitButton.SetActive(true);
	}
}
