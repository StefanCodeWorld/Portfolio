using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private RayToWall _rayToWall;
    private Vector3 _directionUp = new Vector3(0, 0, 1);
    private Vector3 _directionDown = new Vector3(0, 0, -1);
    private Vector3 _directionRight = new Vector3(1, 0, 0);
    private Vector3 _directionLeft = new Vector3(-1, 0, 0);

    private AudioSource _playerStepSound;

    public int Moves;

    // Start is called before the first frame update
    void Start()
    {
        _rayToWall = GetComponent<RayToWall>();
        _playerStepSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && _rayToWall.CantMoveUp == false )
        {
            _playerStepSound.Play();
            Moves++;
            transform.position = transform.position + _directionUp;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && _rayToWall.CantMoveDown == false )
        {
            _playerStepSound.Play();
            Moves++;
            transform.position = transform.position + _directionDown;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && _rayToWall.CantMoveRight == false )
        {
            _playerStepSound.Play();
            Moves++;
            transform.position = transform.position + _directionRight;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && _rayToWall.CantMoveLeft == false )
        {
            _playerStepSound.Play();
            Moves++;
            transform.position = transform.position + _directionLeft;
        }
    }
}
