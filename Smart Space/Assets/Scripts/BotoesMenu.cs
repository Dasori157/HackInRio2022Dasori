using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu : MonoBehaviour
{
    public Animator anim;
    [SerializeField]
    string cena;
   public void JogarEsair()
   {
        anim.SetTrigger("FadeOut");
        Invoke("CarregarCena", 1);
        
   }

    void CarregarCena()
    {
        SceneManager.LoadScene(cena);
    }

    public void Sair()
    {
        anim.SetTrigger("FadeOut");
        Invoke("Sair2", 1f);
    }

    void Sair2()
    {
        Application.Quit();
    }
}
