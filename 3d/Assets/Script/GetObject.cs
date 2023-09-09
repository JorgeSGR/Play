using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
     
        if(other.CompareTag("Sol"))
        {
            Destroy(other.gameObject);

            Debug.Log("Has Conseguido Cristal del Sol");
        }

        if (other.CompareTag("Agua"))
        {
            Destroy(other.gameObject);

            Debug.Log("Has Conseguido El agua Purificante");
        }

        if (other.CompareTag("Fuego"))
        {
            Destroy(other.gameObject);

            Debug.Log("Has Conseguido El Fuego Vigorizante");
        }

        if (other.CompareTag("Aire"))
        {
            Destroy(other.gameObject);

            Debug.Log("Has Conseguido El Aire Envolvente");
        }
    }


}
