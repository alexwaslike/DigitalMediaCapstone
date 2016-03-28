using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(SelfSort))]

public class Player : NetworkBehaviour
{
    private NetworkClient m_client;
    private const short _myMsg = 1002;

    public GameController GameController;
    public SpriteRenderer SpriteRenderer;

    private float _health;
    public float Health
    {
        get { return _health; }
    }

    private List<Collectible> _journal;
    public List<Collectible> Journal
    {
        get { return _journal; }
    }

    public override void OnStartLocalPlayer()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();

        GameController = FindObjectOfType<GameController>();
        GetComponent<SelfSort>().GameController = GameController;

        if (GameController.GameData.PlayerType == PlayerType.Human)
        {
            GameController.Human = gameObject;
        }
        else
        {
            GameController.Ghost = gameObject;
        }

         _journal = new List<Collectible>();
        _health = 100;

        GameController.PlayerLoadedClient();

        Debug.Log("player loaded on client: " + GameController.GameData.PlayerType);
        var message = new SpawnMessage();
        message.Player = gameObject;
        message.PlayerType = GameController.GameData.PlayerType;
        connectionToServer.Send(_myMsg, message);

    }

    public void AddItemToJournal(Collectible item)
    {
        if(isLocalPlayer)
            _journal.Add(item);
    }

    public void TakeDamage(float damageAmount)
    {
        if (isLocalPlayer)
        {
            if (_health - damageAmount <= 0)
                Death();
            else
                _health -= damageAmount;
        }
    }

    private void Death()
    {
        GameController.LoseGame();
    }


}