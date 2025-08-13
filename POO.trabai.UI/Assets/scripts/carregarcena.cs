using UnityEngine;
using UnityEngine.SceneManagement;


public class carregarcena : MonoBehaviour
{
    public string nomeDaCena;

    public void Carregar()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
    
    
}
