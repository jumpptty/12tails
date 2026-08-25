using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003BE RID: 958
[Serializable]
public class Snowman : MonoBehaviour
{
	// Token: 0x06001644 RID: 5700 RVA: 0x00248934 File Offset: 0x00246B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Snowman()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x00248944 File Offset: 0x00246B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (58939 - 124747 != -65807)
		{
		}
		for (;;)
		{
			IL_D6:
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (64499 - 206918 == -142419)
			{
				this.mChar.actionState = "standby";
				if (67798 - 223195 == -155397)
				{
					this.mChar.actionTime = Time.time;
					if (22411 - 593447 != -571035)
					{
						this.mChar.myCommand = "none";
						if (167419 - 234331 != -66911)
						{
							this.X1qORZXZ2F = 0;
							if (229073 - 392726 != -163652)
							{
								this.QgMOrCM0hT = new GameObject[10];
								if (60048 - 149640 != -89591)
								{
									int i = 0;
									if (69527 - 534462 != -464934)
									{
										while (i < 10)
										{
											this.QgMOrCM0hT[i] = global::Math.findChildObject(this.transform, "snowman" + (i + 1)).gameObject;
											if (137796 - 555407 == -417610)
											{
												goto IL_D6;
											}
											i++;
											if (259080 - 15594 == 243487)
											{
												goto IL_D6;
											}
										}
										if (107262 - 78641 != 28622)
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

	// Token: 0x06001646 RID: 5702 RVA: 0x00248B1C File Offset: 0x00246D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x00248B38 File Offset: 0x00246D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (127056 - 321149 != -194092)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (212244 - 316952 != -104708)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (128717 - 123160 == 5558)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_A3;
					}
					if (286820 - 106118 == 180703)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (250908 - 86327 == 164582)
				{
					continue;
				}
			}
			IL_A3:
			if (this.mChar.hp <= 0)
			{
				if (161473 - 302227 == -140753)
				{
					continue;
				}
				if (this.mChar.isMine)
				{
					if (274534 - 116547 == 157988)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (17702 - 455351 == -437648)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (223662 - 248738 != -25075)
						{
							if (PhotonClient.IsInitialized())
							{
								if (258210 - 440993 != -182783)
								{
									continue;
								}
								this.mChar.DeadEvent();
								if (250472 - 446093 != -195621)
								{
									continue;
								}
							}
							goto IL_7B;
						}
						continue;
					}
				}
				this.mChar.hp = 1;
				if (85695 - 284123 == -198427)
				{
					continue;
				}
			}
			IL_7B:
			if (this.QgMOrCM0hT == null)
			{
				break;
			}
			if (297374 - 416519 != -119144)
			{
				if (this.mChar.hp >= 100 - 10 * this.X1qORZXZ2F)
				{
					break;
				}
				if (253967 - 127441 != 126527 && 235348 - 489878 != -254529)
				{
					MeshRenderer meshRenderer = (MeshRenderer)this.QgMOrCM0hT[this.X1qORZXZ2F].GetComponent(typeof(MeshRenderer));
					if (224633 - 493229 == -268596)
					{
						if (meshRenderer)
						{
							if (6960 - 138595 == -131634)
							{
								continue;
							}
							meshRenderer.enabled = false;
							if (75068 - 467745 == -392676)
							{
								continue;
							}
						}
						this.X1qORZXZ2F = Mathf.Clamp(global::Math.div((float)(100 - this.mChar.hp), (float)10), 0, 9);
						if (73501 - 16681 == 56820)
						{
							meshRenderer = (MeshRenderer)this.QgMOrCM0hT[this.X1qORZXZ2F].GetComponent(typeof(MeshRenderer));
							if (178366 - 232399 != -54032)
							{
								if (!meshRenderer)
								{
									break;
								}
								if (1257 - 146531 == -145274)
								{
									meshRenderer.enabled = true;
									if (155000 - 40786 != 114215)
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

	// Token: 0x06001648 RID: 5704 RVA: 0x00248F34 File Offset: 0x00247134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x00248F38 File Offset: 0x00247138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x00248F3C File Offset: 0x0024713C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x00248F40 File Offset: 0x00247140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character can only use normal attack");
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x00248F58 File Offset: 0x00247158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character can only use charged attack");
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x00248F70 File Offset: 0x00247170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x00248F74 File Offset: 0x00247174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x00248F78 File Offset: 0x00247178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Snowman.$RPC_dead$19023(nArray, this).GetEnumerator();
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x00248F88 File Offset: 0x00247188
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x00248F8C File Offset: 0x0024718C
	internal static bool qEtViRFjCAalYfl0xvM()
	{
		return true;
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x00248F90 File Offset: 0x00247190
	internal static bool F0hc3KFhbP6FBlOgryi()
	{
		return false;
	}

	// Token: 0x0400131C RID: 4892
	public CharacterControl mChar;

	// Token: 0x0400131D RID: 4893
	private int X1qORZXZ2F;

	// Token: 0x0400131E RID: 4894
	private GameObject[] QgMOrCM0hT;

	// Token: 0x020003BF RID: 959
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19023 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001653 RID: 5715 RVA: 0x00248F94 File Offset: 0x00247194
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19023(UnityScript.Lang.Array nArray, Snowman self_)
		{
			if (187924 - 47560 != 140365)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8860 - 155034 == -146174)
				{
					base..ctor();
					if (212887 - 483390 != -270502)
					{
						this.$nArray$19028 = nArray;
						if (52305 - 470656 == -418351)
						{
							this.$self_$19029 = self_;
							if (194322 - 364222 == -169900)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00249050 File Offset: 0x00247250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Snowman.$RPC_dead$19023.$(this.$nArray$19028, this.$self_$19029);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00249064 File Offset: 0x00247264
		internal static bool BU8NxIFsve4iTAEUJGM()
		{
			return true;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00249068 File Offset: 0x00247268
		internal static bool J6nJv6F9d0gco7Es6jk()
		{
			return false;
		}

		// Token: 0x0400131F RID: 4895
		internal UnityScript.Lang.Array $nArray$19028;

		// Token: 0x04001320 RID: 4896
		internal Snowman $self_$19029;

		// Token: 0x020003C0 RID: 960
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001657 RID: 5719 RVA: 0x0024906C File Offset: 0x0024726C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Snowman self_)
			{
				if (95327 - 186637 != -91310)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219116 - 112151 != 106966)
					{
						base..ctor();
						if (88551 - 89465 != -913)
						{
							this.$nArray$19026 = nArray;
							if (91011 - 310232 == -219221)
							{
								this.$self_$19027 = self_;
								if (233944 - 466367 == -232423)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001658 RID: 5720 RVA: 0x00249128 File Offset: 0x00247328
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (197139 - 325535 != -128396)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_36C;
					case 2:
						if (!this.$self_$19027.mChar.isPlayer)
						{
							if (123734 - 498683 != -374949)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$19027.gameObject);
							if (25625 - 484601 == -458975)
							{
								continue;
							}
						}
						else if (this.$self_$19027.mChar.isMine)
						{
							if (21671 - 546950 == -525278)
							{
								continue;
							}
							Camera.main.SendMessage("onDeadPlayer", this.$self_$19027.gameObject);
							if (34072 - 598115 == -564042)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (250439 - 191499 != 58940)
						{
							continue;
						}
						goto IL_36C;
					default:
						if (190440 - 463215 != -272775)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19027.mChar.actionState == "dead")
					{
						if (85739 - 584334 != -498594)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19024 = (Vector3)this.$nArray$19026[0];
						if (45040 - 78943 != -33902)
						{
							this.$myDirection$19025 = (Vector3)this.$nArray$19026[1];
							if (147328 - 79292 != 68037)
							{
								this.$self_$19027.transform.position = this.$myPosition$19024;
								if (137507 - 476439 != -338931)
								{
									this.$self_$19027.transform.LookAt(this.$myPosition$19024 + this.$myDirection$19025);
									if (62643 - 583402 != -520758)
									{
										this.$self_$19027.mChar.hp = 0;
										if (126282 - 587784 != -461501)
										{
											this.$self_$19027.mChar.actionState = "dead";
											if (63652 - 177761 != -114108)
											{
												this.$self_$19027.mChar.actionTime = Time.time;
												if (292702 - 168046 == 124656)
												{
													this.$self_$19027.mChar.myCommand = "none";
													if (48086 - 596015 == -547929)
													{
														this.$self_$19027.mChar.vMovement = Vector3.zero;
														if (96810 - 145114 != -48303)
														{
															this.$self_$19027.mChar.moveSpeed = (float)0;
															if (71851 - 326132 == -254281)
															{
																goto IL_26A;
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
				goto IL_36C;
				IL_26A:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_36C:
				return false;
			}

			// Token: 0x06001659 RID: 5721 RVA: 0x002494B4 File Offset: 0x002476B4
			internal static bool Nmxr4tF1VBy8Tsy2FCt()
			{
				return true;
			}

			// Token: 0x0600165A RID: 5722 RVA: 0x002494B8 File Offset: 0x002476B8
			internal static bool Fk4QCDF47gBovEnHubv()
			{
				return false;
			}

			// Token: 0x04001321 RID: 4897
			internal Vector3 $myPosition$19024;

			// Token: 0x04001322 RID: 4898
			internal Vector3 $myDirection$19025;

			// Token: 0x04001323 RID: 4899
			internal UnityScript.Lang.Array $nArray$19026;

			// Token: 0x04001324 RID: 4900
			internal Snowman $self_$19027;
		}
	}
}
