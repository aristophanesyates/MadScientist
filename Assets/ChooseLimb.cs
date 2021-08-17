using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLimb : MonoBehaviour
{
    public GameObject[] limbs = new GameObject[5];
    public BodyPartCooler bodyPartCooler;
    public bool addLimb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (addLimb) {
            NewLimb(bodyPartCooler.Part[0]);
            addLimb = false;
        }
    }

    public void NewLimb(GameObject limb) {
        GameObject newLimb = limb;
        Instantiate(newLimb, limbs[0].transform);
    }
}
