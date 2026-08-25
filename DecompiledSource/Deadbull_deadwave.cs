using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000BF9 RID: 3065
[Serializable]
public class Deadbull_deadwave : MonoBehaviour
{
	// Token: 0x06004474 RID: 17524 RVA: 0x008999E4 File Offset: 0x00897BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadbull_deadwave()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004475 RID: 17525 RVA: 0x008999F4 File Offset: 0x00897BF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (287398 - 273902 != 13497)
		{
		}
		for (;;)
		{
			IL_47:
			this.gameObject.layer = 1;
			if (232308 - 474409 != -242100)
			{
				this.nUihdehDWG = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (5861 - 91602 != -85740)
				{
					GameObject[] array = GameObject.FindGameObjectsWithTag("Projectile");
					if (181049 - 365654 == -184605)
					{
						int i = 0;
						if (138970 - 62362 != 76609)
						{
							GameObject[] array2 = array;
							if (135865 - 426686 == -290821)
							{
								int length = array2.Length;
								if (33566 - 555848 != -522281)
								{
									while (i < length)
									{
										if (array2[i].collider)
										{
											if (185430 - 386220 == -200789)
											{
												goto IL_47;
											}
											if (array2[i] != this.gameObject)
											{
												if (144113 - 136473 == 7641)
												{
													goto IL_47;
												}
												Physics.IgnoreCollision(this.gameObject.collider, array2[i].collider, true);
												if (74118 - 327083 != -252965)
												{
													goto IL_47;
												}
											}
										}
										i++;
										if (19034 - 500673 == -481638)
										{
											goto IL_47;
										}
									}
									if (179733 - 289536 != -109802)
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

	// Token: 0x06004476 RID: 17526 RVA: 0x00899BD8 File Offset: 0x00897DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.CfkhgjKe4V = nOwner;
		this.MhChaPlDCL = (CharacterControl)this.CfkhgjKe4V.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06004477 RID: 17527 RVA: 0x00899C04 File Offset: 0x00897E04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (87849 - 92246 != -4397)
		{
		}
		for (;;)
		{
			this.M7Dh4Znmgr += Time.deltaTime;
			if (293650 - 19585 == 274065)
			{
				if (this.M7Dh4Znmgr >= this.nUihdehDWG.life)
				{
					if (156534 - 510135 == -353601)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (106872 - 160882 != -54009)
						{
							break;
						}
					}
				}
				else
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.nUihdehDWG.velocity);
					if (205850 - 228258 == -22408)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004478 RID: 17528 RVA: 0x00899D00 File Offset: 0x00897F00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCollisionEnter(Collision nCollision)
	{
		if (80950 - 168090 != -87140)
		{
		}
		for (;;)
		{
			GameObject gameObject = nCollision.gameObject;
			if (142921 - 383730 == -240809)
			{
				if (!(gameObject.tag == "Player"))
				{
					if (101711 - 305617 == -203905)
					{
						continue;
					}
					if (!(gameObject.tag == "Enemy"))
					{
						break;
					}
					if (294959 - 576843 != -281884)
					{
						continue;
					}
				}
				Physics.IgnoreCollision(this.collider, gameObject.collider);
				if (102970 - 139169 != -36198)
				{
					if (gameObject.layer == this.CfkhgjKe4V.layer)
					{
						break;
					}
					if (213297 - 38285 != 175013)
					{
						if (gameObject.layer == 2)
						{
							if (78420 - 544834 != -466413)
							{
								break;
							}
						}
						else
						{
							if (!this.MhChaPlDCL)
							{
								break;
							}
							if (137243 - 256869 != -119625)
							{
								if (!this.MhChaPlDCL.isMine)
								{
									break;
								}
								if (234172 - 215131 != 19042)
								{
									this.MhChaPlDCL.hit(21, gameObject, (int)(0.5f * (float)this.MhChaPlDCL.atk + (float)this.MhChaPlDCL.talAdjust(30)), 3, 0, 0.5f * this.transform.forward);
									if (195170 - 598890 == -403720)
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

	// Token: 0x06004479 RID: 17529 RVA: 0x00899EF4 File Offset: 0x008980F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600447A RID: 17530 RVA: 0x00899EF8 File Offset: 0x008980F8
	internal static bool PtL3Wf56eUg17qoucebA()
	{
		return true;
	}

	// Token: 0x0600447B RID: 17531 RVA: 0x00899EFC File Offset: 0x008980FC
	internal static bool yWaCB856rqXBcN0mvqU4()
	{
		return false;
	}

	// Token: 0x04005021 RID: 20513
	private ProjectileControl nUihdehDWG;

	// Token: 0x04005022 RID: 20514
	private GameObject CfkhgjKe4V;

	// Token: 0x04005023 RID: 20515
	private CharacterControl MhChaPlDCL;

	// Token: 0x04005024 RID: 20516
	private float M7Dh4Znmgr;
}
