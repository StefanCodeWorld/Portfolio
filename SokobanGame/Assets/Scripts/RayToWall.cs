using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayToWall : MonoBehaviour
{
    private Ray _rayUp;
    private RaycastHit _hitUp;
    private Vector3 _rayDirectionUp;

    private Ray _rayDown;
    private RaycastHit _hitDown;
    private Vector3 _rayDirectionDown;

    private Ray _rayRight;
    private RaycastHit _hitRight;
    private Vector3 _rayDirectionRight;

    private Ray _rayLeft;
    private RaycastHit _hitLeft;
    private Vector3 _rayDirectionLeft;


    public bool CantMoveUp;
    public bool CantMoveDown;
    public bool CantMoveRight;
    public bool CantMoveLeft;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _rayUp.origin = transform.position;
        _rayUp.direction = _rayDirectionUp = new Vector3(0, 0, 1);

        _rayDown.origin = transform.position;
        _rayDown.direction = _rayDirectionDown = new Vector3(0, 0, -1);

        _rayRight.origin = transform.position;
        _rayRight.direction = _rayDirectionRight = new Vector3(1, 0, 0);

        _rayLeft.origin = transform.position;
        _rayLeft.direction = _rayDirectionLeft = new Vector3(-1, 0, 0);

        if (Physics.Raycast(_rayUp, out _hitUp))
        {
            if (_hitUp.collider.tag == "Wall" && Vector3.Distance(gameObject.transform.position, _hitUp.point) < 1)
            {
                CantMoveUp = true;

            }
            else
            {
                CantMoveUp = false;
            }
        }
        if (Physics.Raycast(_rayDown, out _hitDown))
        {
            if (_hitDown.collider.tag == "Wall" && Vector3.Distance(gameObject.transform.position, _hitDown.point) < 1)
            {
                CantMoveDown = true;
            }
            else
            {
                CantMoveDown = false;
            }
        }
        if (Physics.Raycast(_rayRight, out _hitRight))
        {
            if (_hitRight.collider.tag == "Wall" && Vector3.Distance(gameObject.transform.position, _hitRight.point) < 1)
            {
                CantMoveRight = true;
            }
            else
            {
                CantMoveRight = false;
            }
        }
        if (Physics.Raycast(_rayLeft, out _hitLeft))
        {
            if (_hitLeft.collider.tag == "Wall" && Vector3.Distance(gameObject.transform.position, _hitLeft.point) < 1)
            {
                CantMoveLeft = true;
            }
            else
            {
                CantMoveLeft = false;
            }
        }

    }
}