using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colission : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.name == "RigidBodyFPSController")
        {
            Debug.Log("Houston, We have... emh... something?");
            
                SceneManager.LoadScene(2);
            
        }
    }
}
