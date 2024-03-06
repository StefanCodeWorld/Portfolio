using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Moves : MonoBehaviour
{
    public Text MovesText;
    public Text GameWonMoves;
    public Text GameLostMoves;
    private string _text;
    private int _numberOfMoves;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _numberOfMoves = GameObject.Find("Player").GetComponent<PlayerMove>().Moves;
        _text = "Moves:" + _numberOfMoves.ToString();
        GameWonMoves.text = _text;
        MovesText.text = _text;
        GameLostMoves.text = _text;
    }
}
