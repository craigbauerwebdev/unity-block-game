using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
        //Debug.Log("bumped");
        if(other.gameObject.tag == "Player") {
         //Debug.Log("hahahaha");
         GetComponent<MeshRenderer>().material.color = Color.red;
         gameObject.tag = "Hit";
        }
   }
}
