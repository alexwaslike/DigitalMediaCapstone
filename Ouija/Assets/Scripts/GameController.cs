﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int maxHeight = 100;
	public int minHeight = 0;

	public GameObject MainCharacterObj;

	public void SetSortingOrder(GameObject obj)
    {
		SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer> ();
		if (spriteRenderer != null) {
			spriteRenderer.sortingOrder = maxHeight - Mathf.FloorToInt(obj.transform.position.y*4);
		} else
			Debug.LogError ("Sprite Renderer null when attempting to sort object!");
	}

}
