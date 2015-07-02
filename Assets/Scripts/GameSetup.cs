using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour
{

    public Camera mainCamera;
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public float edgeDistancePlayer = 75f;  //75 Pixels

    public Transform Player;
    
    void Start()
    {

        topWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0, 0)).x, 1f);
        topWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y + 0.5f);

        bottomWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        leftWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y); ;
        leftWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        rightWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

        Player.position = new Vector3(mainCamera.ScreenToWorldPoint(new Vector3(edgeDistancePlayer, 0f, 0f)).x, 0f, 0f);
    }
}