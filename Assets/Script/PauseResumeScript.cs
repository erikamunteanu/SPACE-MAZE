//script pentru comenzile PAUSE/RESUME/EXIT in cadrul jocului

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseResumeScript : MonoBehaviour
{
 
    public GameObject PauseResume;
	public GameObject Player;
	public GameObject Menu;
 
    bool GamePaused;
 
    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false; 
    }
 
    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown ("p") && GamePaused == false)
         {
             PauseGame(); //la apasarea tastei p, jocul va fi pus pe pauza
		 }
    }
 
    public void PauseGame()
    {
		Time.timeScale = 0;
        GamePaused = true;
		Cursor.lockState = CursorLockMode.None; 
		Cursor.visible = true;
		PauseResume.SetActive(true);
    }
 
    public void ResumeGame()
    {
		Time.timeScale = 1;
        GamePaused = false;
		Cursor.lockState = CursorLockMode.Locked; 
		Cursor.visible = false;
		PauseResume.SetActive(false);
    }

	public void ExitGame()
	{
		Cursor.lockState = CursorLockMode.None; 
		Cursor.visible = true;	
		UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
	}
}
