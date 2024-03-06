using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[System.Serializable]
public class PlayerData
{

    public int Moves {  get; set; }

    public string Level {  get; set; }
    public PlayerData()
    {

    }
    public PlayerData(int moves, string level)
    {
        Moves = moves;
        Level = level;
            
    }
}

public class SaveLoadXml : MonoBehaviour
{

    public static string FileNameGeneral;

    public static List<PlayerData> SaveData;

    void Start()
    {
        SaveData = new List<PlayerData>();

        FileNameGeneral = Application.persistentDataPath + "/Save.xml";


        if (File.Exists(FileNameGeneral) == false)
        {
            for (int i = 0; i < 4; i++)
            {
                PlayerData tmpData = new PlayerData(0, "Level"+ i);
                SaveData.Add(tmpData);
            }
            SaveToXML(SaveData);
        }
        SaveData = DeserializeFromXML();

        for(int i = 0; i < SaveData.Count; i++)
        {
            if (SaveData[i].Moves == 0)
            {
                GameObject.Find("Level" + (i+ 1)).GetComponent<Button>().interactable = false;
            }
            else
            {
                GameObject.Find("Level" + (i + 1)).GetComponent<Image>().color = Color.green;
            }
        }
        for (int i = 0; i < SaveData.Count; i++)
        {
            if (SaveData[i].Moves == 0)
            {
                GameObject.Find("Level" + (i + 1)).GetComponent<Button>().interactable = true;
                GameObject.Find("Level" + (i + 1)).GetComponent<Image>().color = Color.green;
                break;
            }
        }
    }
    public static void SaveToXML(List<PlayerData> PlayerDataListArg)
    {
          using (StreamWriter cs = new StreamWriter(FileNameGeneral))
          {
              XmlSerializer xmlser = new XmlSerializer(typeof(List<PlayerData>));
              xmlser.Serialize(cs, PlayerDataListArg);
          }
    }

    public static List<PlayerData> DeserializeFromXML()
    {
        using (StreamReader cs = new StreamReader(FileNameGeneral))
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<PlayerData>));
            var tmp = (List<PlayerData>)xmlser.Deserialize(cs);
            return tmp;
        }
    }
}
