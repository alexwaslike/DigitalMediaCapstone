using UnityEngine;
using System.Collections;



public class PlanchetteMove : MonoBehaviour
{
    public float speed = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = getLetterPosition();

        //float distanceToTarget = Mathf.Sqrt((target.x - transform.position.x) * (target.x - transform.position.x) + (target.y - transform.position.y) * (target.y - transform.position.y));
        var dir = target - transform.position;






        GetComponent<Rigidbody2D>().AddForce(dir * speed);
    }

    Vector3 getLetterPosition()
    {
        Vector3 target1 = new Vector3(21.0f, 203.0f, 0.0f);


        return target1;
    }




}
