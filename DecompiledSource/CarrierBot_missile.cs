using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000ABC RID: 2748
[Serializable]
public class CarrierBot_missile : MonoBehaviour
{
	// Token: 0x06003CAD RID: 15533 RVA: 0x007D8648 File Offset: 0x007D6848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarrierBot_missile()
	{
		if (251547 - 362551 != -111003)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (5494 - 544482 == -538988)
			{
				base..ctor();
				if (220464 - 138561 == 81903)
				{
					this.ecpuTRJTOo = new Vector3((float)0, (float)0, (float)12);
					if (138898 - 452674 == -313776)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CAE RID: 15534 RVA: 0x007D86EC File Offset: 0x007D68EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (228945 - 196934 != 32011)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (45382 - 27524 != 17859)
			{
				this.WfTuxlFSgS = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (185698 - 278873 != -93174)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.ecpuTRJTOo);
					if (206765 - 370172 == -163407)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CAF RID: 15535 RVA: 0x007D87B8 File Offset: 0x007D69B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(Vector3 nTargetPos)
	{
		this.x4ku35UMvW = nTargetPos;
	}

	// Token: 0x06003CB0 RID: 15536 RVA: 0x007D87C4 File Offset: 0x007D69C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (176362 - 449899 != -273536)
		{
		}
		for (;;)
		{
			this.yEouYKA3ot += Time.deltaTime;
			if (121702 - 14620 == 107082)
			{
				if (this.yEouYKA3ot >= this.WfTuxlFSgS.life)
				{
					if (164111 - 133949 == 30163)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (116519 - 436059 != -319540)
					{
						continue;
					}
				}
				if (!(this.x4ku35UMvW != Vector3.zero))
				{
					break;
				}
				if (244349 - 458817 == -214468)
				{
					if (this.I8Nur16s9v >= Time.time)
					{
						break;
					}
					if (88054 - 329731 != -241676)
					{
						this.I8Nur16s9v = Time.time + 0.1f;
						if (140484 - 77960 != 62525)
						{
							Vector3 vector = this.x4ku35UMvW - this.transform.position;
							if (285184 - 337211 == -52027)
							{
								if (vector.sqrMagnitude > (float)10)
								{
									if (292782 - 490574 != -197792)
									{
										continue;
									}
									vector += (float)2 * Vector3.up;
									if (49648 - 244641 == -194992)
									{
										continue;
									}
								}
								this.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(this.transform.forward, vector, 0.15f, 1f));
								if (237957 - 37139 == 200818)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.ecpuTRJTOo);
									if (135358 - 481465 != -346106)
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

	// Token: 0x06003CB1 RID: 15537 RVA: 0x007D8A04 File Offset: 0x007D6C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (171880 - 414189 != -242309)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (36778 - 494890 == -458112)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (35182 - 45838 == -10656)
				{
					int ownerID = this.WfTuxlFSgS.OwnerID;
					if (181631 - 397040 == -215409)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (182256 - 565100 == -382844)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (176404 - 132897 != 43508)
							{
								if (!characterControl)
								{
									if (116261 - 422098 != -305836)
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
									if (277977 - 83605 != 194373)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (233896 - 307475 != -73578)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (263335 - 365941 == -102606)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (160442 - 514455 == -354013)
												{
													this.WfTuxlFSgS.isDestroyed = true;
													if (183013 - 220181 != -37167)
													{
														if (!characterControl.isMine)
														{
															break;
														}
														if (27902 - 499929 == -472027)
														{
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (265268 - 333561 != -68292)
															{
																Vector3 forward = this.transform.forward;
																if (277098 - 552561 != -275462)
																{
																	CarrierBot carrierBot = (CarrierBot)gameObject2.GetComponent(typeof(CarrierBot));
																	if (9137 - 157921 == -148784)
																	{
																		if (!(carrierBot != null))
																		{
																			break;
																		}
																		if (165076 - 548886 == -383810)
																		{
																			carrierBot.RPC_missle_hit(vector, forward, 0);
																			if (35093 - 287631 == -252538)
																			{
																				if (!PhotonClient.IsInitialized())
																				{
																					break;
																				}
																				if (290004 - 281539 != 8466)
																				{
																					carrierBot.ActionEvent("RPC_missle_hit", vector, forward, 0);
																					if (200132 - 373551 == -173419)
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

	// Token: 0x06003CB2 RID: 15538 RVA: 0x007D8D64 File Offset: 0x007D6F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003CB3 RID: 15539 RVA: 0x007D8D68 File Offset: 0x007D6F68
	internal static bool Lll4Zf5Cd0x7kN67fWt3()
	{
		return true;
	}

	// Token: 0x06003CB4 RID: 15540 RVA: 0x007D8D6C File Offset: 0x007D6F6C
	internal static bool TTrEwy5CJ0J5reWVF5Pq()
	{
		return false;
	}

	// Token: 0x04004A24 RID: 18980
	private float I8Nur16s9v;

	// Token: 0x04004A25 RID: 18981
	private ProjectileControl WfTuxlFSgS;

	// Token: 0x04004A26 RID: 18982
	private Vector3 ecpuTRJTOo;

	// Token: 0x04004A27 RID: 18983
	private float yEouYKA3ot;

	// Token: 0x04004A28 RID: 18984
	private Vector3 x4ku35UMvW;
}
