using UnityEngine;
using System.Collections;

public class GuessUI : MonoBehaviour {

	private string _whoGuess;
	private string _weaponGuess;
	private string _roomGuess;

	public void MakeGuess(){

	}

	public void Exit(){
		gameObject.SetActive (false);
	}


}
