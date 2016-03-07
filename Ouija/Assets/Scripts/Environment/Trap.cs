using UnityEngine;
using System.Collections;

[RequireComponent (typeof (BoxCollider2D))]
public class Trap : MonoBehaviour {

	public Sprite Sprite;
	public BoxCollider2D TriggerArea;
	public float Damage;

}
