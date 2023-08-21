using UnityEngine;
using System;
using System.Collections.Generic;

public class ClassToSave : MonoBehaviour
{
    [Serializable]
    public struct SerializableSaveData
    {
        public int dataInt;
        public float dataFloat;
        public bool dataBool;
        public string dataString;
        public List<int> dataList;
    }

    private SerializableSaveData _serializableSaveData;

    void Start()
    {
        _serializableSaveData = new SerializableSaveData
        {
            dataBool = true,
            dataInt = 1,
            dataFloat = 1.2f,
            dataString = "text string",
            dataList = new List<int>
            {
                0,
                1,
                2
            },
        };

        var saveSystem = new JSONSaveSystem(Application.persistentDataPath + "/test.json");
        saveSystem.Save<SerializableSaveData>(_serializableSaveData);

        if (saveSystem.TryToLoad<SerializableSaveData>(out _serializableSaveData))
        {
            print(_serializableSaveData.dataBool);
            print(_serializableSaveData.dataInt);
            print(_serializableSaveData.dataFloat);
            print(_serializableSaveData.dataString);
            print(_serializableSaveData.dataList[0] + " " + _serializableSaveData.dataList[1] + " " +
                  _serializableSaveData.dataList[2]);
        }
    }
}