using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParOimpar : MonoBehaviour
{
    public TextMeshProUGUI resultado;
    public TMP_InputField input;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void paroimp()
    {
        if (input.text == "")
        {
            return;
        }
        int num = int.Parse(input.text);
        if (num % 2 == 0)
        {
            resultado.text = "PAR";
        }
        else
        {
            resultado.text = "IMPAR";
        }
    }
}
