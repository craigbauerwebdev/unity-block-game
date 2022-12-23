using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other) {
        Debug.Log("You Bumped Into " + hits + " things");
        hits++;
    }
}
