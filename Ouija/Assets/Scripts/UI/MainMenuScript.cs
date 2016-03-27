using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayHuman()
    {
        SceneManager.LoadScene("PlayerView");
    }

    public void PlayGhost()
    {
        SceneManager.LoadScene("GhostView");
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
