using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLimb : MonoBehaviour
{
    public GameObject[] limbs = new GameObject[5];
    public BodyPartCooler armCooler;
    public BodyPartCooler legCooler;
    public BodyPartCooler headCooler;

    public bool addLimb;

    public int coolerIndex;
    public int limbIndex;
    // Start is called before the first frame update
    void Start()
    {
        limbIndex = 0;
        coolerIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (addLimb) {
            if (limbs[limbIndex].transform.childCount > 0) {
                Destroy(limbs[limbIndex].transform.GetChild(0).gameObject);
            }

            NewLimb(armCooler.Part[coolerIndex]);
            addLimb = false;
        }
    }

    public void NewLimb(GameObject limb) {
        GameObject newLimb = limb;
        Instantiate(newLimb, limbs[limbIndex].transform);
        coolerIndex++;
    }
}
