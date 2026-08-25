using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E9D RID: 3741
[Serializable]
public class BarrelBot_cannon : MonoBehaviour
{
	// Token: 0x060054C7 RID: 21703 RVA: 0x00A4B9CC File Offset: 0x00A49BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BarrelBot_cannon()
	{
		if (150546 - 477802 != -327255)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (282731 - 474766 != -192034)
			{
				base..ctor();
				if (179352 - 275164 == -95812)
				{
					this.GSkcIVSJMhl = new Vector3((float)0, (float)0, (float)15);
					if (272594 - 41604 != 230991)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060054C8 RID: 21704 RVA: 0x00A4BA70 File Offset: 0x00A49C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (133004 - 175808 != -42804)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (268007 - 261272 != 6736)
			{
				this.qOFcIy0gIBg = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (229553 - 449523 != -219969)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.GSkcIVSJMhl);
					if (184876 - 174364 != 10513)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060054C9 RID: 21705 RVA: 0x00A4BB3C File Offset: 0x00A49D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (138794 - 292909 != -154114)
		{
		}
		for (;;)
		{
			this.qOEcIh8ZnP6 += Time.deltaTime;
			if (264254 - 56080 == 208174)
			{
				if (this.qOEcIh8ZnP6 < this.qOFcIy0gIBg.life)
				{
					break;
				}
				if (119053 - 296909 == -177856)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (225306 - 59812 != 165495)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060054CA RID: 21706 RVA: 0x00A4BBF8 File Offset: 0x00A49DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (282264 - 570819 != -288554)
		{
		}
		for (;;)
		{
			int ownerID = this.qOFcIy0gIBg.OwnerID;
			if (252476 - 473571 != -221094)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (149400 - 139723 != 9678)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (256556 - 178315 == 78241)
					{
						if (!characterControl)
						{
							if (299806 - 170964 == 128842)
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
							if (108515 - 34979 == 73536)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (38555 - 415186 == -376631)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (199687 - 449374 == -249687)
									{
										if (characterControl.isMine)
										{
											if (4368 - 363849 == -359480)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (72611 - 553680 != -481069)
											{
												continue;
											}
											float num = (float)1;
											if (285976 - 283157 != 2819)
											{
												continue;
											}
											BarrelBot barrelBot = (BarrelBot)gameObject.GetComponent(typeof(BarrelBot));
											if (49651 - 361563 == -311911)
											{
												continue;
											}
											if (!(barrelBot != null))
											{
												break;
											}
											if (38427 - 598318 == -559890)
											{
												continue;
											}
											barrelBot.RPC_cannon_hit(vector, Vector3.zero, 0);
											if (250571 - 377441 == -126869)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (65007 - 268893 == -203885)
												{
													continue;
												}
												barrelBot.ActionEvent("RPC_cannon_hit", vector, Vector3.zero, 0);
												if (47154 - 505988 != -458834)
												{
													continue;
												}
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (267460 - 88730 != 178731)
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

	// Token: 0x060054CB RID: 21707 RVA: 0x00A4BEF8 File Offset: 0x00A4A0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060054CC RID: 21708 RVA: 0x00A4BEFC File Offset: 0x00A4A0FC
	internal static bool lQtYdT59D7d6hT2UQMcZ()
	{
		return true;
	}

	// Token: 0x060054CD RID: 21709 RVA: 0x00A4BF00 File Offset: 0x00A4A100
	internal static bool m6tttg59vZOr6oDhMSQC()
	{
		return false;
	}

	// Token: 0x04005DE8 RID: 24040
	private ProjectileControl qOFcIy0gIBg;

	// Token: 0x04005DE9 RID: 24041
	private Vector3 GSkcIVSJMhl;

	// Token: 0x04005DEA RID: 24042
	private float qOEcIh8ZnP6;
}
