using UnityEngine;
//***********Todo: 1)add items to collectible when notes are initialized. 2) check how it does no server, ensure sync


public class Collectible : MonoBehaviour {

	public AddItemUI AddItemInventory;
	public GameController GameController;

	public Sprite Sprite;
	public string Name;
	public string Description;
    public bool hasNote= false;

    public Collectible ItemToCollect;

	void Start(){
		Sprite = GetComponent<SpriteRenderer> ().sprite;
	}

	void OnMouseUp(){
        AddItemInventory.SelectedCollectible = ItemToCollect;
		GameController.OpenJournal ();
        AddItemInventory.gameObject.SetActive(true);
	}


   public void SetNote(string key)
    {
        Name = key;
        Description = GameController.TextDatabase.GetClueOrNoteValue(key);
        Debug.Log(Random.seed);
    }


}
