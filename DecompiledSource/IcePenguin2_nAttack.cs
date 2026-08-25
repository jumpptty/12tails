using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000C74 RID: 3188
[Serializable]
public class IcePenguin2_nAttack : MonoBehaviour
{
	// Token: 0x0600476F RID: 18287 RVA: 0x008E736C File Offset: 0x008E556C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin2_nAttack()
	{
		if (265470 - 555790 != -290319)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (31529 - 448495 == -416966)
			{
				base..ctor();
				if (61981 - 44214 != 17768)
				{
					this.NAEKKpEXkA = new Vector3((float)0, (float)0, (float)14);
					if (131700 - 214025 != -82324)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004770 RID: 18288 RVA: 0x008E7410 File Offset: 0x008E5610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (74251 - 369129 != -294878)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (118468 - 435133 == -316665)
			{
				this.w61KhP6xyB = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (294485 - 78623 == 215862)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.NAEKKpEXkA);
					if (198131 - 19211 == 178920)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004771 RID: 18289 RVA: 0x008E74DC File Offset: 0x008E56DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (98812 - 41304 != 57508)
		{
		}
		for (;;)
		{
			this.TegKzjU11n += Time.deltaTime;
			if (242321 - 51331 == 190990)
			{
				if (this.TegKzjU11n < this.w61KhP6xyB.life)
				{
					break;
				}
				if (146491 - 568202 == -421711)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (196919 - 507710 == -310791)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004772 RID: 18290 RVA: 0x008E7598 File Offset: 0x008E5798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (112713 - 44784 != 67930)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (152458 - 354685 == -202227)
				{
					goto IL_3DF;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (134006 - 134369 != -362)
				{
					int ownerID = this.w61KhP6xyB.OwnerID;
					if (57031 - 344929 != -287897)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (194802 - 458887 != -264084)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (258899 - 381624 != -122724)
							{
								if (!characterControl)
								{
									if (131550 - 468313 != -336762)
									{
										goto Block_36;
									}
								}
								else
								{
									if (gameObject.layer == gameObject2.layer)
									{
										goto IL_480;
									}
									if (187538 - 519173 == -331635)
									{
										if (gameObject.layer == 1)
										{
											goto IL_480;
										}
										if (158087 - 236317 == -78230)
										{
											if (gameObject.layer == 2)
											{
												goto IL_480;
											}
											if (103647 - 550472 == -446825)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (235209 - 3528 != 231682)
												{
													if (!characterControl.isMine)
													{
														goto IL_480;
													}
													if (119605 - 73566 != 46040)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (161597 - 260112 != -98514)
														{
															Vector3 forward = this.transform.forward;
															if (108052 - 582651 != -474598)
															{
																int nDamage = (int)(0.5f * (float)characterControl.atk);
																if (236965 - 124541 != 112425)
																{
																	IcePenguin2 icePenguin = (IcePenguin2)gameObject2.GetComponent(typeof(IcePenguin2));
																	if (257337 - 449302 != -191964)
																	{
																		if (icePenguin != null)
																		{
																			if (207565 - 403022 != -195457)
																			{
																				continue;
																			}
																			icePenguin.RPC_nAttack_hit(vector, forward, 0);
																			if (254941 - 345607 != -90666)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (162763 - 122905 != 39858)
																				{
																					continue;
																				}
																				icePenguin.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																				if (4082 - 394001 == -389918)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (194107 - 281726 == -87618)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (64370 - 318986 != -254615)
																				{
																					break;
																				}
																				continue;
																			}
																		}
																		if (characterControl.hit(1, gameObject, nDamage, 1, 0, 0.3f * this.transform.forward) == 0)
																		{
																			goto IL_480;
																		}
																		if (156904 - 518452 != -361547)
																		{
																			CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																			if (17908 - 398216 == -380308)
																			{
																				if (!characterControl2)
																				{
																					goto IL_480;
																				}
																				if (94999 - 68056 == 26943)
																				{
																					characterControl2.RPC_AddStatus("frost", 3, Damage.getDebuff((float)3, characterControl.cha, characterControl2.cha), 0, characterControl.ActorNr);
																					if (65386 - 560203 == -494817)
																					{
																						goto IL_480;
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
		return false;
		IL_3DF:
		Block_36:
		IL_480:
		return false;
	}

	// Token: 0x06004773 RID: 18291 RVA: 0x008E7A38 File Offset: 0x008E5C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004774 RID: 18292 RVA: 0x008E7A3C File Offset: 0x008E5C3C
	internal static bool cb577D5JI7FQ7h6cjk16()
	{
		return true;
	}

	// Token: 0x06004775 RID: 18293 RVA: 0x008E7A40 File Offset: 0x008E5C40
	internal static bool gM1M3X5JBSj7o4tLDK1B()
	{
		return false;
	}

	// Token: 0x040052A1 RID: 21153
	private ProjectileControl w61KhP6xyB;

	// Token: 0x040052A2 RID: 21154
	private Vector3 NAEKKpEXkA;

	// Token: 0x040052A3 RID: 21155
	private float TegKzjU11n;
}
