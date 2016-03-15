using UnityEngine;
using System.Collections;

//@author James Colby Bellard
public class GhostTimer : MonoBehaviour {

    //time from ghost commu
    float delayTimer = 0f;

    //time until the ghost can communicate again.
    float coolDownTimer = 0f;

    //the number coolDown is set to each time cooldown begins
    public const float CoolDownConstant=40f;

    //a string containing the ghost's message to the player.
    string message;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if (delayTimer > 0)
        {
            delayTimer -= Time.deltaTime;
            if (delayTimer <= 0)
            {
                //To add when the function exists: call a function in another script that allows the ghost to input once again.
            }

        }
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
            if (coolDownTimer <= 0)
            {
                //To add when the function exists: call a function in another script that outputs the ghost's response for the player.
                //Said function will accept the string "message" as an argument.
            }
        }
	}


    //This function is called by the function that takes input.
    void sendMessage(string message)
    {
        //begin timers
        coolDownTimer = CoolDownConstant;
        //having cooldownconstant as the max value ensures that messages always arrive in the correct order.
        delayTimer = Random.Range(0, CoolDownConstant);
     }


}


