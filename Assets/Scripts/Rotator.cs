using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(new Vector3(45, 15, 30) * Time.deltaTime);
    }
}
