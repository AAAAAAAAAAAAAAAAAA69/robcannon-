using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] TMP_Text Ptext;
    float pointcounter = 0f;
    [SerializeField] GameObject[] cilindri;
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
        for (int i = 0; i < cilindri.Length; i++)
    {
        // Controlla se il cilindro è nell'array
        if (collider.gameObject == cilindri[i])
        {
            if (collider.CompareTag("100point"))
            {
                pointcounter += 100;
            }
            else if (collider.CompareTag("80 point"))
            {
                pointcounter += 80;
            }
            else if (collider.CompareTag("60 point"))
            {
                pointcounter += 60;
            }
            else if (collider.CompareTag("50point"))
            {
                pointcounter += 50;
            }
            else if (collider.CompareTag("40 point"))
            {
                pointcounter += 40;
            }
            else if (collider.CompareTag("30 point"))
            {
                pointcounter += 30;
            }
            else if (collider.CompareTag("20 point"))
            {
                pointcounter += 20;
            }
            else if (collider.CompareTag("10point"))
            {
                pointcounter += 10;
            }

            break;
        }
    }
    }

}

