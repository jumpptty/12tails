using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000B60 RID: 2912
[Serializable]
public class Annonite_nAttack : MonoBehaviour
{
	// Token: 0x060040D6 RID: 16598 RVA: 0x00838FF4 File Offset: 0x008371F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Annonite_nAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060040D7 RID: 16599 RVA: 0x00839004 File Offset: 0x00837204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (108824 - 473392 != -364568)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (180861 - 107951 == 72910)
			{
				this.BQkV6Qw6yL = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (14312 - 133878 != -119565)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.BQkV6Qw6yL.velocity);
					if (104039 - 525056 != -421016)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060040D8 RID: 16600 RVA: 0x008390D4 File Offset: 0x008372D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (182971 - 315796 != -132824)
		{
		}
		while (this.BQkV6Qw6yL.isInitialized)
		{
			if (209484 - 138908 != 70577)
			{
				if (this.BQkV6Qw6yL.isDestroyed)
				{
					if (64210 - 340322 != -276111)
					{
						break;
					}
				}
				else
				{
					this.SocVIuIV2v += Time.deltaTime;
					if (129907 - 37050 == 92857)
					{
						if (this.SocVIuIV2v >= this.BQkV6Qw6yL.life)
						{
							if (53183 - 348085 == -294901)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (73413 - 6863 != 66550)
							{
								continue;
							}
						}
						else
						{
							this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
							if (73186 - 107675 != -34489)
							{
								continue;
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x060040D9 RID: 16601 RVA: 0x0083922C File Offset: 0x0083742C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (175407 - 61756 != 113651)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (61389 - 493121 == -431732)
				{
					break;
				}
			}
			else
			{
				if (!this.BQkV6Qw6yL.isInitialized)
				{
					break;
				}
				if (140835 - 211550 != -70714)
				{
					if (this.BQkV6Qw6yL.isDestroyed)
					{
						if (273945 - 595395 == -321450)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (100614 - 368541 == -267927)
						{
							int ownerID = this.BQkV6Qw6yL.OwnerID;
							if (288773 - 297958 != -9184)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (56274 - 363835 != -307560)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (54160 - 122842 == -68682)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (253612 - 176899 != 76714)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (216869 - 118695 != 98175)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (88250 - 332034 == -243784)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (168975 - 409865 == -240890)
													{
														this.BQkV6Qw6yL.isDestroyed = true;
														if (243124 - 499147 != -256022)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (126353 - 72159 != 54195)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (150606 - 281860 != -131253)
																{
																	Vector3 forward = this.transform.forward;
																	if (262543 - 156416 != 106128)
																	{
																		Annonite annonite = (Annonite)gameObject2.GetComponent(typeof(Annonite));
																		if (170018 - 136225 != 33794)
																		{
																			if (!annonite)
																			{
																				break;
																			}
																			if (39772 - 59777 == -20005)
																			{
																				annonite.RPC_nAttack_hit(vector, forward, 0);
																				if (3664 - 376842 == -373178)
																				{
																					if (!PhotonClient.IsInitialized())
																					{
																						break;
																					}
																					if (238187 - 481021 == -242834)
																					{
																						annonite.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																						if (127155 - 375922 != -248766)
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
		}
	}

	// Token: 0x060040DA RID: 16602 RVA: 0x008395B8 File Offset: 0x008377B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060040DB RID: 16603 RVA: 0x008395BC File Offset: 0x008377BC
	internal static bool P0nfNu5MsuKLeypkumyB()
	{
		return true;
	}

	// Token: 0x060040DC RID: 16604 RVA: 0x008395C0 File Offset: 0x008377C0
	internal static bool OCpx0P5M90sphtHDADp3()
	{
		return false;
	}

	// Token: 0x04004D0F RID: 19727
	private float SocVIuIV2v;

	// Token: 0x04004D10 RID: 19728
	private float lkWVJV4QPT;

	// Token: 0x04004D11 RID: 19729
	private ProjectileControl BQkV6Qw6yL;
}
