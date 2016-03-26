using UnityEngine;
using System.Collections.Generic;

public class TextDatabase : MonoBehaviour {

	public Dictionary<string, string> WeaponDescriptions = new Dictionary<string, string> {

		{ "Spoon", "An old-ass spoon." },
		{ "Knife", "A tarnished silver kitchen knife with an ornate hilt." },
		{ "Lorenz Rifle", "An old rifle of Austrian design. The barrel is rusted, but it might still fire." },
		{ "Hydrochloric Acid", "A bottle containing a clear corrosive chemical." },
		{ "Rope", "A dirty and frayed piece of rope. It looks like a single tug could rip it apart." },
		{ "Axe Head", "A piece of an old axe now completely rusted over. The rotted remains of the handle are still attached." },
		{ "Bookshelf", "A large shelf of cypress wood lies on the floor. Its books are in surprisingly good condition, but you don’t see anything of interest." },
		{ "Lead Pipe", "A piece of plumbing from an era before people cared about water safety." },
		{ "Chandelier", "A massive chandelier at least six feet wide. Its broken in many places. It must have fell from the ceiling long ago." },
		{ "Bathtub", "An old iron tub. It's still full of a murky brown water." },
		{ "Pillow", "A white pillow with a floral design. It's been expertly stitched together." }

	};

	public Dictionary<string, string> CharacterDescriptions = new Dictionary<string, string> {

		{ "Your Mom", "Yo mamma so fat, she has her own zip code." },
		{ "Donald Trump", "#idkbutnottrump" }

	};

	public Dictionary<string, string> RoomDescriptions = new Dictionary<string, string> {

		{ "Sex Dungeon", "The walls are lined with chains, leather suits, and... furry handcuffs?" },
		{ "Fancy Bathroom", "The fancy French toilet cleans your butt for you." }

	};

    public List<string> GetWeaponList()
    {
        return new List<string>(WeaponDescriptions.Keys);
    }

    public List<string> GetCharacterList()
    {
        return new List<string>(CharacterDescriptions.Keys);
    }

    public List<string> GetRoomList()
    {
        return new List<string>(RoomDescriptions.Keys);
    }


}
