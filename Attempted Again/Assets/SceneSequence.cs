using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequence : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Player;
    void Start() {
        StartCoroutine (TheSequence());

        IEnumerator TheSequence ()
        {
            yield return new WaitForSeconds(10);
            Cam1.SetActive (false);
            Player.SetActive(true);

        }

    }

   
}
