using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_gameobjects : MonoBehaviour
{

    public GameObject filter1;
    public GameObject filter2;

    //public int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchFilter01()
    {
        filter1.SetActive(true);
        filter2.SetActive(true);

    }

    public void SwitchFilter02()
    {

        filter1.SetActive(false);
        filter2.SetActive(true);         
        /* foreach (GameObject obj in filterob)
        {
            obj.SetActive(true);
        }

       

        for (int i = 0; i < filterob.Length; i++)
        {
            filterob[i].SetActive(false);
        }*/
    }

}