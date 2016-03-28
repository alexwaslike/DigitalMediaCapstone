using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public int maxHeight = 100;
	public int minHeight = 0;
	public bool AllowGameplay;

    public GameData GameData;

	public GameObject PlayerObj;
	public Player Player;

    public GameObject HumanHUD;
    public GameObject GhostHUD;

	public Inventory JournalUI;
	public AddItemUI AddItemUI;
    public LoseUI LoseUI;
    public GameObject GuessUI;

	public TextDatabase TextDatabase;
    public LevelItems LevelItems;

	private string _culprit;
	public string Culprit{
		get {return _culprit;}
	}

	private string _weapon;
	public string Weapon{
		get {return _weapon;}
	}

	private string _room;
	public string Room{
		get {return _room;}
	}

	private float _timeScale;

	void Start(){

        GameData = FindObjectOfType<GameData>();

		_timeScale = Time.timeScale;

		GenerateDeathScenario ();

        if (GameData.PlayerType == PlayerType.Human)
            HumanHUD.SetActive(true);
        else
            GhostHUD.SetActive(true);

	}

	private void GenerateDeathScenario(){

		int randomCulprit = (int)Random.Range (0, TextDatabase.CharacterDescriptions.Count);
		int randomWeapon = (int)Random.Range (0, TextDatabase.WeaponDescriptions.Count);
		int randomRoom = (int)Random.Range (0, TextDatabase.RoomDescriptions.Count);


        _culprit = TextDatabase.GetCharacterList()[randomCulprit];
        _weapon = TextDatabase.GetWeaponList()[randomWeapon];
        _room = TextDatabase.GetRoomList()[randomRoom];

        Debug.Log("name " + _culprit + " weapon " + _weapon + " room " + _room );

	}

	public void PauseGame(bool paused)
	{
		if (paused)
		{
			Time.timeScale = 0.0f;
            if (PlayerObj != null)
                PlayerObj.GetComponent<CharacterMovement>().enabled = false;
			AllowGameplay = false;
		} else
		{
			Time.timeScale = _timeScale;
            if (PlayerObj != null)
                PlayerObj.GetComponent<CharacterMovement>().enabled = true;
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

    public void WinGame()
    {
        // TODO: once player and ghost interaction complete,
        // and networking prototype made,
        // need to have player tell ghost that game is done
        // and display "win" screen on both
    }

    public void LoseGame()
    {
        LoseUI.gameObject.SetActive(true);
    }

}
