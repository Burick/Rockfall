using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipThrust : MonoBehaviour
{
    [Header("Скорость крабобля")]
    [Range( 1.0f, 20.0f)]
    public float speed = 5.0f;

    // Перемещает корабль вперед с постоянной скоростью
    void Update()
    {
        // конструкция (Time.deltaTime * speed) позволяет сделать
        // равномерную величину вне зависимости от времени Update
        var offset = Vector3.forward * (Time.deltaTime * speed);
        this.transform.Translate(offset);
    }
}