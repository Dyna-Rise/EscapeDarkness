using TMPro;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public RoomData roomData; //親オブジェクトの持っているスクリプトを取得
    MessageData message;//親オブジェクトが持つScriptableObject情報を取得

    bool isPlayerInRange; //プレイヤーが領域に入ったかどうか
    bool isTalk; //トークが開始されたかどうか
    GameObject canvas; //トークUIを含んだCanvasオブジェクト
    GameObject talkPanel; //対象となるトークUIパネル
    TextMeshProUGUI nameText; //対象となるトークUIパネルの名前
    TextMeshProUGUI messageText; //対象となるトークUIパネルのメッセージ

    void Start()
    {
        message = roomData.message; //トークデータは親オブジェクトのスクリプトにある変数を参照

        //トークUIオブジェクトなどの情報取得
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        talkPanel = canvas.transform.Find("TalkPanel").gameObject;
        nameText = talkPanel.transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        messageText = talkPanel.transform.Find("MessageText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
