using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class TestAnim : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        InternetChecker internetChecker = new InternetChecker();
        bool isConnected = internetChecker.CheckInternetConnection();

        // Check internet connection
        if (isConnected)
        {
            Debug.Log("Internet connection is available.");
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class InternetChecker
{
    public bool CheckInternetConnection()
    {
        try
        {
            using (var client = new WebClient())
            {
                using (var stream = client.OpenRead("https://www.google.com"))
                {
                    return true;
                }
            }
        }
        catch
        {
            return false;
        }
    }
}
