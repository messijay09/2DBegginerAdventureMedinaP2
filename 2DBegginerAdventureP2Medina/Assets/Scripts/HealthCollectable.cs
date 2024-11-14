using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthcolle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        duckcontroller controller = other.GetComponent<duckcontroller>();
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }

        }

    }
}
