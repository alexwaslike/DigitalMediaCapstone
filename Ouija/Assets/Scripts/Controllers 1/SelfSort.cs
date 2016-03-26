using UnityEngine;
using System.Collections;

public class SelfSort : MonoBehaviour {

	public GameController GameController;

	void Start () {
		SetSortingOrder (gameObject);
	}

	public void SetSortingOrder(GameObject obj)
	{
		SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer> ();
		if (spriteRenderer != null && GameController != null) {
			spriteRenderer.sortingOrder = GameController.maxHeight - Mathf.FloorToInt(obj.transform.position.y*4);
		} else
			Debug.LogError ("Sprite Renderer null when attempting to sort object!");
	}
}
