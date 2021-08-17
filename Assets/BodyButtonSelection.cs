using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyButtonSelection : MonoBehaviour
{
    public ChooseBodyPart chooseBodyPart;
    public Button[] buttons = new Button[6];
    Button rightArmBtn;
    Button leftArmBtn;
    Button rightLegBtn;
    Button leftLegButton;
    Button torsoBtn;
    Button headBtn;

    // Start is called before the first frame update
    void Start()
    {
       
        rightArmBtn = buttons[0].GetComponent<Button>();
        rightArmBtn.onClick.AddListener(() => { FindButtonIndex(0); });

        leftArmBtn = buttons[1].GetComponent<Button>();
        leftArmBtn.onClick.AddListener(() => { FindButtonIndex(1); });

        rightLegBtn = buttons[2].GetComponent<Button>();
        rightLegBtn.onClick.AddListener(() => { FindButtonIndex(2); });

        leftLegButton = buttons[3].GetComponent<Button>();
        leftLegButton.onClick.AddListener(() => { FindButtonIndex(3); });

        torsoBtn = buttons[4].GetComponent<Button>();
        torsoBtn.onClick.AddListener(() => { FindButtonIndex(4); });

        headBtn = buttons[5].GetComponent<Button>();
        headBtn.onClick.AddListener(() => { FindButtonIndex(5); });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FindButtonIndex(int index) {
        chooseBodyPart.bodyPartIndex = index;
    }
    
}
