using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartHealthBar : MonoBehaviour
{
    public GameObject heartPrefab;
    public PlayerHealth playerHealth;
    List<HeartHealth> hearts = new List<HeartHealth>();

    private void OnEnable() {
        PlayerHealth.OnPlayerDamaged += DrawHearts;
    }    private void OnDisable() {
        PlayerHealth.OnPlayerDamaged -= DrawHearts;
    }

    void Start()
    {
        DrawHearts();
    }
    public void DrawHearts ()
    {
        ClearHearts();
        for (int i = 0; i < playerHealth.maxHealth; i++)
        {
            CreateEmptyHeart();
        }
        for (int i = 0; i < hearts.Count; i++)
        {
            int HeartStatusRemainder = (int)Mathf.Clamp(playerHealth.health - i,0 ,1);
            hearts[i].SetHeartImage((HeartStatus)HeartStatusRemainder);
        }
    }

    public void CreateEmptyHeart () {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HeartHealth heartComponent = newHeart.GetComponent<HeartHealth>();
        heartComponent.SetHeartImage(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }
    public void ClearHearts () {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HeartHealth>();
    }
}
