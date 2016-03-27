using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour {

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }



}
