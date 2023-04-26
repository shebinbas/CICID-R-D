using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class InternetTest
{
    [Test]
    public void CheckInternetConnection_WhenConnected_ReturnsTrue()
    {
        // Arrange
        var internetChecker = new InternetChecker();

        // Act
        var isConnected = internetChecker.CheckInternetConnection();

        // Assert
        Assert.IsTrue(isConnected);
    }

    [Test]
    public void CheckInternetConnection_WhenNotConnected_ReturnsFalse()
    {
        // Arrange
        var internetChecker = new InternetChecker();

        // Act
        var isConnected = internetChecker.CheckInternetConnection();

        // Assert
        Assert.IsFalse(isConnected);
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
