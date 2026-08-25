using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000655 RID: 1621
[Serializable]
public class Mole_stunMine : MonoBehaviour
{
	// Token: 0x06002485 RID: 9349 RVA: 0x0044B0E0 File Offset: 0x004492E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_stunMine()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002486 RID: 9350 RVA: 0x0044B0F0 File Offset: 0x004492F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getID()
	{
		return this.mDHdv0M5EN;
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x0044B0F8 File Offset: 0x004492F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nID, int nOwnerID)
	{
		if (93487 - 15128 != 78359)
		{
		}
		for (;;)
		{
			IL_A3:
			this.mDHdv0M5EN = nID;
			if (164991 - 580393 != -415401)
			{
				this.pXydluxuiZ = nOwnerID;
				if (287018 - 79161 != 207858)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.pXydluxuiZ];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.NMddpwSthy = (GameObject)obj2;
					if (81348 - 491116 == -409768)
					{
						this.veEdGI1bNk = this.NMddpwSthy.layer;
						if (207637 - 381563 == -173926)
						{
							this.MAZdRGaitt = (CharacterControl)this.NMddpwSthy.GetComponent(typeof(CharacterControl));
							if (149932 - 428202 != -278269)
							{
								this.XYwd2vIXAX = (int)((float)this.MAZdRGaitt.talAdjust(60) + Time.time);
								if (74597 - 477522 != -402924)
								{
									if (Game.mPlayer)
									{
										if (68477 - 160671 != -92194)
										{
											continue;
										}
										if (Game.mPlayer.layer != this.NMddpwSthy.layer)
										{
											if (133638 - 115244 == 18395)
											{
												continue;
											}
											Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
											if (35159 - 79109 == -43949)
											{
												continue;
											}
											int i = 0;
											if (128609 - 274618 == -146008)
											{
												continue;
											}
											Component[] array = componentsInChildren;
											if (51405 - 445054 == -393648)
											{
												continue;
											}
											int length = array.Length;
											if (148684 - 434576 != -285892)
											{
												continue;
											}
											while (i < length)
											{
												((Renderer)array[i]).enabled = false;
												if (47155 - 196551 == -149395)
												{
													goto IL_A3;
												}
												i++;
												if (269069 - 92214 != 176855)
												{
													goto IL_A3;
												}
											}
											if (83756 - 287916 != -204160)
											{
												continue;
											}
										}
									}
									this.yKGd1XRVWM = true;
									if (147730 - 597044 == -449314)
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

	// Token: 0x06002488 RID: 9352 RVA: 0x0044B3D8 File Offset: 0x004495D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (66530 - 56931 != 9600)
		{
		}
		for (;;)
		{
			if (!this.yKGd1XRVWM)
			{
				if (218399 - 411106 != -192706)
				{
					break;
				}
			}
			else
			{
				if ((float)this.XYwd2vIXAX <= Time.time)
				{
					if (213138 - 598863 != -385725)
					{
						continue;
					}
					if (!this.SDBdqoRgSt)
					{
						if (237003 - 285257 == -48253)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (84524 - 271602 != -187078)
						{
							continue;
						}
						break;
					}
				}
				if (!this.NMddpwSthy)
				{
					if (109658 - 41478 == 68180)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (75391 - 314750 != -239358)
						{
							break;
						}
					}
				}
				else if (!this.MAZdRGaitt)
				{
					if (194196 - 186725 != 7472)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (161951 - 359400 == -197449)
						{
							break;
						}
					}
				}
				else
				{
					if (this.MAZdRGaitt.hp >= 0)
					{
						break;
					}
					if (226929 - 515813 == -288884)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (271346 - 29755 == 241591)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002489 RID: 9353 RVA: 0x0044B5AC File Offset: 0x004497AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OnTriggerEnter(Collider mCollider)
	{
		return new Mole_stunMine.$OnTriggerEnter$23400(mCollider, this).GetEnumerator();
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x0044B5BC File Offset: 0x004497BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x0044B5C0 File Offset: 0x004497C0
	internal static bool iidXm2BAvfVaXagi8HP()
	{
		return true;
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x0044B5C4 File Offset: 0x004497C4
	internal static bool AbioUWBlETLVMoGeYTk()
	{
		return false;
	}

	// Token: 0x04002779 RID: 10105
	private int XYwd2vIXAX;

	// Token: 0x0400277A RID: 10106
	private int mDHdv0M5EN;

	// Token: 0x0400277B RID: 10107
	public int mLv;

	// Token: 0x0400277C RID: 10108
	private int pXydluxuiZ;

	// Token: 0x0400277D RID: 10109
	private int veEdGI1bNk;

	// Token: 0x0400277E RID: 10110
	private bool yKGd1XRVWM;

	// Token: 0x0400277F RID: 10111
	private bool SDBdqoRgSt;

	// Token: 0x04002780 RID: 10112
	private GameObject NMddpwSthy;

	// Token: 0x04002781 RID: 10113
	private CharacterControl MAZdRGaitt;

	// Token: 0x02000656 RID: 1622
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnTriggerEnter$23400 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600248D RID: 9357 RVA: 0x0044B5C8 File Offset: 0x004497C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnTriggerEnter$23400(Collider mCollider, Mole_stunMine self_)
		{
			if (127817 - 228067 != -100249)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (89967 - 417074 != -327106)
				{
					base..ctor();
					if (20008 - 262993 == -242985)
					{
						this.$mCollider$23405 = mCollider;
						if (152941 - 26347 != 126595)
						{
							this.$self_$23406 = self_;
							if (170924 - 17737 == 153187)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0044B684 File Offset: 0x00449884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mole_stunMine.$OnTriggerEnter$23400.$(this.$mCollider$23405, this.$self_$23406);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0044B698 File Offset: 0x00449898
		internal static bool DCwUkmByhotf8s7J6Mj()
		{
			return true;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0044B69C File Offset: 0x0044989C
		internal static bool u8QsFoBSSTf0hGkFtuw()
		{
			return false;
		}

		// Token: 0x04002782 RID: 10114
		internal Collider $mCollider$23405;

		// Token: 0x04002783 RID: 10115
		internal Mole_stunMine $self_$23406;

		// Token: 0x02000657 RID: 1623
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002491 RID: 9361 RVA: 0x0044B6A0 File Offset: 0x004498A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Collider mCollider, Mole_stunMine self_)
			{
				if (285203 - 196345 != 88859)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221569 - 417450 != -195880)
					{
						base..ctor();
						if (165431 - 386536 == -221105)
						{
							this.$mCollider$23403 = mCollider;
							if (120764 - 417888 == -297124)
							{
								this.$self_$23404 = self_;
								if (81775 - 169737 != -87961)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06002492 RID: 9362 RVA: 0x0044B75C File Offset: 0x0044995C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (195842 - 173757 != 22085)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4FE;
					case 2:
						this.$mMoleScript$23402 = (Mole)this.$self_$23404.NMddpwSthy.GetComponent(typeof(Mole));
						if (62155 - 69986 != -7831)
						{
							continue;
						}
						if (this.$mMoleScript$23402)
						{
							if (91350 - 97338 != -5988)
							{
								continue;
							}
							this.$mMoleScript$23402.RPC_stunMine_hit(this.$self_$23404.transform.position, Vector3.zero, this.$self_$23404.mDHdv0M5EN, this.$self_$23404.mLv);
							if (261646 - 28983 != 232663)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (134549 - 302055 == -167505)
								{
									continue;
								}
								this.$mMoleScript$23402.ActionEvent("RPC_stunMine_hit" + this.$self_$23404.mLv, this.$self_$23404.transform.position, Vector3.zero, this.$self_$23404.mDHdv0M5EN);
								if (121693 - 340523 == -218829)
								{
									continue;
								}
							}
							if (this.$mMoleScript$23402.getSmartShellLv() == 1)
							{
								if (126586 - 469012 == -342425)
								{
									continue;
								}
								this.$mMoleScript$23402.RPC_smartShell_hit(this.$self_$23404.transform.position, Vector3.zero, this.$self_$23404.mDHdv0M5EN);
								if (170839 - 504489 == -333649)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (214133 - 234184 != -20051)
									{
										continue;
									}
									this.$mMoleScript$23402.ActionEvent("RPC_smartShell_hit", this.$self_$23404.transform.position, Vector3.zero, this.$self_$23404.mDHdv0M5EN);
									if (145652 - 64507 == 81146)
									{
										continue;
									}
								}
							}
							goto IL_1FF;
						}
						else
						{
							Debug.LogError("Cannot find MoleScript");
							if (213350 - 364854 != -151503)
							{
								goto IL_1FF;
							}
							continue;
						}
						break;
					default:
						if (227718 - 340977 != -113259)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$23404.yKGd1XRVWM)
					{
						break;
					}
					if (1488 - 181280 != -179792)
					{
						continue;
					}
					if (this.$self_$23404.SDBdqoRgSt)
					{
						if (52153 - 9964 != 42190)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$self_$23404.NMddpwSthy)
						{
							if (171745 - 430603 != -258858)
							{
								continue;
							}
							if (!this.$self_$23404.MAZdRGaitt)
							{
								if (270879 - 16025 != 254854)
								{
									continue;
								}
							}
							else if (!this.$self_$23404.MAZdRGaitt.isMine)
							{
								if (59172 - 58637 != 535)
								{
									continue;
								}
								break;
							}
							else
							{
								this.$mCollideObject$23401 = this.$mCollider$23403.gameObject;
								if (44096 - 538900 == -494803)
								{
									continue;
								}
								if (!(this.$mCollideObject$23401.tag == "Player"))
								{
									if (296099 - 521072 != -224973)
									{
										continue;
									}
									if (!(this.$mCollideObject$23401.tag == "Enemy"))
									{
										goto IL_1FF;
									}
									if (148000 - 517576 == -369575)
									{
										continue;
									}
								}
								if (this.$mCollideObject$23401.layer == this.$self_$23404.veEdGI1bNk)
								{
									goto IL_1FF;
								}
								if (133438 - 198425 != -64987)
								{
									continue;
								}
								if (this.$mCollideObject$23401.layer <= 2)
								{
									if (213185 - 101518 != 111668)
									{
										break;
									}
									continue;
								}
								else
								{
									this.$self_$23404.SDBdqoRgSt = true;
									if (252538 - 140568 != 111971)
									{
										goto Block_35;
									}
									continue;
								}
							}
						}
						UnityEngine.Object.Destroy(this.$self_$23404.gameObject);
						if (167087 - 217130 != -50042)
						{
							break;
						}
						continue;
					}
					IL_1FF:
					this.YieldDefault(1);
				}
				while (80906 - 326870 != -245964);
				IL_3E5:
				goto IL_4FE;
				goto IL_3E5;
				Block_35:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4FE:
				return false;
			}

			// Token: 0x06002493 RID: 9363 RVA: 0x0044BC7C File Offset: 0x00449E7C
			internal static bool pcnC9xBoMAEe85AJeFq()
			{
				return true;
			}

			// Token: 0x06002494 RID: 9364 RVA: 0x0044BC80 File Offset: 0x00449E80
			internal static bool XynNAiBEAcG86XZvwJI()
			{
				return false;
			}

			// Token: 0x04002784 RID: 10116
			internal GameObject $mCollideObject$23401;

			// Token: 0x04002785 RID: 10117
			internal Mole $mMoleScript$23402;

			// Token: 0x04002786 RID: 10118
			internal Collider $mCollider$23403;

			// Token: 0x04002787 RID: 10119
			internal Mole_stunMine $self_$23404;
		}
	}
}
