using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;

public class LevelItems : NetworkBehaviour {
    
    public List<Collectible> CollectibleItems;

    public List<string> GetItemNamesList()
    {
        List<string> names = new List<string>();

        if(CollectibleItems != null)
        {
            foreach(Collectible item in CollectibleItems)
            {
                names.Add(item.Name.ToLower());
            }
        }

        return names;
    }

    public Collectible GetItemByName(string name)
    {
        foreach(Collectible item in CollectibleItems)
        {
            if (item.Name.ToLower().Contains(name.ToLower()))
            {
                return item;
            }
        }
        return null;
    }

}
