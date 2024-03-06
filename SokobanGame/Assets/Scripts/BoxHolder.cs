using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoxHolder : MonoBehaviour
{
    public int NumberOfFullBoxHolders;

    private void OnTriggerEnter(Collider other)
    {
        NumberOfFullBoxHolders++;
        other.gameObject.GetComponent<MeshRenderer>().material.color = Color.white * Color.red;
    }
    private void OnTriggerExit(Collider other)
    {
        NumberOfFullBoxHolders--;
        other.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
