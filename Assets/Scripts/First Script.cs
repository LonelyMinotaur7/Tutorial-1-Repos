using UnityEngine;

public class FirstScript : MonoBehaviour
    
{
    int age = 20;
    float speed = 2.5f;
    // Camel case

    int NumberOfStudents = 0;
    string welcomeMessage = "Welcome";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world. My first script");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        Debug.Log("Inside onEnable");
    }
}

