using UnityEngine;
using System.Collections.Generic;

[RequireComponent (typeof (CharacterMovement))]

public class Human : MonoBehaviour {

	public GameController GameController;
	public CharacterMovement CharacterMovement;

	private List<Item> _journal;
	public List<Item> Journal{
		get { return _journal; }
	}

	void Start(){
		_journal = new List<Item> ();
	}

	void Update(){
		GameController.SetSortingOrder (gameObject);
	}

	public void AddItemToJournal(Item item){
		_journal.Add (item);
	}


}
