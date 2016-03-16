using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayHuman()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayGhost()
    {
        SceneManager.LoadScene("GhostGame");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Exit()
    {
        Application.Quit();
    }
	
}
