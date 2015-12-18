using UnityEngine;
using System.Collections;


// Build a pyramid of user selected width
public class Structure : MonoBehaviour {

    public GameObject cube;
    public int startposX, startposZ;
    public int width;
    int x , y , z, height ;
    // Use this for initialization
    void Start () {

        // height needs to be greater than width to close pyramid
        height = width * 2;

        for (y = 1; y <= height; y++)
        { 
            //these loops give us one hollow square at height y
            for (z = startposZ; z < startposZ + width + 1; z++)
            {
                for (x = startposX; x < startposX + width + 1; x++)
                {
                    //Checks to build only on edges
                    if ((x == startposX || x == startposX + width) || (z == startposZ || z == startposZ + width))
                    {
                        GameObject pCube = GameObject.Instantiate(cube);
                        Vector3 p = new Vector3(x, y, z);

                        //Assign colours to cubes. Use mix of red and green. No blue
                        Color c =  new Color(Random.Range(0.7f, 1f), Random.Range(0.2f, 0.5f), 0);
                        pCube.GetComponent<Renderer>().material.color = c;
                        
                        //Place cube
                        pCube.transform.position = p;
                    }
                }

            }
            //Decrease for each layer of pyramid
            width = width - 2;
            startposX++;
            startposZ++;

        }
    }
	
	
}
