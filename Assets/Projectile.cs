using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    private bool addedForce;
    public float shootForce;
    void Start()
    {
        addedForce = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!addedForce)
        {
            rb.AddForce(transform.forward.normalized * shootForce);
            addedForce = true;
        }
        transform.rotation = Quaternion.FromToRotation(Vector3.forward, rb.velocity.normalized);
        if (transform.position.y < -1)
        {
            Destroy(gameObject);
        }
    }
}
