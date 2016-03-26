using UnityEngine;
using System.Collections.Generic;

public class LevelItems : MonoBehaviour {

    public List<Collectible> LevelObjects;

    public List<string> GetItemNamesList()
    {
        List<string> names = new List<string>();

        if(LevelObjects != null)
        {
            foreach(Collectible item in LevelObjects)
            {
                names.Add(item.Name.ToLower());
            }
        }

        return names;
    }

    public Collectible GetItemByName(string name)
    {
        foreach(Collectible item in LevelObjects)
        {
            if (item.Name.ToLower().Equals(name.ToLower()))
            {
                return item;
            }
        }
        return null;
    }

}
