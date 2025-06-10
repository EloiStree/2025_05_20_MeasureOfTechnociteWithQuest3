using UnityEngine;

[ExecuteInEditMode]
public class TechnoMono_DrawPath : MonoBehaviour
{

    public Transform [] m_points;
    public Color m_color = Color.yellow;
    public bool m_drawEndToStart = true;


    private void Reset()
    {

        m_points = GetComponentsInChildren<Transform>();
        m_points = System.Array.FindAll(m_points, t => t != transform); 

    }

    // Update is called once per frame
    void Update()
    {
        if (m_points == null || m_points.Length < 2)
        {
            return;
        }
        for (int i = 0; i < m_points.Length - 1; i++)
        {
            Debug.DrawLine(m_points[i].position, m_points[i + 1].position, m_color);
        }
        if (m_drawEndToStart)
        {
            Debug.DrawLine(m_points[m_points.Length - 1].position, m_points[0].position, m_color);
        }
    }
}
