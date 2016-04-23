using UnityEngine;
using System.Collections;

public class SelfSort : MonoBehaviour {

	public GameController GameController;

	void Start () {
		SetSortingOrder ();
	}

	public void SetSortingOrder()
	{
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null && GameController != null)
        {
            spriteRenderer.sortingOrder = GameController.maxHeight - Mathf.FloorToInt(transform.position.y * 4);
        }
        else Debug.Log("Sprite Renderer or GameController null when attempting to layer sort!");
	}
}
