using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ballparking method vs. BPM method
// bpm song -> bps song -> note speed
public class Note : MonoBehaviour
{
  Rigidbody2D rb;
  public float speed;

  private void Awake()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  void Start()
  {
    rb.velocity = new Vector2(0, -speed);
  }

  void Update()
  {

  }
}
