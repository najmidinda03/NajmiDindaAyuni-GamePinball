using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
	public Collider Bola;
	public float multiplier;
	public Color color;
	public float score;

	public AudioManager audioManager;
	public VFXManager vfxManager;
	public ScoreManager scoreManager;

	private Renderer renderer;
	private Animator animator;


	private void Start()
{
	renderer = GetComponent<Renderer>();
	animator = GetComponent<Animator>();

 	renderer.material.color = color;
}

	private void OnCollisionEnter(Collision collision)
	{	
  		if (collision.collider == Bola)
 		 {
		
			Rigidbody bolaRig = Bola.GetComponent<Rigidbody>();
    		bolaRig.velocity *= multiplier;

			//Animasi
			animator.SetTrigger("Hit");

			//Play SFX
			audioManager.PlaySFX(collision.transform.position);

			//Play VFX
			vfxManager.PlayVFX(collision.transform.position);

			//Score add
			scoreManager.AddScore(score);
  		}
	}
}