using JetBrains.Annotations;
using UnityEngine;

public class Peggie_Score : MonoBehaviour
{
    public int addPoints;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D target)
    {
        ScoreManager.Instance.AddScore(addPoints);
        Destroy(gameObject);
    }
}
