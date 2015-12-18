using UnityEngine;
using System.Collections;


// Generate cubes leaving path through **not working**
public class maze : MonoBehaviour {

    public GameObject cube;
    public int minXZ, maxXZ;



    // Use this for initialization
    void Start () {

        int x, z;
        //Gap in cubes to leave path. + or - 3 to start away from edges
        int randomGap = Random.Range(minXZ + 3, maxXZ - 3);



        for (x = minXZ; x < maxXZ; x++)
        {
            for (z = minXZ; z < maxXZ; z++)
            {
                //Leave a gap of two at randomgap
                if (z == randomGap )
                {
                    //Use to indicate whether to go left or right 
                    int randomChange = Random.Range(0, 10);

                    if (randomChange % 2 == 1) 
                    {
                        randomGap++;
                    }
                    else if (randomChange % 2 ==0)
                    {
                        randomGap--;
                    }
                    break;
                }
                else 
                {
                    GameObject newCube = GameObject.Instantiate(cube);
                    Vector3 p = new Vector3(x, 1, z);
                    newCube.transform.position = p;
                }

            }
        }

    }

  



    // Update is called once per frame
    void Update () {
	
	}
}
