using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atkHitbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("bird"))
        {
            col.gameObject.GetComponent<BirdHealth>().TakeDamage();
        }
    }

}
