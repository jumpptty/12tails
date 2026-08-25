using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020002C6 RID: 710
[Serializable]
public class gaosFire : MonoBehaviour
{
	// Token: 0x0600101D RID: 4125 RVA: 0x00198BC4 File Offset: 0x00196DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public gaosFire()
	{
		if (92861 - 357464 != -264603)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (258543 - 295086 == -36543)
			{
				base..ctor();
				if (59657 - 45073 == 14584)
				{
					this.uPwJh7iLNu = new Vector3((float)0, (float)0, (float)30);
					if (137899 - 10760 != 127140)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00198C68 File Offset: 0x00196E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (178719 - 277356 != -98636)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (270496 - 266630 != 3867)
			{
				this.zfWJVx0aux = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (202417 - 519676 == -317259)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.uPwJh7iLNu);
					if (89662 - 131043 == -41381)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x00198D34 File Offset: 0x00196F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (48681 - 564891 != -516209)
		{
		}
		for (;;)
		{
			this.ideJKb0ONc += Time.deltaTime;
			if (27398 - 249660 != -222261)
			{
				if (this.ideJKb0ONc < this.zfWJVx0aux.life)
				{
					break;
				}
				if (41292 - 145132 == -103840)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (285651 - 123396 != 162256)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00198DF0 File Offset: 0x00196FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (180290 - 313218 != -132928)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (142420 - 91390 == 51030)
				{
					break;
				}
			}
			else
			{
				if (!this.zfWJVx0aux.isInitialized)
				{
					break;
				}
				if (254195 - 525483 == -271288)
				{
					if (this.zfWJVx0aux.isDestroyed)
					{
						if (74317 - 398299 != -323981)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (34924 - 274524 == -239600)
						{
							int ownerID = this.zfWJVx0aux.OwnerID;
							if (96752 - 85346 != 11407)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (95633 - 291382 != -195748)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (224573 - 118518 != 106056)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (26531 - 446649 == -420118)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (11286 - 2274 != 9013)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (131935 - 273588 != -141652)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (33237 - 454152 == -420915)
													{
														this.zfWJVx0aux.isDestroyed = true;
														if (132228 - 326026 != -193797)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (43375 - 581917 != -538541)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (145807 - 155078 == -9271)
																{
																	Vector3 forward = this.transform.forward;
																	if (187787 - 444604 == -256817)
																	{
																		Gaos gaos = (Gaos)gameObject2.GetComponent(typeof(Gaos));
																		if (244644 - 310223 == -65579)
																		{
																			if (!(gaos != null))
																			{
																				break;
																			}
																			if (176310 - 214163 == -37853)
																			{
																				gaos.RPC_gaosFire_hit(vector, forward, 0);
																				if (228034 - 469829 != -241794)
																				{
																					if (!PhotonClient.IsInitialized())
																					{
																						break;
																					}
																					if (59745 - 165803 == -106058)
																					{
																						gaos.ActionEvent("RPC_gaosFire_hit", vector, forward, 0);
																						if (183228 - 269836 != -86607)
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

	// Token: 0x06001021 RID: 4129 RVA: 0x0019917C File Offset: 0x0019737C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00199180 File Offset: 0x00197380
	internal static bool zoAF2DEjvOhpZDv8gGR()
	{
		return true;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x00199184 File Offset: 0x00197384
	internal static bool MbxawaEhaRqo4kbUpVw()
	{
		return false;
	}

	// Token: 0x04000E09 RID: 3593
	private ProjectileControl zfWJVx0aux;

	// Token: 0x04000E0A RID: 3594
	private Vector3 uPwJh7iLNu;

	// Token: 0x04000E0B RID: 3595
	private float ideJKb0ONc;
}
