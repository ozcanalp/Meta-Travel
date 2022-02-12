using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    [SerializeField] string url;
    [SerializeField] private GameObject[] rooms;
    [SerializeField] Transform character;
    private void Awake()
    {
        if (url == "" || url == null)
            url = ReadURL();

        Transform toGoTransform = GetRoomTransform(int.Parse(url));
        Debug.Log(toGoTransform.position);
        character.position = toGoTransform.position;
    }

    string ReadURL()
    {
        string url = Application.absoluteURL;
        string parameters = url.Substring(Application.absoluteURL.IndexOf("?") + 1);
        string[] splittedParameters = parameters.Split(new char[] { '&', '=' });

        if (splittedParameters.Length > 0)
            return parameters.Split(new char[] { '&', '=' })[1];
        else
            return "0";

    }

    Transform GetRoomTransform(int roomId)
    {
        if (roomId < rooms.Length && 0 < roomId)
            return rooms[roomId].transform;
        else
            return rooms[0].transform;
    }
}
