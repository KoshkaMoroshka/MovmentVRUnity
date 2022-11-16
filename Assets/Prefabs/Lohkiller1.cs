using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lohkiller1 : MonoBehaviour
{
    public static float score = 0;
    public GameObject text;

    

    void Start()
    {
        text = GameObject.FindGameObjectsWithTag("zhabke")[0];
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

    private float getscore()
    {
        return transform.position.x;
    }
    private float resolve(GameObject except)
    {
        float s = 0;
        GameObject[] obj = GameObject.FindGameObjectsWithTag("red");
        foreach (GameObject o in obj)
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
