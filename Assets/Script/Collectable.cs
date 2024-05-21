using System;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static Action OnObjectCollected;

    private void OnTriggerEnter(Collider other) {
       if(!(OnObjectCollected is null)) 
        OnObjectCollected();
        Destroy(gameObject);
    }
}