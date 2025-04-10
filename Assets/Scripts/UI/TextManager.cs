using UnityEngine;
using UnityEngine.UI;

public class FreeFall : MonoBehaviour
{
    public Text gText;  // 중력 가속도 UI
    public Text velocityText; // 속도 UI
    public Text timeText; // 시간 UI
    public Text distanceText; // UI 추가

    


    public GameObject Substance1;
    private GravityController PhysicalFactor;

    void Start()
    {
        PhysicalFactor = Substance1.GetComponent<GravityController>();
    }

    void Update()
    {
         // UI 업데이트
        gText.text = "g: " + PhysicalFactor.g.ToString("F2") + " m/s²";
        velocityText.text = "Velocity: " + PhysicalFactor.velocity.y.ToString("F2") + " m/s";
        timeText.text = "Time: " + PhysicalFactor.elapsedTime.ToString("F2") + " s";
        distanceText.text = "Distance: " + (0.5f * PhysicalFactor.g * PhysicalFactor.elapsedTime * PhysicalFactor.elapsedTime).ToString("F2") + " m";
    }
}
