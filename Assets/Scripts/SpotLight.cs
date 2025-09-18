using UnityEngine;

public class SpotLight : MonoBehaviour
{
    public PlayerController playerCnt; //PlayerControllerコンポーネント
    public float rotationSpeed = 20.0f; //スポットライトの回転速度

    void LateUpdate()
    {
        //寸前までのスポットライトの回転値（Z軸のみ取得）
        //float currentAngle = transform.eulerAngles.z;

        //プレイヤーの角度
        float targetAngle = playerCnt.angleZ;

        //ターゲットとなる角度を調整
        Quaternion targetRotation = Quaternion.Euler(0,0,(targetAngle - 90));

        //現在の回転を（寸前の回転）→（ターゲットの回転）になるように
        //なめらかに補間する Quaternion.Slerpメソッド
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

    }
}
