using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool isPanelOpen = false;

    private void Start()
    {
        
    }

    public void OnSettingsButton()
    {
        if (!isPanelOpen)
        {
            panel.SetActive(true);
            isPanelOpen = true;
        }
        else if (isPanelOpen)
        {
            panel.SetActive(false);
            isPanelOpen = false;
        }

    }
}
