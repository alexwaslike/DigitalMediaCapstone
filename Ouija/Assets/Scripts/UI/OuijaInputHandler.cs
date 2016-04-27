using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.IO.Ports;

public class OuijaInputHandler : NetworkBehaviour
{

    public GameController GameController;
    public Text OutputText;
    public Text CooldownText;
    public float MaxInputCooldown = 40.0f;

    private List<string> _objectList;
    private string _input;
    private float _inputCooldown;
    private bool _cooldownFinished;



    void Start()
    {
        _objectList = GameController.LevelItems.GetItemNamesList();
        _inputCooldown = MaxInputCooldown;
        
    }

    void Update()
    {
    
        if (!_cooldownFinished)
        {
            _inputCooldown = _inputCooldown - 1 * Time.deltaTime;
            CooldownText.text = ((int)_inputCooldown).ToString();
        }
        if (_inputCooldown <= 0)
        {
            _cooldownFinished = true;
        }

        // FOR TEST PURPOSES - KEYBOARD INPUT
        if (Input.anyKeyDown)
        {
            if (Input.GetAxis("Submit") > 0 && _cooldownFinished)
            {
                _input = OutputText.text + "_";
                OutputText.text = "";
                SubmitItemName();
            }
            else
            {
                OutputText.text += Input.inputString;
            }

        }

    }
    

    public void AddToText(string toAdd)
    {
        OutputText.text += toAdd;
    }

    public void SendBoardMessage(string message)
    {
        //for the actual ouija board

            if (((Input.GetAxis("Submit") > 0) || message == ";"))
            {
                _input = OutputText.text + "_";
                OutputText.text = "";
                SubmitItemName();
            }
            else
            {
                OutputText.text += Input.inputString;
            }
    }


    private void SubmitItemName()
    {
        _cooldownFinished = false;
        _inputCooldown = MaxInputCooldown;

        _input = _input.ToLower();

        if (_objectList.Contains(_input))
        {

            GameController.Ghost.GetComponent<Player>().HighlightItem(_input);
        }
        else
        {
            GameController.Ghost.GetComponent<Player>().BoardMove(_input);
        }

    }





}