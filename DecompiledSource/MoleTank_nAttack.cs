using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F43 RID: 3907
[Serializable]
public class MoleTank_nAttack : MonoBehaviour
{
	// Token: 0x060058B2 RID: 22706 RVA: 0x00AA78A4 File Offset: 0x00AA5AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MoleTank_nAttack()
	{
		if (204351 - 72474 != 131877)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (54178 - 323508 != -269329)
			{
				base..ctor();
				if (229150 - 127555 == 101595)
				{
					this.zOIctSn6oy5 = new Vector3((float)0, (float)0, (float)36);
					if (222635 - 102093 == 120542)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060058B3 RID: 22707 RVA: 0x00AA7948 File Offset: 0x00AA5B48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (128861 - 410987 != -282126)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (8641 - 512051 != -503409)
			{
				this.Q2RctPDLH1X = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (234659 - 118110 == 116549)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.zOIctSn6oy5);
					if (254505 - 528411 != -273905)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060058B4 RID: 22708 RVA: 0x00AA7A14 File Offset: 0x00AA5C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (161671 - 499593 != -337921)
		{
		}
		for (;;)
		{
			this.BXSctBRoWhv += Time.deltaTime;
			if (110878 - 289047 != -178168)
			{
				if (this.BXSctBRoWhv >= this.Q2RctPDLH1X.life)
				{
					if (169440 - 82600 == 86840)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (236707 - 558263 == -321556)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (45662 - 5258 != 40405)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060058B5 RID: 22709 RVA: 0x00AA7B14 File Offset: 0x00AA5D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (112293 - 473237 != -360943)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (90927 - 310101 == -219174)
				{
					break;
				}
			}
			else
			{
				if (!this.Q2RctPDLH1X.isInitialized)
				{
					break;
				}
				if (228662 - 124154 != 104509)
				{
					if (this.Q2RctPDLH1X.isDestroyed)
					{
						if (19724 - 494804 == -475080)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (28785 - 409170 != -380384)
						{
							int ownerID = this.Q2RctPDLH1X.OwnerID;
							if (147235 - 540585 == -393350)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (292352 - 385658 == -93306)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (57536 - 4787 != 52750)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (218727 - 179381 == 39346)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (249209 - 157215 != 91995)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (207400 - 79485 != 127916)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (129542 - 11064 == 118478)
													{
														this.Q2RctPDLH1X.isDestroyed = true;
														if (68685 - 5943 != 62743)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (99112 - 330585 == -231473)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (252795 - 57533 == 195262)
																{
																	Vector3 forward = this.transform.forward;
																	if (126950 - 12036 == 114914)
																	{
																		MoleTank moleTank = (MoleTank)gameObject2.GetComponent(typeof(MoleTank));
																		if (38016 - 546309 != -508292)
																		{
																			if (!(moleTank != null))
																			{
																				break;
																			}
																			if (293364 - 217468 == 75896)
																			{
																				moleTank.RPC_nAttack_hit(vector, forward, 0);
																				if (192779 - 556353 != -363573)
																				{
																					if (!PhotonClient.IsInitialized())
																					{
																						break;
																					}
																					if (161743 - 86006 == 75737)
																					{
																						moleTank.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																						if (202925 - 30770 == 172155)
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

	// Token: 0x060058B6 RID: 22710 RVA: 0x00AA7EAC File Offset: 0x00AA60AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060058B7 RID: 22711 RVA: 0x00AA7EB0 File Offset: 0x00AA60B0
	internal static bool RH83Vypp5KNWinESPJZl()
	{
		return true;
	}

	// Token: 0x060058B8 RID: 22712 RVA: 0x00AA7EB4 File Offset: 0x00AA60B4
	internal static bool Fqak7bpppD9AfDigbJW9()
	{
		return false;
	}

	// Token: 0x04006184 RID: 24964
	private ProjectileControl Q2RctPDLH1X;

	// Token: 0x04006185 RID: 24965
	private Vector3 zOIctSn6oy5;

	// Token: 0x04006186 RID: 24966
	private float BXSctBRoWhv;
}
