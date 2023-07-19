using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController instance;
    public GameObject DiaLog;
   
    private void Awake()
    {
        instance=this;
    }
    void Start()
    {
        DiaLog.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void Update()
    {
        
    }
}
