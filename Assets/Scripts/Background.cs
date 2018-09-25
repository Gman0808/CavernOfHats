using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {


    public GameObject[] walls;
    float lastPos = -13.5f;

    //x - 6.5
    //x -12.587
    //x - 13.51
    // Use this for initialization
    void Start () {
        walls = GameObject.FindGameObjectsWithTag("bWall");
 
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerControls.instance.alive)
        {
            foreach (GameObject wal in walls)
            {

                wal.transform.position -= new Vector3(0.03f, 0, 0);

                if (wal.transform.position.x > lastPos)
                    lastPos = wal.transform.position.x;


                if (wal.transform.position.x <= -13.5f)
                {
                    wal.transform.position = new Vector3(lastPos - 0.45f, wal.transform.position.y, wal.transform.position.z);
                }


            }
        }
            
	}
}
