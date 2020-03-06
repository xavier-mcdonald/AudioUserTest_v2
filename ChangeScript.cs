using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScript : MonoBehaviour {

    public GameObject cube1, cube2;
    bool happenedOnce = false;

    private void Start()
    {

        DontDestroyOnLoad(cube1);
        DontDestroyOnLoad(cube2);

    }

    void Update() {


        // tells to stop loading scene so that it only happens once.
        if (!happenedOnce && Input.GetKeyDown(KeyCode.Space))
        {
            happenedOnce = true;
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
            

        }



    }

    
}

