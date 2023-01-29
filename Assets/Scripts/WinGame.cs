using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject winTextObject;
    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winTextObject.SetActive(true);
        }
    }
}
