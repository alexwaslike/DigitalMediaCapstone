using UnityEngine;
using System.Collections.Generic; 

public class Ghost : MonoBehaviour {

    public GameController GameController;

    private List<Collectible> _journal;
    public List<Collectible> Journal
    {
        get { return _journal; }
    }

    void Start()
    {
        _journal = new List<Collectible>();
    }

    public void AddItemToJournal(Collectible item)
    {
        _journal.Add(item);
    }
}
