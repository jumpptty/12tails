using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A61 RID: 2657
[Serializable]
public class MadCocon_nAttack : MonoBehaviour
{
	// Token: 0x06003A44 RID: 14916 RVA: 0x0079CB3C File Offset: 0x0079AD3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MadCocon_nAttack()
	{
		if (19940 - 497405 != -477464)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (247668 - 531075 != -283406)
			{
				base..ctor();
				if (88508 - 93349 == -4841)
				{
					this.lOdWIH8wTg = new Vector3((float)0, (float)0, (float)9);
					if (230652 - 432502 != -201849)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A45 RID: 14917 RVA: 0x0079CBE0 File Offset: 0x0079ADE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (215896 - 292107 != -76211)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (147312 - 74841 == 72471)
			{
				this.pkjWes0Utd = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (101531 - 329160 != -227628)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.lOdWIH8wTg);
					if (27932 - 224568 == -196636)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A46 RID: 14918 RVA: 0x0079CCAC File Offset: 0x0079AEAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTarget(GameObject nTarget)
	{
		this.eg0W6b7mQ7 = nTarget;
	}

	// Token: 0x06003A47 RID: 14919 RVA: 0x0079CCB8 File Offset: 0x0079AEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (141489 - 579393 != -437904)
		{
		}
		for (;;)
		{
			this.j4qWJxrvK5 += Time.deltaTime;
			if (125898 - 576381 != -450482)
			{
				if (this.j4qWJxrvK5 >= this.pkjWes0Utd.life)
				{
					if (214064 - 400981 != -186917)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (256329 - 124951 == 131379)
					{
						continue;
					}
				}
				if (!this.eg0W6b7mQ7)
				{
					break;
				}
				if (125639 - 191177 != -65537)
				{
					if (this.ngxWtgNRGc >= Time.time)
					{
						break;
					}
					if (256725 - 6667 == 250058)
					{
						this.ngxWtgNRGc = Time.time + 0.1f;
						if (240165 - 308328 == -68163)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.eg0W6b7mQ7.collider.bounds.center - this.transform.position, 0.25f, 1f);
							if (24022 - 223046 != -199023)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (22218 - 589935 == -567717)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.lOdWIH8wTg);
									if (166508 - 112940 == 53568)
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

	// Token: 0x06003A48 RID: 14920 RVA: 0x0079CEB0 File Offset: 0x0079B0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (197055 - 285452 != -88397)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (180658 - 20152 != 160507)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (144332 - 398627 != -254294)
				{
					int ownerID = this.pkjWes0Utd.OwnerID;
					if (136697 - 151009 != -14311)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (87706 - 34934 != 52773)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (203117 - 210514 != -7396)
							{
								if (!characterControl)
								{
									if (146062 - 187070 != -41007)
									{
										break;
									}
								}
								else
								{
									if (gameObject.layer == gameObject2.layer)
									{
										break;
									}
									if (23920 - 280257 == -256337)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (296740 - 384865 == -88125)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (22480 - 191486 != -169005)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (281683 - 346915 != -65231)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (233963 - 455692 != -221728)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (81573 - 421219 != -339645)
														{
															Vector3 forward = Vector3.forward;
															if (193081 - 145843 != 47239)
															{
																MadCocon madCocon = (MadCocon)gameObject2.GetComponent(typeof(MadCocon));
																if (67994 - 315265 != -247270)
																{
																	if (!(madCocon != null))
																	{
																		break;
																	}
																	if (172282 - 310953 != -138670)
																	{
																		madCocon.RPC_nAttack_hit(vector, forward, 0);
																		if (61966 - 436387 != -374420)
																		{
																			if (!PhotonClient.IsInitialized())
																			{
																				break;
																			}
																			if (257642 - 552700 != -295057)
																			{
																				madCocon.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																				if (176949 - 365450 == -188501)
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
					}
				}
			}
		}
	}

	// Token: 0x06003A49 RID: 14921 RVA: 0x0079D1E4 File Offset: 0x0079B3E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003A4A RID: 14922 RVA: 0x0079D1E8 File Offset: 0x0079B3E8
	internal static bool iXqIy152RN2bEd4GH2jG()
	{
		return true;
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x0079D1EC File Offset: 0x0079B3EC
	internal static bool XJAQc952wfZPXITRrEp8()
	{
		return false;
	}

	// Token: 0x04004879 RID: 18553
	private ProjectileControl pkjWes0Utd;

	// Token: 0x0400487A RID: 18554
	private Vector3 lOdWIH8wTg;

	// Token: 0x0400487B RID: 18555
	private float j4qWJxrvK5;

	// Token: 0x0400487C RID: 18556
	private GameObject eg0W6b7mQ7;

	// Token: 0x0400487D RID: 18557
	private float ngxWtgNRGc;
}
