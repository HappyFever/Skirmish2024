using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RW_ProjetileAim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 50);
       if (Physics.Raycast(ray))
            print("Hit");

        
    }
}
