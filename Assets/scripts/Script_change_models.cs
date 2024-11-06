using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_change_models : MonoBehaviour
{
    public GameObject Filter1;
    public GameObject Filter2;
    public GameObject[] filters;
    public int currentIndex = 0;

    public int filters_count;


    // Start is called before the first frame update
    void Start()
    {



    }
    public void switchfilters()
    {
        Filter1.SetActive(false);
        Filter2.SetActive(true);

        /*foreach (GameObject obj in filters)
        {
            obj.SetActive(true);
        }*/

        // Update is called once per frame
     

    }
}
