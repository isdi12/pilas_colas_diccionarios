using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Queue <int> originalQueue= new Queue<int> ();

        originalQueue.Enqueue(50);
        originalQueue.Enqueue(80);
        originalQueue.Enqueue(1);
        originalQueue.Enqueue(9);

            Queue<int> queue1 = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();

        while (originalQueue.Count > 0)
        {
            queue1.Enqueue(originalQueue.Dequeue());
        }

        while (queue1.Count > 0)
        {
            int aux = queue1.Dequeue();
            while (queue1.Count > 0)
            {
                if(queue1.Peek() < aux)
                {
                    queue2.Enqueue(aux);
                    aux = queue1.Dequeue();
                }
                else
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
            }
            originalQueue.Enqueue(aux);

            Queue<int> auxQueue = queue1;
                queue1  = queue2;
            queue2 = auxQueue; 
        }

        while(originalQueue.Count > 0)
        {
            Debug.Log(originalQueue.Dequeue()); 
        }
    }

  
}
