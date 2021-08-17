using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBodyPart : MonoBehaviour
{
    public GameObject[] bodyParts = new GameObject[5];
    public BodyPartCooler armCooler;
    public BodyPartCooler legCooler;
    public BodyPartCooler headCooler;

    public bool addBodyPart;

    public int coolerIndex;
    public int bodyPartIndex;
    // Start is called before the first frame update
    void Start()
    {
        bodyPartIndex = 0;
        coolerIndex = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (addBodyPart)
        {
            if (bodyParts[bodyPartIndex].transform.childCount > 0)
            {
                Destroy(bodyParts[bodyPartIndex].transform.GetChild(0).gameObject);
            }

            NewLimb(armCooler.Part[coolerIndex]);
            addBodyPart = false;
        }

    }

    public void NewLimb(GameObject limb)
    {
        GameObject newLimb = limb;
        Instantiate(newLimb, bodyParts[bodyPartIndex].transform);
        //coolerIndex++;
    }
}
