using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Counter : MonoBehaviour

{

  
    public Text counterText;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Coroutine());

    }

    IEnumerator Coroutine()
    {
        counterText.text = "Ready?";
        yield return new WaitForSeconds(1);

        for (int i = 3; i >= 0; i--)
        {
            if (i == 0)
            {
                counterText.text = "GO!";
                yield return new WaitForSeconds(1);

                Destroy(gameObject);

            }
            else
            {
                counterText.text = i.ToString();
                yield return new WaitForSeconds(1);
            }
        }

    
    }


}
