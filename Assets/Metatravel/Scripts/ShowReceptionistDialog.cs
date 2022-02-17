using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowReceptionistDialog : MonoBehaviour
{
    private GameObject receptionistDialog;
    private GameObject bubble;
    public float showTime = 0f;
    private float time = 30f;
    private TMP_Text txt;

    private bool show = false;


    private void Awake()
    {
        receptionistDialog = GameObject.Find("/Efe/Receptionist1/Dialog");
        txt = receptionistDialog.GetComponent<TMP_Text>();

        bubble = GameObject.Find("/Efe/Receptionist1/Bubble");
    }

    private void Update()
    {
        if (show)
        {
            ShowDialogReceptionist();
        }
    }

    public void SetShow()
    {
        show = true;
        showTime = 30f;
        receptionistDialog.GetComponent<MeshRenderer>().enabled = true;
        bubble.transform.GetChild(0).gameObject.SetActive(false);
        bubble.transform.GetChild(1).gameObject.SetActive(false);
        bubble.transform.GetChild(2).gameObject.SetActive(false);
        bubble.transform.GetChild(3).gameObject.SetActive(false);
        txt.text = "";
    }

    private void ShowDialogReceptionist()
    {
        if (showTime > 0)
        {
            showTime -= Time.deltaTime;
            if (showTime < ((time / 6) * 1))
            {
                txt.text = "We wIsh you a nIce day.";
            }
            else if (showTime < ((time / 6) * 2))
            {
                txt.text = "You can complete the reservatIon process on the screen here.";
            }
            else if (showTime < ((time / 6) * 3))
            {
                txt.text = "You can vIsIt varIous rooms In our hotel and choose the room you want.";
            }
            else if (showTime < ((time / 6) * 4))
            {
                txt.text = "I would lIke to help you make a reservatIon usIng the Near Protocol Infrastructure.";
            }
            else if (showTime < ((time / 6) * 5))
            {
                txt.text = "I am the receptIonIst.";
            }
            else if (showTime < 27f)
            {
                bubble.transform.GetChild(3).gameObject.SetActive(true);
                txt.text = "HELLO AND WELCOME TO NEAR HOTEL...";
            }
            else if (showTime < 28f)
            {
                bubble.transform.GetChild(2).gameObject.SetActive(true);
            }
            else if (showTime < 29f)
            {
                bubble.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (showTime < 30f)
            {
                bubble.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        else if (showTime <= 0)
        {
            receptionistDialog.GetComponent<MeshRenderer>().enabled = false;
            bubble.transform.GetChild(0).gameObject.SetActive(false);
            bubble.transform.GetChild(1).gameObject.SetActive(false);
            bubble.transform.GetChild(2).gameObject.SetActive(false);
            bubble.transform.GetChild(3).gameObject.SetActive(false);
            show = false;
        }
    }
}
