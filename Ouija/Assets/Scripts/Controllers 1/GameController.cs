using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int maxHeight = 100;
	public int minHeight = 0;
	public bool AllowGameplay;

	public GameObject HumanObj;
	public Human Player;

	public Inventory JournalUI;
	public AddItemUI AddItemUI;

    public GameObject GuessUI;

	public TextDatabase TextDatabase;
	public SpriteDatabase SpriteDatabase;

	private float _timeScale;

	void Start(){
		_timeScale = Time.timeScale;
	}

	public void PauseGame(bool paused)
	{
		if (paused)
		{
			Time.timeScale = 0.0f;
			HumanObj.GetComponent<CharacterMovement>().enabled = false;
			AllowGameplay = false;
		} else
		{
			Time.timeScale = _timeScale;
			if(HumanObj != null)
				HumanObj.GetComponent<CharacterMovement>().enabled = true;
			AllowGameplay = true;
		}
	}

	public void OpenJournal(){
		JournalUI.gameObject.SetActive (true);
	}

	public void AddItem(Collectible item){
		Player.AddItemToJournal (item);
		JournalUI.AddNewItem (item);
		AddItemUI.gameObject.SetActive (false);
		JournalUI.Exit ();
	}

    public void MakeAGuess()
    {
        GuessUI.SetActive(true);
    }

}
