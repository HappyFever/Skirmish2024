using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF_TextInstanceScript : MonoBehaviour
{
    TMPro.TextMeshPro m_TextMeshPro;

    internal void AttachTO(Transform transformToAttachTo)
    {
        throw new NotImplementedException();
    }

    internal void initalise(string newText)
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        m_TextMeshPro.text = newText;
    }

    internal void SetText(string newText)
    {
        m_TextMeshPro.text = newText;
        print("Hello");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
