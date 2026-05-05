using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;

    public enum EstadoJogo
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public EstadoJogo estadoAtual;

    private void Awake()
    {
        if (Instancia != null && Instancia != this)
        {
            Destroy(gameObject);
            return;
        }

        Instancia = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        DefinirEstado(EstadoJogo.Iniciando);
    }

    public void DefinirEstado(EstadoJogo novoEstado)
    {
        estadoAtual = novoEstado;
        Debug.Log("Estado atual: " + estadoAtual);
    }

    public void CarregarCena(string nomeCena)
    {
        switch (nomeCena)
        {

            case "MenuPrincipal":
                DefinirEstado(EstadoJogo.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                DefinirEstado(EstadoJogo.Gameplay);
                break;
        }

        SceneManager.LoadScene(nomeCena);
    }
}