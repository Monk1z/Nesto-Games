using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour

{
    public GameObject ThirdCam;
    public GameObject FirstCam;
    public int CamMode;


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey ("q")){
        if (CamMode == 1) {
            CamMode = 0;
        } else {
            CamMode = 1;
        }
        StartCoroutine (CameraChange());


       } 
    }

    IEnumerator CameraChange () {
        yield return new WaitForSeconds (0.1f);
        if (CamMode == 0) {
            ThirdCam.SetActive(true);
            FirstCam.SetActive(false);
        }
        if (CamMode == 1) {
            FirstCam.SetActive(true);
            ThirdCam.SetActive(false);
        }



    }
}
