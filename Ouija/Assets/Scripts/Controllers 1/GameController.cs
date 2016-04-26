using UnityEngine;
using UnityEngine.Networking;

public class GameController : NetworkBehaviour {

	public int maxHeight = 100;
	public int minHeight = 0;

    public GameData GameData;

    public Camera MainCamera;

    public GameObject HighlightPrefab;
    public GameObject DresserPrefab;

    [SyncVar]
    public GameObject Human;
    [SyncVar]
    public GameObject Ghost;

    private const float _maxTimeSeconds = 500;
    [SyncVar]
    public float SecondsLeft;
    public bool GameplayEnabled;

    public GameObject HumanHUD;
    public GameObject GhostHUD;
    public GameObject Planchette;

    public Sprite HumanSprite;
    public Sprite GhostSprite;

    public Inventory JournalUI;
	public AddItemUI AddItemUI;
    public LoseUI LoseUI;
    public LoseUI WinUI;
    public GameObject GuessUI;

	public TextDatabase TextDatabase;
 
    public LevelItems LevelItems;

    public string Culprit;
    public string Weapon;
    public string Room;
    [SyncVar]
    public int Seed=0;
    private bool spawnedNotes;

    void Awake()
    {
        GameData = FindObjectOfType<GameData>();
        GameplayEnabled = true;
    }

	void Start(){
        if (isServer) {
            GenerateDeathScenario();
            SecondsLeft = _maxTimeSeconds;
        }

        if (GameData.PlayerType == PlayerType.Human)
            HumanHUD.SetActive(true);
        else
            GhostHUD.SetActive(true);

        NetworkServer.RegisterHandler(MyMsgType.Highlight, HandleHintMessage);
        NetworkServer.RegisterHandler(MyMsgType.Spawn, HandleSpawnMessage);
        NetworkServer.RegisterHandler(MyMsgType.BoardMove, HandleBoardMessage);

        FindObjectOfType<NetworkManager>().spawnPrefabs.Add(HighlightPrefab);
        ClientScene.RegisterPrefab(HighlightPrefab);
        FindObjectOfType<NetworkManager>().spawnPrefabs.Add(DresserPrefab);
        ClientScene.RegisterPrefab(DresserPrefab);
    }

    void Update()
    {
        if (isServer)
        {
            if(Ghost != null && Human != null && SecondsLeft > 0)
            {
                SecondsLeft -= 1 * Time.deltaTime;
            }
        }
        else
        {
           if (Seed!=0 && (!spawnedNotes))
            {
                spawnedNotes = true;
                ScenarioGen();
            }
        }

        if (SecondsLeft <= 0)
            LoseGame();
        else
            GhostHUD.GetComponent<PlayerHUD>().UpdateTimerText(SecondsLeft);
            HumanHUD.GetComponent<PlayerHUD>().UpdateTimerText(SecondsLeft);
    }

	private void GenerateDeathScenario(){

        if (isServer)
        {
            Seed = (int)Random.Range(-99999999, 99999999);
            Random.seed = Random.seed;
            ScenarioGen();
        } 
    }

    private void ScenarioGen()
    {
        int randomCulprit = (int)Random.Range(0, TextDatabase.CharacterDescriptions.Count);
        int randomWeapon = (int)Random.Range(0, TextDatabase.WeaponDescriptions.Count);
        int randomRoom = (int)Random.Range(0, TextDatabase.RoomDescriptions.Count);


        Culprit = TextDatabase.GetCharacterList()[randomCulprit];
        Weapon = TextDatabase.GetWeaponList()[randomWeapon];
        Room = TextDatabase.GetRoomList()[randomRoom];

        Debug.Log("name " + Culprit + " weapon " + Weapon + " room " + Room);

        LevelItems.InitializeCluesAndNotes();
    }

    public void PlayerLoadedClient()
    {
        if (Ghost != null)
            Ghost.GetComponent<SpriteRenderer>().sprite = GhostSprite;
        if (Human != null)
            Human.GetComponent<SpriteRenderer>().sprite = HumanSprite;
    }

    public void HandleHintMessage(NetworkMessage netMsg)
    {

        var hintMsg = netMsg.ReadMessage<HintMessage>();

        string itemName = hintMsg.ObjectToHighlight;

        Collectible item = LevelItems.GetItemByName(itemName);
        var highlight = (GameObject)Instantiate(HighlightPrefab, Vector3.zero, Quaternion.identity);
        highlight.transform.SetParent(item.transform, false);
        NetworkServer.Spawn(highlight);

    }

    public void HandleSpawnMessage(NetworkMessage netMsg)
    {
        var spawnMsg = netMsg.ReadMessage<SpawnMessage>();
        
        Debug.Log("player loaded on server: " + spawnMsg.PlayerType);

        if (spawnMsg.PlayerType == PlayerType.Ghost)
        {
            Ghost = spawnMsg.Player;
            Ghost.GetComponent<SpriteRenderer>().sprite = GhostSprite;
        }
        else
        {
            Human = spawnMsg.Player;
            Human.GetComponent<SpriteRenderer>().sprite = HumanSprite;
        }
        
    }

    public void HandleBoardMessage(NetworkMessage netMsg)
    {
        var boardMsg = netMsg.ReadMessage<HintMessage>();
        Planchette.GetComponent<PlanchetteMove>().movePlanchette(boardMsg.textMessage);
    }

	public void OpenJournal(){
        if (GameplayEnabled)
            JournalUI.gameObject.SetActive (true);
	}

	public void AddItem(Collectible item){
        if (GameData.PlayerType == PlayerType.Human)
            Human.GetComponent<Player>().AddItemToJournal(item);
        else
            Ghost.GetComponent<Player>().AddItemToJournal(item);
		JournalUI.AddNewItem (item);
		AddItemUI.gameObject.SetActive (false);
		JournalUI.Exit ();
	}

    public void MakeAGuess()
    {
        if(GameplayEnabled)
            GuessUI.SetActive(true);
    }

    public void WinGame()
    {
        DisableGameplay();
        WinUI.gameObject.SetActive(true);
    }

    public void LoseGame()
    {
        MainCamera.transform.SetParent(null);
        DisableGameplay();
        LoseUI.gameObject.SetActive(true);
    }

    private void DisableGameplay()
    {
        GameplayEnabled = false;
        Human.GetComponent<CharacterMovement>().enabled = false;
        if(Ghost != null)
            Ghost.GetComponent<CharacterMovement>().enabled = false;
        Human.GetComponent<Player>().enabled = false;
        if (Ghost != null)
            Ghost.GetComponent<Player>().enabled = false;
    }

}
