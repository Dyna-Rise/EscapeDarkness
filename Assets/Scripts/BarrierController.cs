using UnityEngine;

public class BarrierController : MonoBehaviour
{
    public float deleteTime = 5.0f; //消滅するまでの時あkン

    void Start()
    {
        //deleteTime秒後に消滅
        Destroy(gameObject, deleteTime);
    }

}
