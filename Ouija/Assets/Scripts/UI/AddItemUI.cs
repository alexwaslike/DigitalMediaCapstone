using UnityEngine;

public class AddItemUI : MonoBehaviour {

	public GameController GameController;
	public Collectible SelectedCollectible;
	public Icon SelectedCollectibleIcon;
	public Inventory Inventory;

	void OnEnable(){
		Inventory.IconClicked (SelectedCollectible);
		SelectedCollectibleIcon.Collectible = SelectedCollectible;
		SelectedCollectibleIcon.Inventory = Inventory;
		SelectedCollectibleIcon.Image.sprite = SelectedCollectible.Sprite;
	}

	public void AddItem(){
		GameController.AddItem (SelectedCollectible.GetComponent<Collectible>());
		Exit ();
	}

	public void Exit(){
		Inventory.gameObject.SetActive (false);
		gameObject.SetActive(false);
	}

}
