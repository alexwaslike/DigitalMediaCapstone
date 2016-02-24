using UnityEngine;
using System.Collections;

public class EnvObject : MonoBehaviour {

	public GameController GameController;

	void Start(){

		GameController.SetSortingOrder (gameObject);

	}
}
