﻿using UnityEngine;

[RequireComponent (typeof (BoxCollider2D))]
public class Trap : MonoBehaviour {

	public GameController GameController;

	public Sprite Sprite;
	public BoxCollider2D TriggerArea;
	public float Damage;

}
