using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    private int items = 0;

    [SerializeField]
    private TextMeshPro textMeshPro;

    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Destroy(collision.gameObject);
            items ++;
        }

    }

    private void Update()
    {
        if(items == 4 )
        {
            textMeshPro.text = "Win!!!";
        } else {
            textMeshPro.text = "Items " + items; 
        }
    }
}
