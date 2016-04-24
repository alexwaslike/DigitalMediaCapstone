using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour {

    public float Speed = 1.0f;

	void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, vertical, 0) * Speed * Time.deltaTime);
    }
}
