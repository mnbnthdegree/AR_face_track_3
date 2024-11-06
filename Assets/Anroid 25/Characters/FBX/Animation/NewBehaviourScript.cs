using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator anim;
   

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("walk", false);
        anim.SetBool("run", false);
        anim.SetBool("idle", true);

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("walk", true);
            anim.SetBool("idle", false);
            anim.SetBool("run", false);

        }
        else
        {
            anim.SetBool("walk", false);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            anim.SetBool("run", true);
            anim.SetBool("idle", false);
            anim.SetBool("walk", false);
        }
        else
        {
            anim.SetBool("run", false);
        }




}
}