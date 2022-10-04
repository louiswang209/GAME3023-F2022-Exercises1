using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    [SerializeField]
    GameObject playerPrefeb;

    //private static Traveler player = null;
    public static Traveler Player
    {
        get;
        private set;
        //get { return player; }
        //private set { }
    }

    
    
    // Start is called before the first frame update
    void Start()
    {
        if(Player == null && playerPrefeb != null)
        {
            GameObject newPlayer = Instantiate(playerPrefeb, transform.position, Quaternion.identity);
            Player = newPlayer.GetComponent<Traveler>();
        }
    }

    
}
