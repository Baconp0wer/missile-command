using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField] GameObject playerMissilePrefab;
    [SerializeField] GameObject karakterPrefab;

    
    [SerializeField] private Texture2D cursorTexture;
private Vector2 cursorHotspot;
    // Start is called before the first frame update
    void Start()
    {
    cursorHotspot = new Vector2(cursorTexture.width / 2f, cursorTexture.height / 2f);
    Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            Instantiate(playerMissilePrefab, karakterPrefab.transform.position, Quaternion.identity);
        }
    }
}