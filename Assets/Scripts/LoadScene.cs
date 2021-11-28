using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LoadPlayScene();
        // HelpLoadScene();
        // GameQuit();
    }
    public void LoadPlayScene(){
        SceneManager.LoadScene("SampleScene");
    }
    public void HelpLoadScene(){
        SceneManager.LoadScene("StoryMain");
    }
    public void GameQuit(){
        Application.Quit();
    }
}
