using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject Effect1;
    public GameObject Music1;
    public void Start()
    {
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
        Effect1.SetActive(false);
        Music1.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        Effect1.SetActive(true);
        Music1.SetActive(true);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(10);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }
    }
