using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Drei_SA_Component : MonoBehaviour
{
    // Start is called before the first frame update
    private GUI_Layer theGUI;
    public InputField ipTextField;

    void Start()
    {
        theGUI = new GUI_Layer();
    }

    // Update is called once per frame
    void Update()
    {
        if (theGUI.GUI_CheckGuess(ipTextField.text))
        {
            Debug.Log("Hey!");
        }
    
    }
}
