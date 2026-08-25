using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000658 RID: 1624
[Serializable]
public class Mole_timeNuke : MonoBehaviour
{
	// Token: 0x06002495 RID: 9365 RVA: 0x0044BC84 File Offset: 0x00449E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_timeNuke()
	{
		if (53364 - 175580 != -122215)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (24677 - 275186 == -250509)
			{
				base..ctor();
				if (282797 - 343687 != -60889)
				{
					this.isVisible = true;
					if (237215 - 400348 == -163133)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x0044BD1C File Offset: 0x00449F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		if (219538 - 462723 != -243185)
		{
		}
		for (;;)
		{
			IL_F7:
			this.LogdrBttBs = nOwner;
			if (122429 - 234396 == -111967)
			{
				this.GPWdx6OEmF = (CharacterControl)this.LogdrBttBs.GetComponent(typeof(CharacterControl));
				if (226662 - 227056 == -394)
				{
					this.DOBdTpEK5v = Time.time;
					if (5507 - 369669 != -364161)
					{
						this.vw1dY3Ap6M = 1;
						if (100062 - 473069 == -373007)
						{
							this.RB0d3a0rRO = new GUIStyle();
							if (134787 - 148551 == -13764)
							{
								this.RB0d3a0rRO.font = (Font)Resources.Load("GameGui/Fonts/GMO24");
								if (182896 - 471697 != -288800)
								{
									this.RB0d3a0rRO.normal.textColor = new Color(0.8f, 0.3f, 0.3f, (float)1);
									if (263767 - 562004 == -298237)
									{
										this.RB0d3a0rRO.alignment = TextAnchor.MiddleCenter;
										if (161028 - 486514 != -325485)
										{
											if (!Game.mPlayer)
											{
												break;
											}
											if (48116 - 550015 != -501898)
											{
												if (nOwner.layer == Game.mPlayer.layer)
												{
													break;
												}
												if (153138 - 491837 == -338699)
												{
													this.isVisible = false;
													if (189005 - 185603 != 3403)
													{
														this.renderer.enabled = false;
														if (217387 - 224709 != -7321)
														{
															Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
															if (38709 - 341261 == -302552)
															{
																int i = 0;
																if (256322 - 435242 == -178920)
																{
																	Component[] array = componentsInChildren;
																	if (94520 - 221709 == -127189)
																	{
																		int length = array.Length;
																		if (46875 - 137461 != -90585)
																		{
																			while (i < length)
																			{
																				((Renderer)array[i]).enabled = false;
																				if (267218 - 479755 != -212537)
																				{
																					goto IL_F7;
																				}
																				i++;
																				if (207136 - 228451 != -21315)
																				{
																					goto IL_F7;
																				}
																			}
																			if (124637 - 505362 != -380724)
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
		}
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x0044C04C File Offset: 0x0044A24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (29117 - 448426 != -419308)
		{
		}
		while (this.vw1dY3Ap6M == 1)
		{
			if (202842 - 264610 == -61768)
			{
				if (!this.isVisible)
				{
					break;
				}
				if (205273 - 448555 != -243281)
				{
					Vector3 vector = Camera.main.WorldToScreenPoint(this.transform.position + (0.2f * (float)this.mLv + 0.6f) * Vector3.up);
					if (279758 - 50601 == 229157)
					{
						if ((float)0 >= vector.z)
						{
							break;
						}
						if (281743 - 484251 == -202508)
						{
							if (vector.z >= (float)30)
							{
								break;
							}
							if (262041 - 271048 != -9006)
							{
								GUI.depth = 3;
								if (290123 - 579218 != -289094)
								{
									GUI.Label(new Rect(vector.x - (float)15, (float)Screen.height - vector.y - (float)15, (float)30, (float)30), string.Empty + Mathf.FloorToInt(this.DOBdTpEK5v + (float)60 - Time.time), this.RB0d3a0rRO);
									if (166944 - 553079 == -386135)
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

	// Token: 0x06002498 RID: 9368 RVA: 0x0044C204 File Offset: 0x0044A404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (133462 - 518767 != -385304)
		{
		}
		for (;;)
		{
			if (this.vw1dY3Ap6M == 0)
			{
				if (244952 - 440173 == -195221)
				{
					break;
				}
			}
			else
			{
				if (this.LogdrBttBs)
				{
					if (105816 - 441878 != -336062)
					{
						continue;
					}
					if (!this.GPWdx6OEmF)
					{
						if (249911 - 492133 == -242221)
						{
							continue;
						}
					}
					else if (this.GPWdx6OEmF.hp <= 0)
					{
						if (196010 - 28887 != 167123)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (59212 - 328264 != -269052)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.vw1dY3Ap6M <= 1)
						{
							if (239776 - 468615 == -228838)
							{
								continue;
							}
							if (this.DOBdTpEK5v + (float)60 <= Time.time + (float)1)
							{
								if (110882 - 178401 == -67518)
								{
									continue;
								}
								this.vw1dY3Ap6M = 2;
								if (264821 - 176528 != 88294)
								{
									break;
								}
								continue;
							}
						}
						if (this.vw1dY3Ap6M > 2)
						{
							break;
						}
						if (225033 - 582941 != -357908)
						{
							continue;
						}
						if (this.DOBdTpEK5v + (float)60 > Time.time)
						{
							break;
						}
						if (257822 - 90031 == 167792)
						{
							continue;
						}
						this.vw1dY3Ap6M = 3;
						if (53843 - 527266 == -473422)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.doExplode());
						if (65167 - 326704 != -261537)
						{
							continue;
						}
						break;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (141185 - 383853 != -242667)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x0044C454 File Offset: 0x0044A654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator detonate()
	{
		return new Mole_timeNuke.$detonate$23407(this).GetEnumerator();
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x0044C464 File Offset: 0x0044A664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator doExplode()
	{
		return new Mole_timeNuke.$doExplode$23415(this).GetEnumerator();
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x0044C474 File Offset: 0x0044A674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x0044C478 File Offset: 0x0044A678
	internal static bool zUVNVYB2ElCqduKHYWU()
	{
		return true;
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x0044C47C File Offset: 0x0044A67C
	internal static bool HrdUoQB81GRE8NoNFge()
	{
		return false;
	}

	// Token: 0x04002788 RID: 10120
	private GameObject LogdrBttBs;

	// Token: 0x04002789 RID: 10121
	private CharacterControl GPWdx6OEmF;

	// Token: 0x0400278A RID: 10122
	private float DOBdTpEK5v;

	// Token: 0x0400278B RID: 10123
	private int vw1dY3Ap6M;

	// Token: 0x0400278C RID: 10124
	private GUIStyle RB0d3a0rRO;

	// Token: 0x0400278D RID: 10125
	public int mLv;

	// Token: 0x0400278E RID: 10126
	public bool isVisible;

	// Token: 0x0400278F RID: 10127
	private int ScddbTPrjN;

	// Token: 0x04002790 RID: 10128
	public GameObject timeNuke_explosion;

	// Token: 0x02000659 RID: 1625
	[CompilerGenerated]
	[Serializable]
	internal sealed class $detonate$23407 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600249E RID: 9374 RVA: 0x0044C480 File Offset: 0x0044A680
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $detonate$23407(Mole_timeNuke self_)
		{
			if (290686 - 50611 != 240075)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42118 - 415597 != -373478)
				{
					base..ctor();
					if (28428 - 444931 != -416502)
					{
						this.$self_$23414 = self_;
						if (121091 - 253295 == -132204)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0044C518 File Offset: 0x0044A718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mole_timeNuke.$detonate$23407.$(this.$self_$23414);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0044C528 File Offset: 0x0044A728
		internal static bool PCvtCHBZlU81BW91RS6()
		{
			return true;
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0044C52C File Offset: 0x0044A72C
		internal static bool sEfEKyBC9dbQnMiA3Ae()
		{
			return false;
		}

		// Token: 0x04002791 RID: 10129
		internal Mole_timeNuke $self_$23414;

		// Token: 0x0200065A RID: 1626
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060024A2 RID: 9378 RVA: 0x0044C530 File Offset: 0x0044A730
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Mole_timeNuke self_)
			{
				if (109430 - 222477 != -113046)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29278 - 171788 != -142509)
					{
						base..ctor();
						if (272802 - 42030 != 230773)
						{
							this.$self_$23413 = self_;
							if (202277 - 38967 != 163311)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060024A3 RID: 9379 RVA: 0x0044C5C8 File Offset: 0x0044A7C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66513 - 221349 != -154835)
				{
				}
				for (;;)
				{
					IL_88:
					switch (this._state)
					{
					case 0:
						goto IL_24B;
					case 1:
						goto IL_276;
					case 2:
						this.$self_$23413.StartCoroutine_Auto(this.$self_$23413.doExplode());
						if (85573 - 328415 == -242841)
						{
							continue;
						}
						break;
					default:
						if (63735 - 72267 != -8531)
						{
							goto IL_24B;
						}
						continue;
					}
					IL_40:
					this.YieldDefault(1);
					if (284118 - 349589 != -65470)
					{
						break;
					}
					continue;
					IL_24B:
					if (this.$self_$23413.vw1dY3Ap6M != 1)
					{
						goto IL_40;
					}
					if (29822 - 123171 == -93349)
					{
						this.$self_$23413.ScddbTPrjN = Mathf.FloorToInt(Time.time - this.$self_$23413.DOBdTpEK5v);
						if (251797 - 210611 == 41186)
						{
							this.$self_$23413.vw1dY3Ap6M = 3;
							if (258596 - 590310 != -331713)
							{
								this.$mRendererList$23408 = this.$self_$23413.gameObject.GetComponentsInChildren(typeof(Renderer));
								if (99348 - 496435 != -397086)
								{
									this.$$11320$23410 = 0;
									if (25942 - 272727 == -246785)
									{
										this.$$11321$23411 = this.$mRendererList$23408;
										if (107112 - 202172 != -95059)
										{
											this.$$11322$23412 = this.$$11321$23411.Length;
											if (199185 - 474833 == -275648)
											{
												while (this.$$11320$23410 < this.$$11322$23412)
												{
													((Renderer)this.$$11321$23411[this.$$11320$23410]).enabled = true;
													if (57977 - 222324 != -164347)
													{
														goto IL_88;
													}
													this.$$11320$23410++;
													if (244663 - 102578 == 142086)
													{
														goto IL_88;
													}
												}
												if (167913 - 233072 == -65159)
												{
													goto IL_19E;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_276;
				IL_19E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_276:
				return false;
			}

			// Token: 0x060024A4 RID: 9380 RVA: 0x0044C860 File Offset: 0x0044AA60
			internal static bool w5Kj1aBLw2mgojyZiDx()
			{
				return true;
			}

			// Token: 0x060024A5 RID: 9381 RVA: 0x0044C864 File Offset: 0x0044AA64
			internal static bool nVcS8yBO9EP6xt0fBG1()
			{
				return false;
			}

			// Token: 0x04002792 RID: 10130
			internal Component[] $mRendererList$23408;

			// Token: 0x04002793 RID: 10131
			internal Renderer $mRendererer$23409;

			// Token: 0x04002794 RID: 10132
			internal int $$11320$23410;

			// Token: 0x04002795 RID: 10133
			internal Component[] $$11321$23411;

			// Token: 0x04002796 RID: 10134
			internal int $$11322$23412;

			// Token: 0x04002797 RID: 10135
			internal Mole_timeNuke $self_$23413;
		}
	}

	// Token: 0x0200065B RID: 1627
	[CompilerGenerated]
	[Serializable]
	internal sealed class $doExplode$23415 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060024A6 RID: 9382 RVA: 0x0044C868 File Offset: 0x0044AA68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $doExplode$23415(Mole_timeNuke self_)
		{
			if (102759 - 328716 != -225956)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151461 - 203649 != -52187)
				{
					base..ctor();
					if (106740 - 81452 == 25288)
					{
						this.$self_$23434 = self_;
						if (188161 - 203270 != -15108)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0044C900 File Offset: 0x0044AB00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mole_timeNuke.$doExplode$23415.$(this.$self_$23434);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0044C910 File Offset: 0x0044AB10
		internal static bool grG9cqBmwLpR1m2CvlQ()
		{
			return true;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0044C914 File Offset: 0x0044AB14
		internal static bool fq8AUqBFejMnpnQRdR0()
		{
			return false;
		}

		// Token: 0x04002798 RID: 10136
		internal Mole_timeNuke $self_$23434;

		// Token: 0x0200065C RID: 1628
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060024AA RID: 9386 RVA: 0x0044C918 File Offset: 0x0044AB18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Mole_timeNuke self_)
			{
				if (27558 - 464244 != -436685)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297306 - 476465 == -179159)
					{
						base..ctor();
						if (113712 - 1828 == 111884)
						{
							this.$self_$23433 = self_;
							if (80092 - 230667 == -150575)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060024AB RID: 9387 RVA: 0x0044C9B0 File Offset: 0x0044ABB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277194 - 300405 != -23211)
				{
				}
				for (;;)
				{
					IL_352:
					switch (this._state)
					{
					case 0:
						goto IL_656;
					case 1:
						goto IL_9D5;
					case 2:
						this.$i$23425++;
						if (262506 - 434988 == -172481)
						{
							continue;
						}
						break;
					default:
						if (289780 - 173623 != 116158)
						{
							goto IL_656;
						}
						continue;
					}
					IL_54A:
					if (this.$i$23425 >= 4)
					{
						if (284091 - 56386 != 227706)
						{
							goto IL_9AB;
						}
						continue;
					}
					else
					{
						this.$hitList$23424 = Damage.FindAreaTarget(this.$self_$23433.transform.position, (float)Mathf.FloorToInt(0.25f * (float)(this.$i$23425 + 1) * this.$mRange$23421), (float)5, this.$hitLayer$23423);
						if (13871 - 354982 != -341111)
						{
							continue;
						}
						this.$$iterator$9841$23429 = UnityRuntimeServices.GetEnumerator(this.$hitList$23424);
						if (64689 - 335733 != -271044)
						{
							continue;
						}
						while (this.$$iterator$9841$23429.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$9841$23429.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$23426 = (GameObject)obj2;
							if (133031 - 512317 != -379286)
							{
								goto IL_352;
							}
							this.$hitChar$23427 = (CharacterControl)this.$hitObject$23426.GetComponent(typeof(CharacterControl));
							if (208234 - 551950 != -343716)
							{
								goto IL_352;
							}
							UnityRuntimeServices.Update(this.$$iterator$9841$23429, this.$hitObject$23426);
							if (128161 - 205420 != -77259)
							{
								goto IL_352;
							}
							if (!this.$hitChar$23427.hasStatus("insight"))
							{
								if (222347 - 136621 == 85727)
								{
									goto IL_352;
								}
								this.$hitDistance$23428 = (float)1 - 0.8f * ((this.$hitObject$23426.transform.position - this.$self_$23433.transform.position).magnitude / this.$mRange$23421);
								if (199015 - 563004 == -363988)
								{
									goto IL_352;
								}
								UnityRuntimeServices.Update(this.$$iterator$9841$23429, this.$hitObject$23426);
								if (126912 - 208734 != -81822)
								{
									goto IL_352;
								}
								if (this.$mSmartShellLv$23422 > 0)
								{
									if (228912 - 479827 == -250914)
									{
										goto IL_352;
									}
									if (this.$hitObject$23426.layer == this.$self_$23433.LogdrBttBs.layer)
									{
										if (111417 - 95613 != 15804)
										{
											goto IL_352;
										}
										this.$mChar$23418.hit(270 + this.$self_$23433.mLv, this.$hitObject$23426, Mathf.FloorToInt(0.5f * (float)this.$mDamage$23420 * this.$hitDistance$23428), 3, 0, (float)2 * (this.$hitObject$23426.transform.position - this.$self_$23433.transform.position).normalized);
										if (243266 - 31844 == 211423)
										{
											goto IL_352;
										}
										UnityRuntimeServices.Update(this.$$iterator$9841$23429, this.$hitObject$23426);
										if (102983 - 100826 == 2158)
										{
											goto IL_352;
										}
									}
									else
									{
										this.$mChar$23418.hit(270 + this.$self_$23433.mLv, this.$hitObject$23426, Mathf.FloorToInt((float)this.$mDamage$23420 * this.$hitDistance$23428), 3, 0, (float)2 * (this.$hitObject$23426.transform.position - this.$self_$23433.transform.position).normalized);
										if (282882 - 408538 != -125656)
										{
											goto IL_352;
										}
										UnityRuntimeServices.Update(this.$$iterator$9841$23429, this.$hitObject$23426);
										if (46354 - 568053 != -521699)
										{
											goto IL_352;
										}
										this.$hitChar$23427.RPC_AddEffectDamage(264, 30, 0, 0, Vector3.zero, this.$self_$23433.GPWdx6OEmF.ActorNr);
										if (152419 - 503418 == -350998)
										{
											goto IL_352;
										}
									}
								}
								else
								{
									this.$mChar$23418.hit(270 + this.$self_$23433.mLv, this.$hitObject$23426, Mathf.FloorToInt((float)this.$mDamage$23420 * this.$hitDistance$23428), 3, 0, (float)2 * (this.$hitObject$23426.transform.position - this.$self_$23433.transform.position).normalized);
									if (252323 - 490318 != -237995)
									{
										goto IL_352;
									}
									UnityRuntimeServices.Update(this.$$iterator$9841$23429, this.$hitObject$23426);
									if (95558 - 1102 == 94457)
									{
										goto IL_352;
									}
								}
							}
						}
						if (175165 - 342890 != -167724)
						{
							break;
						}
						continue;
					}
					IL_656:
					UnityEngine.Object.Instantiate(this.$self_$23433.timeNuke_explosion, this.$self_$23433.transform.position, this.$self_$23433.transform.rotation);
					if (235672 - 9145 != 226527)
					{
						continue;
					}
					this.$self_$23433.renderer.enabled = false;
					if (144811 - 245585 != -100774)
					{
						continue;
					}
					this.$mRendererList$23416 = this.$self_$23433.gameObject.GetComponentsInChildren(typeof(Renderer));
					if (223386 - 187508 == 35879)
					{
						continue;
					}
					this.$$11324$23430 = 0;
					if (15446 - 183233 == -167786)
					{
						continue;
					}
					this.$$11325$23431 = this.$mRendererList$23416;
					if (17372 - 265470 == -248097)
					{
						continue;
					}
					this.$$11326$23432 = this.$$11325$23431.Length;
					if (156109 - 42404 == 113706)
					{
						continue;
					}
					while (this.$$11324$23430 < this.$$11326$23432)
					{
						((Renderer)this.$$11325$23431[this.$$11324$23430]).enabled = false;
						if (167316 - 448612 == -281295)
						{
							goto IL_352;
						}
						this.$$11324$23430++;
						if (18961 - 395629 == -376667)
						{
							goto IL_352;
						}
					}
					if (129051 - 36097 == 92955)
					{
						continue;
					}
					this.$mChar$23418 = (CharacterControl)this.$self_$23433.LogdrBttBs.GetComponent(typeof(CharacterControl));
					if (75327 - 496032 != -420705)
					{
						continue;
					}
					if (this.$mChar$23418.isMine)
					{
						if (74359 - 159885 != -85526)
						{
							continue;
						}
						this.$mMoleScript$23419 = (Mole)this.$self_$23433.LogdrBttBs.GetComponent(typeof(Mole));
						if (36674 - 301102 != -264428)
						{
							continue;
						}
						if (this.$mMoleScript$23419)
						{
							if (138250 - 127330 == 10921)
							{
								continue;
							}
							this.$mDamage$23420 = this.$mChar$23418.talAdjust(this.$self_$23433.mLv * 100 + 50);
							if (98630 - 549130 == -450499)
							{
								continue;
							}
							if (this.$self_$23433.ScddbTPrjN != 0)
							{
								if (75709 - 161888 == -86178)
								{
									continue;
								}
								this.$mDamage$23420 = Mathf.FloorToInt((float)this.$mDamage$23420 * Mathf.Clamp((float)this.$self_$23433.ScddbTPrjN * 0.0166f, 0.1f, 0.99f));
								if (188532 - 134670 != 53862)
								{
									continue;
								}
							}
							this.$mRange$23421 = 20f + (float)this.$mMoleScript$23419.getExtraPowderLv();
							if (103425 - 569068 != -465643)
							{
								continue;
							}
							this.$mSmartShellLv$23422 = this.$mMoleScript$23419.getSmartShellLv();
							if (217869 - 553397 == -335527)
							{
								continue;
							}
							this.$hitLayer$23423 = 130818;
							if (236982 - 77889 == 159094)
							{
								continue;
							}
							this.$hitList$23424 = null;
							if (397 - 17282 == -16884)
							{
								continue;
							}
							this.$i$23425 = 0;
							if (294052 - 179362 != 114690)
							{
								continue;
							}
							goto IL_54A;
						}
					}
					IL_9AB:
					UnityEngine.Object.Destroy(this.$self_$23433.gameObject);
					if (94161 - 466299 != -372137)
					{
						this.YieldDefault(1);
						if (27164 - 321400 == -294236)
						{
							goto IL_9D5;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_9D5:
				return false;
			}

			// Token: 0x060024AC RID: 9388 RVA: 0x0044D3A4 File Offset: 0x0044B5A4
			internal static bool fGoTFVBM1cqxpS5kL59()
			{
				return true;
			}

			// Token: 0x060024AD RID: 9389 RVA: 0x0044D3A8 File Offset: 0x0044B5A8
			internal static bool UiXdtuBxMn9X61A9CZg()
			{
				return false;
			}

			// Token: 0x04002799 RID: 10137
			internal Component[] $mRendererList$23416;

			// Token: 0x0400279A RID: 10138
			internal Renderer $mRendererer$23417;

			// Token: 0x0400279B RID: 10139
			internal CharacterControl $mChar$23418;

			// Token: 0x0400279C RID: 10140
			internal Mole $mMoleScript$23419;

			// Token: 0x0400279D RID: 10141
			internal int $mDamage$23420;

			// Token: 0x0400279E RID: 10142
			internal float $mRange$23421;

			// Token: 0x0400279F RID: 10143
			internal int $mSmartShellLv$23422;

			// Token: 0x040027A0 RID: 10144
			internal int $hitLayer$23423;

			// Token: 0x040027A1 RID: 10145
			internal UnityScript.Lang.Array $hitList$23424;

			// Token: 0x040027A2 RID: 10146
			internal int $i$23425;

			// Token: 0x040027A3 RID: 10147
			internal GameObject $hitObject$23426;

			// Token: 0x040027A4 RID: 10148
			internal CharacterControl $hitChar$23427;

			// Token: 0x040027A5 RID: 10149
			internal float $hitDistance$23428;

			// Token: 0x040027A6 RID: 10150
			internal IEnumerator $$iterator$9841$23429;

			// Token: 0x040027A7 RID: 10151
			internal int $$11324$23430;

			// Token: 0x040027A8 RID: 10152
			internal Component[] $$11325$23431;

			// Token: 0x040027A9 RID: 10153
			internal int $$11326$23432;

			// Token: 0x040027AA RID: 10154
			internal Mole_timeNuke $self_$23433;
		}
	}
}
