using System.IO;
using UnityEngine;
using JInvader;

public class JSONController : MonoBehaviour
{
    [SerializeField] private Invader[] _invaders;
    private string _savePath;

    private void Awake()
    {
        _savePath = Application.streamingAssetsPath + "/SAVE.JSON";
        LoadField(); 
    }

    [ContextMenu("Load")]
    public void LoadField()
    {
        if(File.Exists(_savePath))
        {
            string[] fileDate = File.ReadAllLines(_savePath);

            for (int i = 0; i < fileDate.Length; i++)
            {
                SaveInvader saveInvaders = JsonUtility.FromJson<SaveInvader>(fileDate[i]);
                _invaders[i].Set—haracteristic(saveInvaders.Damage, saveInvaders.SpeedShoot, saveInvaders.Score);
            }
        }
    }
}
