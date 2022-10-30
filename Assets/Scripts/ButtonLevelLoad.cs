using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{
    // Start is called before the first frame update

    public string mLevelToLoad;
    
    public void LoadLevel()
    {
        SceneManager.LoadScene(mLevelToLoad);
    }
}
