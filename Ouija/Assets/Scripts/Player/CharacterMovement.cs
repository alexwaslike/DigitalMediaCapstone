using UnityEngine;
using UnityEngine.Networking;

public class CharacterMovement : NetworkBehaviour {

	public float Speed = 0.1f;
    
	void Update()
    {
        if (!isLocalPlayer)
            return;
        else
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(horizontal, vertical, 0) * Speed);

            if (horizontal != 0 || vertical != 0)
                GetComponent<SelfSort>().SetSortingOrder();
        }

	}
}
