using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Destroy : MonoBehaviour
{
    public List<Rigidbody2D> rbPieces = new List<Rigidbody2D>();

    float dirX, dirY, torque;

    void Start()
    {
        for(int i=0;i<rbPieces.Count;i++)
        {
            dirX = Random.Range(-5, 5);
            dirY = Random.Range(5, 8);
            torque = Random.Range(5, 15);

            rbPieces[i].AddForce(new Vector2(dirX, dirY), ForceMode2D.Impulse);
            rbPieces[i].AddTorque(torque, ForceMode2D.Force);
        }

        //mais legal deixar a mostra hehe
        //Destroy(gameObject, 5);
    }
}
