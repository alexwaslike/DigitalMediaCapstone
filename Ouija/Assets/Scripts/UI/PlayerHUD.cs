using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour {

    public Text timerText;

    public void UpdateTimerText(float timeLeft)
    {
        timerText.text = timeLeft.ToString();
    }
}
