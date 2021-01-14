using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderCircle : MonoBehaviour
{
   [SerializeField] private float _radius = 1.0f;
   [SerializeField] private int _segment = 128;

   private void Start()
   {
     
      DoRender();

   }


   void DoRender()
   {
      LineRenderer lineRenderer = GetComponent<LineRenderer>();
      Color c1 = new Color(0.5f, 0.5f, 0.5f, 1f);
      //lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
      lineRenderer.SetColors(c1,c1);
      lineRenderer.SetWidth(0.1f, 0.1f);
      lineRenderer.SetVertexCount(_segment + 1);
      lineRenderer.useWorldSpace = false;

      float deltaTheta = (float) (2.0 * Mathf.PI) / _segment;
      float theta = 0f;

      for (int i = 0; i < _segment + 1; i++)
      {
         float x = _radius * Mathf.Cos(theta);
         float z = _radius * Mathf.Sin(theta);
         
         Vector3 _pos = new Vector3(x , -0.5f , z);
         lineRenderer.SetPosition(i, _pos);
         theta += deltaTheta;
      }
   }
}
