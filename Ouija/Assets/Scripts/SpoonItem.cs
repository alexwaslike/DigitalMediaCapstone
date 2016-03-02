using UnityEngine;
using System.Collections;

public class SpoonItem : Item {


	void Start () {

		Name = "Spoon";
		Description = GameController.TextDatabase.ItemDescriptions[Name];
		Icon = GameController.SpriteDatabase.sprite_Spoon;

	}
	

}
