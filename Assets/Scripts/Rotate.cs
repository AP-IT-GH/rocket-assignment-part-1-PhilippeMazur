using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int score = 0;
    public bool yesno = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(this.transform.rotation.x * 70 * Time.deltaTime, this.transform.rotation.y * 70 * Time.deltaTime, this.transform.rotation.z ));
        
    }
    private void OnTriggerEnter(Collider other)
    {
        yesno = true;
        this.transform.position = new Vector3(100, 100, 100);
    }
}
