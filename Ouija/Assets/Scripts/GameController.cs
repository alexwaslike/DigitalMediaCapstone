using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int maxHeight = 100;
	public int minHeight = 0;
	public bool AllowGameplay;

	public GameObject HumanObj;
	public Human Player;

	public InventoryUI JournalUI;

	public TextDatabase TextDatabase;
	public SpriteDatabase SpriteDatabase;

	private float _timeScale;

	void Start(){
		_timeScale = Time.timeScale;
	}

	public void SetSortingOrder(GameObject obj)
    {
		SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer> ();
		if (spriteRenderer != null) {
			spriteRenderer.sortingOrder = maxHeight - Mathf.FloorToInt(obj.transform.position.y*4);
		} else
			Debug.LogError ("Sprite Renderer null when attempting to sort object!");
	}

	public void PauseGame(bool paused)
	{
		if (paused)
		{
			Time.timeScale = 0.0f;
			HumanObj.GetComponent<CharacterMovement>().enabled = false;
			AllowGameplay = false;
		} else
		{
			Time.timeScale = _timeScale;
			if(HumanObj != null)
				HumanObj.GetComponent<CharacterMovement>().enabled = true;
			AllowGameplay = true;
		}
	}

	public void OpenJournal(){
		JournalUI.gameObject.SetActive (true);
	}

}
