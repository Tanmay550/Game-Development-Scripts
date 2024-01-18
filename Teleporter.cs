using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField]
    GameObject PortB;
    [SerializeField]
    GameObject PortA;

    // Define a small tolerance for position comparison
    private float positionTolerance = 0.01f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 TposB = PortB.transform.position;
        Vector3 TposA = PortA.transform.position;

        if (collision.gameObject.CompareTag("Player"))
        {
            // Compare the positions with tolerance
            if (Vector3.Distance(collision.gameObject.transform.position, TposA) < positionTolerance)
            {
                collision.gameObject.transform.position = TposB;
            }
            else
            {
                collision.gameObject.transform.position = TposA;
            }
        }
    }
}
