using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batoot : MonoBehaviour
{
    public float bounciness = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Transform>().tag == "Player")
        {
            Vector3 objVelocity = other.gameObject.GetComponent<Rigidbody2D>().velocity;

            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(objVelocity.x, objVelocity.y * -1 * bounciness);
        }
    }
}
