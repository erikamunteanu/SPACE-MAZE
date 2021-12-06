using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewGameOnClick : MonoBehaviour 
{
	public GameObject Player;
	public GameObject MainMenu;
	public GameObject Timer;
	public GameObject Score;

    public void LoadByName(string SceneName)
    {
		MainMenu.SetActive(false);
		Player.SetActive(true);
		Timer.SetActive(true);
		Score.SetActive(true);
	}
}