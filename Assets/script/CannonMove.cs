using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    float one = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
 {
     Quaternion targetRotation = Quaternion.Euler(90, 0, 0); // 90° around Y-axis
     transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

 }
 else if (Input.GetKey(KeyCode.LeftArrow))
        {
             Quaternion targetRotation = Quaternion.Euler(-90, 0, 0); // 90° around Y-axis
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
        }
    }
}
