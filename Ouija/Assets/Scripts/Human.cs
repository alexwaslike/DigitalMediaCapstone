using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterMovement))]

public class Human : MonoBehaviour {

	public GameController GameController;
	public CharacterMovement CharacterMovement;

	void Start(){

		GameController.SetSortingOrder (gameObject);

	}


}
