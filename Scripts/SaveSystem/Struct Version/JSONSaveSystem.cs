using System.IO;
using Newtonsoft.Json;

public class JSONSaveSystem
{
    private readonly string _saveFilePath;

    public JSONSaveSystem(string saveFilePath)
    {
        _saveFilePath = saveFilePath;
    }

    public void Save<T>(T dataToSave)
    {
        var json = JsonConvert.SerializeObject(dataToSave);
        File.WriteAllText(_saveFilePath, json);
    }

    public bool TryToLoad<T>(out T dataToLoad)
    {
        if (File.Exists(_saveFilePath))
        {
            var TextJson = File.ReadAllText(_saveFilePath);
            dataToLoad = JsonConvert.DeserializeObject<T>(TextJson);
            return true;
        }

        dataToLoad = default;
        return false;
    }
}