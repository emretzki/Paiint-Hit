using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "red")
        {
            
        }

        else
        {
            base.gameObject.GetComponent<Collider>().enabled = true;
            GameObject gameObject = Instantiate(Resources.Load("splash1")) as GameObject;
        }
    }
}
