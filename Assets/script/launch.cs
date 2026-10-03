using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{
   [SerializeField] int force = 90;
    Rigidbody rb;
    [SerializeField] GameObject ball;
    Collider collider;
    Vector3 cuurentangle;
    // Start is called before the ggfirst frame update
    void Start()
    {
      rb =   GetComponent<Rigidbody>();
      collider = GetComponent<Collider>();
      GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {  
            collider.isTrigger = true;
        rb.AddForce(new Vector3(0,force,force), ForceMode.Impulse);
        }

    }
}
