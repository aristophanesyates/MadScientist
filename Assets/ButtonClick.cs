using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public ChooseBodyPart chooseBodyPart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScrollRight() {
        chooseBodyPart.addBodyPart = true;
        chooseBodyPart.coolerIndex++;
        if (chooseBodyPart.coolerIndex > 3) {
            chooseBodyPart.coolerIndex = 0;
        }
    }
    public void ScrollLeft()
    {
        chooseBodyPart.addBodyPart = true;
        chooseBodyPart.coolerIndex--;
        if (chooseBodyPart.coolerIndex < 0)
        {
            chooseBodyPart.coolerIndex = 3;
        }
    }
}
