using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(IrParaMenu());
    }

    IEnumerator IrParaMenu()
    {
        yield return new WaitForSeconds(2f);
       
        GameManager.Instancia.CarregarCena("MenuPrincipal");
    }
}