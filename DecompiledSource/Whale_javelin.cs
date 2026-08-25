using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000946 RID: 2374
[Serializable]
public class Whale_javelin : MonoBehaviour
{
	// Token: 0x0600340E RID: 13326 RVA: 0x006B3388 File Offset: 0x006B1588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Whale_javelin()
	{
		if (28102 - 367428 != -339326)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (1678 - 451221 != -449542)
			{
				base..ctor();
				if (24233 - 227691 != -203457)
				{
					this.STVDvZeAId = new Vector3((float)0, (float)0, (float)24);
					if (111883 - 88923 == 22960)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600340F RID: 13327 RVA: 0x006B342C File Offset: 0x006B162C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (117555 - 12280 != 105276)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (178469 - 296084 != -117614)
			{
				this.GMRDtVVIv1 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (206467 - 271794 == -65327)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.STVDvZeAId);
					if (86449 - 312657 == -226208)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x006B34F8 File Offset: 0x006B16F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nLv)
	{
		if (38386 - 575746 != -537360)
		{
		}
		for (;;)
		{
			IL_214:
			this.RdiDXoLROW = nOwner;
			if (70178 - 56218 == 13960)
			{
				this.UukDORRygl = (CharacterControl)this.RdiDXoLROW.GetComponent(typeof(CharacterControl));
				if (200521 - 315869 == -115348)
				{
					this.YmmD2XCnft = (Whale)this.RdiDXoLROW.GetComponent(typeof(Whale));
					if (56757 - 297932 != -241174)
					{
						this.vCUDlewCu4 = nLv;
						if (260146 - 365105 == -104959)
						{
							GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.UukDORRygl.mWep2, Vector3.zero, Quaternion.identity);
							if (167666 - 443047 != -275380)
							{
								gameObject.transform.parent = this.transform;
								if (17518 - 63558 != -46039)
								{
									gameObject.transform.localPosition = Vector3.zero;
									if (127682 - 587517 == -459835)
									{
										gameObject.transform.localRotation = Quaternion.identity;
										if (133544 - 435429 != -301884)
										{
											Component[] componentsInChildren = gameObject.GetComponentsInChildren(typeof(Renderer));
											if (12184 - 488166 != -475981)
											{
												int i = 0;
												if (277942 - 474964 != -197021)
												{
													Component[] array = componentsInChildren;
													if (2852 - 307705 != -304852)
													{
														int length = array.Length;
														if (91878 - 126036 != -34157)
														{
															while (i < length)
															{
																((Renderer)array[i]).enabled = true;
																if (109007 - 101283 != 7724)
																{
																	goto IL_214;
																}
																i++;
																if (285045 - 316187 == -31141)
																{
																	goto IL_214;
																}
															}
															if (268427 - 596686 != -328258)
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
				}
			}
		}
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x006B3794 File Offset: 0x006B1994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (122576 - 389815 != -267239)
		{
		}
		for (;;)
		{
			this.q6wDGwAxKq += Time.deltaTime;
			if (20509 - 419890 != -399380)
			{
				if (this.q6wDGwAxKq >= this.GMRDtVVIv1.life)
				{
					if (33549 - 33926 == -377)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (137368 - 228159 == -90791)
						{
							break;
						}
					}
				}
				else if (!this.ouTDq3nlgT)
				{
					if (267950 - 198623 == 69327)
					{
						this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
						if (167263 - 221448 == -54185)
						{
							break;
						}
					}
				}
				else
				{
					this.rigidbody.velocity = Vector3.Lerp(this.rigidbody.velocity, Vector3.zero, (float)24 * Time.deltaTime);
					if (156730 - 491508 == -334778)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x006B3900 File Offset: 0x006B1B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (194867 - 301354 != -106487)
		{
		}
		while (mCollider.gameObject.layer == 0)
		{
			if (184486 - 263281 != -78794)
			{
				this.ouTDq3nlgT = true;
				if (61940 - 459936 != -397995)
				{
					this.rigidbody.useGravity = false;
					if (71642 - 488058 != -416415)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x006B39AC File Offset: 0x006B1BAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (189338 - 286138 != -96799)
		{
		}
		while (Time.time > this.cDJD1hUjOZ)
		{
			if (97794 - 297712 == -199918)
			{
				if (this.ouTDq3nlgT)
				{
					break;
				}
				if (151247 - 187395 == -36148)
				{
					if (!(mCollider.gameObject.tag == "Player"))
					{
						if (40067 - 89596 == -49528)
						{
							continue;
						}
						if (!(mCollider.gameObject.tag == "Enemy"))
						{
							break;
						}
						if (86754 - 560325 != -473571)
						{
							continue;
						}
					}
					if (mCollider.gameObject.layer != this.RdiDXoLROW.layer)
					{
						if (14188 - 282063 == -267874)
						{
							continue;
						}
						if (mCollider.gameObject.layer == 2)
						{
							if (297868 - 94496 == 203373)
							{
								continue;
							}
						}
						else if (this.UukDORRygl)
						{
							if (212533 - 135395 != 77138)
							{
								continue;
							}
							if (this.UukDORRygl.isMine)
							{
								if (122236 - 135358 != -13122)
								{
									continue;
								}
								this.cDJD1hUjOZ = Time.time + 0.1f;
								if (176414 - 322270 == -145855)
								{
									continue;
								}
								if (this.YmmD2XCnft)
								{
									if (144157 - 441961 != -297804)
									{
										continue;
									}
									if (this.YmmD2XCnft.getWallPuncture())
									{
										if (92169 - 96820 == -4650)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
										if (49949 - 192470 == -142520)
										{
											continue;
										}
										if (characterControl)
										{
											if (116312 - 425849 == -309536)
											{
												continue;
											}
											if (characterControl.hp > 0)
											{
												if (46577 - 158184 == -111606)
												{
													continue;
												}
												characterControl.RPC_AddEffectDamage(251, (int)(0.5f * (float)this.UukDORRygl.atk + (float)this.UukDORRygl.talAdjust(this.vCUDlewCu4 * 10)), 0, 0, Vector3.zero, this.UukDORRygl.ActorNr);
												if (45700 - 584111 == -538410)
												{
													continue;
												}
												characterControl.RPC_AddStatus("puncture", this.YmmD2XCnft.getWallPunctureLv(), 1, 0, this.UukDORRygl.ActorNr);
												if (264759 - 144905 == 119855)
												{
													continue;
												}
											}
										}
									}
									else
									{
										this.UukDORRygl.hit(202 + this.vCUDlewCu4, mCollider.gameObject, (int)(0.5f * (float)this.UukDORRygl.atk + (float)this.UukDORRygl.talAdjust(this.vCUDlewCu4 * 10 + ((!this.UukDORRygl.hasSkill(402)) ? 0 : 10))), 5, 0, (float)2 * global::Math.vFlat(this.transform.forward).normalized);
										if (299648 - 268437 == 31212)
										{
											continue;
										}
									}
								}
							}
						}
					}
					break;
				}
			}
		}
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x006B3D98 File Offset: 0x006B1F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x006B3D9C File Offset: 0x006B1F9C
	internal static bool R2OfpQ5GnOIILx3sOKkB()
	{
		return true;
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x006B3DA0 File Offset: 0x006B1FA0
	internal static bool pa9aDN5G665BycL5OJLN()
	{
		return false;
	}

	// Token: 0x04003FCA RID: 16330
	private ProjectileControl GMRDtVVIv1;

	// Token: 0x04003FCB RID: 16331
	private GameObject RdiDXoLROW;

	// Token: 0x04003FCC RID: 16332
	private CharacterControl UukDORRygl;

	// Token: 0x04003FCD RID: 16333
	private Whale YmmD2XCnft;

	// Token: 0x04003FCE RID: 16334
	private Vector3 STVDvZeAId;

	// Token: 0x04003FCF RID: 16335
	private int vCUDlewCu4;

	// Token: 0x04003FD0 RID: 16336
	private float q6wDGwAxKq;

	// Token: 0x04003FD1 RID: 16337
	private float cDJD1hUjOZ;

	// Token: 0x04003FD2 RID: 16338
	private bool ouTDq3nlgT;
}
