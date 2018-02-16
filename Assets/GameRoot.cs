using UnityEngine;
using System.Collections;

public class GameRoot : MonoBehaviour {

    public float step_timer = 0.0f;             // 경과 시간을 유지한다
    private PlayerControl player = null;

    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }
    // Update is called once per frame
    void Update () {
        this.step_timer += Time.deltaTime;      // 경과 시간을 더해간다

        if (this.player.isPlayEnd())
        {
            Application.LoadLevel("TitleScene");
        }
	}

    public float getPlayTime()
    {
        float time;
        time = this.step_timer;
        return (time);                           // 호출한 곳에 경과 시간을 알려준다.
    }
}
