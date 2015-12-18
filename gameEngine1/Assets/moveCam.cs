using UnityEngine;
using System.Collections;

// Camera movement and firing behaviour
public class moveCam : MonoBehaviour {


    public KeyCode forwardButton;
    public KeyCode leftButton;
    public KeyCode rightButton;

    public KeyCode diveButton;
    public KeyCode lookUpButton;
    public KeyCode levelButton;
    public KeyCode fireCube;


    //speed ball will fire at
    public int launchSpeed = 30;
    float x, y, z;

    public float speed = 10;
    public float turnSpeed = 90;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(forwardButton))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
           
        }
        

        if (Input.GetKey(leftButton))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(rightButton))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(diveButton))
        {
            transform.Rotate(Vector3.right, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(lookUpButton))
        {
            transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(levelButton))
        {
            //Get y angle and level out
            y = transform.eulerAngles.y;

            transform.rotation = Quaternion.Euler(0, y, 0);

        }
        if (Input.GetKey(fireCube))
        {
            Vector3 look = transform.forward;
            
            //Create ball on the fly
            GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //Place in front of user camera
            ball.transform.position = transform.position + 6 * transform.forward;

            //Ball Colour
            ball.GetComponent<Renderer>().material.color = Color.yellow;
            //Add light inside ball
            var light = ball.AddComponent<Light>();
            light.color = Color.green;

            //Make rigidbody
            Rigidbody rigidBody = ball.AddComponent<Rigidbody>();
            rigidBody.mass = 1.0f;
            rigidBody.velocity = transform.forward * launchSpeed;


        }
       
    }
}
