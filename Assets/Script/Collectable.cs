using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static Action OnObjectCollected;

    private void OntriggerEnter( Collider other) {
        if(!(OnObjectCollected is null)) 
        OnObjectCollected();
        Destroy(gameObject);
    }
}
