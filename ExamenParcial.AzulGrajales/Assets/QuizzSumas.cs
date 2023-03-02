using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizzSumas : MonoBehaviour
{
    [SerializeField] private TMP_Text reversa;
    [SerializeField] private TMP_Text comprobar;
    [SerializeField] private TMP_Text ecuacion;

    public TMP_InputField interactivo;
    private int numal1; //numero aleatorio 1
    private int numal2;
    private int result;
    private int numjugador;
   

    void Start()
    {

        NumRandom();
        Suma();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NumRandom()
    {
        numal1 = Random.Range(1, 11);
        numal2 = Random.Range(1, 11);
        ecuacion.text = "Preparate para tu siguiente pregunta:" + numal1 + "+" + numal2;
    }

    private void Suma()
    {
        result = numal1 + numal2;
    }    

    public void Comparar()
    {
        int.TryParse(interactivo.text, out numjugador);

        Debug.Log(result);
        Debug.Log(numjugador);

        if (result == numjugador)
        {
            comprobar.text = "Es correcto!";
            
        }

        else 
        {
            comprobar.text = "Incorrecto :(";
        }
    }


    public void Reinicio()
    {
        SceneManager.LoadScene(1);
    }
}
