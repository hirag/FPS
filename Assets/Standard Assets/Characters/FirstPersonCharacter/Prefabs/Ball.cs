using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    void Update()
    {
        //３秒後に削除されます。
        Destroy(gameObject, 3f);

    }
}