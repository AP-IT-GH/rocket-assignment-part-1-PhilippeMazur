using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coin;
    public GameObject txt;
    public Rotate rot;
    private int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coin.GetComponent<Rotate>().yesno == true)
        {
            score++;
            txt.GetComponent<UnityEngine.UI.Text>().text = "Score : " + score;
            coin.GetComponent<Rotate>().yesno = false;
        }
    }
}
