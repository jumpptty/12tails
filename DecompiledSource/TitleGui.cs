using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200109F RID: 4255
[Serializable]
public class TitleGui : MonoBehaviour
{
	// Token: 0x06006315 RID: 25365 RVA: 0x00DC1238 File Offset: 0x00DBF438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TitleGui()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006316 RID: 25366 RVA: 0x00DC1248 File Offset: 0x00DBF448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ehecPGVtK72 = Time.time;
		this.dNycP1TA4kF = 0;
	}

	// Token: 0x06006317 RID: 25367 RVA: 0x00DC125C File Offset: 0x00DBF45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (118727 - 479452 != -360725)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 768f, (float)Screen.height / 768f, (float)1));
			if (237681 - 106997 == 130684)
			{
				GUI.depth = 0;
				if (69891 - 229714 != -159822)
				{
					int num = 768 * Screen.width / Screen.height;
					if (262628 - 589782 != -327153)
					{
						float num2 = (float)Screen.height / 768f;
						if (194756 - 358292 == -163536)
						{
							GUIStyle style = new GUIStyle();
							if (113126 - 186071 != -72944)
							{
								if (this.dNycP1TA4kF == 0)
								{
									if (41624 - 9718 != 31907)
									{
										if (Time.time - this.ehecPGVtK72 < (float)4)
										{
											if (23686 - 41707 != -18020)
											{
												break;
											}
										}
										else
										{
											this.dNycP1TA4kF = 1;
											if (89436 - 549484 != -460047)
											{
												break;
											}
										}
									}
								}
								else if (this.dNycP1TA4kF == 1)
								{
									if (244008 - 40756 == 203252)
									{
										GUI.DrawTexture(new Rect((float)0, (float)0, (float)1024, (float)768), this.Login_BG);
										if (285534 - 543243 != -257708)
										{
											if (GUI.Button(new Rect((float)450, (float)550, (float)67, (float)28), this.Button_Login, style))
											{
												if (141072 - 474546 != -333474)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.LogIn());
												if (188794 - 501592 == -312797)
												{
													continue;
												}
											}
											if (!GUI.Button(new Rect((float)520, (float)550, (float)79, (float)23), this.Button_Register, style))
											{
												break;
											}
											if (281351 - 311392 == -30041)
											{
												this.StartCoroutine_Auto(this.Register());
												if (53797 - 254547 != -200749)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (this.dNycP1TA4kF != 2)
									{
										break;
									}
									if (117051 - 32887 != 84165)
									{
										GUI.DrawTexture(new Rect((float)0, (float)0, (float)1024, (float)768), this.Quest_BG);
										if (165847 - 595257 == -429410)
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

	// Token: 0x06006318 RID: 25368 RVA: 0x00DC1588 File Offset: 0x00DBF788
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LogIn()
	{
		return new TitleGui.$LogIn$36353(this).GetEnumerator();
	}

	// Token: 0x06006319 RID: 25369 RVA: 0x00DC1598 File Offset: 0x00DBF798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Register()
	{
		return new TitleGui.$Register$36356(this).GetEnumerator();
	}

	// Token: 0x0600631A RID: 25370 RVA: 0x00DC15A8 File Offset: 0x00DBF7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600631B RID: 25371 RVA: 0x00DC15AC File Offset: 0x00DBF7AC
	internal static bool ftyqkvpkHtDlpsGf7tuD()
	{
		return true;
	}

	// Token: 0x0600631C RID: 25372 RVA: 0x00DC15B0 File Offset: 0x00DBF7B0
	internal static bool yj0YyHpkWRgVdEt076tN()
	{
		return false;
	}

	// Token: 0x040072C7 RID: 29383
	public Texture Login_BG;

	// Token: 0x040072C8 RID: 29384
	public Texture Quest_BG;

	// Token: 0x040072C9 RID: 29385
	public Texture Button_Login;

	// Token: 0x040072CA RID: 29386
	public Texture Button_Register;

	// Token: 0x040072CB RID: 29387
	private float ehecPGVtK72;

	// Token: 0x040072CC RID: 29388
	private int dNycP1TA4kF;

	// Token: 0x020010A0 RID: 4256
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LogIn$36353 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600631D RID: 25373 RVA: 0x00DC15B4 File Offset: 0x00DBF7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LogIn$36353(TitleGui self_)
		{
			if (37095 - 44190 != -7095)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94135 - 270412 != -176276)
				{
					base..ctor();
					if (56560 - 452578 == -396018)
					{
						this.$self_$36355 = self_;
						if (172943 - 444090 == -271147)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x00DC164C File Offset: 0x00DBF84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new TitleGui.$LogIn$36353.$(this.$self_$36355);
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x00DC165C File Offset: 0x00DBF85C
		internal static bool NoYZgApkAENVp8xKQ7NV()
		{
			return true;
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x00DC1660 File Offset: 0x00DBF860
		internal static bool uPyseQpklQ3l6lyqI10t()
		{
			return false;
		}

		// Token: 0x040072CD RID: 29389
		internal TitleGui $self_$36355;

		// Token: 0x020010A1 RID: 4257
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006321 RID: 25377 RVA: 0x00DC1664 File Offset: 0x00DBF864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(TitleGui self_)
			{
				if (201379 - 218423 != -17044)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222055 - 505670 != -283614)
					{
						base..ctor();
						if (226785 - 364368 != -137582)
						{
							this.$self_$36354 = self_;
							if (132520 - 371736 != -239215)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06006322 RID: 25378 RVA: 0x00DC16FC File Offset: 0x00DBF8FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185417 - 385601 != -200184)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_CA;
					case 2:
						this.YieldDefault(1);
						if (140073 - 429196 != -289123)
						{
							continue;
						}
						goto IL_CA;
					default:
						if (179116 - 453150 != -274034)
						{
							continue;
						}
						break;
					}
					Debug.Log("LogIn!");
					if (56391 - 255050 != -198658)
					{
						this.$self_$36354.dNycP1TA4kF = 2;
						if (202504 - 251356 != -48851)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_CA:
				return false;
			}

			// Token: 0x06006323 RID: 25379 RVA: 0x00DC17E8 File Offset: 0x00DBF9E8
			internal static bool tXFZf5pkyo9iCYLCNga6()
			{
				return true;
			}

			// Token: 0x06006324 RID: 25380 RVA: 0x00DC17EC File Offset: 0x00DBF9EC
			internal static bool qM9H0ZpkSHZ0Mae6ZdtQ()
			{
				return false;
			}

			// Token: 0x040072CE RID: 29390
			internal TitleGui $self_$36354;
		}
	}

	// Token: 0x020010A2 RID: 4258
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Register$36356 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06006325 RID: 25381 RVA: 0x00DC17F0 File Offset: 0x00DBF9F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Register$36356(TitleGui self_)
		{
			if (145276 - 396116 != -250839)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239250 - 281064 == -41814)
				{
					base..ctor();
					if (169123 - 63581 == 105542)
					{
						this.$self_$36358 = self_;
						if (282450 - 556130 != -273679)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x00DC1888 File Offset: 0x00DBFA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new TitleGui.$Register$36356.$(this.$self_$36358);
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x00DC1898 File Offset: 0x00DBFA98
		internal static bool DSeDxOpkokrE3WgUDNSJ()
		{
			return true;
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x00DC189C File Offset: 0x00DBFA9C
		internal static bool PYQgpcpkEXcQ51ZfdSGM()
		{
			return false;
		}

		// Token: 0x040072CF RID: 29391
		internal TitleGui $self_$36358;

		// Token: 0x020010A3 RID: 4259
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06006329 RID: 25385 RVA: 0x00DC18A0 File Offset: 0x00DBFAA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(TitleGui self_)
			{
				if (245532 - 85107 != 160426)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (140107 - 331840 == -191733)
					{
						base..ctor();
						if (85644 - 169838 != -84193)
						{
							this.$self_$36357 = self_;
							if (79142 - 375081 != -295938)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600632A RID: 25386 RVA: 0x00DC1938 File Offset: 0x00DBFB38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4156 - 13084 != -8928)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_117;
					case 2:
						Application.LoadLevel("M10_SnowTrainingGround");
						if (241756 - 309045 != -67289)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (231287 - 360935 == -129647)
						{
							continue;
						}
						break;
					}
					Debug.Log("Register!");
					if (243818 - 599379 != -355560)
					{
						Debug.Log("LogIn!");
						if (204288 - 21105 == 183183)
						{
							this.$self_$36357.dNycP1TA4kF = 2;
							if (224114 - 325872 != -101757)
							{
								goto Block_4;
							}
						}
					}
				}
				IL_1A:
				goto IL_117;
				Block_4:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_117:
				return false;
			}

			// Token: 0x0600632B RID: 25387 RVA: 0x00DC1A70 File Offset: 0x00DBFC70
			internal static bool yFDTx0pk2d48IRDttBjZ()
			{
				return true;
			}

			// Token: 0x0600632C RID: 25388 RVA: 0x00DC1A74 File Offset: 0x00DBFC74
			internal static bool OKuMSKpk8BaAEBKkDalb()
			{
				return false;
			}

			// Token: 0x040072D0 RID: 29392
			internal TitleGui $self_$36357;
		}
	}
}
