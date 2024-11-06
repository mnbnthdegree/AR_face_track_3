using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class extra_elements : MonoBehaviour
{
	public GameObject b00;
	public GameObject b01;
	public GameObject b02;
	public GameObject b03;
	public GameObject b04;
	public GameObject b05;
	public GameObject b06;



	public void button00()
    {
		b00.SetActive(true);
		b01.SetActive(false);
		b02.SetActive(false);
		b03.SetActive(false);
		b04.SetActive(false);
		b05.SetActive(false);
		b06.SetActive(false);

    }

    public void button01()
    {
        
		b00.SetActive(false);
		b01.SetActive(true);
		b02.SetActive(false);
		b03.SetActive(false);
		b04.SetActive(false);
		b05.SetActive(false);
		b06.SetActive(false);

    }

    public void button02()
    {
        
		b00.SetActive(false);
		b01.SetActive(false);
		b02.SetActive(true);
		b03.SetActive(false);
		b04.SetActive(false);
		b05.SetActive(false);
		b06.SetActive(false);

    }

    public void button03()
    {
        
		b00.SetActive(false);
		b01.SetActive(false);
		b02.SetActive(false);
		b03.SetActive(true);
		b04.SetActive(false);
		b05.SetActive(false);
		b06.SetActive(false);

    }

    public void button04()
    {
        
		b00.SetActive(false);
		b01.SetActive(false);
		b02.SetActive(false);
		b03.SetActive(false);
		b04.SetActive(true);
		b05.SetActive(false);
		b06.SetActive(false);

    }

    public void button05()
    {
        
		b00.SetActive(false);
		b01.SetActive(false);
		b02.SetActive(false);
		b03.SetActive(false);
		b04.SetActive(false);
		b05.SetActive(true);
		b06.SetActive(false);

    }

    public void button06()
    {
        
		b00.SetActive(false);
		b01.SetActive(false);
		b02.SetActive(false);
		b03.SetActive(false);
		b04.SetActive(false);
		b05.SetActive(false);
		b06.SetActive(true);

    }

    

}
