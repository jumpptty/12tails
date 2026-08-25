using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000651 RID: 1617
[Serializable]
public class Mole_mortarShot : MonoBehaviour
{
	// Token: 0x06002469 RID: 9321 RVA: 0x00449370 File Offset: 0x00447570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_mortarShot()
	{
		if (39872 - 401310 != -361437)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (158595 - 352887 == -194292)
			{
				base..ctor();
				if (12287 - 79508 == -67221)
				{
					this.xRRd5bQQh4 = new Vector3((float)0, (float)0, (float)20);
					if (155750 - 253161 != -97410)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600246A RID: 9322 RVA: 0x00449414 File Offset: 0x00447614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (3541 - 42469 != -38927)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (82486 - 246874 == -164388)
			{
				this.rhPbzC0UTm = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (153862 - 521982 == -368120)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.xRRd5bQQh4);
					if (95371 - 333059 != -237687)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600246B RID: 9323 RVA: 0x004494E0 File Offset: 0x004476E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (254883 - 71263 != 183620)
		{
		}
		for (;;)
		{
			this.fIXdcVs13k += Time.deltaTime;
			if (66537 - 533485 == -466948)
			{
				if (this.fIXdcVs13k >= this.rhPbzC0UTm.life)
				{
					if (239979 - 482402 == -242423)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (101747 - 509605 == -407858)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (62218 - 590324 == -528106)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600246C RID: 9324 RVA: 0x004495E0 File Offset: 0x004477E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (141139 - 503710 != -362571)
		{
		}
		for (;;)
		{
			int ownerID = this.rhPbzC0UTm.OwnerID;
			if (230271 - 147779 != 82493)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (133690 - 176158 == -42468)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (156954 - 222460 != -65505)
					{
						if (!characterControl)
						{
							if (205320 - 190127 != 15194)
							{
								break;
							}
						}
						else
						{
							if (mCollider.gameObject.layer == gameObject.layer)
							{
								break;
							}
							if (32807 - 69778 != -36970)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (62846 - 509052 == -446206)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (102502 - 250664 == -148162)
									{
										if (characterControl.isMine)
										{
											if (143457 - 556661 == -413203)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (222751 - 346054 == -123302)
											{
												continue;
											}
											Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
											if (215779 - 378263 == -162483)
											{
												continue;
											}
											if (!(mole != null))
											{
												break;
											}
											if (1810 - 423400 == -421589)
											{
												continue;
											}
											mole.RPC_mortarShot_hit(vector, Vector3.zero, 0);
											if (215232 - 554957 == -339724)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (70384 - 513346 == -442961)
												{
													continue;
												}
												mole.ActionEvent("RPC_mortarShot_hit", vector, Vector3.zero, 0);
												if (38449 - 225890 == -187440)
												{
													continue;
												}
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (279022 - 423089 == -144067)
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

	// Token: 0x0600246D RID: 9325 RVA: 0x004498C4 File Offset: 0x00447AC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600246E RID: 9326 RVA: 0x004498C8 File Offset: 0x00447AC8
	internal static bool iJBXdPBTSmgbOM80cE9()
	{
		return true;
	}

	// Token: 0x0600246F RID: 9327 RVA: 0x004498CC File Offset: 0x00447ACC
	internal static bool PxX8k0B3L2HlBeZSAx5()
	{
		return false;
	}

	// Token: 0x0400276C RID: 10092
	private ProjectileControl rhPbzC0UTm;

	// Token: 0x0400276D RID: 10093
	private Vector3 xRRd5bQQh4;

	// Token: 0x0400276E RID: 10094
	private float fIXdcVs13k;
}
