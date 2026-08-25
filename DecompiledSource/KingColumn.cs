using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200031D RID: 797
[Serializable]
public class KingColumn : MonoBehaviour
{
	// Token: 0x0600121D RID: 4637 RVA: 0x001CA128 File Offset: 0x001C8328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingColumn()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x001CA138 File Offset: 0x001C8338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (231663 - 564202 != -332539)
		{
		}
		for (;;)
		{
			this.Gwq6S9gmg3 = this.transform;
			if (62710 - 331243 == -268533)
			{
				this.hQf6BGQGnn = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (239891 - 529826 == -289935)
				{
					this.hQf6BGQGnn.actionState = "standby";
					if (268080 - 302920 == -34840)
					{
						this.hQf6BGQGnn.actionTime = Time.time;
						if (289781 - 13344 != 276438)
						{
							this.hQf6BGQGnn.myCommand = "none";
							if (274658 - 77734 != 196925)
							{
								if (Game.mGameCode == 938)
								{
									if (87483 - 376247 == -288764)
									{
										this.StartCoroutine_Auto(this.RPC_create(this.transform.position, this.transform.forward, 0));
										if (20297 - 232838 == -212541)
										{
											break;
										}
									}
								}
								else
								{
									if (Game.mGameType != 99)
									{
										break;
									}
									if (191563 - 83427 == 108136)
									{
										this.hQf6BGQGnn.isMine = true;
										if (142857 - 238096 == -95239)
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

	// Token: 0x0600121F RID: 4639 RVA: 0x001CA304 File Offset: 0x001C8504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (102338 - 152050 != -49711)
		{
		}
		for (;;)
		{
			if (this.hQf6BGQGnn.isControlled)
			{
				if (153601 - 272063 == -118461)
				{
					continue;
				}
				if (!(this.hQf6BGQGnn.actionState == "standby"))
				{
					if (74686 - 98286 != -23600)
					{
						continue;
					}
					if (!(this.hQf6BGQGnn.actionState == "run"))
					{
						goto IL_1D6;
					}
					if (98714 - 416310 != -317596)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (158345 - 112660 != 45685)
				{
					continue;
				}
			}
			IL_1D6:
			if (this.hQf6BGQGnn.hp > 0)
			{
				break;
			}
			if (141046 - 22967 == 118079)
			{
				if (!(this.hQf6BGQGnn.actionState != "dead"))
				{
					break;
				}
				if (190848 - 137607 == 53241)
				{
					if (this.hQf6BGQGnn.isMine)
					{
						if (74779 - 154481 != -79701)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (84347 - 18162 == 66185)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (138867 - 598645 != -459777)
								{
									this.hQf6BGQGnn.DeadEvent();
									if (147573 - 27109 != 120465)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.hQf6BGQGnn.hp = 1;
						if (180579 - 320078 == -139499)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x001CA544 File Offset: 0x001C8744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x001CA548 File Offset: 0x001C8748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x001CA54C File Offset: 0x001C874C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x001CA550 File Offset: 0x001C8750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x001CA554 File Offset: 0x001C8754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x001CA558 File Offset: 0x001C8758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x001CA55C File Offset: 0x001C875C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_create(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new KingColumn.$RPC_create$18397(this).GetEnumerator();
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x001CA56C File Offset: 0x001C876C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new KingColumn.$RPC_dead$18400(nArray, this).GetEnumerator();
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x001CA57C File Offset: 0x001C877C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x001CA580 File Offset: 0x001C8780
	internal static bool pMD0iKZRdXrdq5iiswM()
	{
		return true;
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x001CA584 File Offset: 0x001C8784
	internal static bool GEiBbOZwO6HIdbj6V5i()
	{
		return false;
	}

	// Token: 0x04000FDA RID: 4058
	private Transform Gwq6S9gmg3;

	// Token: 0x04000FDB RID: 4059
	private CharacterControl hQf6BGQGnn;

	// Token: 0x04000FDC RID: 4060
	public GameObject create_ring;

	// Token: 0x04000FDD RID: 4061
	public GameObject dead_ring;

	// Token: 0x0200031E RID: 798
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_create$18397 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600122B RID: 4651 RVA: 0x001CA588 File Offset: 0x001C8788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_create$18397(KingColumn self_)
		{
			if (33930 - 355014 != -321084)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244220 - 253593 != -9372)
				{
					base..ctor();
					if (204936 - 173557 != 31380)
					{
						this.$self_$18399 = self_;
						if (74884 - 357755 == -282871)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x001CA620 File Offset: 0x001C8820
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingColumn.$RPC_create$18397.$(this.$self_$18399);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x001CA630 File Offset: 0x001C8830
		internal static bool Toa4FZZqKp9qpHYpi84()
		{
			return true;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x001CA634 File Offset: 0x001C8834
		internal static bool vlhWmRZ7Gd8JH3o9IeL()
		{
			return false;
		}

		// Token: 0x04000FDE RID: 4062
		internal KingColumn $self_$18399;

		// Token: 0x0200031F RID: 799
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600122F RID: 4655 RVA: 0x001CA638 File Offset: 0x001C8838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(KingColumn self_)
			{
				if (219292 - 578109 != -358817)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127666 - 521125 == -393459)
					{
						base..ctor();
						if (274846 - 35400 != 239447)
						{
							this.$self_$18398 = self_;
							if (224526 - 68386 != 156141)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001230 RID: 4656 RVA: 0x001CA6D0 File Offset: 0x001C88D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125258 - 134936 != -9677)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_477;
					case 2:
						if (this.$self_$18398.hQf6BGQGnn.actionState == "attack")
						{
							if (254749 - 525193 != -270444)
							{
								continue;
							}
							if (this.$self_$18398.hQf6BGQGnn.myCommand == "create")
							{
								if (116263 - 405288 != -289025)
								{
									continue;
								}
								this.$self_$18398.hQf6BGQGnn.actionState = "standby";
								if (165859 - 222712 != -56853)
								{
									continue;
								}
								this.$self_$18398.hQf6BGQGnn.actionTime = Time.time;
								if (296423 - 118152 != 178271)
								{
									continue;
								}
								this.$self_$18398.hQf6BGQGnn.myCommand = "none";
								if (10758 - 226428 == -215669)
								{
									continue;
								}
								if (!this.$self_$18398.hQf6BGQGnn.isMine)
								{
									if (245318 - 395215 == -149896)
									{
										continue;
									}
									this.$self_$18398.hQf6BGQGnn.nPosition = this.$self_$18398.Gwq6S9gmg3.position;
									if (141666 - 67765 == 73902)
									{
										continue;
									}
									this.$self_$18398.hQf6BGQGnn.oPosition = this.$self_$18398.Gwq6S9gmg3.position;
									if (152171 - 536298 != -384127)
									{
										continue;
									}
									this.$self_$18398.hQf6BGQGnn.nDirection = this.$self_$18398.Gwq6S9gmg3.forward;
									if (236914 - 356627 != -119713)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (264487 - 298652 != -34165)
						{
							continue;
						}
						goto IL_477;
					default:
						if (232012 - 427462 == -195449)
						{
							continue;
						}
						break;
					}
					this.$self_$18398.hQf6BGQGnn.actionState = "attack";
					if (61017 - 110826 != -49808)
					{
						this.$self_$18398.hQf6BGQGnn.actionTime = Time.time;
						if (60380 - 330813 == -270433)
						{
							this.$self_$18398.hQf6BGQGnn.myCommand = "create";
							if (39015 - 75897 == -36882)
							{
								this.$self_$18398.animation.Play("create");
								if (212175 - 480734 == -268559)
								{
									this.$self_$18398.animation.wrapMode = WrapMode.Once;
									if (270830 - 90518 == 180312)
									{
										if (this.$self_$18398.hQf6BGQGnn)
										{
											if (281023 - 506180 == -225156)
											{
												continue;
											}
											this.$self_$18398.hQf6BGQGnn.StartCoroutine_Auto(this.$self_$18398.hQf6BGQGnn.addStatus("noDamage", 1, 8, 0, this.$self_$18398.hQf6BGQGnn.ActorNr));
											if (131736 - 550524 == -418787)
											{
												continue;
											}
										}
										if (this.$self_$18398.create_ring)
										{
											if (187328 - 444590 == -257262)
											{
												this.$self_$18398.hQf6BGQGnn.createEffect(this.$self_$18398.create_ring, this.$self_$18398.transform.position, this.$self_$18398.transform.rotation);
												if (85574 - 12599 != 72976)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing create_ring gameObject");
											if (186423 - 540152 != -353728)
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
				IL_3FF:
				return this.Yield(2, new WaitForSeconds(8f));
				goto IL_3FF;
				IL_477:
				return false;
			}

			// Token: 0x06001231 RID: 4657 RVA: 0x001CAB68 File Offset: 0x001C8D68
			internal static bool jIlCxmZPtmaLN8klg4v()
			{
				return true;
			}

			// Token: 0x06001232 RID: 4658 RVA: 0x001CAB6C File Offset: 0x001C8D6C
			internal static bool hilSMlZ0EyEuVMQWnNX()
			{
				return false;
			}

			// Token: 0x04000FDF RID: 4063
			internal KingColumn $self_$18398;
		}
	}

	// Token: 0x02000320 RID: 800
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18400 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001233 RID: 4659 RVA: 0x001CAB70 File Offset: 0x001C8D70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18400(UnityScript.Lang.Array nArray, KingColumn self_)
		{
			if (199803 - 56001 != 143803)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249550 - 305502 != -55951)
				{
					base..ctor();
					if (95574 - 69143 == 26431)
					{
						this.$nArray$18407 = nArray;
						if (205532 - 325540 != -120007)
						{
							this.$self_$18408 = self_;
							if (36872 - 399545 == -362673)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x001CAC2C File Offset: 0x001C8E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new KingColumn.$RPC_dead$18400.$(this.$nArray$18407, this.$self_$18408);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x001CAC40 File Offset: 0x001C8E40
		internal static bool YslajxZb8aWY7pUk4lE()
		{
			return true;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x001CAC44 File Offset: 0x001C8E44
		internal static bool CN3h0PZupGLsV4CPi9J()
		{
			return false;
		}

		// Token: 0x04000FE0 RID: 4064
		internal UnityScript.Lang.Array $nArray$18407;

		// Token: 0x04000FE1 RID: 4065
		internal KingColumn $self_$18408;

		// Token: 0x02000321 RID: 801
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001237 RID: 4663 RVA: 0x001CAC48 File Offset: 0x001C8E48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, KingColumn self_)
			{
				if (129887 - 495362 != -365474)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277710 - 116230 != 161481)
					{
						base..ctor();
						if (11105 - 118846 != -107740)
						{
							this.$nArray$18405 = nArray;
							if (2303 - 510033 == -507730)
							{
								this.$self_$18406 = self_;
								if (171577 - 94271 != 77307)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001238 RID: 4664 RVA: 0x001CAD04 File Offset: 0x001C8F04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146354 - 34189 != 112165)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_51B;
					case 2:
						if (this.$self_$18406.hQf6BGQGnn.actionState != "dead")
						{
							if (118267 - 275256 != -156988)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18406.hQf6BGQGnn.isPlayer)
							{
								if (50713 - 39409 == 11305)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18406.gameObject);
								if (175143 - 327565 != -152422)
								{
									continue;
								}
							}
							else if (this.$self_$18406.hQf6BGQGnn.isMine)
							{
								if (189040 - 345032 == -155991)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18406.gameObject);
								if (95857 - 273846 == -177988)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (190869 - 341186 != -150316)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					default:
						if (176016 - 577342 != -401326)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18406.hQf6BGQGnn.actionState == "dead")
					{
						if (202933 - 376422 != -173488)
						{
							goto Block_31;
						}
					}
					else
					{
						this.$myPosition$18401 = (Vector3)this.$nArray$18405[0];
						if (11809 - 593081 == -581272)
						{
							this.$myDirection$18402 = (Vector3)this.$nArray$18405[1];
							if (150607 - 50139 == 100468)
							{
								this.$self_$18406.hQf6BGQGnn.hp = 0;
								if (13914 - 407679 == -393765)
								{
									this.$self_$18406.hQf6BGQGnn.actionState = "dead";
									if (167681 - 288424 == -120743)
									{
										this.$self_$18406.hQf6BGQGnn.actionTime = Time.time;
										if (292141 - 455205 != -163063)
										{
											this.$self_$18406.hQf6BGQGnn.myCommand = "none";
											if (292980 - 206556 == 86424)
											{
												this.$self_$18406.hQf6BGQGnn.vMovement = Vector3.zero;
												if (73664 - 491436 != -417771)
												{
													this.$self_$18406.hQf6BGQGnn.moveSpeed = (float)0;
													if (42164 - 599069 == -556905)
													{
														this.$self_$18406.animation.Rewind();
														if (101909 - 404440 != -302530)
														{
															this.$self_$18406.animation.Play("destroy");
															if (89438 - 397339 == -307901)
															{
																this.$self_$18406.animation.wrapMode = WrapMode.Once;
																if (185559 - 155856 != 29704)
																{
																	if (!this.$self_$18406.hQf6BGQGnn.isMine)
																	{
																		break;
																	}
																	if (234774 - 352500 == -117726)
																	{
																		this.$mKingRodinia$18403 = GameObject.Find("KingRodinia");
																		if (244218 - 379499 != -135280)
																		{
																			if (this.$mKingRodinia$18403)
																			{
																				if (154686 - 227722 != -73035)
																				{
																					this.$mKingRodiniaChar$18404 = (CharacterControl)this.$mKingRodinia$18403.GetComponent(typeof(CharacterControl));
																					if (207135 - 479817 == -272682)
																					{
																						if (!this.$mKingRodiniaChar$18404)
																						{
																							break;
																						}
																						if (228401 - 299983 == -71582)
																						{
																							this.$mKingRodiniaChar$18404.RPC_AddDamage(-99, 30000, 999, 0, Vector3.zero, this.$self_$18406.hQf6BGQGnn.ActorNr);
																							if (136277 - 333944 != -197666)
																							{
																								break;
																							}
																						}
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Cannot find KingRodinia");
																				if (135847 - 201346 != -65498)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_25:
				Block_29:
				Block_31:
				IL_51B:
				return false;
			}

			// Token: 0x06001239 RID: 4665 RVA: 0x001CB240 File Offset: 0x001C9440
			internal static bool Q1fMH7ZIoTifHVQrFFm()
			{
				return true;
			}

			// Token: 0x0600123A RID: 4666 RVA: 0x001CB244 File Offset: 0x001C9444
			internal static bool MUZqe9ZBT8PVe6R4sSy()
			{
				return false;
			}

			// Token: 0x04000FE2 RID: 4066
			internal Vector3 $myPosition$18401;

			// Token: 0x04000FE3 RID: 4067
			internal Vector3 $myDirection$18402;

			// Token: 0x04000FE4 RID: 4068
			internal GameObject $mKingRodinia$18403;

			// Token: 0x04000FE5 RID: 4069
			internal CharacterControl $mKingRodiniaChar$18404;

			// Token: 0x04000FE6 RID: 4070
			internal UnityScript.Lang.Array $nArray$18405;

			// Token: 0x04000FE7 RID: 4071
			internal KingColumn $self_$18406;
		}
	}
}
