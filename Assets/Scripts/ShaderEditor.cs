using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShaderEditor : MonoBehaviour
{
    public Material ChromaKeyShader;
    public TMP_InputField inputField;

    public float thresholdValue = 0.5f;

    private void Start()
    {
        ChromaKeyShader.SetFloat("Vector1_84B7BD56", 0.5f);
        
    }

    public void SetChromaKeyShaderThreshold()
    {
        float value = 0f;
        bool success = float.TryParse(inputField.text, out value);
        thresholdValue = value;
        ChromaKeyShader.SetFloat("Vector1_84B7BD56", thresholdValue);
    }
}
