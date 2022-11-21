using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    private float speed = 50f;
    private float FloatStrenght = 170f;
    private float FloatStrenght2 = 3f;

    private float inputX;
    public Rigidbody RocketBody;



    // Start is called before the first frame update
    void Start()
    {
        RocketBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ProcessInput();
    }

    void Move()
    {
    

        
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * FloatStrenght2);
            print("space");

        }
        


    }

    void rotate()
    {
        transform.Rotate(transform.rotation.x + inputX, transform.rotation.y, transform.rotation.z);
    }

    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            RocketBody.AddRelativeForce(Vector3.up * Time.deltaTime * FloatStrenght);
        }
        if ((Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow)) && !(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            Rotation('L');
        }
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && !((Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))))
        {
            Rotation('R');
        }
    }
    void Rotation(char Rotation)
    {
        switch (Rotation)
        {
            case 'L':
                RocketBody.freezeRotation = true;
                transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                RocketBody.freezeRotation = false;
                break;

            case 'R':
                RocketBody.freezeRotation = true;
                transform.Rotate(-Vector3.forward * Time.deltaTime * speed);
                RocketBody.freezeRotation = false;
                break;
        }
    }
}
