using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject prefabBall;
    public float power;
    //public GameObject rightController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        QWE("XRI_Right_GripButton");
        QWE("XRI_Right_TriggerButton");
        QWE("XRI_Right_IndexTouch");
        QWE("XRI_Right_PrimaryButton");
        QWE("XRI_Right_SecondaryButton");


    }

    void QWE(string name)
    {
        if (Input.GetButtonDown(name))
        {
            var obj = Instantiate(prefabBall, transform.position, Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(transform.forward * power);
        }
    }
}
