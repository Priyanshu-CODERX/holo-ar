using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIToggler : MonoBehaviour
{
    public GameObject[] UIParent;
    bool isOn = true;

    public RawImage buttonTexture;

    public Texture On;
    public Texture Off;

    public void toggleUI()
    {
        if (isOn)
        {
            for(int i = 0; i<UIParent.Length; i++)
                UIParent[i].SetActive(false);
            isOn = false;
            buttonTexture.texture = On;
        }
        else
        {
            for (int i = 0; i < UIParent.Length; i++)
                UIParent[i].SetActive(true);
            isOn = true;
            buttonTexture.texture = Off;
        }
    }
}
