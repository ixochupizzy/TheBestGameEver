using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aidkit : MonoBehaviour
{

    public float healAmount = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        var playerhealth = other.gameObject.GetComponent<PlayerHealth>();
        if (playerhealth != null)
        {
            playerhealth.AddHealth(healAmount);
            Destroy(gameObject);
        }
    }
}
