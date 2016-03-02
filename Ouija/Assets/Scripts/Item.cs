using UnityEngine;
using System.Collections;

[RequireComponent (typeof(BoxCollider2D))]
public class Item : MonoBehaviour {

	public GameController GameController;

	public string Name;
	public string Description;
	public Sprite Icon;

	void OnMouseUp(){
		GameController.Player.AddItemToJournal (this);
	}

}
