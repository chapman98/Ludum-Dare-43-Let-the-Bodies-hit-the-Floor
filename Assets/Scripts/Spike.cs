//Kill Player (Dosent leave body)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
public class Spike : MonoBehaviour
{
    public Tile spike;
    public Tilemap spiketilemap;

    private Vector3Int previous;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Debug.Log("boo");
            // Currently spawns at pos 0
            Vector3Int currentCell = spiketilemap.WorldToCell(this.transform.position);
            spiketilemap.SetTile(currentCell, spike);
            spiketilemap.SetTile(previous, null);
        }
    }
}