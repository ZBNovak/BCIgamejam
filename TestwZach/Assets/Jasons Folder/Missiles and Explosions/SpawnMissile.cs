using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMissile : MonoBehaviour
{
    // Instantiate a rigidbody then set the velocity

    public GameObject projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("FIRE");
            // Instantiate the projectile at the position and rotation of this transform
            GameObject clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            //clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
