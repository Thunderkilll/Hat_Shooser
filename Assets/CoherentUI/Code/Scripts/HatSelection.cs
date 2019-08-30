using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KhaledGuesmi
{
    public class HatSelection : MonoBehaviour
    {
        public GameObject hat1;
        public GameObject hat2;
        public GameObject hat3;
        public GameObject hat4;


        public void Hat1Selected()
        {
            hat1.SetActive(true);
            hat2.SetActive(false);
            hat3.SetActive(false);
            hat4.SetActive(false);
        }
        public void Hat2Selected()
        {
            hat1.SetActive(false);
            hat2.SetActive(true);
            hat3.SetActive(false);
            hat4.SetActive(false);
        }
        public void Hat3Selected()
        {
            hat1.SetActive(false);
            hat2.SetActive(false);
            hat3.SetActive(true);
            hat4.SetActive(false);
        }
        public void Hat4Selected()
        {
            hat1.SetActive(false);
            hat2.SetActive(false);
            hat3.SetActive(false);
            hat4.SetActive(true);
        }
    }
}

