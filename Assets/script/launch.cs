using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{
     [SerializeField] GameObject projectilePrefab;
// Il punto in cui apparirà la bomba
[SerializeField] Transform firePoint;
// Tempo tra i lanci delle bombe

// Forza di lancio
[SerializeField] float launchForce = 5000f;
    // Start is called before the ggfirst frame update
    void Start()
    {
      
      
      
      

    }

    // Update is called once per frame
    void Update()
    {
        
    Launch();
    if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Transform.Rotate(0f,1f,0f);
        }
    
    }
    void Launch()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        GameObject proj = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        Rigidbody rb = proj.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * launchForce);
        Destroy(proj, 9f);

       
        }

    }
}
