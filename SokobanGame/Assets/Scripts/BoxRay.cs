using UnityEngine;

public class BoxRay : MonoBehaviour
{
    private Ray _rayUp;
    private RaycastHit _hitUp;

    private Ray _rayDown;
    private RaycastHit _hitDown;

    private Ray _rayRight;
    private RaycastHit _hitRight;

    private Ray _rayLeft;
    private RaycastHit _hitLeft;

    public bool BoxCantMoveUp;
    public bool BoxCantMoveDown;
    public bool BoxCantMoveRight;
    public bool BoxCantMoveLeft;

    private AudioSource _boxMove;
  

    // Start is called before the first frame update
    void Start()
    {
        _boxMove = gameObject.GetComponent<AudioSource>();
    }
       
    // Update is called once per frame
    void Update()
    {
        _rayUp.origin = transform.position;
        _rayUp.direction = new Vector3(0, 0, 1);

        _rayDown.origin = transform.position;
        _rayDown.direction = new Vector3(0, 0, -1);

        _rayRight.origin = transform.position;
        _rayRight.direction = new Vector3(1, 0, 0);

        _rayLeft.origin = transform.position;
        _rayLeft.direction = new Vector3(-1, 0, 0);

        if (Physics.Raycast(_rayDown, out _hitDown))
        {
            if (_hitDown.collider.CompareTag("Box"))
            {
                if (Vector3.Distance(transform.position, _hitDown.point) <= 1)
                {
                    BoxCantMoveDown = true;
                }
            }
            else
            {
                BoxCantMoveDown = false;
            }
            if (_hitDown.collider.tag == "Wall")
            {
                if (Vector3.Distance(transform.position, _hitDown.point) <= 1)
                {
                    BoxCantMoveDown = true;
                }
                else
                {
                    BoxCantMoveDown = false;
                }
            }
            if (_hitDown.collider.tag == "Player" && BoxCantMoveUp == false)
            {
                if (Vector3.Distance(transform.position, _hitDown.transform.position) == 0)
                {
                    _boxMove.Play();
                    transform.position = transform.position + new Vector3(0, 0, 1);
                }
            }
        }
        if (Physics.Raycast(_rayUp, out _hitUp))
        {
            if (_hitUp.collider.CompareTag("Box"))
            {
                if (Vector3.Distance(transform.position, _hitUp.point) <= 1)
                {
                    BoxCantMoveUp = true;
                }
            }
            else
            {
                BoxCantMoveUp = false;
            }
            if (_hitUp.collider.tag == "Wall")
            {
                if (Vector3.Distance(transform.position, _hitUp.point) <= 1)
                {
                    BoxCantMoveUp = true;
                }
                else
                {
                    BoxCantMoveUp = false;
                }
            }
            if (_hitUp.collider.tag == "Player" && BoxCantMoveDown == false)
            {
                if (Vector3.Distance(transform.position, _hitUp.transform.position) == 0)
                {
                    _boxMove.Play();
                    transform.position = transform.position + new Vector3(0, 0, -1);
                }
            }
        }
        if (Physics.Raycast(_rayRight, out _hitRight))
        {
            if (_hitRight.collider.CompareTag("Box"))
            {
                if (Vector3.Distance(transform.position, _hitRight.point) <= 1)
                {
                    BoxCantMoveRight = true;
                }
            }
            else
            {
                BoxCantMoveRight = false;
            }
            if (_hitRight.collider.tag == "Wall")
            {
                if (Vector3.Distance(transform.position, _hitRight.point) <= 1)
                {
                    BoxCantMoveRight = true;
                }
                else
                {
                    BoxCantMoveRight = false;
                }
            }
            if (_hitRight.collider.tag == "Player" && BoxCantMoveLeft == false)
            {
                if (Vector3.Distance(transform.position, _hitRight.transform.position) == 0)
                {
                    _boxMove.Play();
                    transform.position = transform.position + new Vector3(-1, 0, 0);
                }
            }
        }
        if (Physics.Raycast(_rayLeft, out _hitLeft))
        {
            if (_hitLeft.collider.CompareTag("Box"))
            {
                if (Vector3.Distance(transform.position, _hitLeft.point) <= 1)
                {
                    BoxCantMoveLeft = true;
                }
            }
            else
            {
                BoxCantMoveLeft = false;
            }

            if (_hitLeft.collider.tag == "Wall")
            {
                if (Vector3.Distance(transform.position, _hitLeft.point) <= 1)
                {
                    BoxCantMoveLeft = true;
                }
                else
                {
                    BoxCantMoveLeft = false;
                }
            }
            if (_hitLeft.collider.tag == "Player" && BoxCantMoveRight == false)
            {
                if (Vector3.Distance(transform.position, _hitLeft.transform.position) == 0)
                {
                    _boxMove.Play();
                    transform.position = transform.position + new Vector3(1, 0, 0);
                }
            }
        }
    }
}
