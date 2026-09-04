using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCreatingProperties : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerCreatingProperties myPlayer = new PlayerCreatingProperties();


        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
