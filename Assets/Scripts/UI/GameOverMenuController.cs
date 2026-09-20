using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{

    public class GameOverMenu : MonoBehaviour
    {
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
        

    }   
    
    
    
}