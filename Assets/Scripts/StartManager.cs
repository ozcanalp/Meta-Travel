using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    [SerializeField] private GameObject[] rooms;
    private void Start()
    {
        string url = ReadURL();
        
        Transform toGoTransform = GetRoomTransform(int.Parse(url));
    }

    string ReadURL()
    {
        string url = Application.absoluteURL;
        string parameters = url.Substring(Application.absoluteURL.IndexOf("?") + 1);
        return parameters.Split(new char[] { '&', '=' })[1];
    }

    Transform GetRoomTransform(int roomId)
    {
        return rooms[roomId].transform;
    }
}
