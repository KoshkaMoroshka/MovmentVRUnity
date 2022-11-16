using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lohkiller2 : MonoBehaviour
{
    public static float score = 0;
    public GameObject text;


    void Start()
    {
        text = GameObject.FindGameObjectsWithTag("legushka")[0];

    }

    void Update()
    {
        if (transform.position.y < -1)
        {
            text.GetComponent<TextMeshProUGUI>().SetText((score = resolve(gameObject)).ToString());
            Destroy(gameObject);
            return;
        }

        float s = getscore();
        if (s <= score)
            return;

        text.GetComponent<TextMeshProUGUI>().SetText((score = s).ToString());
    }

    public float getscore()
    {
        return transform.position.x;
    }
    private float resolve(GameObject except)
    {
        float s = 0;
        GameObject[] obj = GameObject.FindGameObjectsWithTag("blue");
        foreach(GameObject o in obj)
        {
            if (o == except) continue;
            Lohkiller2 l = o.GetComponent<Lohkiller2>();
            if (l == null) continue;
            float _s = l.getscore();
            s = s < _s ? _s : s;
        }
        return s;
    }
}
