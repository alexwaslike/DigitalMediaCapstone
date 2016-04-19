using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlanchetteMove : MonoBehaviour
{
    Vector3 target;
    Vector3 startPos;
    CanvasScaler scaler;

    string moveTo = "";
    string stringBuffer = "";

    bool moving = false;
    bool inProgress = false;

    float startTime = 1.0f;
    float timer;
    public float speed = 444.4f;
    public Transform board;

    // Use this for initialization
    void Start()
    {
        timer = startTime;
        startPos = transform.position;
        target = startPos;
        scaler = GetComponentInParent<CanvasScaler>();

    }

    // Update is called once per frame
    void Update()
    {
        attemptToMove();
    }
 
   


    //to be called from another function to start movement.
    public void movePlanchette(string str)
    {
        stringBuffer += str;
        if (!moving)
        {
            target = getLetterPosition();
            moving = true;
        }
    }

    //called each update
    void attemptToMove()
    {
        if (moving && !inProgress && timer<0f)
        {
            inProgress = true;
            Vector3 dir = target - transform.position;
            dir = new Vector3(dir.x * speed, dir.y * speed, dir.z * speed);
            if (Mathf.Abs(dir.x) <= 1 && Mathf.Abs(dir.y) <= 1)
            {
                if (stringBuffer != "")
                {
                    target = getLetterPosition();
                    timer = startTime;
                }
                else
                {
                    moving = false;
                }
            }
            else 
            {
                transform.Translate(dir * Time.deltaTime);
            }
            inProgress = false;
        }
        else
        {

            timer = timer - Time.deltaTime;
        }

    }


    //returns position of next letter
    Vector3 getLetterPosition()
    {
        moveTo="" + stringBuffer[0];
        moveTo = moveTo.ToUpper();
        stringBuffer = stringBuffer.Remove(0, 1);
        Vector3 letterPos = startPos;

        Transform childOfBoard = board.FindChild(moveTo);
		if (childOfBoard == null) 
		{
			return (target);
		} 
		else 
		{
			letterPos = childOfBoard.position;

			return(letterPos);
		}
    }




}
