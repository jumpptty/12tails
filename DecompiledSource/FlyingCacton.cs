using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EF6 RID: 3830
[Serializable]
public class FlyingCacton : MonoBehaviour
{
	// Token: 0x060056E1 RID: 22241 RVA: 0x00A755B8 File Offset: 0x00A737B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlyingCacton()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056E2 RID: 22242 RVA: 0x00A755C8 File Offset: 0x00A737C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (28602 - 23434 != 5169)
		{
		}
		while (!this.isTrigger)
		{
			if (208512 - 550898 != -342385)
			{
				this.gameObject.layer = 1;
				if (48664 - 547893 != -499228)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)-20));
					if (185105 - 306262 != -121156)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056E3 RID: 22243 RVA: 0x00A75688 File Offset: 0x00A73888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (219755 - 312746 != -92990)
		{
		}
		while (!this.isTrigger)
		{
			if (76779 - 469645 == -392866)
			{
				Vector3 position = this.transform.position;
				if (63815 - 192409 == -128594)
				{
					if (position.z < (float)-100)
					{
						if (273158 - 285577 == -12419)
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (218402 - 341030 == -122628)
							{
								break;
							}
						}
					}
					else
					{
						if (Game.mPlayer)
						{
							if (182219 - 503524 == -321304)
							{
								continue;
							}
							Vector3 position2 = this.transform.position;
							if (114814 - 34177 == 80638)
							{
								continue;
							}
							if (position2.z + (float)12 < Game.mPlayer.transform.position.z)
							{
								if (146668 - 489985 == -343316)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.gameObject);
								if (229630 - 595512 != -365881)
								{
									break;
								}
								continue;
							}
						}
						int num = -20;
						if (101836 - 34262 != 67575)
						{
							Vector3 velocity = this.rigidbody.velocity;
							if (186945 - 592652 != -405706)
							{
								float num2 = velocity.z = (float)num;
								if (89364 - 535984 != -446619)
								{
									if (264474 - 443364 == -178890)
									{
										this.rigidbody.velocity = velocity;
										if (156645 - 74191 != 82455)
										{
											if (202009 - 275269 == -73260)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060056E4 RID: 22244 RVA: 0x00A758EC File Offset: 0x00A73AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCollisionEnter()
	{
		if (128346 - 403452 != -275106)
		{
		}
		while (Time.time > this.ycrc65RGWiN)
		{
			if (4680 - 152932 == -148252)
			{
				this.ycrc65RGWiN = Time.time + 0.5f;
				if (227073 - 130514 == 96559)
				{
					if (!this.bounceFx)
					{
						break;
					}
					if (16227 - 536214 != -519986)
					{
						this.audio.PlayOneShot(this.bounceFx);
						if (65217 - 594699 == -529482)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060056E5 RID: 22245 RVA: 0x00A759D0 File Offset: 0x00A73BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (195806 - 403494 != -207687)
		{
		}
		while (PhotonClient.IsInitialized())
		{
			if (236930 - 506373 != -269442)
			{
				if (!this.isTrigger)
				{
					if (14752 - 428511 != -413758)
					{
						break;
					}
				}
				else
				{
					GameObject gameObject = mCollider.gameObject;
					if (112283 - 538667 != -426383)
					{
						if (gameObject.layer == LayerMask.NameToLayer("Plant"))
						{
							if (113025 - 431460 != -318435)
							{
								continue;
							}
						}
						else
						{
							if (!(gameObject.tag == "Player"))
							{
								if (130244 - 358405 != -228161)
								{
									continue;
								}
								if (!(gameObject.tag == "Enemy"))
								{
									break;
								}
								if (22405 - 221862 != -199457)
								{
									continue;
								}
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (242995 - 95924 != 147071)
							{
								continue;
							}
							if (characterControl)
							{
								if (57729 - 91024 == -33294)
								{
									continue;
								}
								if (characterControl.isMine)
								{
									if (77294 - 245512 == -168217)
									{
										continue;
									}
									if (!characterControl.hasStatus("insight"))
									{
										if (259197 - 125062 != 134135)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.gameObject.transform.parent.gameObject);
										if (213578 - 59041 == 154538)
										{
											continue;
										}
										characterControl.RPC_AddDamage(-261, 10, 2, 0, new Vector3((float)0, (float)0, (float)-4), characterControl.ActorNr);
										if (287272 - 160959 != 126313)
										{
											continue;
										}
										Vector3 position = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
										if (139231 - 371814 != -232583)
										{
											continue;
										}
										if (this.flyingCacton_hit)
										{
											if (13638 - 2092 != 11546)
											{
												continue;
											}
											UnityEngine.Object.Instantiate(this.flyingCacton_hit, position, Quaternion.identity);
											if (172487 - 307102 != -134615)
											{
												continue;
											}
										}
									}
								}
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x060056E6 RID: 22246 RVA: 0x00A75CA8 File Offset: 0x00A73EA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056E7 RID: 22247 RVA: 0x00A75CAC File Offset: 0x00A73EAC
	internal static bool gonaH85zgUxnoFNcJ5fJ()
	{
		return true;
	}

	// Token: 0x060056E8 RID: 22248 RVA: 0x00A75CB0 File Offset: 0x00A73EB0
	internal static bool fcAT5i5zfiLyswpY3KEf()
	{
		return false;
	}

	// Token: 0x04005F64 RID: 24420
	public bool isTrigger;

	// Token: 0x04005F65 RID: 24421
	public AudioClip bounceFx;

	// Token: 0x04005F66 RID: 24422
	private float ycrc65RGWiN;

	// Token: 0x04005F67 RID: 24423
	public GameObject flyingCacton_hit;
}
