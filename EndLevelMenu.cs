using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndLevelMenu : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Panel.gameObject.SetActive(true);
    }
    void EndLevel()
    {
        Panel.gameObject.SetActive(true);
    }
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Panel.gameObject.SetActive(false);
    }
    void Menu()
    {
        SceneManager.LoadScene(0);
        Panel.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Flag")
        {
            Debug.Log("niveau fini");
            Panel.gameObject.SetActive(true);
        }
    }
}
