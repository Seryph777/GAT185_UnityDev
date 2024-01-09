using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float speed = 5f; // Adjust this var to change speed
    float height = 1f; // Adjust this var to change how high it goes
    float xPos = 11.758f;
    float zPos = 15.914f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(50 * Time.deltaTime, 0, 0);

        //get the objects current position and put it in a variable so we can access it later with less code
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(xPos, 2 + newY, zPos) * height;
        // I got this code from: https://forum.unity.com/threads/how-to-make-an-object-move-up-and-down-on-a-loop.380159/ 
    }
}
