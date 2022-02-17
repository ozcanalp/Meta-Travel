using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowReceptionistDialog : MonoBehaviour
{
    private GameObject receptionistDialog;
    public float showTime = 0f;
    private float time = 30f;
    private TMP_Text txt;

    private bool show = false;


    private void Awake()
    {
        receptionistDialog = GameObject.Find("/Efe/Receptionist1/Dialog");
        txt = receptionistDialog.GetComponent<TMP_Text>();
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
        txt.text = "HELLO AND WELCOME TO NEAR HOTEL...";
        showTime = 30f;
        receptionistDialog.GetComponent<MeshRenderer>().enabled = true;
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
        }
        else if (showTime <= 0)
        {
            receptionistDialog.GetComponent<MeshRenderer>().enabled = false;
            show = false;
        }
    }
}
