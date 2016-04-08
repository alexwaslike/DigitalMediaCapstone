using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

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

    private const float maxTimeSeconds = 60 * 5;
    [SyncVar]
    public float secondsLeft;

    public GameObject HumanHUD;
    public GameObject GhostHUD;

    public Sprite HumanSprite;
    public Sprite GhostSprite;

    public Inventory JournalUI;
	public AddItemUI AddItemUI;
    public LoseUI LoseUI;
    public GameObject GuessUI;

	public TextDatabase TextDatabase;
    public LevelItems LevelItems;

    [SyncVar]
    public string Culprit;
    [SyncVar]
    public string Weapon;
    [SyncVar]
    public string Room;

    void Awake()
    {
        GameData = FindObjectOfType<GameData>();
        MainCamera = FindObjectOfType<Camera>();
    }

	void Start(){

        if (isServer) {
            GenerateDeathScenario();
        }

        if (GameData.PlayerType == PlayerType.Human)
            HumanHUD.SetActive(true);
        else
            GhostHUD.SetActive(true);

        NetworkServer.RegisterHandler(MyMsgType.Highlight, HandleHintMessage);
        NetworkServer.RegisterHandler(MyMsgType.Spawn, HandleSpawnMessage);
        
        FindObjectOfType<NetworkManager>().spawnPrefabs.Add(HighlightPrefab);
        ClientScene.RegisterPrefab(HighlightPrefab);
        FindObjectOfType<NetworkManager>().spawnPrefabs.Add(DresserPrefab);
        ClientScene.RegisterPrefab(DresserPrefab);
    }

    void Update()
    {
        if (isServer)
        {
            secondsLeft -= 1 * Time.deltaTime;
        }
    }

	private void GenerateDeathScenario(){

        if (isServer)
        {
		    int randomCulprit = (int)Random.Range (0, TextDatabase.CharacterDescriptions.Count);
		    int randomWeapon = (int)Random.Range (0, TextDatabase.WeaponDescriptions.Count);
		    int randomRoom = (int)Random.Range (0, TextDatabase.RoomDescriptions.Count);


            Culprit = TextDatabase.GetCharacterList()[randomCulprit];
            Weapon = TextDatabase.GetWeaponList()[randomWeapon];
            Room = TextDatabase.GetRoomList()[randomRoom];

            Debug.Log("name " + Culprit + " weapon " + Weapon + " room " + Room);
        }

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

	public void OpenJournal(){
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
