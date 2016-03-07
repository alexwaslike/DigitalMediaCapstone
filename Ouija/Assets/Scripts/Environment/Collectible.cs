using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {

	public AddItemUI AddItemInventory;
	public GameController GameController;

	public Sprite Sprite;
	public string Name;
	public string Description;

	void Start(){
		Sprite = GetComponent<SpriteRenderer> ().sprite;
	}

	void OnMouseUp(){
		AddItemInventory.SelectedCollectible = this;
		GameController.OpenJournal ();
		AddItemInventory.gameObject.SetActive (true);
	}

}
