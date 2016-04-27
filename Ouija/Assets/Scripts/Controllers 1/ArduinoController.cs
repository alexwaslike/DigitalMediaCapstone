using UnityEngine;
using System.Collections;
using System.IO.Ports;
using UnityEngine.UI;

public class ArduinoController : MonoBehaviour
{
    public OuijaInputHandler oih;
    SerialPort sp;
    string recieved;
    void Start()
    {
        foreach (string str in SerialPort.GetPortNames())
        {
            Debug.Log(str);
            if (str == "C0M4")
            {

            }
        }
        sp = new SerialPort("COM3", 9600);
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