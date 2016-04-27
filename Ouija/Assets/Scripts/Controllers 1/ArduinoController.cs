using UnityEngine;
using System.Collections;
using System.IO.Ports;
using UnityEngine.UI;

public class ArduinoController : MonoBehaviour
{
    public OuijaInputHandler oih;
    SerialPort sp;
    string recieved;
    string defaultPort = "COM3";
    void Start()
    {
        bool defaultPortFound = false;
        foreach (string str in SerialPort.GetPortNames())
        {
            Debug.Log(str);
            if (str == defaultPort )
            {
                defaultPortFound = true;
            }
        }
        foreach (string str in SerialPort.GetPortNames())
        {
            Debug.Log(str);
            if (str != "" && !defaultPortFound)
            {
                defaultPort = str;
            }
        }



        sp = new SerialPort(defaultPort, 9600);
        sp.Open();
        sp.ReadTimeout = 1;

        
    }

    void Update()
    {
        try
        {
            recieved = sp.ReadLine();
            Debug.Log(recieved);
            oih.AddToText(recieved);
            oih.SendBoardMessage(recieved);
        }
        catch (System.Exception)
        {
        }
    }
}