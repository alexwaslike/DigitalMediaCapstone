using UnityEngine;
using System.Collections.Generic;

[RequireComponent (typeof (CharacterMovement))]

public class Human : MonoBehaviour {

	public GameController GameController;
	public CharacterMovement CharacterMovement;

	private float _health;
	public float Health{
		get{ return _health; }
	}

	private List<Collectible> _journal;
	public List<Collectible> Journal{
		get { return _journal; }
	}

	void Start(){
		_journal = new List<Collectible> ();
		_health = 100;
	}

	public void AddItemToJournal(Collectible item){
		_journal.Add (item);
	}

	public void TakeDamage(float damageAmount){
		if (_health - damageAmount <= 0) {
			Death ();
		} else {
			_health -= damageAmount;
		}
	}

	private void Death(){
		// TODO: this.
	}


}
