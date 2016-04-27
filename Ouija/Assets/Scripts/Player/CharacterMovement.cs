using UnityEngine;
using UnityEngine.Networking;

public class CharacterMovement : NetworkBehaviour {

	public float Speed = 0.1f;
    public Animator Animator;
    
	void Update()
    {
        if (!isLocalPlayer)
            return;
        else
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(horizontal, vertical, 0) * Speed);

            if (horizontal != 0 || vertical != 0) {
                GetComponent<SelfSort>().SetSortingOrder();

                if(Animator.enabled) {
                    if (horizontal > 0.001)
                        Animator.SetBool("facingRight", true);
                    else Animator.SetBool("facingRight", false);

                    if (vertical > 0.001)
                        Animator.SetBool("facingUp", true);
                    else Animator.SetBool("facingUp", false);
                }
                
            }
                
        }

	}
}
