using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class share_button : MonoBehaviour
{
	public GameObject UIelements;
	public GameObject UIelements2;


	public void ClickShareButton()
    {
		UIelements.SetActive(false);
		UIelements2.SetActive(false);
		StartCoroutine(TakeScreenshotAndShare());
	    

    }

	private IEnumerator TakeScreenshotAndShare()
	{       
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
		File.WriteAllBytes(filePath, ss.EncodeToPNG());
		

		// To avoid memory leaks
		Destroy(ss);
		UIelements.SetActive(true);
		UIelements2.SetActive(true);


		new NativeShare().AddFile(filePath)
			.SetSubject("Your Future STEM Career Photo is Ready!")
			.SetText("Congratulations! You chose the perfect STEM career. If you’d like to learn more about how you can accelerate your path to college and next-gen careers, please visit the ASU Prep Academy website to explore our school options.")
			.SetUrl( "asuprep.asu.edu/" )
			.SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
			.Share();

		

		


	}

    

}
