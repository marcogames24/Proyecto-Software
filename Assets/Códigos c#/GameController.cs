using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour

{
    // Referencia al personaje
    public GameObject jugador;

    // Referencia al punto B
    public Transform puntoB;

    // Referencia al texto de UI para mostrar el mensaje
    public Text mensajeUI;

    // Distancia para determinar la victoria
    public float distanciaVictoria = 1.0f;

    // Nivel de caída para determinar la derrota
    public float nivelCaida = -5f;

    void Update()
    {
        // Verificar si el jugador ha llegado al punto B (Zona Mística)
        float distancia = Vector3.Distance(jugador.transform.position, puntoB.position);
        if (distancia < distanciaVictoria)
        {
            Victoria();
        }

        // Verificar si el jugador ha caído
        if (jugador.transform.position.y <= nivelCaida)
        {
            Derrota();
        }

        // Verificar si el jugador desea reiniciar el nivel o salir del juego
        if (Input.GetKeyDown(KeyCode.R)) // Presionar 'R' para reiniciar
        {
            ReiniciarNivel();
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) // Presionar 'Esc' para salir
        {
            SalirDelJuego();
        }
    }

    // Método para manejar la victoria
    void Victoria()
    {
        mensajeUI.text = "¡Has ganado! Presiona 'R' para reiniciar o 'Esc' para salir.";
        jugador.SetActive(false); // Desactiva el jugador
    }

    // Método para manejar la derrota
    void Derrota()
    {
        mensajeUI.text = "Has perdido. Presiona 'R' para reiniciar o 'Esc' para salir.";
        jugador.SetActive(false); // Desactiva el jugador
    }

    // Método para reiniciar el nivel
    void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Método para salir del juego
    void SalirDelJuego()
    {
        Application.Quit();
    }
}





















