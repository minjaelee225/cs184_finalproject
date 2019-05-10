using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class bez : MonoBehaviour {

	public LineRenderer lineRenderer;
	public Transform point0, point1, point2, point3;

	private int numPoints = 50;
	private Vector3[] positions = new Vector3[50];

	private Vector3 pos;
	private Vector3[] controlPoints;

	// Use this for initialization
	void Start () {
		//lineRenderer = lineRenderer;
		lineRenderer.positionCount = numPoints;
		pos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		//Debug.Log (pos);
		/*Vector3[] points = new Vector3[4];
		points[0] = transform.position;
		for (int i = 1; i < 2; i++) {
			float randX = Random.Range(pos.x, transform.position.x);
			float randY = Random.Range(pos.y, transform.position.y);
			float randZ = Random.Range(pos.z, transform.position.z);
			Vector3 randPoint = new Vector3(randX, randY, randZ);
			points[i] = randPoint;
		}
		points[3] = pos;
		controlPoints = points.OrderBy (v => v.z).ToArray();
		point0 = controlPoints [0];
		point1 = controlPoints [1];
		point2 = controlPoints [2];
		point3 = controlPoints [3];*/
		//DrawLinear ();
		//DrawQuad ();
		DrawCubic ();
	}

	// Update is called once per frame
	void Update () {
		//DrawCubicCurve ();
		//DrawCubic ();
	}

	/*private void DrawLinear() {
		for (int i = 1; i < numPoints + 1; i++) {
			float t = i/(float)numPoints;
			positions [i - 1] = calculateLinearBezierPoint (t, point0, point1);
		}
		lineRenderer.SetPositions (positions);
	}

	private void DrawQuad() {
		for (int i = 1; i < numPoints + 1; i++) {
			float t = i/(float)numPoints;
			positions [i - 1] = calculateQuadBezierPoint (t, point0, point1, point2);
		}
		lineRenderer.SetPositions (positions);
	}*/

	private void DrawCubic() {
		for (int i = 1; i < numPoints + 1; i++) {
			float t = i/(float)numPoints;
			positions [i - 1] = calculateCubicBezierPoint (t, point0.position, point1.position, point2.position, point3.position);
		}
		lineRenderer.SetPositions (positions);
	}

	private Vector3 calculateLinearBezierPoint(float t, Vector3 p0, Vector3 p1) {
		return p0 + t * (p1 - p0);
	}

	private Vector3 calculateQuadBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2) {
		float u = 1 - t;
		return (Mathf.Pow (u, 2) * p0) + (2 * u * t * p1) + (Mathf.Pow (t, 2) * p2);
	}

	private Vector3 calculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) {
		float u = 1 - t;
		return (Mathf.Pow(u, 3) * p0) + (3 * Mathf.Pow(u, 2) * t * p1) + (3 * u * Mathf.Pow(t, 2) * p2) + (Mathf.Pow(t, 3) * p3);
	}
}
