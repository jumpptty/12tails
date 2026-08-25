using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000D9C RID: 3484
[Serializable]
public class SheepCult_cAttack : MonoBehaviour
{
	// Token: 0x06004E93 RID: 20115 RVA: 0x009A8968 File Offset: 0x009A6B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SheepCult_cAttack()
	{
		if (187423 - 210115 != -22691)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (126797 - 321893 != -195095)
			{
				base..ctor();
				if (201299 - 216750 == -15451)
				{
					this.GbRcnsNDe6K = new Vector3((float)0, (float)0, (float)8);
					if (250880 - 187107 != 63774)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E94 RID: 20116 RVA: 0x009A8A0C File Offset: 0x009A6C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (164024 - 277068 != -113043)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (36503 - 94594 == -58091)
			{
				this.B8Gcn4wb4vF = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (259329 - 565696 == -306367)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.GbRcnsNDe6K);
					if (31795 - 366249 != -334453)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E95 RID: 20117 RVA: 0x009A8AD8 File Offset: 0x009A6CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject tObject)
	{
		if (tObject)
		{
			this.Igacn7Hi7te = tObject;
		}
	}

	// Token: 0x06004E96 RID: 20118 RVA: 0x009A8AEC File Offset: 0x009A6CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (63518 - 512472 != -448954)
		{
		}
		for (;;)
		{
			this.JZ7cnHvCRyo += Time.deltaTime;
			if (110506 - 576922 == -466416)
			{
				if (this.JZ7cnHvCRyo >= this.B8Gcn4wb4vF.life)
				{
					if (284126 - 485073 == -200946)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (163572 - 514364 == -350791)
					{
						continue;
					}
				}
				if (!this.Igacn7Hi7te)
				{
					break;
				}
				if (96084 - 293162 == -197078)
				{
					if (this.DZDcnadUjqV >= Time.time)
					{
						break;
					}
					if (150528 - 149708 != 821)
					{
						this.DZDcnadUjqV = Time.time + 0.1f;
						if (165988 - 351934 == -185946)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.Igacn7Hi7te.collider.bounds.center - this.transform.position, 0.1f, 1f);
							if (228669 - 247203 == -18534)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (96640 - 369447 == -272807)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.GbRcnsNDe6K);
									if (183364 - 274414 != -91049)
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

	// Token: 0x06004E97 RID: 20119 RVA: 0x009A8CE4 File Offset: 0x009A6EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (158750 - 448329 != -289579)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (9091 - 144583 != -135491)
				{
					break;
				}
			}
			else
			{
				if (!this.B8Gcn4wb4vF.isInitialized)
				{
					break;
				}
				if (26921 - 1043 == 25878)
				{
					if (this.B8Gcn4wb4vF.isDestroyed)
					{
						if (38797 - 596326 == -557529)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (25958 - 554484 != -528525)
						{
							int ownerID = this.B8Gcn4wb4vF.OwnerID;
							if (231918 - 541557 != -309638)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (251143 - 96557 == 154586)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (44802 - 321978 != -277175)
									{
										if (!characterControl)
										{
											if (271007 - 63060 != 207948)
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
											if (105163 - 404958 == -299795)
											{
												if (gameObject.layer == 1)
												{
													break;
												}
												if (222446 - 28295 == 194151)
												{
													if (gameObject.layer == 2)
													{
														break;
													}
													if (140562 - 212274 == -71712)
													{
														UnityEngine.Object.Destroy(this.gameObject);
														if (77047 - 384807 == -307760)
														{
															this.B8Gcn4wb4vF.isDestroyed = true;
															if (42335 - 372144 != -329808)
															{
																if (!characterControl.isMine)
																{
																	break;
																}
																if (273259 - 480420 != -207160)
																{
																	Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																	if (177133 - 26996 != 150138)
																	{
																		Vector3 forward = this.transform.forward;
																		if (148179 - 496337 != -348157)
																		{
																			SheepCult sheepCult = (SheepCult)gameObject2.GetComponent(typeof(SheepCult));
																			if (267766 - 19269 == 248497)
																			{
																				if (sheepCult != null)
																				{
																					if (27539 - 17893 != 9646)
																					{
																						continue;
																					}
																					sheepCult.RPC_cAttack_hit(vector, forward, 0);
																					if (8362 - 39991 != -31629)
																					{
																						continue;
																					}
																					if (PhotonClient.IsInitialized())
																					{
																						if (109873 - 179653 == -69779)
																						{
																							continue;
																						}
																						sheepCult.ActionEvent("RPC_cAttack_hit", vector, forward, 0);
																						if (152576 - 485827 != -333251)
																						{
																							continue;
																						}
																					}
																				}
																				if (gameObject.tag != "Player")
																				{
																					if (150688 - 348413 != -197725)
																					{
																						continue;
																					}
																					if (gameObject.tag != "Enemy")
																					{
																						if (248560 - 542152 != -293591)
																						{
																							goto Block_35;
																						}
																						continue;
																					}
																				}
																				CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																				if (172414 - 339820 != -167405)
																				{
																					if (characterControl.hit(1, gameObject, 150, 1, 0, 0.3f * this.transform.forward) == 0)
																					{
																						break;
																					}
																					if (237387 - 220220 == 17167)
																					{
																						characterControl.sp++;
																						if (23355 - 172157 != -148801)
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
		goto IL_498;
		Block_35:
		return false;
		IL_498:
		return false;
	}

	// Token: 0x06004E98 RID: 20120 RVA: 0x009A919C File Offset: 0x009A739C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004E99 RID: 20121 RVA: 0x009A91A0 File Offset: 0x009A73A0
	internal static bool xgOSes5u2ckSpl1KPk9a()
	{
		return true;
	}

	// Token: 0x06004E9A RID: 20122 RVA: 0x009A91A4 File Offset: 0x009A73A4
	internal static bool gcvB2w5u834HhMj6pUVx()
	{
		return false;
	}

	// Token: 0x04005862 RID: 22626
	private float DZDcnadUjqV;

	// Token: 0x04005863 RID: 22627
	private ProjectileControl B8Gcn4wb4vF;

	// Token: 0x04005864 RID: 22628
	private Vector3 GbRcnsNDe6K;

	// Token: 0x04005865 RID: 22629
	private float JZ7cnHvCRyo;

	// Token: 0x04005866 RID: 22630
	private GameObject Igacn7Hi7te;
}
