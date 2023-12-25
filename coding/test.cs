using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatasetTester : MonoBehaviour
{
    public TextAsset dataset;

    void Start()
    {
        string[] lines = dataset.text.Split('\n');
        foreach (string line in lines)
        {
            Debug.Log(line);
        }
    }
}

using NUnit.Framework;
using UnityEngine;

public class ExampleTest
{
    [Test]
    public void ExampleTestSimplePasses()
    {
        // Arrange
        int a = 1;
        int b = 2;

        // Act
        int result = a + b;

        // Assert
        Assert.AreEqual(3, result);
    }
}
