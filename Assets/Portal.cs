using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// this object type will transport traveler into other scene
public class Portal : MonoBehaviour
{
    [SerializeField]
    private string destinationSpawn = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Portal entered by:" + collision.gameObject.name);
        //find out if it is a Traveler
        Traveler traveler = collision.GetComponent<Traveler>();
        if(traveler != null)
        {
            traveler.LastSpawnPointName = destinationSpawn;
            SceneManager.LoadScene(gameObject.tag, LoadSceneMode.Single);
        }
    }

}
