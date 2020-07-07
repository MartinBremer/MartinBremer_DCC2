using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToggle : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;

    void Update()
    {
        if (Input.GetKeyDown("1"))
            go1.SetActive(!go1.activeSelf);
        else if (Input.GetKeyDown("2"))
            go2.SetActive(!go2.activeSelf);
        else if (Input.GetKeyDown("3"))
            go3.SetActive(!go3.activeSelf);
        else if (Input.GetKeyDown("h"))
            go4.SetActive(!go4.activeSelf);
    }
}
