using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    [SerializeField] private string url;

   public void BookRoom()
   {
       Application.OpenURL(url);
   }
}
