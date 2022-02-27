using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStart : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown) SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        
    }
}
