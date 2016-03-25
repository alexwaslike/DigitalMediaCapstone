using UnityEngine;
using System.Collections;

public class PitTrap : Trap{

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.GetComponent<Human>() != null)
			GameController.Player.TakeDamage (Damage);
	}

}
