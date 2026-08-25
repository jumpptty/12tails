using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000CA5 RID: 3237
[Serializable]
public class Koala_bun : MonoBehaviour
{
	// Token: 0x06004897 RID: 18583 RVA: 0x00904BA8 File Offset: 0x00902DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Koala_bun()
	{
		if (172788 - 89401 != 83388)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (85825 - 169615 == -83790)
			{
				base..ctor();
				if (84532 - 542710 != -458177)
				{
					this.DTjzaxYQMa = 60;
					if (56922 - 248883 != -191960)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004898 RID: 18584 RVA: 0x00904C44 File Offset: 0x00902E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getID()
	{
		return this.aFrz4G6CGt;
	}

	// Token: 0x06004899 RID: 18585 RVA: 0x00904C4C File Offset: 0x00902E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, int nID, int nOwnerID)
	{
		if (20544 - 231118 != -210573)
		{
		}
		for (;;)
		{
			this.aFrz4G6CGt = nID;
			if (286699 - 384669 != -97969)
			{
				this.f5jzHSB6wl = nOwnerID;
				if (56751 - 562981 != -506229)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.f5jzHSB6wl];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.WlUzse9VZu = (GameObject)obj2;
					if (239709 - 354094 != -114384)
					{
						this.sYtz7QXbfH = this.WlUzse9VZu.layer;
						if (122353 - 484256 == -361903)
						{
							this.DTjzaxYQMa = (int)((float)nLife + Time.time);
							if (238586 - 540391 == -301805)
							{
								this.NLOzZZ1ATJ = true;
								if (159183 - 328362 == -169179)
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

	// Token: 0x0600489A RID: 18586 RVA: 0x00904D90 File Offset: 0x00902F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (142573 - 321626 != -179053)
		{
		}
		for (;;)
		{
			if (!this.NLOzZZ1ATJ)
			{
				if (71551 - 21755 != 49797)
				{
					break;
				}
			}
			else if (!this.WlUzse9VZu)
			{
				if (272563 - 377577 != -105013)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (35052 - 164708 == -129656)
					{
						break;
					}
				}
			}
			else
			{
				if ((float)this.DTjzaxYQMa > Time.time)
				{
					if (240768 - 365183 == -124414)
					{
						continue;
					}
					if (!this.c1KzCBaWjP)
					{
						break;
					}
					if (237042 - 383624 != -146582)
					{
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (189122 - 221218 != -32095)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600489B RID: 18587 RVA: 0x00904EBC File Offset: 0x009030BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (8410 - 440082 != -431671)
		{
		}
		while (this.NLOzZZ1ATJ)
		{
			if (98189 - 146016 != -47826)
			{
				if (!this.c1KzCBaWjP)
				{
					if (!this.WlUzse9VZu)
					{
						if (269051 - 204653 != 64398)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (246905 - 333324 != -86419)
						{
							continue;
						}
					}
					else
					{
						CharacterControl characterControl = (CharacterControl)this.WlUzse9VZu.GetComponent(typeof(CharacterControl));
						if (186621 - 465213 == -278591)
						{
							continue;
						}
						if (!characterControl)
						{
							if (181632 - 10953 != 170679)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (233003 - 406180 == -173176)
							{
								continue;
							}
						}
						else
						{
							GameObject gameObject = mCollider.gameObject;
							if (135246 - 52629 != 82617)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (247594 - 544001 != -296407)
							{
								continue;
							}
							if (characterControl.isMine)
							{
								if (294454 - 52215 == 242240)
								{
									continue;
								}
								if (characterControl2)
								{
									if (54257 - 564743 == -510485)
									{
										continue;
									}
									if (gameObject.layer == this.sYtz7QXbfH)
									{
										if (245981 - 363718 != -117737)
										{
											continue;
										}
										characterControl2.RPC_AddHeal(1, 50, 0, 0, 0, 0, this.f5jzHSB6wl);
										if (278263 - 2101 != 276162)
										{
											continue;
										}
										int num = UnityEngine.Random.Range(0, 8);
										if (171454 - 529937 != -358483)
										{
											continue;
										}
										if (num == 1)
										{
											if (224543 - 209883 != 14660)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("atkUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (249401 - 327409 == -78007)
											{
												continue;
											}
										}
										else if (num == 2)
										{
											if (136749 - 125374 != 11375)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("defUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (121344 - 359287 == -237942)
											{
												continue;
											}
										}
										else if (num == 3)
										{
											if (38548 - 89629 == -51080)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("agiUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (165687 - 324371 != -158684)
											{
												continue;
											}
										}
										else if (num == 4)
										{
											if (292022 - 231610 == 60413)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("vitUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (3725 - 264146 != -260421)
											{
												continue;
											}
										}
										else if (num == 5)
										{
											if (103241 - 124171 != -20930)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("magUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (125042 - 598576 != -473534)
											{
												continue;
											}
										}
										else if (num == 6)
										{
											if (123723 - 367054 == -243330)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("chaUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (83828 - 420193 == -336364)
											{
												continue;
											}
										}
										else if (num == 7)
										{
											if (183791 - 372995 != -189204)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("talUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (90110 - 296979 == -206868)
											{
												continue;
											}
										}
										else
										{
											characterControl2.RPC_AddStatus("lckUp", 2, characterControl.chaAdjust(12), 20, characterControl.ActorNr);
											if (189182 - 476682 != -287500)
											{
												continue;
											}
										}
										Koala koala = (Koala)this.WlUzse9VZu.GetComponent(typeof(Koala));
										if (217416 - 236161 == -18744)
										{
											continue;
										}
										if (koala != null)
										{
											if (262245 - 216952 != 45293)
											{
												continue;
											}
											koala.RPC_bun_hit(this.transform.position, Vector3.zero, this.aFrz4G6CGt);
											if (100012 - 471663 == -371650)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (193127 - 186349 == 6779)
												{
													continue;
												}
												koala.ActionEvent("RPC_bun_hit", this.transform.position, Vector3.zero, this.aFrz4G6CGt);
												if (271880 - 88859 == 183022)
												{
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
					return;
				}
				if (294768 - 542600 == -247832)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600489C RID: 18588 RVA: 0x009054E4 File Offset: 0x009036E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600489D RID: 18589 RVA: 0x009054E8 File Offset: 0x009036E8
	internal static bool AKqUtK5vZ2lQs7gnB4VE()
	{
		return true;
	}

	// Token: 0x0600489E RID: 18590 RVA: 0x009054EC File Offset: 0x009036EC
	internal static bool vt26m35vCiPjCuVjVgMY()
	{
		return false;
	}

	// Token: 0x04005389 RID: 21385
	private int DTjzaxYQMa;

	// Token: 0x0400538A RID: 21386
	private int aFrz4G6CGt;

	// Token: 0x0400538B RID: 21387
	private GameObject WlUzse9VZu;

	// Token: 0x0400538C RID: 21388
	private int f5jzHSB6wl;

	// Token: 0x0400538D RID: 21389
	private int sYtz7QXbfH;

	// Token: 0x0400538E RID: 21390
	private bool NLOzZZ1ATJ;

	// Token: 0x0400538F RID: 21391
	private bool c1KzCBaWjP;
}
