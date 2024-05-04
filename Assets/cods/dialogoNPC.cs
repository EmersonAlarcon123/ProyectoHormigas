using System.Collections;
using UnityEngine;
using TMPro;

public class dialogoNPC : MonoBehaviour
{
    private bool estaCerca;
    [SerializeField] private GameObject dialogo;

    [SerializeField, TextArea(3,4)] private string[] lienadeDialogo;
    [SerializeField] private GameObject textoMostrar; // panel del dialogo
    [SerializeField] private TMP_Text texto; //dialogo text

    private bool iniciodialogo;
    private bool indicasiinicio;
    private int linea;

    private float timeForLinea = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (estaCerca && Input.GetKey(KeyCode.H))
        {
            if (!indicasiinicio) 
            {
                iniciadialogo();
            }
            else if(texto.text == lienadeDialogo[linea]) 
            {
                nextText();
            }
        }
    }
    public void iniciadialogo()
    {
        indicasiinicio = true;
        textoMostrar.SetActive(true);
        dialogo.SetActive(false);
        linea = 0;
        StartCoroutine(showline());
    }
    private void nextText()
    {
        linea++;    
        if (linea < lienadeDialogo.Length)
        {
            StartCoroutine(showline());
        }
        else 
        {
            indicasiinicio = false;
            textoMostrar.SetActive(false);
            dialogo.SetActive(true);
        }
    }


    private IEnumerator showline()
    {
        texto.text = string.Empty;

        foreach (char ch in lienadeDialogo[linea])
        {
            texto.text += ch;
            yield return new WaitForSeconds(0.05f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            estaCerca = true;
            dialogo.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            estaCerca = false;
            dialogo.SetActive(false);
        }
    }
}
