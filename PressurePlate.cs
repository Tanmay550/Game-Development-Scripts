using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private bool isActivated = false;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(!isActivated)
        {
            if(collision.gameObject.CompareTag("Player"))
            {
                isActivated = true;
                Destroy(collision.gameObject);

            }
        }
    }
}
