using System;

public class Control_Layer
{
    public GUI_Layer theGUI;
    public Data_Layer theData = new Data_Layer();

	public Control_Layer(GUI_Layer pGUI)
	{
        theGUI = pGUI;
	}

    public bool CheckIfTextHello(String pString)
    {
        if (pString == "hello" || pString == "Hello")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
