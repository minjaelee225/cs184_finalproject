using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Bezier : MonoBehaviour {

	private LineRenderer lineRenderer;
	private Vector3 point0, point1, point2, point3;

	public float moveSpeed = 8f;
	private int numPoints = 50;
	private Vector3[] positions = new Vector3[50];

	private Vector3 pos;

	int currentPosition;
	float duration = 1.0f;
	Vector3 startPoint;
	Vector3 endPoint;
	float startTime;
	

	// Use this for initialization
	void Start () {
		GameObject newLine = new GameObject("Line");
		lineRenderer = newLine.AddComponent<LineRenderer> ();
		lineRenderer.startWidth = 0.1f;
		lineRenderer.positionCount = numPoints;
		pos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		Vector3[] points = new Vector3[4];
		points [0] = transform.position;
		for (int i = 1; i < 3; i++) {
			float randX = Random.Range(pos.x, transform.position.x);
			float randY = Random.Range(pos.y, transform.position.y);
			float randZ = Random.Range(pos.z, transform.position.z);
			Vector3 randPoint = new Vector3(randX, randY, randZ);
			points[i] = randPoint;
		}
		points[3] = pos;
		point0 = points [0];
		point1 = points [1];
		point2 = points [2];
		point3 = points [3];
		//DrawLinear ();
		//DrawQuad ();
		DrawCubic ();
		currentPosition = 0;
		startPoint = transform.position;
		startTime = Time.time;
		endPoint = positions [currentPosition];
	}
	
	// Update is called once per frame
	void Update () {
		/*if (currentPosition < 30) {
			currentPosition++;
		}
		float t = Time.deltaTime / timetoReachTarget;
		transform.position = Vector3.Lerp (transform.position, positions [currentPosition], t * moveSpeed);*/
		//DrawCubic ();
		float i = (Time.time - startTime) / duration;
		transform.position = Vector3.Lerp (startPoint, endPoint, i);
		if (i >= 1) {
			startTime = Time.time;
			currentPosition++;
			currentPosition = currentPosition % positions.Length;
			startPoint = endPoint;
			endPoint = positions[currentPosition];
		}

	}

	private void DrawLinear() {
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
	}

	private void DrawCubic() {
		for (int i = 1; i < numPoints + 1; i++) {
			float t = i/(float)numPoints;
			positions [i - 1] = calculateCubicBezierPoint (t, point0, point1, point2, point3);
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
