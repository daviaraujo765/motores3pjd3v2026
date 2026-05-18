using UnityEngine;

public class BootLoader : MonoBehaviour
{
    void Start()
    {
        GameManager.Instancia.DefinirEstado(GameManager.EstadoJogo.Iniciando);
        GameManager.Instancia.CarregarCena("Splash");
    }
}