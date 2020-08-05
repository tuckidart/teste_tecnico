using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Destroy : MonoBehaviour
{
    public GameObject mensagem;
    public Transform headPivot;
    public List<Rigidbody2D> rbPieces = new List<Rigidbody2D>();

    float dirX, dirY, torque;
    float timeToDestroy = 3;
    float timer;
    bool destroyed = false;
    float speed = 45;

    void Start()
    {
        mensagem.SetActive(true);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToDestroy && !destroyed)
        {
            Explode();
            destroyed = true;
        }
        else if (!destroyed)
        {
            //shake head
            float AngleAmount = (Mathf.Cos(Time.time * speed) * 180) / Mathf.PI * 0.5f;
            AngleAmount = Mathf.Clamp(AngleAmount, -20, 20);
            headPivot.transform.localRotation = Quaternion.Euler(0, 0, AngleAmount);
        }
    }

    void Explode()
    {
        mensagem.SetActive(false);

        for (int i = 0; i < rbPieces.Count; i++)
        {
            dirX = Random.Range(-5, 5);
            dirY = Random.Range(5, 8);
            torque = Random.Range(5, 15);

            rbPieces[i].simulated = true;
            rbPieces[i].AddForce(new Vector2(dirX, dirY), ForceMode2D.Impulse);
            rbPieces[i].AddTorque(torque, ForceMode2D.Force);
        }

        //mais legal deixar a mostra hehe
        //Destroy(gameObject, 5);
    }
}
