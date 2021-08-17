using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float shootForce;
    public GameObject arrow;
    public GameObject targetMonster;
    private Vector3 target;
    public float recoveryTime;
    private float remainingRecoveryTime;
    // Start is called before the first frame update
    void Start()
    {
        remainingRecoveryTime = recoveryTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingRecoveryTime > 0)
        {
            remainingRecoveryTime -= Time.deltaTime;
            return;
        }
        remainingRecoveryTime = recoveryTime;
        target = targetMonster.transform.position;
        GameObject temp = Instantiate(arrow, transform.position, Quaternion.FromToRotation(transform.forward, target - transform.position));
        temp.GetComponent<Projectile>().shootForce = shootForce;
    }
}
