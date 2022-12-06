using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnableDisableColorBtn : MonoBehaviour
{
    public List<Image> images;
    public List<TextMeshProUGUI> labels;


    public Color activeColor;
    public Color disableColor;

    public Color secondaryActiveColor;
    public Color secondaryDisableColor;


    public void ActiveColor()
    {
        foreach (Image i in images)
        {
            i.color = activeColor;
        }
        foreach (TextMeshProUGUI tc in labels)
        {
            tc.color = activeColor;
        }
    }

    public void DisableColor()
    {
        foreach (Image i in images)
        {
            i.color = disableColor;
        }
        foreach (TextMeshProUGUI tc in labels)
        {
            tc.color = disableColor;
        }
    }

    public void SecActiveColor()
    {
        foreach (Image i in images)
        {
            i.color = secondaryActiveColor;
        }
        foreach (TextMeshProUGUI tc in labels)
        {
            tc.color = secondaryActiveColor;
        }
    }

    public void DisableActiveColor()
    {
        foreach (Image i in images)
        {
            i.color = secondaryDisableColor;
        }
        foreach (TextMeshProUGUI tc in labels)
        {
            tc.color = secondaryDisableColor;
        }
    }

}
