using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("打到分數")]
    public int scoreIn = 2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="神奇球球")
        {
            AddScore();
        }
        if (other.tag == "聯結球")
        {
            scoreIn = 3;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "聯結球")
        {
            scoreIn = 2;
        }
    }
    private void AddScore()
    {
        score += scoreIn;
        textScore.text = "目前得分:" + score;
    }
}
