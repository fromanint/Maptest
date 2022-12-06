using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Make3DButton : MonoBehaviour
{
   
   
    public UnityEvent enterButton;
    public UnityEvent exitButton;
    public UnityEvent clickDown;
    public UnityEvent clickUp;

    #region EVENTS
    //-----------------------------------------------------------------------------------------------------------------------------------------------
    //---------- EVENTS --------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------

    public void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        clickDown.Invoke();
    }

    public void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
        clickUp.Invoke();
    }

    public void OnMouseOver()
    {
        Debug.Log("OnMouseOver");
        enterButton.Invoke();
    }

    public void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
        enterButton.Invoke();
    }

   
    
    

    #endregion
}
