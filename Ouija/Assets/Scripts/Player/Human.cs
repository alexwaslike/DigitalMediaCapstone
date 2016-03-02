using UnityEngine;
using System.Collections.Generic;

[RequireComponent (typeof (CharacterMovement))]

public class Human : MonoBehaviour {

	public GameController GameController;
	public CharacterMovement CharacterMovement;

	private List<Collectible> _journal;
	public List<Collectible> Journal{
		get { return _journal; }
	}

	void Start(){
		_journal = new List<Collectible> ();
	}

	public void AddItemToJournal(Collectible item){
		_journal.Add (item);
	}


}
