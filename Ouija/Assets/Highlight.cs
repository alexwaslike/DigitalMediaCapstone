using UnityEngine;
using UnityEngine.Networking;

public class Highlight : NetworkBehaviour
{

    private void FixedUpdate()
    {
        if (!isServer)
            return;
    }

}