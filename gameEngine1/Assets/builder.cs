using UnityEngine;
using System.Collections;

// ****** Builds large warehouse type building *****
public class builder : MonoBehaviour
{


    public GameObject cube;//instantiate this at runtime
    public GameObject roofCube;
    public int width = 100;
    int height = 10;
    int depth = 21;
    int roofHeight = 11;

    // Use this for initialization
    private void Awake()
    {

        int x = 0, y = 0, z = 0;

        //Nestd loops for walls
        for (z = 0; z < depth + 1; z++)
        {
            //walls built to depth 
            if (z <= 0 || z >= depth)
            {
                for (x = 0; x < width + 1; x++)
                {
                    for (y = 0; y < height + 1; y++)
                    {
                        GameObject newCube = GameObject.Instantiate(cube);
                        Vector3 p = new Vector3(x, y, z);
                        newCube.transform.position = p;

                    }
                }
            }
        }


       //Build half roof. Z counting down from depth
        for (y = height - 1; y < height + roofHeight + 1; y++)
        {
            for (x = 0; x < width + 1; x++)
            {
                GameObject newCube = GameObject.Instantiate(roofCube);
                Vector3 p = new Vector3(x, y, z + 1);
                newCube.transform.position = p;

            }
            z--;
        }
        // Build other half z counting up from -3 works when depth is 21
        z = -3;
        for (y = height - 1; y < height + roofHeight + 1; y++)
        {
            for (x = 0; x < width + 1; x++)
            {
                GameObject newCube = GameObject.Instantiate(roofCube);
                Vector3 p = new Vector3(x, y, z + 1);
                newCube.transform.position = p;

            }
            z++;
        }
    }
}