using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;


public class LevelItems : NetworkBehaviour {
    
    public List<Collectible> CollectibleItems;
    public Object NotePrefab;
    public GameController GameController;

    private int totalNotes= 22;

    // add 2 clues and 20 notes (all but the first note and the killer's final note)
    public void InitializeCluesAndNotes()
    {
        string culprit = GameController.Culprit;

        //first we handle the clues
        List<string> textList = GameController.TextDatabase.GetClueList();
        string clue1 = culprit + " Clue 1";
        string clue2 = culprit + " Clue 2";
        foreach (string key in textList)
        {
            if (key == clue1 || key == clue2)
            {
                AddNoteToFurniture(key);
            }
        }


        //now we handle the notes
        textList = GameController.TextDatabase.GetNoteList();
        string killerFinalNote = culprit + " Note 4";
        string firstNote = "Louis Prejean Note 1";
        foreach (string key in textList)
        {
            //killer's final note will be omitted so they can use process of elimination to find killer. Louis's first note will be put into the game manually.
            if (key != killerFinalNote && key != firstNote)
            {
                AddNoteToFurniture(key);
            }
        }

    }

    //choose a random child to add the note (or clue) to.
    public void AddNoteToFurniture(string key)
    {
        Random.seed = GameController.Seed;

        //create the note and make it a child of a random piece of furniture
        int rand = (int)Mathf.Round(Random.Range(-.409f, transform.childCount - .501f));
        Transform furniture = transform.GetChild(rand);
        Collectible furnitureCol = furniture.GetComponent<Collectible>();
        if (furnitureCol.hasNote)
        {
            if (transform.childCount >= totalNotes)
            {
                AddNoteToFurniture(key);
            }
        }
        else
        {

            GameObject note = Instantiate(NotePrefab) as GameObject;
            note.transform.parent = furniture;
            Collectible collectibleNote = note.GetComponent<Collectible>();
            furnitureCol.ItemToCollect = collectibleNote;

            furnitureCol.hasNote = true;

            //initialize note values

            collectibleNote.GameController = GameController;
            collectibleNote.SetNote(key);
            
        }
    }

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
