using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	[SerializeField, Min(0f)]float maxXSpeed=20f, startXSpeed = 8f,	constantYSpeed = 10f, extents = 0.5f;

	Vector2 position, velocity , zeroPosition = Vector2.zero;
	public Vector2 Velocity => velocity;

	public float Extents => extents;
	public Vector2 Position => position;
	public void UpdateVisualization() => transform.localPosition = new Vector3(position.x, 0f, position.y);

	public void Move() => position += velocity * Time.deltaTime;

	public void StartNewGame()
	{
		position = zeroPosition;
		UpdateVisualization();
		velocity = new Vector2(startXSpeed, -constantYSpeed);
	}

	public void SetXPositionAndSpeed(float start, float speedFactor, float deltaTime)
	{
		velocity.x = maxXSpeed * speedFactor;
		position.x = start + velocity.x * deltaTime;
	}

	public void BounceX(float boundary)
	{
		position.x = 2f * boundary - position.x;
		velocity.x = -velocity.x;
	}

	public void BounceY(float boundary)
	{
		position.y = 2f * boundary - position.y;
		velocity.y = -velocity.y;
	}


}
