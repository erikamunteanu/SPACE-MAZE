using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsOnClick : MonoBehaviour
{
    public GameObject Logo;
	public GameObject NewGameButton;
	public GameObject InstructionsButton;
	public GameObject QuitButton;
	public GameObject Instructions;

	public void LoadInstructions() 
	{
		Logo.SetActive(false);
		NewGameButton.SetActive(false);
		InstructionsButton.SetActive(false);
		QuitButton.SetActive(false);
		Instructions.SetActive(true);
	}
}
