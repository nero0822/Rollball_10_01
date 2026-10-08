//ライブラリの宣言　->これからこの機能を使うよ
using UnityEngine;
using UnityEngine.InputSystem; 

public class NewMonoBehaviourScript : MonoBehaviour
{
    //変数、関数
    //変数 ->int,string　値を格納するための箱
    //アクセス修飾子＋データ型(int,string,InputAction)＋変数名(num,name)
    private InputAction MoveInput;
    //関数->処理をまとめて実行するための箱

    //目的(抽象的課題):ステージを回転させること
    //手段(具体的課題):ActionMapを使用してプレイヤーの入力を受け取る
    //　　　　　　　　　受け取った入力をもとにステージのRotstionを変更する

    //Start ->シーンのロード時(ゲーム開始時)に自動的に実行される関数
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveInput = InputSystem.actions.FindAction("Move");
    }

    // Update ->:毎フレーム(0,1～0.3f刻み)に自動で実行される関数
    void Update()
    {
        Debug.Log(MoveInput.ReadValue<Vector2>());
        //  A += B -> A= A+ B
        //this.transform.localposition ->このコードがアタッチされているオブジェクトの位置情報
        //moveInput.Readlue<Vector2> -=(X,Y,Z=0)
        Vector3 rotation;
        float threshold = 0.2f;
        //Vector3 -> (x.y.z)
        //MoveInput.ReadValue<Vector2>().x =>x軸
        //MoveInput.ReadValue<Vector2>().y =>z軸
        rotation = new Vector3(MoveInput.ReadValue<Vector2>().y*threshold, 0, MoveInput.ReadValue<Vector2>().x*threshold);
        this.transform.Rotate(rotation);
        //this.transform.Rotation += (x,y);
        //X,Z += (x,y)
        //1.回転軸がおかしい

    }
}
