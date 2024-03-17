using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<char, string> diccionario = new Dictionary<char, string>();
        diccionario.Add('€' , 'Euro');
        diccionario.Add('$' , 'Dollar'):
        diccionario.Add('¥', 'Yen');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
