using UnityEngine;
using System.Collections.Generic;

public class TextDatabase : MonoBehaviour
{

    public Dictionary<string, string> WeaponDescriptions = new Dictionary<string, string> {

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
        { "Donald Drumpf", "#idkbutnottrump" }

    };

    public Dictionary<string, string> RoomDescriptions = new Dictionary<string, string> {

        { "Sex Dungeon", "The walls are lined with chains, leather suits, and... furry handcuffs?" },
        { "Fancy Bathroom", "The fancy French toilet cleans your butt for you." }

    };

    public Dictionary<string, string> Clues = new Dictionary<string, string> {


        {"Adam Clue 1", "Evidence #1 \nCase: 342 \nEntrant: Adam Abrams\nDescription: REDACTED.\n"},

        {"Adam Clue 2", "Evidence #2 \nCase: 342 \nEntrant: Adam Abrams\n" +
            "Description:  fingerprints found at the crime scene.\n" +
            "UPDATE: It appears these are actually palm prints which would not be in the database.\n"},

        { "Bernard Clue 1", "Evidence #3 \nCase: 342 \nEntrant: Adam Abrams\n" +
            "Description: A list of chemicals including Hydrochloric Acid.\n"},

        { "Bernard Clue 2", "Evidence #4 \nCase: 342 \nEntrant: Adam Abrams\n" +
            "Description: an arm found dismembered cleanly, more cleanly than I’ve ever seen in a murder case before.\n"},

        {"Gina Clue 1", "Evidence #5 \nCase: 342 \nEntrant: Adam Abrams\n Description: A strand of long dark hair found on the body.\n"
         },

        {"Gina Clue 2", "Evidence #6 \nCase: 342 \nEntrant: Adam Abrams\n Description: The body was burned in an attempted cremation along with a large amount of cash.\n"
        },

        {"Augustine Clue 1", "Evidence #7 \nCase: 342 \nEntrant: Adam Abrams\n Description: A strand of short dark hair found on the body.\n"
        },

        {"Augustine Clue 2", "Evidence #8 \nCase: 342 \nEntrant: Adam Abrams\n Description: The body shows heavy bruising after time of death.\n"
        },

        {"Claudia Clue 1", "Evidence #9 \nCase: 342 \nEntrant: Adam Abrams\n Description: A strange marking on  the body.\n"
        },

        {"Claudia Clue 2", "Evidence #10 \nCase: 342 \nEntrant: Adam Abrams\n Description: A queer black substance."+
            " It is neither solid nor liquid. If only I could file it away and never need look at it again.\n"
        },


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

    public List<string> GetClueList()
    {
        return new List<string>(Clues.Keys);
    }

}
