using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlanchetteMove : MonoBehaviour
{
    Vector3 target;
    Vector3 startPos;
    CanvasScaler scaler;

    public float speed = 1;

    // Use this for initialization
    void Start()
    {
       startPos = transform.position;
       target = startPos;
       scaler = GetComponentInParent<CanvasScaler>();
    }

    // Update is called once per frame
    void Update()
    {
        

        target = getLetterPosition();

        var dir = target - transform.position;

        //Debug.Log("dir: "+dir + "/n");



       // dir.x = dir.x * scaler.scaleFactor;
       // dir.y = dir.y * scaler.scaleFactor;
        GetComponent<Rigidbody2D>().AddForce(dir * speed);
    }
    //returns letter position relative to parent (UI board)
   Vector3 getLetterPosition()
    {
        Vector3 letterPos = new Vector3(040.0f, -100.0f, 0.0f);



       letterPos.x = letterPos.x/1000 * scaler.scaleFactor * Screen.width;
        letterPos.y = letterPos.y/1000 * scaler.scaleFactor *Screen.height;
        return (startPos + letterPos);
    }




}
