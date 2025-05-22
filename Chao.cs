using UnityEngine;

public class Chao : MonoBehaviour
{

    public GameObject refPlayer;
    public Transform spawnPoint;
    public GameObject refPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  if(Input.GetKeyDown(KeyCode.Z)){

        //     refPlayer.SetActive(true);
            
        // }
       
        // if(Input.GetMouseButtonDown(0)){

        //     Destroy(refPlayer);
            
        // }
        
        if(Input.GetKeyDown(KeyCode.M)){

            Instantiate(refPrefab, spawnPoint);
            ScoreManager.circleCount++;

        }


    }
}

        // if(Input.GetKeyDown(KeyCode.Z)){

        //     refPlayer.SetActive(true);
            
        // }