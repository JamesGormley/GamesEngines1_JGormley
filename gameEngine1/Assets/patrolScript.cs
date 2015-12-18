using UnityEngine;
using System.Collections;

//Script to make object move in circle. Anchored by empty gameobject
public class patrolScript : MonoBehaviour {

    public GameObject ship;
    public int rotSpeed = 10;
    public int startX = 10;
    public int startZ = 10;
    public float waveHeight = 10f;
    float y = 10f;
    GameObject newShip;

    // Use this for initialization
    void Start () {

        //create object
        newShip = GameObject.Instantiate(ship);
        Vector3 p = new Vector3(startX, y, startZ);
        newShip.transform.position = p;


    }
	
	// Update is called once per frame
	void Update () {
        
        newShip.transform.RotateAround(transform.parent.position, Vector3.up, rotSpeed * Time.deltaTime);


        //Makes ship float up endlessly
        //newShip.transform.Translate(Vector3.up * Mathf.Sin(Time.deltaTime) * 5);

    }
}
