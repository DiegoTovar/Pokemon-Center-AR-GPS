using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSelector : MonoBehaviour
{
     public void SetScene(int SceneNumber) 
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
