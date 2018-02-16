using UnityEngine;
using System.Collections;

public class BlockCreator : MonoBehaviour {
    public GameObject[] blockPrefabs;
    private int block_count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void createBlock(Vector3 block_position)
    {
        // 만들어야 할 블럭의 종류(흰색 or 빨간색)를 구한다.
        int next_block_type = this.block_count % this.blockPrefabs.Length;

        // 블럭을 생성하고 go에 보관한다.
        GameObject go = GameObject.Instantiate(this.blockPrefabs[next_block_type]) as GameObject;

        go.transform.position = block_position;
        this.block_count++;
    }

}
