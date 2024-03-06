using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeftRightMove : MonoBehaviour
{

    public float Speed;
    private Vector3 _positionsPositive;
    private Vector3 _positionsNegative;

    // Start is called before the first frame update
    void Start()
    {
        _positionsPositive = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
        _positionsNegative = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * Speed, 1);
        transform.position = Vector3.Lerp(_positionsPositive, _positionsNegative, time);

    }
}
