using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GuessUIScript : MonoBehaviour
{
    public Text WhoInput;
    private bool WhoGuess;

    public Text WhereInput;
    private bool WhereGuess;

    public Text WhatInput;
    private bool WhatGuess;
    
    private string WhoGuessString;
    private string WhereGuessString;
    private string WhatGuessString;

    private string[] WhoList;
    private string[] WhatList;
    private string[] WhereList;

    private int i = 0;
    private int length;

    void Start()
    {
        //initialize or set lists here.
        WhoList = new string[3];
        WhoList[0] = "apple";
        WhereList = new string[3];
        WhereList[0] = "apple";
        WhatList = new string[3];
        WhatList[0] = "apple";
    }

    //takes the guess from the who input field and checks to see if its a valid answer. 
    //the game will prompt the player if an answer is invalid and will let the player know if an answer is valid.
    public void GuessWho()
    {
        WhoGuessString = WhoInput.text.ToString();


        while (WhoGuess==false)
        {
            if (i>=2)
            {
                //text box will be set to try again
                i = 0;
                break;
            }
            if(!WhoGuessString.Equals(WhoList[i]))
            {
                
                i++;
                
            }
            else
            {
                WhoGuess = true;
                
            }
        }
    }

    public void GuessWhere()
    {
        WhereGuessString = WhereInput.text.ToString();
        while (WhereGuess == false)
        {
            if (i>=WhereList.Length)
            {
                //text box will be set to try again
                i = 0;
                break;
            }
            if (!WhereGuessString.Equals(WhereList[i]) )
            {
                i++;
                
            }
            else
            {
                WhereGuess = true;
            }
        }
    }

    public void GuessWhat()
    {
        WhatGuessString = WhatInput.text.ToString();
        while (WhatGuess == false)
        {
            if (i>WhereList.Length)
            {
                //text box will be set to try again
                i = 0;
                break;
            }

            if (!WhatGuessString.Equals(WhatList[i]))
            {
                i++;   
            }
            else
            {
                WhatGuess = true;
            }
        }

    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }
	
}
