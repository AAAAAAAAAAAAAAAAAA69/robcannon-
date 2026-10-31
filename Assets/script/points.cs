using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] TMP_Text Ptext;
    float pointcounter = 0f;
    // Start is called before the first frame update
    void Start()
    {
         Ptext.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
        Ptext.text = Mathf.FloorToInt(pointcounter).ToString();
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.CompareTag("100point"))
        {
            pointcounter = pointcounter + 100;
        }
        else if(collider.gameObject.CompareTag("80 point"))
        {
            pointcounter = pointcounter + 80;
        }
        else if(collider.gameObject.CompareTag("60 point"))
        {
           pointcounter = pointcounter + 60;
        }
        else if(collider.gameObject.CompareTag("50point"))
        {
            pointcounter = pointcounter + 50;
        }
        else if(collider.gameObject.CompareTag("40 point"))
        {
            pointcounter = pointcounter+ 40;
             Debug.Log("40 points");
        }
        else if(collider.gameObject.CompareTag("30 point"))
        {
            pointcounter = pointcounter + 30;
             Debug.Log("30 points");
        }
        else if(collider.gameObject.CompareTag("20 point"))
        {
            pointcounter = pointcounter + 20;
             Debug.Log("20 points");
        }
        else if(collider.gameObject.CompareTag("10point"))
        {
           pointcounter  = pointcounter + 10;
           Debug.Log("10 points");
        }
    }
}
