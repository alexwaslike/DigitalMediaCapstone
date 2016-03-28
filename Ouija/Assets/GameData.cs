using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour {

    public PlayerType PlayerType;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
