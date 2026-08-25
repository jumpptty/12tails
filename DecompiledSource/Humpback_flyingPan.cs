using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000C60 RID: 3168
[Serializable]
public class Humpback_flyingPan : MonoBehaviour
{
	// Token: 0x060046E9 RID: 18153 RVA: 0x008D9CE4 File Offset: 0x008D7EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Humpback_flyingPan()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060046EA RID: 18154 RVA: 0x008D9CF4 File Offset: 0x008D7EF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		if (33218 - 119732 != -86514)
		{
		}
		for (;;)
		{
			this.marKP28QUo = nOwner;
			if (86346 - 341876 != -255529)
			{
				if (!this.marKP28QUo)
				{
					break;
				}
				if (139042 - 174814 != -35771)
				{
					this.tlrKSImI83 = (CharacterControl)this.marKP28QUo.GetComponent(typeof(CharacterControl));
					if (57368 - 274810 != -217441)
					{
						this.EKsKBpaKiR = (Humpback)this.marKP28QUo.GetComponent(typeof(Humpback));
						if (59587 - 375450 == -315863)
						{
							if (!this.tlrKSImI83)
							{
								break;
							}
							if (138411 - 332661 == -194250)
							{
								if (!this.EKsKBpaKiR)
								{
									break;
								}
								if (63297 - 383045 == -319748)
								{
									this.DWhK0cHGQL = true;
									if (209911 - 356602 != -146690)
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

	// Token: 0x060046EB RID: 18155 RVA: 0x008D9E60 File Offset: 0x008D8060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider nCollider)
	{
		if (222666 - 119035 != 103632)
		{
		}
		for (;;)
		{
			if (!this.DWhK0cHGQL)
			{
				if (78052 - 556739 != -478686)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = nCollider.gameObject;
				if (161653 - 70740 == 90913)
				{
					if (!gameObject)
					{
						break;
					}
					if (172751 - 348333 == -175582)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (69529 - 583699 != -514170)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (143483 - 542674 != -399191)
							{
								continue;
							}
						}
						if (gameObject.layer == this.marKP28QUo.layer)
						{
							break;
						}
						if (185869 - 227349 != -41479)
						{
							if (gameObject.layer == 2)
							{
								if (141510 - 134711 == 6799)
								{
									break;
								}
							}
							else
							{
								if (!this.tlrKSImI83)
								{
									break;
								}
								if (62345 - 168324 != -105978)
								{
									if (!this.tlrKSImI83.isMine)
									{
										break;
									}
									if (22605 - 439642 == -417037)
									{
										if (this.EKsKBpaKiR)
										{
											if (117662 - 91859 == 25804)
											{
												continue;
											}
											this.EKsKBpaKiR.RPC_cAttack_hit(this.transform.position, this.transform.forward, 0);
											if (108425 - 9489 == 98937)
											{
												continue;
											}
											this.EKsKBpaKiR.ActionEvent("RPC_cAttack_hit", this.transform.position, this.transform.forward, 0);
											if (218914 - 471166 != -252252)
											{
												continue;
											}
										}
										this.tlrKSImI83.hit(11, gameObject, (int)(0.5f * (float)this.tlrKSImI83.def + (float)this.tlrKSImI83.talAdjust(20)), 10, 0, (float)2 * Vector3.up);
										if (252941 - 59781 == 193160)
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

	// Token: 0x060046EC RID: 18156 RVA: 0x008DA118 File Offset: 0x008D8318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060046ED RID: 18157 RVA: 0x008DA11C File Offset: 0x008D831C
	internal static bool XNeMh25JXZJtytikqZNM()
	{
		return true;
	}

	// Token: 0x060046EE RID: 18158 RVA: 0x008DA120 File Offset: 0x008D8320
	internal static bool y5dG5Z5JQnIug1weT3fV()
	{
		return false;
	}

	// Token: 0x0400524C RID: 21068
	private GameObject marKP28QUo;

	// Token: 0x0400524D RID: 21069
	private CharacterControl tlrKSImI83;

	// Token: 0x0400524E RID: 21070
	private Humpback EKsKBpaKiR;

	// Token: 0x0400524F RID: 21071
	private bool DWhK0cHGQL;
}
