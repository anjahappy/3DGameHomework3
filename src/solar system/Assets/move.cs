using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

  public Transform Sun;
  public Transform Moon;
  public Transform Mercury;//水星
  public Transform Venus;//金星
  public Transform Earth;//地球
  public Transform Mars;//火星
  public Transform Jupiter;//木星
  public Transform Saturn;//土星
  public Transform Uranus;//天王星
  public Transform Neptune;//海王星

  // Use this for initialization
  void Start () {
      Sun.position = Vector3.zero;
  }

  // Update is called once per frame
  void Update () {
      Mercury.RotateAround (Sun.position, new Vector3(0, 5, 1), 60 * Time.deltaTime);
      Mercury.Rotate ( new Vector3(0, 5, 1) * 10000 / 58 * Time.deltaTime);

      Venus.RotateAround (Sun.position, new Vector3(0, 2, 1), 55 * Time.deltaTime);
      Venus.Rotate (new Vector3(0, 2, 1) * 10000/ 243 *Time.deltaTime);

      Earth.RotateAround (Sun.position, Vector3.up, 50 * Time.deltaTime);
      Earth.Rotate (Vector3.up * 30 * Time.deltaTime);
      Moon.transform.RotateAround (Earth.position, Vector3.up, 5 * Time.deltaTime);

      Mars.RotateAround (Sun.position, new Vector3(0, 12, 5), 45 * Time.deltaTime);
      Mars.Rotate (new Vector3(0, 12, 5) * 10000 * Time.deltaTime);

      Jupiter.RotateAround (Sun.position, new Vector3(0, 10, 3), 35 * Time.deltaTime);
      Jupiter.Rotate (new Vector3(0, 10, 3) * 10000/0.3f * Time.deltaTime);

      Saturn.RotateAround (Sun.position, new Vector3(0, 3, 1), 20 * Time.deltaTime);
      Saturn.Rotate (new Vector3(0, 3, 1) * 10000/0.4f * Time.deltaTime);

      Uranus.RotateAround (Sun.position, new Vector3(0, 10, 1), 15 * Time.deltaTime);
      Uranus.Rotate (new Vector3(0, 10, 1) * 10000/0.6f * Time.deltaTime);

      Neptune.RotateAround (Sun.position, new Vector3(0, 8, 1), 10 * Time.deltaTime);
      Neptune.Rotate (new Vector3(0, 8, 1) * 10000/0.7f * Time.deltaTime);
  }
}