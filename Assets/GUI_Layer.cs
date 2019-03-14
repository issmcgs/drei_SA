using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUI_Layer
{
    Control_Layer theControl;
	public GUI_Layer()
	{
        theControl = new Control_Layer(this);
	}

    public bool GUI_CheckGuess(String pString)
    {
        bool textIsHello = theControl.CheckIfTextHello(pString);
        return textIsHello;
    }
    

}
