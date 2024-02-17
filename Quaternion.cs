using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
Homework Problems

Given that we have a 3D cube in your Unity scene, we want to 
animate our cube to rotate with Quaternions. 

*/
public class QuaternionHW : MonoBehaviour
{
    // TODO: Problem 1: Define Vector3 and Rotation variables here.
    Vector3 Vector = new Vector3(1f, 1f, 1f);
    float rotation = 30f;

    // TODO: Problem 2: Define two Quaternions
    Quaternion quaternion1 = Quaternion.identity;
    Quaternion quaternion2 = Quaternion.Euler(0f, 0f, 30f);

    // Update is called once per frame
    void Update()
    {
        // Example Problem: Multiply a quaternion by a vector using Quaternion.Euler and save it as a temporary variable
        //result = Quaternion.Euler(0, rotation, 0) * result;


        // TODO: Problem 3: Multiply a Quaternion by another Quaternion using Quaternion.Euler and save it as a temporary variable
        Quaternion result = Quaternion.Euler(0f, 0f, 30f) * quaternion1;

        // TODO: Problem 4: Check if two quaternions are equal to each other. 

        // If they are, print out the "[Names of Quaternions] are Equal".
        // Else, print out "Quaternions are different"
        if (quaternion1 == quaternion2)
        {
            Debug.Log("Quaternion1 and Quaternion2 are Equal");
        }
        else
        {
            Debug.Log("Quaternion1 and Quaternion2 are different");
        }

        // TODO: Problem 5: Using Quaternion.Lerp, rotate your vector
        // The vector starts at (0,0,0) and wants to be rotated to (100, 100, 100)
       Vector3 startVector = new Vector3(0f, 0f, 0f);
        Vector3 targetVector = new Vector3(100f, 100f, 100f);
        float lerpFactor = 0.5f;
        Vector3 lerpedVector = Vector3.Lerp(startVector, targetVector, lerpFactor);
        transform.position = lerpedVector;
    }
}