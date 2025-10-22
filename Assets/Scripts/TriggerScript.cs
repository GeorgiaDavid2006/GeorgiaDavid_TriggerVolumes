using Unity.VisualScripting;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject cube;
    public Material trigger_Mat;
    public Material trigger_Mat2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cube.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        cube.SetActive(true);
        gameObject.GetComponent<Renderer>().material = trigger_Mat;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().material = trigger_Mat2;
        }
    }
}
