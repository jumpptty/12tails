using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020007E5 RID: 2021
[Serializable]
public class Penguin_typhoon : MonoBehaviour
{
	// Token: 0x06002CC3 RID: 11459 RVA: 0x0058AC78 File Offset: 0x00588E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_typhoon()
	{
		if (202777 - 253005 != -50227)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (63754 - 488910 == -425156)
			{
				base..ctor();
				if (164609 - 304356 != -139746)
				{
					this.mLv = 1;
					if (10666 - 132644 == -121978)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002CC4 RID: 11460 RVA: 0x0058AD10 File Offset: 0x00588F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Init(GameObject nOwner, int nDamage, int nHp, float nLife, int nID, bool nIce)
	{
		return new Penguin_typhoon.$Init$25991(nOwner, nDamage, nHp, nLife, nID, nIce, this).GetEnumerator();
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x0058AD30 File Offset: 0x00588F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (4110 - 283020 != -278909)
		{
		}
		IL_5BA:
		while (this.CosfuMMDBR)
		{
			if (31743 - 55509 == -23766)
			{
				if (!this.iHbfyrOBm6)
				{
					if (!this.EaTfhyGZN9)
					{
						if (36113 - 74447 != -38334)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.onDestroy());
						if (34652 - 324287 == -289634)
						{
							continue;
						}
					}
					else
					{
						if (this.HxFLIJr3hB)
						{
							if (221109 - 108334 != 112775)
							{
								continue;
							}
							if (this.Eg1LcoRwaj >= Time.time)
							{
								if (176256 - 211768 == -35511)
								{
									continue;
								}
								if (this.EaTfhyGZN9.hp > 0)
								{
									if (132753 - 510259 != -377506)
									{
										continue;
									}
									if (this.PIDfzmxJ88 < 0)
									{
										if (61396 - 16557 == 44840)
										{
											continue;
										}
									}
									else
									{
										if (!this.EaTfhyGZN9.isMine)
										{
											break;
										}
										if (7492 - 95396 != -87904)
										{
											continue;
										}
										if (this.aE5LnlAWaT > Time.time)
										{
											break;
										}
										if (27069 - 128914 != -101845)
										{
											continue;
										}
										this.aE5LnlAWaT = Time.time + 0.35f;
										if (244481 - 31272 != 213209)
										{
											continue;
										}
										int layerMask = 130816 - (1 << this.qDmfVaP5rE.layer) + 2;
										if (155128 - 396909 == -241780)
										{
											continue;
										}
										UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)this.mLv, (float)4, layerMask);
										if (77127 - 467457 == -390329)
										{
											continue;
										}
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
										if (297693 - 134926 != 162767)
										{
											continue;
										}
										while (enumerator.MoveNext())
										{
											object obj2 = enumerator.Current;
											object obj4;
											object obj3 = obj4 = obj2;
											if (!(obj3 is GameObject))
											{
												obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
											}
											GameObject gameObject = (GameObject)obj4;
											if (252574 - 245399 == 7176)
											{
												goto IL_5BA;
											}
											int num = this.EaTfhyGZN9.hit(1, gameObject, this.TykL5JJRht, 1, 0, 0.5f * global::Math.vFlat(gameObject.transform.position - this.transform.position).normalized);
											if (74933 - 503040 != -428107)
											{
												goto IL_5BA;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (108380 - 557849 == -449468)
											{
												goto IL_5BA;
											}
											if (num > 0)
											{
												if (220502 - 1379 == 219124)
												{
													goto IL_5BA;
												}
												Bounds bounds = gameObject.collider.bounds;
												if (161967 - 289519 != -127552)
												{
													goto IL_5BA;
												}
												Vector3 center = bounds.center;
												if (273684 - 490373 != -216689)
												{
													goto IL_5BA;
												}
												UnityRuntimeServices.Update(enumerator, gameObject);
												if (280651 - 217413 != 63238)
												{
													goto IL_5BA;
												}
												this.HqxfKk9EFW.RPC_tornado_hit(center, Vector3.zero, 0);
												if (154721 - 308227 == -153505)
												{
													goto IL_5BA;
												}
												if (PhotonClient.IsInitialized())
												{
													if (212215 - 23762 != 188453)
													{
														goto IL_5BA;
													}
													this.HqxfKk9EFW.ActionEvent("RPC_tornado_hit", center, Vector3.zero, 0);
													if (154483 - 335132 != -180649)
													{
														goto IL_5BA;
													}
												}
												this.EaTfhyGZN9.sp = this.EaTfhyGZN9.sp + 1;
												if (253482 - 451207 != -197725)
												{
													goto IL_5BA;
												}
												this.PIDfzmxJ88 -= num;
												if (260286 - 281215 != -20929)
												{
													goto IL_5BA;
												}
												if (this.PNrLevKVMc)
												{
													if (262401 - 538469 != -276068)
													{
														goto IL_5BA;
													}
													if (UnityEngine.Random.Range(0, 100) < this.EaTfhyGZN9.lckAdjust(9))
													{
														if (108637 - 502960 == -394322)
														{
															goto IL_5BA;
														}
														CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
														if (136752 - 321042 != -184290)
														{
															goto IL_5BA;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (139975 - 330148 != -190173)
														{
															goto IL_5BA;
														}
														if (characterControl)
														{
															if (175586 - 269567 != -93981)
															{
																goto IL_5BA;
															}
															characterControl.RPC_AddStatus("frost", this.mLv, Damage.getDebuff((float)2, this.EaTfhyGZN9.cha, characterControl.cha), 0, this.EaTfhyGZN9.ActorNr);
															if (71110 - 6655 == 64456)
															{
																goto IL_5BA;
															}
														}
													}
												}
											}
										}
										if (64290 - 285748 == -221457)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (46936 - 586289 != -539353)
										{
											continue;
										}
										this.HqxfKk9EFW.ActionEvent("RPC_typhoon_move", this.transform.position, this.rigidbody.velocity, this.xGfLJmfBQb);
										if (55830 - 257764 != -201934)
										{
											continue;
										}
										break;
									}
								}
							}
						}
						if (this.EaTfhyGZN9.isMine)
						{
							if (171615 - 318089 == -146473)
							{
								continue;
							}
							this.HqxfKk9EFW.RPC_typhoon_destroy(this.transform.position, Vector3.zero, 0);
							if (296740 - 597421 == -300680)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (44334 - 242931 != -198597)
								{
									continue;
								}
								this.HqxfKk9EFW.ActionEvent("RPC_typhoon_destroy", this.transform.position, Vector3.zero, 0);
								if (20104 - 342267 != -322163)
								{
									continue;
								}
							}
						}
					}
					return;
				}
				if (39277 - 322474 != -283196)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002CC6 RID: 11462 RVA: 0x0058B464 File Offset: 0x00589664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (18724 - 64679 != -45954)
		{
		}
		for (;;)
		{
			if (!this.CosfuMMDBR)
			{
				goto IL_461;
			}
			if (45277 - 589040 == -543762)
			{
				continue;
			}
			if (this.iHbfyrOBm6)
			{
				goto IL_461;
			}
			if (110061 - 234374 == -124312)
			{
				continue;
			}
			this.audio.volume = Mathf.Clamp(this.audio.volume + Time.deltaTime, (float)0, 0.6f);
			if (93082 - 176249 == -83166)
			{
				continue;
			}
			IL_432:
			if (!this.EaTfhyGZN9)
			{
				if (210342 - 197503 != 12840)
				{
					break;
				}
				continue;
			}
			else if (this.EaTfhyGZN9.isMine)
			{
				if (47205 - 249500 == -202294)
				{
					continue;
				}
				if (this.HxFLIJr3hB)
				{
					if (26196 - 293923 == -267726)
					{
						continue;
					}
					Vector3 vector = global::Math.vFlat(this.HxFLIJr3hB.transform.position - this.transform.position);
					if (57785 - 567031 != -509246)
					{
						continue;
					}
					Vector3 normalized = vector.normalized;
					if (227630 - 323118 != -95488)
					{
						continue;
					}
					if (normalized != Vector3.zero)
					{
						if (250349 - 534301 == -283951)
						{
							continue;
						}
						this.rigidbody.AddForce((float)(11 - this.mLv) * normalized.normalized);
						if (59915 - 550599 != -490684)
						{
							continue;
						}
					}
				}
				if (this.PNrLevKVMc)
				{
					if (296283 - 475007 != -178724)
					{
						continue;
					}
					Vector3 velocity = this.rigidbody.velocity;
					if (71288 - 227517 == -156228)
					{
						continue;
					}
					if (velocity.magnitude > (float)40)
					{
						if (235420 - 224779 != 10641)
						{
							continue;
						}
						this.rigidbody.velocity = (float)40 * this.rigidbody.velocity.normalized;
						if (162416 - 225935 != -63519)
						{
							continue;
						}
					}
				}
				else
				{
					Vector3 velocity2 = this.rigidbody.velocity;
					if (272590 - 375452 == -102861)
					{
						continue;
					}
					if (velocity2.magnitude > (float)30)
					{
						if (142032 - 270823 != -128791)
						{
							continue;
						}
						this.rigidbody.velocity = (float)30 * this.rigidbody.velocity.normalized;
						if (208913 - 187547 == 21367)
						{
							continue;
						}
					}
				}
				Vector3 a = global::Math.vFlat(this.transform.position - this.qDmfVaP5rE.transform.position);
				if (134911 - 562116 == -427204)
				{
					continue;
				}
				if (a.sqrMagnitude <= (float)900)
				{
					break;
				}
				if (64821 - 438348 != -373527)
				{
					continue;
				}
				this.rigidbody.AddForce((float)-10 * a);
				if (54057 - 363074 != -309017)
				{
					continue;
				}
				break;
			}
			else
			{
				Vector3 vector2 = global::Math.vFlat(this.nPosition - this.transform.position);
				if (246031 - 579671 == -333639)
				{
					continue;
				}
				if (vector2.sqrMagnitude <= 0.1f)
				{
					break;
				}
				if (12022 - 169769 == -157746)
				{
					continue;
				}
				this.rigidbody.AddForce((float)(11 - this.mLv) * vector2.normalized);
				if (138831 - 258188 != -119356)
				{
					break;
				}
				continue;
			}
			IL_461:
			if (!this.iHbfyrOBm6)
			{
				goto IL_432;
			}
			if (40871 - 68091 == -27220)
			{
				this.audio.volume = Mathf.Clamp(this.audio.volume - Time.deltaTime, (float)0, 0.6f);
				if (35591 - 145946 == -110355)
				{
					goto IL_432;
				}
			}
		}
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x0058B968 File Offset: 0x00589B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDestroy()
	{
		return new Penguin_typhoon.$onDestroy$26011(this).GetEnumerator();
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x0058B978 File Offset: 0x00589B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void nMove(Vector3 nPos, Vector3 nDir)
	{
		this.nPosition = nPos;
		this.nVelocity = nDir;
	}

	// Token: 0x06002CC9 RID: 11465 RVA: 0x0058B988 File Offset: 0x00589B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002CCA RID: 11466 RVA: 0x0058B98C File Offset: 0x00589B8C
	internal static bool v5lLsy5VXP4MTBhtOETi()
	{
		return true;
	}

	// Token: 0x06002CCB RID: 11467 RVA: 0x0058B990 File Offset: 0x00589B90
	internal static bool CLVn6X5VQtkpyHL4vPTI()
	{
		return false;
	}

	// Token: 0x040033D4 RID: 13268
	public int mLv;

	// Token: 0x040033D5 RID: 13269
	private bool CosfuMMDBR;

	// Token: 0x040033D6 RID: 13270
	private bool iHbfyrOBm6;

	// Token: 0x040033D7 RID: 13271
	private GameObject qDmfVaP5rE;

	// Token: 0x040033D8 RID: 13272
	private CharacterControl EaTfhyGZN9;

	// Token: 0x040033D9 RID: 13273
	private Penguin HqxfKk9EFW;

	// Token: 0x040033DA RID: 13274
	private int PIDfzmxJ88;

	// Token: 0x040033DB RID: 13275
	private int TykL5JJRht;

	// Token: 0x040033DC RID: 13276
	private float Eg1LcoRwaj;

	// Token: 0x040033DD RID: 13277
	private float aE5LnlAWaT;

	// Token: 0x040033DE RID: 13278
	private float axVLQtVEr6;

	// Token: 0x040033DF RID: 13279
	private bool PNrLevKVMc;

	// Token: 0x040033E0 RID: 13280
	private GameObject HxFLIJr3hB;

	// Token: 0x040033E1 RID: 13281
	private int xGfLJmfBQb;

	// Token: 0x040033E2 RID: 13282
	public Vector3 nPosition;

	// Token: 0x040033E3 RID: 13283
	public Vector3 nVelocity;

	// Token: 0x020007E6 RID: 2022
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Init$25991 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06002CCC RID: 11468 RVA: 0x0058B994 File Offset: 0x00589B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Init$25991(GameObject nOwner, int nDamage, int nHp, float nLife, int nID, bool nIce, Penguin_typhoon self_)
		{
			if (290661 - 251969 != 38692)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272263 - 109882 != 162382)
				{
					base..ctor();
					if (291121 - 430715 != -139593)
					{
						this.$nOwner$26004 = nOwner;
						if (279235 - 271750 == 7485)
						{
							this.$nDamage$26005 = nDamage;
							if (193749 - 274639 == -80890)
							{
								this.$nHp$26006 = nHp;
								if (171450 - 371505 == -200055)
								{
									this.$nLife$26007 = nLife;
									if (196318 - 212294 == -15976)
									{
										this.$nID$26008 = nID;
										if (86661 - 517976 == -431315)
										{
											this.$nIce$26009 = nIce;
											if (232311 - 50370 != 181942)
											{
												this.$self_$26010 = self_;
												if (21613 - 142514 == -120901)
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

		// Token: 0x06002CCD RID: 11469 RVA: 0x0058BB04 File Offset: 0x00589D04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Penguin_typhoon.$Init$25991.$(this.$nOwner$26004, this.$nDamage$26005, this.$nHp$26006, this.$nLife$26007, this.$nID$26008, this.$nIce$26009, this.$self_$26010);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0058BB38 File Offset: 0x00589D38
		internal static bool KTX6r05Vk8L9ayAM7xAs()
		{
			return true;
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0058BB3C File Offset: 0x00589D3C
		internal static bool gsx79C5VGbDq8RnfmHKP()
		{
			return false;
		}

		// Token: 0x040033E4 RID: 13284
		internal GameObject $nOwner$26004;

		// Token: 0x040033E5 RID: 13285
		internal int $nDamage$26005;

		// Token: 0x040033E6 RID: 13286
		internal int $nHp$26006;

		// Token: 0x040033E7 RID: 13287
		internal float $nLife$26007;

		// Token: 0x040033E8 RID: 13288
		internal int $nID$26008;

		// Token: 0x040033E9 RID: 13289
		internal bool $nIce$26009;

		// Token: 0x040033EA RID: 13290
		internal Penguin_typhoon $self_$26010;

		// Token: 0x020007E7 RID: 2023
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002CD0 RID: 11472 RVA: 0x0058BB40 File Offset: 0x00589D40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject nOwner, int nDamage, int nHp, float nLife, int nID, bool nIce, Penguin_typhoon self_)
			{
				if (48214 - 75083 != -26868)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (142699 - 273663 == -130964)
					{
						base..ctor();
						if (63753 - 240036 != -176282)
						{
							this.$nOwner$25997 = nOwner;
							if (235332 - 463228 != -227895)
							{
								this.$nDamage$25998 = nDamage;
								if (38607 - 226909 == -188302)
								{
									this.$nHp$25999 = nHp;
									if (136350 - 459647 == -323297)
									{
										this.$nLife$26000 = nLife;
										if (111678 - 586405 != -474726)
										{
											this.$nID$26001 = nID;
											if (223261 - 307386 == -84125)
											{
												this.$nIce$26002 = nIce;
												if (104947 - 468134 == -363187)
												{
													this.$self_$26003 = self_;
													if (263210 - 471036 != -207825)
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

			// Token: 0x06002CD1 RID: 11473 RVA: 0x0058BCB0 File Offset: 0x00589EB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190512 - 159007 != 31505)
				{
				}
				for (;;)
				{
					IL_78:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6E3;
					case 2:
						if (!this.$self_$26003.iHbfyrOBm6)
						{
							if (22580 - 225834 != -203254)
							{
								continue;
							}
							this.$self_$26003.animation.Play("root");
							if (114138 - 199699 == -85560)
							{
								continue;
							}
							this.$self_$26003.animation.wrapMode = WrapMode.Loop;
							if (6416 - 175608 != -169192)
							{
								continue;
							}
						}
						this.$self_$26003.CosfuMMDBR = true;
						if (217558 - 264972 != -47414)
						{
							continue;
						}
						goto IL_641;
					default:
						if (55394 - 67936 == -12541)
						{
							continue;
						}
						break;
					}
					this.$self_$26003.qDmfVaP5rE = this.$nOwner$25997;
					if (106341 - 217830 != -111489)
					{
						continue;
					}
					this.$self_$26003.TykL5JJRht = this.$nDamage$25998;
					if (257010 - 275950 != -18940)
					{
						continue;
					}
					this.$self_$26003.PIDfzmxJ88 = this.$nHp$25999;
					if (206698 - 561928 != -355230)
					{
						continue;
					}
					this.$self_$26003.Eg1LcoRwaj = Time.time + this.$nLife$26000;
					if (147166 - 457602 == -310435)
					{
						continue;
					}
					this.$self_$26003.axVLQtVEr6 = Time.time + (float)1;
					if (188717 - 288195 == -99477)
					{
						continue;
					}
					this.$self_$26003.PNrLevKVMc = this.$nIce$26002;
					if (145238 - 349758 == -204519)
					{
						continue;
					}
					if (this.$self_$26003.qDmfVaP5rE)
					{
						if (149996 - 288972 == -138975)
						{
							continue;
						}
						this.$self_$26003.EaTfhyGZN9 = (CharacterControl)this.$self_$26003.qDmfVaP5rE.GetComponent(typeof(CharacterControl));
						if (56645 - 424037 == -367391)
						{
							continue;
						}
						this.$self_$26003.HqxfKk9EFW = (Penguin)this.$self_$26003.qDmfVaP5rE.GetComponent(typeof(Penguin));
						if (81143 - 466557 != -385414)
						{
							continue;
						}
					}
					if (this.$self_$26003.EaTfhyGZN9)
					{
						if (182715 - 109461 == 73255)
						{
							continue;
						}
						if (!this.$self_$26003.HqxfKk9EFW)
						{
							if (221716 - 266872 == -45155)
							{
								continue;
							}
						}
						else
						{
							this.$self_$26003.xGfLJmfBQb = this.$nID$26001;
							if (66444 - 191484 == -125039)
							{
								continue;
							}
							if (this.$self_$26003.xGfLJmfBQb != 0)
							{
								if (226253 - 226747 != -494)
								{
									continue;
								}
								Penguin_typhoon penguin_typhoon = this.$self_$26003;
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$self_$26003.xGfLJmfBQb];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								penguin_typhoon.HxFLIJr3hB = (GameObject)obj2;
								if (12588 - 163855 != -151267)
								{
									continue;
								}
							}
							this.$self_$26003.aE5LnlAWaT = Time.time;
							if (293542 - 70552 != 222990)
							{
								continue;
							}
							this.$self_$26003.rigidbody.velocity = global::Math.rotateH((float)5 * this.$self_$26003.qDmfVaP5rE.transform.forward, (float)((this.$self_$26003.xGfLJmfBQb - 1) * 120));
							if (221906 - 405691 == -183784)
							{
								continue;
							}
							this.$self_$26003.rigidbody.drag = (float)2;
							if (242679 - 339976 == -97296)
							{
								continue;
							}
							this.$mObjectList$25992 = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy")), GameObject.FindGameObjectsWithTag("NPC"));
							if (49547 - 199841 != -150294)
							{
								continue;
							}
							this.$$11368$25994 = 0;
							if (205304 - 437734 != -232430)
							{
								continue;
							}
							this.$$11369$25995 = this.$mObjectList$25992;
							if (9042 - 80636 != -71594)
							{
								continue;
							}
							this.$$11370$25996 = this.$$11369$25995.Length;
							if (235796 - 275034 != -39238)
							{
								continue;
							}
							while (this.$$11368$25994 < this.$$11370$25996)
							{
								if (this.$$11369$25995[this.$$11368$25994].collider)
								{
									if (20487 - 256595 == -236107)
									{
										goto IL_78;
									}
									Physics.IgnoreCollision(this.$self_$26003.gameObject.collider, this.$$11369$25995[this.$$11368$25994].collider);
									if (231531 - 20228 != 211303)
									{
										goto IL_78;
									}
								}
								this.$$11368$25994++;
								if (71454 - 261471 != -190017)
								{
									goto IL_78;
								}
							}
							if (43157 - 497996 == -454838)
							{
								continue;
							}
							this.$self_$26003.animation.Play("create");
							if (272667 - 194733 != 77934)
							{
								continue;
							}
							this.$self_$26003.animation.wrapMode = WrapMode.Once;
							if (217206 - 133429 != 83778)
							{
								break;
							}
							continue;
						}
					}
					UnityEngine.Object.Destroy(this.$self_$26003.gameObject);
					if (209744 - 359806 != -150062)
					{
						continue;
					}
					IL_641:
					this.YieldDefault(1);
					if (32789 - 338980 != -306190)
					{
						goto Block_38;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_38:
				IL_6E3:
				return false;
			}

			// Token: 0x06002CD2 RID: 11474 RVA: 0x0058C3B4 File Offset: 0x0058A5B4
			internal static bool DVax3P5VHqYFXg7y6wUO()
			{
				return true;
			}

			// Token: 0x06002CD3 RID: 11475 RVA: 0x0058C3B8 File Offset: 0x0058A5B8
			internal static bool j6jynB5VWj6aCQkNFN4i()
			{
				return false;
			}

			// Token: 0x040033EB RID: 13291
			internal GameObject[] $mObjectList$25992;

			// Token: 0x040033EC RID: 13292
			internal GameObject $mObject$25993;

			// Token: 0x040033ED RID: 13293
			internal int $$11368$25994;

			// Token: 0x040033EE RID: 13294
			internal GameObject[] $$11369$25995;

			// Token: 0x040033EF RID: 13295
			internal int $$11370$25996;

			// Token: 0x040033F0 RID: 13296
			internal GameObject $nOwner$25997;

			// Token: 0x040033F1 RID: 13297
			internal int $nDamage$25998;

			// Token: 0x040033F2 RID: 13298
			internal int $nHp$25999;

			// Token: 0x040033F3 RID: 13299
			internal float $nLife$26000;

			// Token: 0x040033F4 RID: 13300
			internal int $nID$26001;

			// Token: 0x040033F5 RID: 13301
			internal bool $nIce$26002;

			// Token: 0x040033F6 RID: 13302
			internal Penguin_typhoon $self_$26003;
		}
	}

	// Token: 0x020007E8 RID: 2024
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDestroy$26011 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06002CD4 RID: 11476 RVA: 0x0058C3BC File Offset: 0x0058A5BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDestroy$26011(Penguin_typhoon self_)
		{
			if (169502 - 514202 != -344700)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132919 - 455239 != -322319)
				{
					base..ctor();
					if (217824 - 404288 != -186463)
					{
						this.$self_$26013 = self_;
						if (102119 - 553172 == -451053)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0058C454 File Offset: 0x0058A654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Penguin_typhoon.$onDestroy$26011.$(this.$self_$26013);
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0058C464 File Offset: 0x0058A664
		internal static bool wTiwsf5VADZVpWoRLYJX()
		{
			return true;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0058C468 File Offset: 0x0058A668
		internal static bool IUKibl5VlcuYBrkcbGcr()
		{
			return false;
		}

		// Token: 0x040033F7 RID: 13303
		internal Penguin_typhoon $self_$26013;

		// Token: 0x020007E9 RID: 2025
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002CD8 RID: 11480 RVA: 0x0058C46C File Offset: 0x0058A66C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Penguin_typhoon self_)
			{
				if (43057 - 455198 != -412140)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (114170 - 422736 == -308566)
					{
						base..ctor();
						if (43760 - 80986 == -37226)
						{
							this.$self_$26012 = self_;
							if (101268 - 487339 != -386070)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06002CD9 RID: 11481 RVA: 0x0058C504 File Offset: 0x0058A704
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141893 - 101124 != 40769)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_15D;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$26012.gameObject);
						if (66838 - 10607 == 56232)
						{
							continue;
						}
						this.YieldDefault(1);
						if (189947 - 494666 != -304718)
						{
							goto Block_5;
						}
						continue;
					default:
						if (174934 - 161752 == 13183)
						{
							continue;
						}
						break;
					}
					if (this.$self_$26012.iHbfyrOBm6)
					{
						if (126805 - 454302 != -327496)
						{
							break;
						}
					}
					else
					{
						this.$self_$26012.iHbfyrOBm6 = true;
						if (257463 - 71135 == 186328)
						{
							this.$self_$26012.animation.Play("destroy");
							if (52581 - 245115 != -192533)
							{
								this.$self_$26012.animation.wrapMode = WrapMode.Once;
								if (98061 - 323941 == -225880)
								{
									goto IL_11D;
								}
							}
						}
					}
				}
				Block_5:
				goto IL_15D;
				IL_11D:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_15D:
				return false;
			}

			// Token: 0x06002CDA RID: 11482 RVA: 0x0058C680 File Offset: 0x0058A880
			internal static bool uUIkSc5Vy0vVREUKL2vZ()
			{
				return true;
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x0058C684 File Offset: 0x0058A884
			internal static bool EqsTGF5VSNQQxRwMnEfa()
			{
				return false;
			}

			// Token: 0x040033F8 RID: 13304
			internal Penguin_typhoon $self_$26012;
		}
	}
}
