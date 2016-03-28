using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameData GameData;

    public void PlayHuman()
    {
        GameData.PlayerType = PlayerType.Human;
        SceneManager.LoadScene("PlayerView");
    }

    public void PlayGhost()
    {
        GameData.PlayerType = PlayerType.Ghost;
        SceneManager.LoadScene("PlayerView");
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
