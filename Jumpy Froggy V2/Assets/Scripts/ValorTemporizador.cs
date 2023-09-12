using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValorTemporizador : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public Temporizador temporizador;
    private int tiempo;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();    
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = (int)temporizador.tiempoActual;
        textMesh.text = tiempo.ToString();
    }
}
