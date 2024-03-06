using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxStuck : MonoBehaviour
{
    public GameObject LosePanel;
    private void OnTriggerEnter(Collider other)
    {
        LosePanel.SetActive(true);
    }
}
