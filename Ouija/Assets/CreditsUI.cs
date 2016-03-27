using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsUI : MonoBehaviour {

	public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
