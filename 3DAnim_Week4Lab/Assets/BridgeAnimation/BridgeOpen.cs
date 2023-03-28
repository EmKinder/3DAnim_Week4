using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeOpen : MonoBehaviour
{
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator anim7;
    public Animator anim8;
    public Animator anim9;
    public Animator anim10;
    public Animator anim11;
    public bool TriggerTest;
    public float waitTime = 0.1f;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(TriggerTest == true)
        {
            StartCoroutine(ThisBridgeOpen1(waitTime));
            TriggerTest = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(ThisBridgeOpen1(waitTime));
        }
        
    }
    
    IEnumerator ThisBridgeOpen1(float waitTime)
    {
        anim1.SetTrigger("PutBridgeUp");
        yield return new WaitForSecondsRealtime(waitTime);
       
        StartCoroutine(ThisBridgeOpen2(waitTime));
        anim1.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen2(float waitTime)
    {
        anim2.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen3(waitTime));
        anim2.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen3(float waitTime)
    {
        anim3.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen4(waitTime));
        anim3.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen4(float waitTime)
    {
        anim4.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen5(waitTime));
        anim4.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen5(float waitTime)
    {
        
        anim5.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen6(waitTime));
        anim5.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen6(float waitTime)
    {
        
        anim6.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen7(waitTime));
        anim6.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen7(float waitTime)
    {
        
        anim7.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen8(waitTime));
        anim7.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen8(float waitTime)
    {
        
        anim8.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen9(waitTime));
        anim8.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen9(float waitTime)
    {
        
        anim9.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen10(waitTime));
        anim9.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen10(float waitTime)
    {
        
        anim10.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);

        StartCoroutine(ThisBridgeOpen11(waitTime));
        anim10.GetComponent<Renderer>().enabled = true;

    }
    IEnumerator ThisBridgeOpen11(float waitTime)
    {
        
        anim11.SetTrigger("PutBridgeUp");

        yield return new WaitForSecondsRealtime(waitTime);
        anim11.GetComponent<Renderer>().enabled = true;



    }
}
