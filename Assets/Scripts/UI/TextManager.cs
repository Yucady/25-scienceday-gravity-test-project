using UnityEngine;
using UnityEngine.UI;

public class FreeFall : MonoBehaviour
{
    public Text gText;  // �߷� ���ӵ� UI
    public Text velocityText; // �ӵ� UI
    public Text timeText; // �ð� UI
    public Text distanceText; // UI �߰�

    


    public GameObject Substance1;
    private GravityController PhysicalFactor;

    void Start()
    {
        PhysicalFactor = Substance1.GetComponent<GravityController>();
    }

    void Update()
    {
         // UI ������Ʈ
        gText.text = "g: " + PhysicalFactor.g.ToString("F2") + " m/s��";
        velocityText.text = "Velocity: " + PhysicalFactor.velocity.y.ToString("F2") + " m/s";
        timeText.text = "Time: " + PhysicalFactor.elapsedTime.ToString("F2") + " s";
        distanceText.text = "Distance: " + (0.5f * PhysicalFactor.g * PhysicalFactor.elapsedTime * PhysicalFactor.elapsedTime).ToString("F2") + " m";
    }
}
