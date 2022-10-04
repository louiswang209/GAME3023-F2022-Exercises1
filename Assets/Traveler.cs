using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Traveler : MonoBehaviour
{

    public string LastSpawnPointName
    {
        get;
        set;
    } = "";

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoadAction;
    }

    void OnSceneLoadAction(Scene scene, LoadSceneMode loadMode)
    {
        if (LastSpawnPointName != "")
        {
            //Find spawn point
            SpawnPoint[] spawnPoints = GameObject.FindObjectsOfType<SpawnPoint>();
            foreach (SpawnPoint spawn in spawnPoints)
            {
                //Teleport to that spawn
                if (spawn.name == LastSpawnPointName)
                {
                    transform.position = spawn.transform.position;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
