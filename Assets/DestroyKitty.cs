using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKitty : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y < -100)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.transform.position = new Vector3(19.061f, 1.75f, 0f);
            Destroy(gameObject);
            Destroy(GameObject.FindGameObjectWithTag("kitty"));
        }

    }
}
