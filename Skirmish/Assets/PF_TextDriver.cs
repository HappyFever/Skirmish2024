using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF_TextDriver : MonoBehaviour
{
    public Transform TextCloneTemplate;
    void Start()
    {
        Transform myTextGO = Instantiate(TextCloneTemplate);
        PF_TextInstanceScript myText = myTextGO.GetComponent<PF_TextInstanceScript>();

        myText.initalise("Hello");
        myText.SetText("Score");

        myText.AttachTO(Camera.main.transform);
    }

    // Update is called once per frame
    void Update()
    {
        positionOverParent();
        transform.LookAt(Camera.main.transform.position);
    }

    private void positionOverParent()
    {
        throw new NotImplementedException();
    }
}
