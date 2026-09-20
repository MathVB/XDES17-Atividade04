using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{

    public class MainMenu : MonoBehaviour
    {
        public void StartGame()
        {
                SceneManager.LoadScene("MainMenu");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    

}   
    
    
    
}

