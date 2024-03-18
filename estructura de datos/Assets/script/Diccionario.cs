using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionario : MonoBehaviour
{
    public string currencyToSearch;
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string , char> diccionario = new Dictionary<string, char>();
        diccionario.Add("euro" , '€');
        diccionario.Add("dollar", '$');
        diccionario.Add("yen", '¥');

        if(diccionario.ContainsKey(currencyToSearch.ToLower())) // para sacarlo usamos el containskey , el toLower es para pasarlo todo a minuscula y toUpper para mayusculas
        {
            print(diccionario[currencyToSearch.ToLower()]);
        }
        else
        {
            Debug.LogError("No contiene esa key");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
