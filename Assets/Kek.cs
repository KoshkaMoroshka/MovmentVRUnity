using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Kek : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_TriggerButton"))
            CreateMen(obj1);
        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
            CreateMen(obj2);

    }

    private void CreateMen(GameObject obj)
    {
        Instantiate(obj, obj.transform.position, obj.transform.rotation);
    }
    
}
