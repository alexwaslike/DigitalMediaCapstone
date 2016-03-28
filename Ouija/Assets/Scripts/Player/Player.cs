using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(SelfSort))]

public class Player : MonoBehaviour
{

    public GameController GameController;
    public SpriteRenderer SpriteRenderer;

    public Sprite HumanSprite;
    public Sprite GhostSprite;

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

    void Start()
    {
        _journal = new List<Collectible>();
        _health = 100;

        GameController = FindObjectOfType<GameController>();
        GameController.PlayerObj = gameObject;
        GameController.Player = this;

        GetComponent<SelfSort>().GameController = GameController;

        if (GameController.GameData.PlayerType == PlayerType.Human)
            SpriteRenderer.sprite = HumanSprite;
        else
            SpriteRenderer.sprite = GhostSprite;

    }

    public void AddItemToJournal(Collectible item)
    {
        _journal.Add(item);
    }

    public void TakeDamage(float damageAmount)
    {
        if (_health - damageAmount <= 0)
        {
            Death();
        }
        else {
            _health -= damageAmount;
        }
    }

    private void Death()
    {
        GameController.LoseGame();
    }


}