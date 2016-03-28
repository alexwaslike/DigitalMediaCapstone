using UnityEngine;

public class GameData : MonoBehaviour {

    public PlayerType PlayerType;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
