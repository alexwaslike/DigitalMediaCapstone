using UnityEngine;
using System.Collections;

public class SelfSort : MonoBehaviour {

	public GameController GameController;

	void Start () {
		GameController.SetSortingOrder (gameObject);
	}

}
