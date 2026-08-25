using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020004F2 RID: 1266
[Serializable]
public class Bat_guardianOfTheNight : MonoBehaviour
{
	// Token: 0x06001D0C RID: 7436 RVA: 0x00317E58 File Offset: 0x00316058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat_guardianOfTheNight()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x00317E68 File Offset: 0x00316068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Init(GameObject nOwner, int nLv)
	{
		return new Bat_guardianOfTheNight.$Init$20736(nOwner, nLv, this).GetEnumerator();
	}

	// Token: 0x06001D0E RID: 7438 RVA: 0x00317E78 File Offset: 0x00316078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (107908 - 148267 != -40358)
		{
		}
		while (this.Ln6GBoGI1g)
		{
			if (284357 - 16923 == 267434)
			{
				if (this.ClTG8kN2W9)
				{
					if (this.Pb1Gm2pPyV != eGuardianOfTheNightState.standby)
					{
						if (265571 - 38091 == 227481)
						{
							continue;
						}
					}
					else
					{
						Vector3 a = this.transform.position - this.lofG0IVuWm.position;
						if (116079 - 283822 != -167743)
						{
							continue;
						}
						if (a.sqrMagnitude > (float)9)
						{
							if (237569 - 465632 == -228062)
							{
								continue;
							}
							this.animation.CrossFade("walk", 0.1f);
							if (88131 - 184691 == -96559)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (6913 - 552212 != -545299)
							{
								continue;
							}
							this.transform.position = Vector3.Lerp(this.transform.position, this.lofG0IVuWm.position + (float)2 * a.normalized, Time.deltaTime);
							if (162973 - 444780 != -281807)
							{
								continue;
							}
							this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(-a), (float)2 * Time.deltaTime);
							if (200129 - 414038 != -213909)
							{
								continue;
							}
						}
						else
						{
							this.animation.CrossFade("root", 0.2f);
							if (54789 - 418158 == -363368)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (236179 - 527906 == -291726)
							{
								continue;
							}
						}
					}
					return;
				}
				if (24156 - 491151 != -466994)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x003180E4 File Offset: 0x003162E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator attack(Vector3 mPos, Vector3 tDir)
	{
		return new Bat_guardianOfTheNight.$attack$20750(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x003180F4 File Offset: 0x003162F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator castSpell(GameObject tObject)
	{
		return new Bat_guardianOfTheNight.$castSpell$20783(tObject, this).GetEnumerator();
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x00318104 File Offset: 0x00316304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new Bat_guardianOfTheNight.$unsummon$20795(this).GetEnumerator();
	}

	// Token: 0x06001D12 RID: 7442 RVA: 0x00318114 File Offset: 0x00316314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x00318118 File Offset: 0x00316318
	internal static bool Wygdv8JIUpOEihB9QG8()
	{
		return true;
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x0031811C File Offset: 0x0031631C
	internal static bool xSpWeoJBXkX9jblTi8B()
	{
		return false;
	}

	// Token: 0x04001AEB RID: 6891
	private GameObject Ln6GBoGI1g;

	// Token: 0x04001AEC RID: 6892
	private Transform lofG0IVuWm;

	// Token: 0x04001AED RID: 6893
	private CharacterControl ClTG8kN2W9;

	// Token: 0x04001AEE RID: 6894
	private Bat kIxGiXguI4;

	// Token: 0x04001AEF RID: 6895
	private int G2OGDwqKtM;

	// Token: 0x04001AF0 RID: 6896
	private eGuardianOfTheNightState Pb1Gm2pPyV;

	// Token: 0x04001AF1 RID: 6897
	private float a4pGjxUjoI;

	// Token: 0x04001AF2 RID: 6898
	public GameObject guardianBlade;

	// Token: 0x04001AF3 RID: 6899
	private AudioClip BTSGosCMmd;

	// Token: 0x04001AF4 RID: 6900
	public GameObject castEffect;

	// Token: 0x020004F3 RID: 1267
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Init$20736 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x00318120 File Offset: 0x00316320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Init$20736(GameObject nOwner, int nLv, Bat_guardianOfTheNight self_)
		{
			if (99169 - 510470 != -411301)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (264003 - 177442 != 86562)
				{
					base..ctor();
					if (236100 - 249446 == -13346)
					{
						this.$nOwner$20747 = nOwner;
						if (76049 - 154391 == -78342)
						{
							this.$nLv$20748 = nLv;
							if (133625 - 56609 != 77017)
							{
								this.$self_$20749 = self_;
								if (134570 - 127607 == 6963)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x003181FC File Offset: 0x003163FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new Bat_guardianOfTheNight.$Init$20736.$(this.$nOwner$20747, this.$nLv$20748, this.$self_$20749);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00318218 File Offset: 0x00316418
		internal static bool F4NmciJeKyKttcAHjSs()
		{
			return true;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0031821C File Offset: 0x0031641C
		internal static bool EDmJxVJru0J261MFtwT()
		{
			return false;
		}

		// Token: 0x04001AF5 RID: 6901
		internal GameObject $nOwner$20747;

		// Token: 0x04001AF6 RID: 6902
		internal int $nLv$20748;

		// Token: 0x04001AF7 RID: 6903
		internal Bat_guardianOfTheNight $self_$20749;

		// Token: 0x020004F4 RID: 1268
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06001D19 RID: 7449 RVA: 0x00318220 File Offset: 0x00316420
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject nOwner, int nLv, Bat_guardianOfTheNight self_)
			{
				if (241872 - 500644 != -258771)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60475 - 495066 != -434590)
					{
						base..ctor();
						if (292955 - 42348 == 250607)
						{
							this.$nOwner$20744 = nOwner;
							if (251976 - 464880 != -212903)
							{
								this.$nLv$20745 = nLv;
								if (85292 - 427070 != -341777)
								{
									this.$self_$20746 = self_;
									if (32900 - 51732 == -18832)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001D1A RID: 7450 RVA: 0x003182FC File Offset: 0x003164FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266831 - 544592 != -277761)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_6A7;
					case 1:
						goto IL_6D2;
					case 2:
						goto IL_287;
					default:
						if (234290 - 422334 != -188043)
						{
							goto IL_6A7;
						}
						continue;
					}
					IL_1A:
					this.$self_$20746.Pb1Gm2pPyV = eGuardianOfTheNightState.standby;
					if (253257 - 97816 == 155442)
					{
						continue;
					}
					this.$self_$20746.a4pGjxUjoI = Time.time;
					if (37491 - 109949 != -72458)
					{
						continue;
					}
					this.YieldDefault(1);
					if (20515 - 595720 != -575205)
					{
						continue;
					}
					goto IL_6D2;
					IL_287:
					if (this.$self_$20746.a4pGjxUjoI + (float)1 <= Time.time)
					{
						if (51835 - 319177 != -267342)
						{
							continue;
						}
						goto IL_1A;
					}
					else
					{
						this.$tDir$20739 = this.$self_$20746.transform.position - this.$self_$20746.lofG0IVuWm.position;
						if (215430 - 267194 != -51764)
						{
							continue;
						}
						this.$self_$20746.transform.position = Vector3.Lerp(this.$self_$20746.lofG0IVuWm.position - (float)4 * this.$self_$20746.lofG0IVuWm.forward, this.$self_$20746.lofG0IVuWm.position - (float)2 * this.$self_$20746.lofG0IVuWm.forward, Time.time - this.$self_$20746.a4pGjxUjoI);
						if (187773 - 439235 != -251462)
						{
							continue;
						}
						if (!this.$mSkinMeshRenderder$20738)
						{
							break;
						}
						if (2075 - 290917 != -288842)
						{
							continue;
						}
						this.$$13748$20740 = Mathf.Lerp((float)0, 0.8f, Time.time - this.$self_$20746.a4pGjxUjoI);
						if (28143 - 120874 != -92731)
						{
							continue;
						}
						if (129887 - 203141 != -73254)
						{
							continue;
						}
						this.$$13749$20741 = this.$mSkinMeshRenderder$20738.materials[0].color;
						if (254437 - 12768 != 241669)
						{
							continue;
						}
						if (138306 - 215318 == -77011)
						{
							continue;
						}
						float num = this.$$13749$20741.a = this.$$13748$20740;
						if (78332 - 60349 != 17983)
						{
							continue;
						}
						if (83890 - 463804 != -379914)
						{
							continue;
						}
						this.$mSkinMeshRenderder$20738.materials[0].color = this.$$13749$20741;
						if (55514 - 507059 == -451544 || 52292 - 584232 == -531939)
						{
							continue;
						}
						this.$$13750$20742 = Mathf.Lerp((float)0, 1f, Time.time - this.$self_$20746.a4pGjxUjoI);
						if (98611 - 309091 != -210480)
						{
							continue;
						}
						if (61082 - 183946 == -122863)
						{
							continue;
						}
						Color color = this.$$13751$20743 = this.$mSkinMeshRenderder$20738.materials[1].color;
						if (117205 - 404639 != -287434)
						{
							continue;
						}
						if (186726 - 539048 == -352321)
						{
							continue;
						}
						this.$$13751$20743.a = this.$$13750$20742;
						if (13691 - 103472 == -89780 || 125821 - 52750 == 73072)
						{
							continue;
						}
						Color color2 = this.$mSkinMeshRenderder$20738.materials[1].color = this.$$13751$20743;
						if (19776 - 324407 == -304630)
						{
							continue;
						}
						if (120375 - 277626 != -157251)
						{
							continue;
						}
						break;
					}
					IL_6A7:
					this.$self_$20746.Ln6GBoGI1g = this.$nOwner$20744;
					if (41865 - 321889 == -280024)
					{
						this.$self_$20746.lofG0IVuWm = this.$self_$20746.Ln6GBoGI1g.transform;
						if (168741 - 226468 == -57727)
						{
							this.$self_$20746.ClTG8kN2W9 = (CharacterControl)this.$self_$20746.Ln6GBoGI1g.GetComponent(typeof(CharacterControl));
							if (63537 - 170545 != -107007)
							{
								this.$self_$20746.kIxGiXguI4 = (Bat)this.$self_$20746.Ln6GBoGI1g.GetComponent(typeof(Bat));
								if (47486 - 377803 != -330316)
								{
									this.$self_$20746.G2OGDwqKtM = this.$nLv$20745;
									if (85273 - 182592 == -97319)
									{
										this.$self_$20746.a4pGjxUjoI = Time.time;
										if (67092 - 187907 != -120814)
										{
											this.$self_$20746.animation.Play("walk");
											if (232398 - 594771 != -362372)
											{
												this.$self_$20746.animation.wrapMode = WrapMode.Loop;
												if (151619 - 466343 == -314724)
												{
													this.$mModel$20737 = this.$self_$20746.transform.Find("Shade4_tri").gameObject;
													if (287150 - 284915 != 2236)
													{
														if (!this.$mModel$20737)
														{
															goto IL_1A;
														}
														if (283918 - 186003 != 97916)
														{
															this.$mSkinMeshRenderder$20738 = (SkinnedMeshRenderer)this.$mModel$20737.GetComponent(typeof(SkinnedMeshRenderer));
															if (290805 - 143844 == 146961)
															{
																goto IL_287;
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
				return this.Yield(2, new WaitForFixedUpdate());
				IL_6D2:
				return false;
			}

			// Token: 0x06001D1B RID: 7451 RVA: 0x003189F0 File Offset: 0x00316BF0
			internal static bool HJoPHZJjkSbjF1SilHO()
			{
				return true;
			}

			// Token: 0x06001D1C RID: 7452 RVA: 0x003189F4 File Offset: 0x00316BF4
			internal static bool FvYb7qJhU0R7QwLCMU1()
			{
				return false;
			}

			// Token: 0x04001AF8 RID: 6904
			internal GameObject $mModel$20737;

			// Token: 0x04001AF9 RID: 6905
			internal SkinnedMeshRenderer $mSkinMeshRenderder$20738;

			// Token: 0x04001AFA RID: 6906
			internal Vector3 $tDir$20739;

			// Token: 0x04001AFB RID: 6907
			internal float $$13748$20740;

			// Token: 0x04001AFC RID: 6908
			internal Color $$13749$20741;

			// Token: 0x04001AFD RID: 6909
			internal float $$13750$20742;

			// Token: 0x04001AFE RID: 6910
			internal Color $$13751$20743;

			// Token: 0x04001AFF RID: 6911
			internal GameObject $nOwner$20744;

			// Token: 0x04001B00 RID: 6912
			internal int $nLv$20745;

			// Token: 0x04001B01 RID: 6913
			internal Bat_guardianOfTheNight $self_$20746;
		}
	}

	// Token: 0x020004F5 RID: 1269
	[CompilerGenerated]
	[Serializable]
	internal sealed class $attack$20750 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x06001D1D RID: 7453 RVA: 0x003189F8 File Offset: 0x00316BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $attack$20750(Vector3 mPos, Vector3 tDir, Bat_guardianOfTheNight self_)
		{
			if (47821 - 355914 != -308092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227541 - 373270 != -145728)
				{
					base..ctor();
					if (248269 - 172687 == 75582)
					{
						this.$mPos$20780 = mPos;
						if (198642 - 375636 == -176994)
						{
							this.$tDir$20781 = tDir;
							if (188029 - 59543 == 128486)
							{
								this.$self_$20782 = self_;
								if (42369 - 57843 == -15474)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00318AD4 File Offset: 0x00316CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new Bat_guardianOfTheNight.$attack$20750.$(this.$mPos$20780, this.$tDir$20781, this.$self_$20782);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00318AF0 File Offset: 0x00316CF0
		internal static bool NJlBxNJsdYQ1YvW0gxR()
		{
			return true;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00318AF4 File Offset: 0x00316CF4
		internal static bool UOWL1AJ9mtwpbxrLIDO()
		{
			return false;
		}

		// Token: 0x04001B02 RID: 6914
		internal Vector3 $mPos$20780;

		// Token: 0x04001B03 RID: 6915
		internal Vector3 $tDir$20781;

		// Token: 0x04001B04 RID: 6916
		internal Bat_guardianOfTheNight $self_$20782;

		// Token: 0x020004F6 RID: 1270
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06001D21 RID: 7457 RVA: 0x00318AF8 File Offset: 0x00316CF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Bat_guardianOfTheNight self_)
			{
				if (217568 - 543962 != -326394)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157983 - 287844 != -129860)
					{
						base..ctor();
						if (223923 - 433215 != -209291)
						{
							this.$mPos$20777 = mPos;
							if (108596 - 160728 != -52131)
							{
								this.$tDir$20778 = tDir;
								if (188950 - 387521 != -198570)
								{
									this.$self_$20779 = self_;
									if (191233 - 538776 != -347542)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001D22 RID: 7458 RVA: 0x00318BD4 File Offset: 0x00316DD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270549 - 247715 != 22835)
				{
				}
				for (;;)
				{
					IL_A54:
					switch (this._state)
					{
					case 0:
						goto IL_1A25;
					case 1:
						goto IL_1C19;
					case 2:
						if (this.$self_$20779.Pb1Gm2pPyV == eGuardianOfTheNightState.attack)
						{
							goto IL_75C;
						}
						if (31637 - 238054 != -206417)
						{
							continue;
						}
						goto IL_757;
					case 3:
						if (this.$self_$20779.Pb1Gm2pPyV == eGuardianOfTheNightState.attack)
						{
							goto IL_5E2;
						}
						if (7801 - 591184 != -583382)
						{
							goto Block_61;
						}
						continue;
					case 4:
						if (this.$self_$20779.Pb1Gm2pPyV == eGuardianOfTheNightState.attack)
						{
							goto IL_EC3;
						}
						if (187691 - 439306 != -251615)
						{
							continue;
						}
						goto IL_EBE;
					case 5:
						if (this.$self_$20779.Pb1Gm2pPyV != eGuardianOfTheNightState.attack)
						{
							if (124458 - 447356 != -322897)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$20779.Pb1Gm2pPyV == eGuardianOfTheNightState.attack)
						{
							goto IL_A1F;
						}
						if (172206 - 443045 != -270839)
						{
							continue;
						}
						goto IL_A1A;
					default:
						if (239159 - 524809 != -285649)
						{
							goto IL_1A25;
						}
						continue;
					}
					IL_B3:
					if (this.$self_$20779.a4pGjxUjoI + 0.5f <= Time.time)
					{
						if (204964 - 239962 == -34997)
						{
							continue;
						}
						this.$self_$20779.animation.Play("root");
						if (180769 - 32190 == 148580)
						{
							continue;
						}
						this.$self_$20779.animation.wrapMode = WrapMode.Loop;
						if (94492 - 468196 == -373703)
						{
							continue;
						}
						this.$self_$20779.transform.position = this.$self_$20779.lofG0IVuWm.position - (float)2 * this.$self_$20779.lofG0IVuWm.forward;
						if (255541 - 361197 == -105655)
						{
							continue;
						}
						this.$self_$20779.transform.rotation = Quaternion.LookRotation(this.$self_$20779.lofG0IVuWm.forward);
						if (88521 - 560407 == -471885)
						{
							continue;
						}
						this.$self_$20779.a4pGjxUjoI = Time.time;
						if (247968 - 505134 != -257166)
						{
							continue;
						}
						goto IL_A1F;
					}
					else
					{
						this.$self_$20779.transform.position = Vector3.Slerp(this.$mPos$20777 + (float)1 * this.$tDir$20778, this.$mPos$20777 + (float)4 * this.$tDir$20778, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (54688 - 372267 == -317578)
						{
							continue;
						}
						if (!this.$mSkinMeshRenderder$20752)
						{
							goto IL_959;
						}
						if (204250 - 503333 == -299082)
						{
							continue;
						}
						this.$$13760$20769 = Mathf.Lerp(0.8f, (float)0, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (257096 - 105874 != 151222)
						{
							continue;
						}
						if (266883 - 87293 != 179590)
						{
							continue;
						}
						this.$$13761$20770 = this.$mSkinMeshRenderder$20752.materials[0].color;
						if (253402 - 505765 == -252362 || 280944 - 495385 == -214440)
						{
							continue;
						}
						float num = this.$$13761$20770.a = this.$$13760$20769;
						if (44155 - 84169 == -40013 || 133658 - 132475 == 1184)
						{
							continue;
						}
						Color color = this.$mSkinMeshRenderder$20752.materials[0].color = this.$$13761$20770;
						if (152586 - 300828 == -148241)
						{
							continue;
						}
						if (278250 - 467213 != -188963)
						{
							continue;
						}
						float num2 = this.$$13762$20771 = Mathf.Lerp(1f, (float)0, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (274711 - 305869 != -31158)
						{
							continue;
						}
						if (53018 - 362172 != -309154)
						{
							continue;
						}
						this.$$13763$20772 = this.$mSkinMeshRenderder$20752.materials[1].color;
						if (155767 - 206880 == -51112)
						{
							continue;
						}
						if (280705 - 124825 != 155880)
						{
							continue;
						}
						float num3 = this.$$13763$20772.a = this.$$13762$20771;
						if (22789 - 422100 == -399310)
						{
							continue;
						}
						if (21823 - 347376 != -325553)
						{
							continue;
						}
						Color color2 = this.$mSkinMeshRenderder$20752.materials[1].color = this.$$13763$20772;
						if (9253 - 559927 != -550674)
						{
							continue;
						}
						if (221984 - 355984 != -134000)
						{
							continue;
						}
						goto IL_959;
					}
					IL_5E2:
					if (this.$self_$20779.a4pGjxUjoI + 0.5f <= Time.time)
					{
						if (281948 - 421992 == -140043)
						{
							continue;
						}
						this.$hitLayer$20754 = 130816;
						if (91756 - 290864 != -199108)
						{
							continue;
						}
						this.$hitList$20755 = null;
						if (157277 - 399762 != -242485)
						{
							continue;
						}
						this.$hitPos$20756 = default(Vector3);
						if (62045 - 66603 == -4557)
						{
							continue;
						}
						if (this.$self_$20779.Ln6GBoGI1g)
						{
							if (281471 - 200369 == 81103)
							{
								continue;
							}
							this.$hitLayer$20754 -= 1 << this.$self_$20779.Ln6GBoGI1g.layer;
							if (159420 - 588682 == -429261)
							{
								continue;
							}
						}
						if (this.$self_$20779.ClTG8kN2W9.isMine)
						{
							if (293332 - 142620 == 150713)
							{
								continue;
							}
							this.$hitList$20755 = Damage.FindAreaTarget(this.$self_$20779.transform.position, (float)4, (float)3, this.$hitLayer$20754);
							if (222211 - 142018 != 80193)
							{
								continue;
							}
							this.$$iterator$10348$20758 = UnityRuntimeServices.GetEnumerator(this.$hitList$20755);
							if (61093 - 297159 != -236066)
							{
								continue;
							}
							while (this.$$iterator$10348$20758.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10348$20758.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$20757 = (GameObject)obj2;
								if (294381 - 520712 != -226331)
								{
									goto IL_A54;
								}
								if (this.$self_$20779.ClTG8kN2W9.hit(270 + this.$self_$20779.G2OGDwqKtM, this.$hitObject$20757, 66 * this.$self_$20779.G2OGDwqKtM + 33, 3, 0, Vector3.zero) != 0)
								{
									if (163639 - 499981 != -336342)
									{
										goto IL_A54;
									}
									this.$hitPos$20756 = this.$hitObject$20757.collider.ClosestPointOnBounds(this.$self_$20779.transform.position + Vector3.up);
									if (273357 - 299489 == -26131)
									{
										goto IL_A54;
									}
									UnityRuntimeServices.Update(this.$$iterator$10348$20758, this.$hitObject$20757);
									if (294923 - 29017 == 265907)
									{
										goto IL_A54;
									}
									if (this.$self_$20779.kIxGiXguI4)
									{
										if (4339 - 411149 == -406809)
										{
											goto IL_A54;
										}
										this.$self_$20779.kIxGiXguI4.RPC_guardian_hit(this.$hitPos$20756, this.$self_$20779.transform.forward, 0);
										if (106367 - 584984 != -478617)
										{
											goto IL_A54;
										}
										if (PhotonClient.IsInitialized())
										{
											if (139283 - 35976 == 103308)
											{
												goto IL_A54;
											}
											this.$self_$20779.kIxGiXguI4.ActionEvent("RPC_guardian_hit", this.$hitPos$20756, this.$self_$20779.transform.forward, 0);
											if (5470 - 402424 == -396953)
											{
												goto IL_A54;
											}
										}
									}
								}
							}
							if (137838 - 91364 == 46475)
							{
								continue;
							}
						}
						this.$self_$20779.a4pGjxUjoI = Time.time;
						if (238573 - 164254 != 74320)
						{
							goto IL_EC3;
						}
						continue;
					}
					else
					{
						this.$self_$20779.transform.position = Vector3.Lerp(this.$mPos$20777 - (float)8 * this.$tDir$20778, this.$mPos$20777 - (float)2 * this.$tDir$20778, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (2591 - 115117 == -112525)
						{
							continue;
						}
						if (!this.$mSkinMeshRenderder$20752)
						{
							goto IL_8F0;
						}
						if (28891 - 402260 == -373368)
						{
							continue;
						}
						float num4 = this.$$13756$20765 = Mathf.Lerp((float)0, 0.8f, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (107183 - 285324 == -178140)
						{
							continue;
						}
						if (238447 - 85573 != 152874)
						{
							continue;
						}
						Color color3 = this.$$13757$20766 = this.$mSkinMeshRenderder$20752.materials[0].color;
						if (79568 - 162348 != -82780)
						{
							continue;
						}
						if (26169 - 289173 == -263003)
						{
							continue;
						}
						this.$$13757$20766.a = this.$$13756$20765;
						if (125637 - 506832 == -381194)
						{
							continue;
						}
						if (40570 - 540311 != -499741)
						{
							continue;
						}
						this.$mSkinMeshRenderder$20752.materials[0].color = this.$$13757$20766;
						if (77976 - 350756 != -272780)
						{
							continue;
						}
						if (21503 - 1992 == 19512)
						{
							continue;
						}
						this.$$13758$20767 = Mathf.Lerp((float)0, 1f, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (138178 - 405776 != -267598)
						{
							continue;
						}
						if (130242 - 202771 == -72528)
						{
							continue;
						}
						this.$$13759$20768 = this.$mSkinMeshRenderder$20752.materials[1].color;
						if (297202 - 419319 != -122117)
						{
							continue;
						}
						if (63409 - 103296 != -39887)
						{
							continue;
						}
						this.$$13759$20768.a = this.$$13758$20767;
						if (190534 - 273351 != -82817)
						{
							continue;
						}
						if (293310 - 559463 != -266153)
						{
							continue;
						}
						Color color4 = this.$mSkinMeshRenderder$20752.materials[1].color = this.$$13759$20768;
						if (131969 - 522722 != -390753)
						{
							continue;
						}
						if (19616 - 324931 != -305315)
						{
							continue;
						}
						goto IL_8F0;
					}
					IL_75C:
					if (this.$self_$20779.a4pGjxUjoI + 0.5f <= Time.time)
					{
						if (58888 - 494823 == -435934)
						{
							continue;
						}
						this.$self_$20779.transform.position = this.$mPos$20777 - (float)6 * this.$tDir$20778;
						if (146394 - 178542 == -32147)
						{
							continue;
						}
						this.$self_$20779.transform.rotation = Quaternion.LookRotation(this.$tDir$20778);
						if (213524 - 395416 == -181891)
						{
							continue;
						}
						this.$self_$20779.animation.Play("nAttack");
						if (152371 - 367495 != -215124)
						{
							continue;
						}
						this.$self_$20779.animation.wrapMode = WrapMode.Once;
						if (37849 - 345315 != -307466)
						{
							continue;
						}
						if (!this.$self_$20779.BTSGosCMmd)
						{
							if (214774 - 574835 == -360060)
							{
								continue;
							}
							this.$self_$20779.BTSGosCMmd = (AudioClip)Resources.Load("GameAssets/Characters/Elementals/Shade4/Sounds/nAttack", typeof(AudioClip));
							if (166297 - 24360 != 141937)
							{
								continue;
							}
						}
						if (this.$self_$20779.BTSGosCMmd)
						{
							if (163149 - 160449 != 2700)
							{
								continue;
							}
							this.$self_$20779.audio.PlayOneShot(this.$self_$20779.BTSGosCMmd);
							if (160262 - 464370 == -304107)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing guardian_nAttack sound");
							if (103567 - 524310 == -420742)
							{
								continue;
							}
						}
						if (this.$self_$20779.guardianBlade)
						{
							if (237832 - 352196 == -114363)
							{
								continue;
							}
							this.$mBlade$20753 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$20779.guardianBlade);
							if (182668 - 476757 != -294089)
							{
								continue;
							}
							this.$mBlade$20753.transform.parent = global::Math.findChildObject(this.$self_$20779.gameObject.transform, "sword");
							if (25318 - 324202 == -298883)
							{
								continue;
							}
							this.$mBlade$20753.transform.localPosition = new Vector3(-1.1f, (float)0, (float)0);
							if (1329 - 456724 == -455394)
							{
								continue;
							}
							this.$mBlade$20753.transform.localRotation = Quaternion.Euler((float)0, (float)180, (float)90);
							if (126280 - 284172 != -157892)
							{
								continue;
							}
						}
						this.$self_$20779.a4pGjxUjoI = Time.time;
						if (297772 - 314311 != -16538)
						{
							goto IL_5E2;
						}
						continue;
					}
					else
					{
						if (!this.$mSkinMeshRenderder$20752)
						{
							goto IL_197F;
						}
						if (224256 - 497230 != -272974)
						{
							continue;
						}
						this.$$13752$20761 = Mathf.Lerp(0.8f, (float)0, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (127321 - 148827 == -21505)
						{
							continue;
						}
						if (120346 - 87824 != 32522)
						{
							continue;
						}
						Color color5 = this.$$13753$20762 = this.$mSkinMeshRenderder$20752.materials[0].color;
						if (134144 - 310346 != -176202)
						{
							continue;
						}
						if (143780 - 476598 == -332817)
						{
							continue;
						}
						this.$$13753$20762.a = this.$$13752$20761;
						if (10697 - 584194 == -573496)
						{
							continue;
						}
						if (171422 - 369541 != -198119)
						{
							continue;
						}
						this.$mSkinMeshRenderder$20752.materials[0].color = this.$$13753$20762;
						if (245514 - 293232 == -47717)
						{
							continue;
						}
						if (75502 - 361542 != -286040)
						{
							continue;
						}
						this.$$13754$20763 = Mathf.Lerp(1f, (float)0, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (174667 - 439870 == -265202 || 266528 - 43350 == 223179)
						{
							continue;
						}
						Color color6 = this.$$13755$20764 = this.$mSkinMeshRenderder$20752.materials[1].color;
						if (47857 - 176397 != -128540)
						{
							continue;
						}
						if (153822 - 70406 != 83416)
						{
							continue;
						}
						this.$$13755$20764.a = this.$$13754$20763;
						if (25280 - 302909 == -277628)
						{
							continue;
						}
						if (202048 - 106769 != 95279)
						{
							continue;
						}
						Color color7 = this.$mSkinMeshRenderder$20752.materials[1].color = this.$$13755$20764;
						if (226644 - 143824 != 82821 && 228184 - 131577 != 96608)
						{
							goto Block_111;
						}
						continue;
					}
					IL_A1F:
					if (this.$self_$20779.a4pGjxUjoI + 0.5f <= Time.time)
					{
						if (288458 - 590677 == -302218)
						{
							continue;
						}
						this.$self_$20779.Pb1Gm2pPyV = eGuardianOfTheNightState.standby;
						if (271196 - 84989 == 186208)
						{
							continue;
						}
						this.$self_$20779.a4pGjxUjoI = Time.time;
						if (123362 - 493108 != -369746)
						{
							continue;
						}
						this.YieldDefault(1);
						if (276314 - 400151 != -123837)
						{
							continue;
						}
						goto IL_1C19;
					}
					else
					{
						if (!this.$mSkinMeshRenderder$20752)
						{
							goto IL_B9B;
						}
						if (265120 - 593984 != -328864)
						{
							continue;
						}
						float num5 = this.$$13764$20773 = Mathf.Lerp((float)0, 0.8f, (Time.time - this.$self_$20779.a4pGjxUjoI) / 0.5f);
						if (107838 - 217576 == -109737)
						{
							continue;
						}
						if (211049 - 464896 != -253847)
						{
							continue;
						}
						this.$$13765$20774 = this.$mSkinMeshRenderder$20752.materials[0].color;
						if (238747 - 442864 == -204116)
						{
							continue;
						}
						if (121625 - 274036 != -152411)
						{
							continue;
						}
						float num6 = this.$$13765$20774.a = this.$$13764$20773;
						if (23423 - 147352 == -123928 || 103790 - 404832 == -301041)
						{
							continue;
						}
						Color color8 = this.$mSkinMeshRenderder$20752.materials[0].color = this.$$13765$20774;
						if (227098 - 46217 == 180882 || 98482 - 465741 == -367258)
						{
							continue;
						}
						float num7 = this.$$13766$20775 = Mathf.Lerp((float)0, 1f, (Time.time - this.$self_$20779.a4pGjxUjoI) / 0.5f);
						if (59649 - 95550 == -35900 || 115040 - 234379 == -119338)
						{
							continue;
						}
						Color color9 = this.$$13767$20776 = this.$mSkinMeshRenderder$20752.materials[1].color;
						if (73816 - 12659 == 61158 || 4895 - 489840 == -484944)
						{
							continue;
						}
						float num8 = this.$$13767$20776.a = this.$$13766$20775;
						if (166722 - 529648 != -362926)
						{
							continue;
						}
						if (87103 - 532852 != -445749)
						{
							continue;
						}
						Color color10 = this.$mSkinMeshRenderder$20752.materials[1].color = this.$$13767$20776;
						if (218739 - 190124 != 28615)
						{
							continue;
						}
						if (276528 - 44690 != 231839)
						{
							goto Block_153;
						}
						continue;
					}
					IL_EC3:
					if (this.$self_$20779.a4pGjxUjoI + 0.5f <= Time.time)
					{
						if (5752 - 548677 == -542924)
						{
							continue;
						}
						if (this.$self_$20779.ClTG8kN2W9.isMine)
						{
							if (149115 - 147687 == 1429)
							{
								continue;
							}
							this.$hitList$20755 = Damage.FindAreaTarget(this.$self_$20779.transform.position, (float)4, (float)3, this.$hitLayer$20754);
							if (279641 - 242394 == 37248)
							{
								continue;
							}
							this.$$iterator$10349$20760 = UnityRuntimeServices.GetEnumerator(this.$hitList$20755);
							if (29962 - 571851 == -541888)
							{
								continue;
							}
							while (this.$$iterator$10349$20760.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10349$20760.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$20759 = (GameObject)obj4;
								if (45386 - 425357 != -379971)
								{
									goto IL_A54;
								}
								if (this.$self_$20779.ClTG8kN2W9.hit(270 + this.$self_$20779.G2OGDwqKtM, this.$hitObject$20759, 66 * this.$self_$20779.G2OGDwqKtM + 33, 3, 0, Vector3.zero) != 0)
								{
									if (61683 - 461224 != -399541)
									{
										goto IL_A54;
									}
									this.$hitPos$20756 = this.$hitObject$20759.collider.ClosestPointOnBounds(this.$self_$20779.transform.position + Vector3.up);
									if (157923 - 385357 != -227434)
									{
										goto IL_A54;
									}
									UnityRuntimeServices.Update(this.$$iterator$10349$20760, this.$hitObject$20759);
									if (247723 - 180894 == 66830)
									{
										goto IL_A54;
									}
									if (this.$self_$20779.kIxGiXguI4)
									{
										if (234833 - 10509 != 224324)
										{
											goto IL_A54;
										}
										this.$self_$20779.kIxGiXguI4.RPC_guardian_hit(this.$hitPos$20756, this.$self_$20779.transform.forward, 0);
										if (110341 - 425786 == -315444)
										{
											goto IL_A54;
										}
										if (PhotonClient.IsInitialized())
										{
											if (90581 - 187659 == -97077)
											{
												goto IL_A54;
											}
											this.$self_$20779.kIxGiXguI4.ActionEvent("RPC_guardian_hit", this.$hitPos$20756, this.$self_$20779.transform.forward, 0);
											if (291846 - 551534 != -259688)
											{
												goto IL_A54;
											}
										}
									}
								}
							}
							if (186086 - 113634 == 72453)
							{
								continue;
							}
						}
						this.$self_$20779.a4pGjxUjoI = Time.time;
						if (108240 - 362142 != -253901)
						{
							goto IL_B3;
						}
						continue;
					}
					else
					{
						this.$self_$20779.transform.position = Vector3.Slerp(this.$mPos$20777 - (float)2 * this.$tDir$20778, this.$mPos$20777 + (float)1 * this.$tDir$20778, (float)2 * (Time.time - this.$self_$20779.a4pGjxUjoI));
						if (601 - 234356 != -233755)
						{
							continue;
						}
						break;
					}
					IL_1A25:
					if (this.$self_$20779.Pb1Gm2pPyV != eGuardianOfTheNightState.standby)
					{
						if (247488 - 430612 != -183123)
						{
							goto Block_167;
						}
					}
					else
					{
						this.$self_$20779.Pb1Gm2pPyV = eGuardianOfTheNightState.attack;
						if (33242 - 169787 != -136544)
						{
							this.$self_$20779.a4pGjxUjoI = Time.time;
							if (219843 - 173224 != 46620)
							{
								this.$self_$20779.animation.CrossFade("root", 0.2f);
								if (84021 - 114178 == -30157)
								{
									this.$self_$20779.animation.wrapMode = WrapMode.Loop;
									if (76899 - 342379 != -265479)
									{
										this.$mModel$20751 = this.$self_$20779.transform.Find("Shade4_tri").gameObject;
										if (125038 - 517231 != -392192)
										{
											this.$mSkinMeshRenderder$20752 = null;
											if (49649 - 508868 == -459219)
											{
												if (this.$mModel$20751)
												{
													if (12276 - 485314 == -473037)
													{
														continue;
													}
													this.$mSkinMeshRenderder$20752 = (SkinnedMeshRenderer)this.$mModel$20751.GetComponent(typeof(SkinnedMeshRenderer));
													if (149279 - 438922 != -289643)
													{
														continue;
													}
												}
												goto IL_75C;
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForFixedUpdate());
				IL_757:
				goto IL_1C19;
				IL_8F0:
				return this.Yield(3, new WaitForFixedUpdate());
				Block_61:
				goto IL_1C19;
				IL_959:
				return this.Yield(5, new WaitForFixedUpdate());
				Block_64:
				IL_A1A:
				goto IL_1C19;
				IL_B9B:
				return this.Yield(6, new WaitForFixedUpdate());
				IL_EBE:
				goto IL_1C19;
				Block_111:
				goto IL_197F;
				Block_153:
				goto IL_B9B;
				IL_197F:
				return this.Yield(2, new WaitForFixedUpdate());
				Block_167:
				IL_1C19:
				return false;
			}

			// Token: 0x06001D23 RID: 7459 RVA: 0x0031A80C File Offset: 0x00318A0C
			internal static bool QgbOqTJ1n8MWOFRGfpn()
			{
				return true;
			}

			// Token: 0x06001D24 RID: 7460 RVA: 0x0031A810 File Offset: 0x00318A10
			internal static bool vTMoqcJ4MFRefL5ZOUQ()
			{
				return false;
			}

			// Token: 0x04001B05 RID: 6917
			internal GameObject $mModel$20751;

			// Token: 0x04001B06 RID: 6918
			internal SkinnedMeshRenderer $mSkinMeshRenderder$20752;

			// Token: 0x04001B07 RID: 6919
			internal GameObject $mBlade$20753;

			// Token: 0x04001B08 RID: 6920
			internal int $hitLayer$20754;

			// Token: 0x04001B09 RID: 6921
			internal UnityScript.Lang.Array $hitList$20755;

			// Token: 0x04001B0A RID: 6922
			internal Vector3 $hitPos$20756;

			// Token: 0x04001B0B RID: 6923
			internal GameObject $hitObject$20757;

			// Token: 0x04001B0C RID: 6924
			internal IEnumerator $$iterator$10348$20758;

			// Token: 0x04001B0D RID: 6925
			internal GameObject $hitObject$20759;

			// Token: 0x04001B0E RID: 6926
			internal IEnumerator $$iterator$10349$20760;

			// Token: 0x04001B0F RID: 6927
			internal float $$13752$20761;

			// Token: 0x04001B10 RID: 6928
			internal Color $$13753$20762;

			// Token: 0x04001B11 RID: 6929
			internal float $$13754$20763;

			// Token: 0x04001B12 RID: 6930
			internal Color $$13755$20764;

			// Token: 0x04001B13 RID: 6931
			internal float $$13756$20765;

			// Token: 0x04001B14 RID: 6932
			internal Color $$13757$20766;

			// Token: 0x04001B15 RID: 6933
			internal float $$13758$20767;

			// Token: 0x04001B16 RID: 6934
			internal Color $$13759$20768;

			// Token: 0x04001B17 RID: 6935
			internal float $$13760$20769;

			// Token: 0x04001B18 RID: 6936
			internal Color $$13761$20770;

			// Token: 0x04001B19 RID: 6937
			internal float $$13762$20771;

			// Token: 0x04001B1A RID: 6938
			internal Color $$13763$20772;

			// Token: 0x04001B1B RID: 6939
			internal float $$13764$20773;

			// Token: 0x04001B1C RID: 6940
			internal Color $$13765$20774;

			// Token: 0x04001B1D RID: 6941
			internal float $$13766$20775;

			// Token: 0x04001B1E RID: 6942
			internal Color $$13767$20776;

			// Token: 0x04001B1F RID: 6943
			internal Vector3 $mPos$20777;

			// Token: 0x04001B20 RID: 6944
			internal Vector3 $tDir$20778;

			// Token: 0x04001B21 RID: 6945
			internal Bat_guardianOfTheNight $self_$20779;
		}
	}

	// Token: 0x020004F7 RID: 1271
	[CompilerGenerated]
	[Serializable]
	internal sealed class $castSpell$20783 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D25 RID: 7461 RVA: 0x0031A814 File Offset: 0x00318A14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $castSpell$20783(GameObject tObject, Bat_guardianOfTheNight self_)
		{
			if (134393 - 593827 != -459434)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221406 - 434641 != -213234)
				{
					base..ctor();
					if (3702 - 472970 == -469268)
					{
						this.$tObject$20793 = tObject;
						if (170174 - 499950 == -329776)
						{
							this.$self_$20794 = self_;
							if (117349 - 180259 != -62909)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0031A8D0 File Offset: 0x00318AD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_guardianOfTheNight.$castSpell$20783.$(this.$tObject$20793, this.$self_$20794);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0031A8E4 File Offset: 0x00318AE4
		internal static bool MMoVqLJzl1NFt8iiLD7()
		{
			return true;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0031A8E8 File Offset: 0x00318AE8
		internal static bool tiySrIDauQW6bu0WVsn()
		{
			return false;
		}

		// Token: 0x04001B22 RID: 6946
		internal GameObject $tObject$20793;

		// Token: 0x04001B23 RID: 6947
		internal Bat_guardianOfTheNight $self_$20794;

		// Token: 0x020004F8 RID: 1272
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D29 RID: 7465 RVA: 0x0031A8EC File Offset: 0x00318AEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject tObject, Bat_guardianOfTheNight self_)
			{
				if (153418 - 59933 != 93486)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (68985 - 556816 != -487830)
					{
						base..ctor();
						if (69411 - 567093 != -497681)
						{
							this.$tObject$20791 = tObject;
							if (87736 - 397793 == -310057)
							{
								this.$self_$20792 = self_;
								if (239027 - 268407 == -29380)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001D2A RID: 7466 RVA: 0x0031A9A8 File Offset: 0x00318BA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214568 - 388522 != -173954)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_786;
					case 2:
						if (this.$self_$20792.Pb1Gm2pPyV != eGuardianOfTheNightState.castSpell)
						{
							if (13176 - 25250 != -12074)
							{
								continue;
							}
							goto IL_2A5;
						}
						else
						{
							UnityEngine.Object.Instantiate(this.$self_$20792.castEffect, this.$self_$20792.transform.position + this.$self_$20792.transform.TransformDirection((float)0, 2.75f, 1.2f), this.$self_$20792.transform.rotation);
							if (166974 - 279291 != -112316)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$20792.Pb1Gm2pPyV != eGuardianOfTheNightState.castSpell)
						{
							if (47250 - 167151 != -119900)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (!this.$self_$20792.ClTG8kN2W9.isMine)
							{
								goto IL_4F0;
							}
							if (214115 - 36463 == 177653)
							{
								continue;
							}
							this.$tChar$20786 = (CharacterControl)this.$tObject$20791.GetComponent(typeof(CharacterControl));
							if (182635 - 368413 != -185778)
							{
								continue;
							}
							if (UnityEngine.Random.Range(0, 100) > 50)
							{
								if (267226 - 426233 != -159007)
								{
									continue;
								}
								this.$tChar$20786.RPC_AddStatus("curse", this.$self_$20792.G2OGDwqKtM * 2, Damage.getDebuff((float)12, 128, this.$tChar$20786.cha), 0, this.$self_$20792.ClTG8kN2W9.ActorNr);
								if (167594 - 97061 != 70533)
								{
									continue;
								}
								goto IL_8D;
							}
							else
							{
								this.$tChar$20786.RPC_AddStatus("nightmare", this.$self_$20792.G2OGDwqKtM, Damage.getDebuff((float)3, 128, this.$tChar$20786.cha), 0, this.$self_$20792.ClTG8kN2W9.ActorNr);
								if (3679 - 339843 != -336163)
								{
									goto Block_5;
								}
								continue;
							}
						}
						break;
					case 4:
						this.$self_$20792.Pb1Gm2pPyV = eGuardianOfTheNightState.standby;
						if (106232 - 159469 != -53237)
						{
							continue;
						}
						this.$self_$20792.a4pGjxUjoI = Time.time;
						if (12116 - 239164 == -227047)
						{
							continue;
						}
						this.YieldDefault(1);
						if (299173 - 159088 != 140086)
						{
							goto Block_2;
						}
						continue;
					default:
						if (185912 - 533204 == -347291)
						{
							continue;
						}
						break;
					}
					if (!this.$tObject$20791)
					{
						if (164849 - 140165 != 24685)
						{
							break;
						}
					}
					else
					{
						this.$self_$20792.Pb1Gm2pPyV = eGuardianOfTheNightState.castSpell;
						if (106028 - 320438 == -214410)
						{
							this.$self_$20792.a4pGjxUjoI = Time.time;
							if (72185 - 428216 == -356031)
							{
								this.$self_$20792.transform.LookAt(global::Math.cFlat(this.$tObject$20791.transform.position, this.$self_$20792.transform.position.y));
								if (86541 - 441575 == -355034)
								{
									this.$self_$20792.animation.CrossFade("cast", 0.2f);
									if (251594 - 204989 == 46605)
									{
										this.$self_$20792.animation.wrapMode = WrapMode.Once;
										if (125865 - 113323 == 12542)
										{
											this.$mModel$20784 = this.$self_$20792.transform.Find("Shade4_tri").gameObject;
											if (33952 - 174655 == -140703)
											{
												if (!this.$mModel$20784)
												{
													goto IL_3E2;
												}
												if (59662 - 540538 == -480876)
												{
													this.$mSkinMeshRenderder$20785 = (SkinnedMeshRenderer)this.$mModel$20784.GetComponent(typeof(SkinnedMeshRenderer));
													if (299169 - 315871 == -16702)
													{
														if (!this.$mSkinMeshRenderder$20785)
														{
															goto IL_3E2;
														}
														if (298469 - 196891 != 101579)
														{
															float num = this.$$13768$20787 = 0.8f;
															if (214175 - 459501 == -245326)
															{
																if (53039 - 302814 == -249775)
																{
																	Color color = this.$$13769$20788 = this.$mSkinMeshRenderder$20785.materials[0].color;
																	if (228103 - 586383 != -358279)
																	{
																		if (5174 - 548157 == -542983)
																		{
																			float num2 = this.$$13769$20788.a = this.$$13768$20787;
																			if (21646 - 162259 == -140613)
																			{
																				if (17716 - 512548 == -494832)
																				{
																					this.$mSkinMeshRenderder$20785.materials[0].color = this.$$13769$20788;
																					if (137807 - 326061 != -188253 && 250878 - 226530 != 24349)
																					{
																						this.$$13770$20789 = 1f;
																						if (105653 - 91959 != 13695 && 14876 - 47195 != -32318)
																						{
																							Color color2 = this.$$13771$20790 = this.$mSkinMeshRenderder$20785.materials[1].color;
																							if (24514 - 356135 == -331621)
																							{
																								if (200962 - 542920 == -341958)
																								{
																									float num3 = this.$$13771$20790.a = this.$$13770$20789;
																									if (51631 - 229016 == -177385)
																									{
																										if (128306 - 131923 == -3617)
																										{
																											Color color3 = this.$mSkinMeshRenderder$20785.materials[1].color = this.$$13771$20790;
																											if (94217 - 500822 == -406605)
																											{
																												if (23449 - 275404 == -251955)
																												{
																													goto IL_3E2;
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
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_786;
				IL_8D:
				Block_5:
				goto IL_4F0;
				IL_2A5:
				goto IL_786;
				Block_14:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_3E2:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_27:
				goto IL_786;
				IL_4F0:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_786:
				return false;
			}

			// Token: 0x06001D2B RID: 7467 RVA: 0x0031B150 File Offset: 0x00319350
			internal static bool sLp8OgD5Z8LDu4Usl9F()
			{
				return true;
			}

			// Token: 0x06001D2C RID: 7468 RVA: 0x0031B154 File Offset: 0x00319354
			internal static bool c8uS3VDpARvNdw30JJP()
			{
				return false;
			}

			// Token: 0x04001B24 RID: 6948
			internal GameObject $mModel$20784;

			// Token: 0x04001B25 RID: 6949
			internal SkinnedMeshRenderer $mSkinMeshRenderder$20785;

			// Token: 0x04001B26 RID: 6950
			internal CharacterControl $tChar$20786;

			// Token: 0x04001B27 RID: 6951
			internal float $$13768$20787;

			// Token: 0x04001B28 RID: 6952
			internal Color $$13769$20788;

			// Token: 0x04001B29 RID: 6953
			internal float $$13770$20789;

			// Token: 0x04001B2A RID: 6954
			internal Color $$13771$20790;

			// Token: 0x04001B2B RID: 6955
			internal GameObject $tObject$20791;

			// Token: 0x04001B2C RID: 6956
			internal Bat_guardianOfTheNight $self_$20792;
		}
	}

	// Token: 0x020004F9 RID: 1273
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$20795 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x0031B158 File Offset: 0x00319358
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$20795(Bat_guardianOfTheNight self_)
		{
			if (151318 - 60226 != 91092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141644 - 582538 != -440893)
				{
					base..ctor();
					if (30296 - 351462 != -321165)
					{
						this.$self_$20803 = self_;
						if (89537 - 314775 != -225237)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0031B1F0 File Offset: 0x003193F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_guardianOfTheNight.$unsummon$20795.$(this.$self_$20803);
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x0031B200 File Offset: 0x00319400
		internal static bool WsiE7qDVg7nSoTL1M7D()
		{
			return true;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0031B204 File Offset: 0x00319404
		internal static bool Aslh7NDteRr5Srgl1h1()
		{
			return false;
		}

		// Token: 0x04001B2D RID: 6957
		internal Bat_guardianOfTheNight $self_$20803;

		// Token: 0x020004FA RID: 1274
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D31 RID: 7473 RVA: 0x0031B208 File Offset: 0x00319408
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Bat_guardianOfTheNight self_)
			{
				if (69655 - 92664 != -23009)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163000 - 121679 == 41321)
					{
						base..ctor();
						if (266742 - 503741 != -236998)
						{
							this.$self_$20802 = self_;
							if (290853 - 560729 == -269876)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001D32 RID: 7474 RVA: 0x0031B2A0 File Offset: 0x003194A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153273 - 560291 != -407017)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_456;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$20802.gameObject);
						if (7820 - 94683 != -86863)
						{
							continue;
						}
						this.YieldDefault(1);
						if (118933 - 2703 != 116231)
						{
							goto IL_456;
						}
						continue;
					default:
						if (84494 - 345385 != -260891)
						{
							continue;
						}
						break;
					}
					this.$self_$20802.Pb1Gm2pPyV = eGuardianOfTheNightState.unsummon;
					if (293476 - 232761 != 60716)
					{
						this.$self_$20802.animation.Play("ko");
						if (269058 - 242140 != 26919)
						{
							this.$self_$20802.animation.wrapMode = WrapMode.Once;
							if (199394 - 326694 != -127299)
							{
								this.$mModel$20796 = this.$self_$20802.transform.Find("Shade4_tri").gameObject;
								if (211678 - 107759 != 103920)
								{
									if (!this.$mModel$20796)
									{
										break;
									}
									if (40525 - 356351 == -315826)
									{
										this.$mSkinMeshRenderder$20797 = (SkinnedMeshRenderer)this.$mModel$20796.GetComponent(typeof(SkinnedMeshRenderer));
										if (32144 - 372871 != -340726)
										{
											if (!this.$mSkinMeshRenderder$20797)
											{
												break;
											}
											if (60427 - 210230 != -149802)
											{
												float num = this.$$13772$20798 = 0.8f;
												if (156026 - 120232 != 35795)
												{
													if (13650 - 399949 == -386299)
													{
														Color color = this.$$13773$20799 = this.$mSkinMeshRenderder$20797.materials[0].color;
														if (30305 - 81949 == -51644)
														{
															if (63442 - 478242 == -414800)
															{
																float num2 = this.$$13773$20799.a = this.$$13772$20798;
																if (9479 - 91074 != -81594)
																{
																	if (281485 - 187496 == 93989)
																	{
																		Color color2 = this.$mSkinMeshRenderder$20797.materials[0].color = this.$$13773$20799;
																		if (44543 - 178786 == -134243)
																		{
																			if (133039 - 158418 == -25379)
																			{
																				float num3 = this.$$13774$20800 = 1f;
																				if (6683 - 157426 != -150742)
																				{
																					if (192550 - 147335 == 45215)
																					{
																						Color color3 = this.$$13775$20801 = this.$mSkinMeshRenderder$20797.materials[1].color;
																						if (110104 - 306572 != -196467 && 190470 - 210982 != -20511)
																						{
																							float num4 = this.$$13775$20801.a = this.$$13774$20800;
																							if (148931 - 364557 == -215626)
																							{
																								if (73815 - 573761 == -499946)
																								{
																									Color color4 = this.$mSkinMeshRenderder$20797.materials[1].color = this.$$13775$20801;
																									if (227009 - 53708 != 173302)
																									{
																										if (200467 - 492924 == -292457)
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
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_456:
				return false;
			}

			// Token: 0x06001D33 RID: 7475 RVA: 0x0031B718 File Offset: 0x00319918
			internal static bool cZpyQmDN0bQuFq5pYin()
			{
				return true;
			}

			// Token: 0x06001D34 RID: 7476 RVA: 0x0031B71C File Offset: 0x0031991C
			internal static bool O6cKRADYJhlaCnwW7T0()
			{
				return false;
			}

			// Token: 0x04001B2E RID: 6958
			internal GameObject $mModel$20796;

			// Token: 0x04001B2F RID: 6959
			internal SkinnedMeshRenderer $mSkinMeshRenderder$20797;

			// Token: 0x04001B30 RID: 6960
			internal float $$13772$20798;

			// Token: 0x04001B31 RID: 6961
			internal Color $$13773$20799;

			// Token: 0x04001B32 RID: 6962
			internal float $$13774$20800;

			// Token: 0x04001B33 RID: 6963
			internal Color $$13775$20801;

			// Token: 0x04001B34 RID: 6964
			internal Bat_guardianOfTheNight $self_$20802;
		}
	}
}
