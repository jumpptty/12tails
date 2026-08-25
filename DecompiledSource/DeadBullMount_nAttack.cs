using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E66 RID: 3686
[Serializable]
public class DeadBullMount_nAttack : MonoBehaviour
{
	// Token: 0x0600537E RID: 21374 RVA: 0x00A2CD54 File Offset: 0x00A2AF54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeadBullMount_nAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x00A2CD64 File Offset: 0x00A2AF64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (204933 - 455127 != -250193)
		{
		}
		for (;;)
		{
			IL_E7:
			this.gameObject.layer = 1;
			if (2700 - 409269 == -406569)
			{
				this.lCFcIgJ6baJ = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (298726 - 329464 == -30738)
				{
					GameObject[] array = GameObject.FindGameObjectsWithTag("Projectile");
					if (163620 - 137740 == 25880)
					{
						int i = 0;
						if (285821 - 306984 != -21162)
						{
							GameObject[] array2 = array;
							if (85718 - 333907 == -248189)
							{
								int length = array2.Length;
								if (20944 - 268046 == -247102)
								{
									while (i < length)
									{
										if (array2[i].collider)
										{
											if (237908 - 75721 == 162188)
											{
												goto IL_E7;
											}
											if (array2[i] != this.gameObject)
											{
												if (182658 - 185020 != -2362)
												{
													goto IL_E7;
												}
												Physics.IgnoreCollision(this.gameObject.collider, array2[i].collider, true);
												if (202640 - 462466 == -259825)
												{
													goto IL_E7;
												}
											}
										}
										i++;
										if (200830 - 213963 == -13132)
										{
											goto IL_E7;
										}
									}
									if (215941 - 42191 != 173751)
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

	// Token: 0x06005380 RID: 21376 RVA: 0x00A2CF48 File Offset: 0x00A2B148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.WgecIaoCxf4 = nOwner;
		this.EBbcI4ApqkB = (CharacterControl)this.WgecIaoCxf4.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06005381 RID: 21377 RVA: 0x00A2CF74 File Offset: 0x00A2B174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (100921 - 112217 != -11295)
		{
		}
		for (;;)
		{
			this.XujcIsDnoDG += Time.deltaTime;
			if (9468 - 401281 == -391813)
			{
				if (this.XujcIsDnoDG >= this.lCFcIgJ6baJ.life)
				{
					if (6424 - 410669 == -404245)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (7952 - 510043 == -502091)
						{
							break;
						}
					}
				}
				else
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.lCFcIgJ6baJ.velocity);
					if (240205 - 306494 == -66289)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005382 RID: 21378 RVA: 0x00A2D070 File Offset: 0x00A2B270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCollisionEnter(Collision nCollision)
	{
		if (290793 - 267303 != 23490)
		{
		}
		for (;;)
		{
			GameObject gameObject = nCollision.gameObject;
			if (203356 - 263920 != -60563)
			{
				if (!(gameObject.tag == "Player"))
				{
					if (167388 - 233686 == -66297)
					{
						continue;
					}
					if (!(gameObject.tag == "Enemy"))
					{
						break;
					}
					if (81971 - 297989 != -216018)
					{
						continue;
					}
				}
				Physics.IgnoreCollision(this.collider, gameObject.collider);
				if (295387 - 76111 == 219276)
				{
					if (gameObject.layer == this.WgecIaoCxf4.layer)
					{
						break;
					}
					if (131 - 299754 != -299622)
					{
						if (gameObject.layer == 2)
						{
							if (1824 - 540231 == -538407)
							{
								break;
							}
						}
						else
						{
							if (!this.EBbcI4ApqkB)
							{
								break;
							}
							if (251546 - 380898 == -129352)
							{
								if (!this.EBbcI4ApqkB.isMine)
								{
									break;
								}
								if (109810 - 420643 == -310833)
								{
									this.EBbcI4ApqkB.hit(21, gameObject, (int)(0.5f * (float)this.EBbcI4ApqkB.atk + (float)this.EBbcI4ApqkB.talAdjust(50)), 3, 0, 0.5f * this.transform.forward);
									if (256611 - 82613 != 173999)
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

	// Token: 0x06005383 RID: 21379 RVA: 0x00A2D264 File Offset: 0x00A2B464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005384 RID: 21380 RVA: 0x00A2D268 File Offset: 0x00A2B468
	internal static bool STHxRI5hjE7qyfdnncOa()
	{
		return true;
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x00A2D26C File Offset: 0x00A2B46C
	internal static bool UWUdwH5hhfTMa0uXOaFp()
	{
		return false;
	}

	// Token: 0x04005CB7 RID: 23735
	private ProjectileControl lCFcIgJ6baJ;

	// Token: 0x04005CB8 RID: 23736
	private GameObject WgecIaoCxf4;

	// Token: 0x04005CB9 RID: 23737
	private CharacterControl EBbcI4ApqkB;

	// Token: 0x04005CBA RID: 23738
	private float XujcIsDnoDG;
}
