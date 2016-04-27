using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;

public class ServerHUD : MonoBehaviour {

    public NetworkManager NetworkManager;
    public Camera MainCamera;

    public GameObject ConnectUI;
    public GameObject HostConnectedUI;
    public GameObject ClientConnectedUI;

    public InputField AddressInput;
    public InputField PortInput;

    public Text HostAddressText;
    public Text ClientAddressText;

    public string NotConnectedText = "[Not Connected]";
    public string StartingHostText = "[Starting host...]";
    public string ConnectingText = "[Connecting...]";
    public string HostFailedTtext = "[Starting host failed.]";
    public string ConnectionFailedText = "[Connection Failed]";

    public void StartHost()
    {
        NetworkManager.StartHost();

        ConnectUI.SetActive(false);
        HostConnectedUI.SetActive(true);

        HostAddressText.text = NetworkManager.networkAddress;
    }
    
    public void StartClient()
    {
        NetworkManager.StartClient();

        ConnectUI.SetActive(false);
        ClientConnectedUI.SetActive(true);

        ClientAddressText.text = NetworkManager.networkAddress;
    }

    public void StopHost()
    {
        NetworkManager.StopHost();

        MainCamera.transform.SetParent(null);

        ConnectUI.SetActive(true);
        ClientConnectedUI.SetActive(false);
        HostConnectedUI.SetActive(false);
    }

    public void StopClient()
    {
        NetworkManager.StopClient();

        MainCamera.transform.SetParent(null);

        ConnectUI.SetActive(true);
        ClientConnectedUI.SetActive(false);
        HostConnectedUI.SetActive(false);
    }

    public void SetNetworkAddress()
    {
        NetworkManager.networkAddress = AddressInput.text;
    }

    public void SetNetworkPort()
    {
        NetworkManager.networkPort = Convert.ToInt32(AddressInput.text);
    }


}
