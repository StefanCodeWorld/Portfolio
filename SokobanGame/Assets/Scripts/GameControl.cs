using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private int _full1;
    private int _full2;
    private int _full3;
    private int _full4;
    private int _full5;

    public GameObject BoxHolder1;
    public GameObject BoxHolder2;
    public GameObject BoxHolder3;
    public GameObject BoxHolder4;
    public GameObject BoxHolder5;

    public GameObject WinPanel;

    private int AllHolders;
    // Start is called before the first frame update
    void Start()
    {
        BoxHolder2.GetComponent<BoxHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        if( BoxHolder1.GetComponent<BoxHolder>().NumberOfFullBoxHolders == 1)
        {
            _full1 = 1;
        }
        else
        {
            _full1 = 0;
        }

        if (BoxHolder2.GetComponent<BoxHolder>().NumberOfFullBoxHolders == 1)
        {
            _full2 = 1;
        }
        else
        {
            _full2 = 0;
        }

        if (BoxHolder3.GetComponent<BoxHolder>().NumberOfFullBoxHolders == 1)
        {
            _full3 = 1;
        }
        else
        {
            _full3 = 0;
        }

        if (BoxHolder4.GetComponent<BoxHolder>().NumberOfFullBoxHolders == 1)
        {
            _full4 = 1;
        }
        else
        {
            _full4 = 0;
        }

        if (BoxHolder5.GetComponent<BoxHolder>().NumberOfFullBoxHolders == 1)
        {
            _full5 = 1;
        }
        else
        {
            _full5 = 0;
        }
        AllHolders = _full1 + _full2 + _full3 + _full4 + _full5;
        if(AllHolders == 5)
        {
            WinPanel.SetActive(true);

            string sceneName = SceneManager.GetActiveScene().name;
            sceneName = sceneName.Remove(0, 5);
            int index = int.Parse(sceneName);
            index--;

            int playerMoves = GameObject.Find("Player").GetComponent<PlayerMove>().Moves;

            SaveLoadXml.SaveData[index].Moves = playerMoves;
            SaveLoadXml.SaveData[index].Level = SceneManager.GetActiveScene().name;

            SaveLoadXml.SaveToXML(SaveLoadXml.SaveData);
        }
    }
}
