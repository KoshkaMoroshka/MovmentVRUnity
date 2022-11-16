using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDistrict : MonoBehaviour
{
    [SerializeField] private GameObject kittyHorizontal;
    [SerializeField] private GameObject kittyVertical;
    [SerializeField] private bool activeGame = false;

    private void Update()
    {
        if (!activeGame)
            return;

        var kittysObjs = GameObject.FindGameObjectsWithTag("kitty");
        if (kittysObjs.Length >= 4)
            return;

        var generateKitty = Random.Range(0, 3);
        GameObject obj;
        if (generateKitty == 0)
        {
            obj = Instantiate(kittyHorizontal, new Vector3(-4, 0, Random.Range(-18, 16)), kittyHorizontal.transform.rotation);
            obj.GetComponent<Rigidbody>().AddForce(new Vector3(-2000, 0, 0));
        }
        else if (generateKitty == 1)
        {
            obj = Instantiate(kittyVertical, new Vector3(Random.Range(-38, -5), 0, 16.44f), kittyVertical.transform.rotation);
            obj.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -2000));
        }
        else if (generateKitty == 2)
        {
            obj = Instantiate(kittyHorizontal, new Vector3(-39.51f, 0, Random.Range(-18, 16)), kittyHorizontal.transform.rotation);
            obj.GetComponent<Rigidbody>().AddForce(new Vector3(+2000, 0, 0));
        }
        else if (generateKitty == 3)
        {
            obj = Instantiate(kittyVertical, new Vector3(Random.Range(-38, -5), 0, -18.26f), kittyVertical.transform.rotation);
            obj.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, +2000));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
            activeGame = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
            activeGame = false ;
    }
}
