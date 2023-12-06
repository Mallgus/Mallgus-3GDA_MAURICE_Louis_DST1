using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformActions : MonoBehaviour
{

    public void RotateLocalPitch(float pitch)
    {
        transform.Rotate(pitch, 0, 0, Space.Self);
    }

    public void RotateLocalYaw(float yaw)
    {
        transform.Rotate(0, yaw, 0, Space.Self);
    }

    public void RotateLocalRoll(float roll)
    {
        transform.Rotate(0,0, roll, Space.Self);
    }

    public void TeleportX(float x)
    {
        Vector3 pos = transform.position;
        pos.x = x;
        transform.position = pos;
    }

    public void TeleportY(float y)
    {
        Vector3 pos = transform.position;
        pos.y = y;
        transform.position = pos;
    }

    public void TeleportZ(float z)
    {
        Vector3 pos = transform.position;
        pos.z = z;
        transform.position = pos;
    }

    public void TranslateLocalX(float a)
    {
        transform.Translate(a, 0, 0);
    }
    public void TranslateLocalY(float a)
    {
        transform.Translate(0, a, 0);
    }
    public void TranslateLocalZ(float a)
    {
        transform.Translate(0, 0, a);
    }

    public void TranslateWorldX(float a)
    {
        transform.Translate(a, 0, 0, Space.World);
    }
    public void TranslateWorldY(float a)
    {
        transform.Translate(0, a, 0, Space.World);
    }
    public void TranslateWorldZ(float a)
    {
        transform.Translate(0, 0, a, Space.World);
    }
}
