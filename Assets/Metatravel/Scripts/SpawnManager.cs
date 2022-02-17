using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance { get; private set; }

    string url;
    [SerializeField] GameObject player;
    [SerializeField] private GameObject[] rooms;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void SpawnCharacter()
    {
        string url;

#if !UNITY_EDITOR && UNITY_WEBGL
        url = ReadURL();
#else
        url = Random.Range(0, rooms.Length).ToString();
#endif
        Transform spawnTransform = GetRoomTransform(ProcessURL(url));

        PhotonNetwork.Instantiate(player.name, spawnTransform.position, spawnTransform.rotation,0);
    }

    int ProcessURL(string url)
    {
        if (int.TryParse(url, out int parsedUrl))
            return parsedUrl;
        else
            return 0;

    }

    string ReadURL()
    {
        string url = Application.absoluteURL;

        if (url.Length < 0 && url.Length % 2 != 0)
            return "0";

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
