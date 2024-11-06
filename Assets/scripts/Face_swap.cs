using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class Face_swap : MonoBehaviour
{


    public ARFaceManager facemanager;
    public List<Material> faceMaterials = new List<Material>();
    private int faceMaterialIndex = 0;
    private int matindexfalse = 3;


    /*    public GameObject[] Face_filters;
    */    //public GameObject FilterMesh;
          // public Mesh[] Meshes;

     int facefilterIndex = 0;
     int totalfaceindex;

    void Start()
    {
        facemanager = GetComponent<ARFaceManager>();

        totalfaceindex = facemanager.facePrefab.transform.childCount;

    }

    public void OnClickButton(string PrefabChildName)
    {

        foreach (ARFace face in facemanager.trackables)
        {

            for(int i =0; i<face.transform.childCount; i++)
            {
                if(face.transform.GetChild(i).name== PrefabChildName)
                {
                    face.transform.GetChild(i).gameObject.SetActive(true);
                    facefilterIndex = i;

                }
                else
                {
                    face.transform.GetChild(i).gameObject.SetActive(false);

                }
            }
        }

   
    }
    public void SwitchFace()
    {
        #region oldcode
        /*  //facemanager.facePrefab = new 
          foreach (ARFace face in facemanager.trackables)
          {
              Destroy(facePrefab);

              facemanager.GetComponent<ARFaceManager>().facePrefab = Face_filters [facefilterIndex];


          }
          facefilterIndex++;


          if (facefilterIndex == Facefilters_count)
          {
              facefilterIndex = 0;
          }*/
        #endregion


        foreach (ARFace face in facemanager.trackables)
        {


            face.transform.GetChild(facefilterIndex).gameObject.SetActive(false);



        }


        facefilterIndex++;

        if (facefilterIndex >= totalfaceindex)
        {
            facefilterIndex = 0;
        }


        foreach (ARFace face in facemanager.trackables)
        {


            face.transform.GetChild(facefilterIndex).gameObject.SetActive(true);



        }

    }


    public void Switctmat(int indexnum)
    {
        foreach (ARFace face in facemanager.trackables)
        {
            face.GetComponent<Renderer>().material = faceMaterials[indexnum];



        }
        //faceMaterialIndex++;


       /* if (faceMaterialIndex == faceMaterials.Count)
        {
            faceMaterialIndex = 0;
        }*/
    }
}