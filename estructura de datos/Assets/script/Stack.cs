using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stack<int> originalStack = new Stack<int>();
        originalStack.Push(4);
        originalStack.Push(-5);
        originalStack.Push(-10);
        originalStack.Push(88);
        originalStack.Push(2);


        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        // vaciamos la pila original y le damos todos los valores a la pila1 
        while (originalStack.Count > 0)
        {
            stack1.Push(originalStack.Pop());
        }

        while (stack1.Count > 0)
        {
            int aux = stack1.Pop();
            while (stack1.Count > 0)
            {
                if (stack1.Peek() < aux) // cuando el numero del stack1 sea menor que el auxiliar nos guardamos el valor del aux en la pila 2 y el valor de auxiliar lo actualizamos con el que sale de la pila 1
                {
                    stack2.Push(aux);
                    aux = stack1.Pop();
                }
                else
                {
                    stack2.Push(stack1.Pop()); // para pasar  de la pila 1 a la pila 2
                }
            }
            // el menor valor de aux pasa al stack original
            originalStack.Push(aux);

            //swap de las pilas
            Stack<int> auxStack = stack1; // variable necesaria para hacer el swap
            stack1 = stack2;
            stack2 = auxStack;
        }

        while (originalStack.Count > 0)
        {
            Debug.Log(originalStack.Pop());
        }




    
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
