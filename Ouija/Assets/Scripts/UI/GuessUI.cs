using UnityEngine;
using UnityEngine.UI; 

public class GuessUI : MonoBehaviour {

    public GameController GameController;

    public InputField WhoInput;
    public InputField WeaponInput;
    public InputField RoomInput;

    public Text WhoFeedback;
    public Text WhereFeedback;
    public Text WhatFeedback;

    private string _positiveFeedback = "Correct!";
    private string _negativeFeedback = "WRONG";

	private string _whoGuess;
	private string _weaponGuess;
	private string _roomGuess;
   

	public void MakeGuess(){

        bool allCorrect = true;

        _whoGuess = WhoInput.text.ToLower();
        if (!GameController.Culprit.ToLower().Contains(_whoGuess))
        {
            allCorrect = false;
            WhoFeedback.gameObject.SetActive(true);
            WhoFeedback.text = _negativeFeedback;
        }
        else
        {
            WhoFeedback.text = _positiveFeedback;
        }
        
        _weaponGuess = WeaponInput.text.ToLower();
        if (!GameController.Weapon.ToLower().Contains(_weaponGuess))
        {
            allCorrect = false;
            WhatFeedback.gameObject.SetActive(true);
            WhatFeedback.text = _negativeFeedback;
        }
        else
        {
            WhatFeedback.text = _positiveFeedback;
        }

        _roomGuess = RoomInput.text.ToLower();
        if (!GameController.Room.ToLower().Contains(_roomGuess))
        {
            allCorrect = false;
            WhereFeedback.gameObject.SetActive(true);
            WhereFeedback.text = _negativeFeedback;
        }
        else
        {
            WhereFeedback.text = _positiveFeedback;
        }

        if (allCorrect)
            GameController.WinGame();

    }

	public void Exit(){

        WhoFeedback.gameObject.SetActive(false);
        WhereFeedback.gameObject.SetActive(false);
        WhatFeedback.gameObject.SetActive(false);

		gameObject.SetActive (false);
	}


}
