using UnityEngine;

public class Collectible : MonoBehaviour {

	public AddItemUI AddItemInventory;
	public GameController GameController;

	public Sprite Sprite;
	public string Name;
	public string Description;

    public Collectible ItemToCollect;

	void Start(){
		Sprite = GetComponent<SpriteRenderer> ().sprite;
	}

	void OnMouseUp(){
        AddItemInventory.SelectedCollectible = ItemToCollect;
		GameController.OpenJournal ();
		AddItemInventory.gameObject.SetActive (true);
	}

}
