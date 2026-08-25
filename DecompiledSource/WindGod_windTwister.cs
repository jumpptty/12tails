using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000462 RID: 1122
[Serializable]
public class WindGod_windTwister : MonoBehaviour
{
	// Token: 0x06001A0E RID: 6670 RVA: 0x002A1F08 File Offset: 0x002A0108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WindGod_windTwister()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x002A1F18 File Offset: 0x002A0118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, float nLife, int nID)
	{
		if (163142 - 301971 != -138829)
		{
		}
		for (;;)
		{
			IL_EB:
			this.eJn2LMp2eA = nOwner;
			if (281214 - 492928 != -211713)
			{
				this.N5L2NZiDaT = Time.time + nLife;
				if (282239 - 516490 == -234251)
				{
					if (this.eJn2LMp2eA)
					{
						if (98464 - 237670 != -139206)
						{
							continue;
						}
						this.CDS2wowuBo = (CharacterControl)this.eJn2LMp2eA.GetComponent(typeof(CharacterControl));
						if (263986 - 362467 == -98480)
						{
							continue;
						}
					}
					if (!this.CDS2wowuBo)
					{
						if (155132 - 152832 == 2300)
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (67516 - 422705 == -355189)
							{
								break;
							}
						}
					}
					else
					{
						this.DiC2U5Vm7W = (WindGod_gm)this.eJn2LMp2eA.GetComponent(typeof(WindGod_gm));
						if (59394 - 529734 != -470339)
						{
							this.Tlc2BNj2sF = nID;
							if (27951 - 219131 == -191180)
							{
								if (this.Tlc2BNj2sF != 0)
								{
									if (287501 - 118909 != 168592)
									{
										continue;
									}
									object obj2;
									object obj = obj2 = PhotonClient.ActorNrList[this.Tlc2BNj2sF];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.hXN2Pa8K7h = (GameObject)obj2;
									if (287926 - 405860 != -117934)
									{
										continue;
									}
								}
								if (this.hXN2Pa8K7h)
								{
									if (70087 - 212947 == -142859)
									{
										continue;
									}
									this.rkl2S5F77s = (CharacterControl)this.hXN2Pa8K7h.GetComponent(typeof(CharacterControl));
									if (284015 - 447155 != -163140)
									{
										continue;
									}
								}
								this.gM32E3q8HV = Time.time;
								if (182088 - 319360 != -137271)
								{
									this.rigidbody.velocity = global::Math.rotateH((float)5 * this.eJn2LMp2eA.transform.forward, (float)((this.Tlc2BNj2sF - 1) * 120));
									if (217484 - 103622 != 113863)
									{
										this.rigidbody.drag = (float)2;
										if (99399 - 223252 == -123853)
										{
											GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy")), GameObject.FindGameObjectsWithTag("NPC"));
											if (142109 - 443104 == -300995)
											{
												int i = 0;
												if (146560 - 90495 == 56065)
												{
													GameObject[] array2 = array;
													if (250032 - 105291 == 144741)
													{
														int length = array2.Length;
														if (293094 - 481159 == -188065)
														{
															while (i < length)
															{
																if (array2[i].collider)
																{
																	if (223747 - 374497 != -150750)
																	{
																		goto IL_EB;
																	}
																	Physics.IgnoreCollision(this.gameObject.collider, array2[i].collider);
																	if (125577 - 391577 == -265999)
																	{
																		goto IL_EB;
																	}
																}
																i++;
																if (206205 - 302434 == -96228)
																{
																	goto IL_EB;
																}
															}
															if (279334 - 567003 == -287669)
															{
																this.Yhw2M4UToq = true;
																if (129390 - 255344 != -125953)
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

	// Token: 0x06001A10 RID: 6672 RVA: 0x002A23A0 File Offset: 0x002A05A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (273848 - 17859 != 255990)
		{
		}
		IL_2B2:
		while (this.Yhw2M4UToq)
		{
			if (176491 - 15129 == 161362)
			{
				if (!this.MN32fIIUIG)
				{
					if (this.CDS2wowuBo)
					{
						if (241871 - 137371 != 104500)
						{
							continue;
						}
						if (!this.rkl2S5F77s)
						{
							if (216932 - 211324 == 5609)
							{
								continue;
							}
						}
						else
						{
							if (this.hXN2Pa8K7h)
							{
								if (109959 - 66574 != 43385)
								{
									continue;
								}
								if (this.N5L2NZiDaT >= Time.time)
								{
									if (290686 - 28381 != 262305)
									{
										continue;
									}
									if (this.CDS2wowuBo.hp > 0)
									{
										if (175680 - 18168 == 157513)
										{
											continue;
										}
										if (this.rkl2S5F77s.hp <= 0)
										{
											if (222233 - 282786 != -60553)
											{
												continue;
											}
										}
										else
										{
											if (!this.CDS2wowuBo.isMine)
											{
												break;
											}
											if (144702 - 218914 == -74211)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (251367 - 286980 != -35613)
												{
													continue;
												}
												if (this.DiC2U5Vm7W)
												{
													if (236794 - 69893 == 166902)
													{
														continue;
													}
													this.DiC2U5Vm7W.ActionEvent("RPC_windTwister_move", this.transform.position, this.rigidbody.velocity, this.Tlc2BNj2sF);
													if (98978 - 65606 != 33372)
													{
														continue;
													}
												}
											}
											if (this.gM32E3q8HV > Time.time)
											{
												break;
											}
											if (241697 - 97426 != 144271)
											{
												continue;
											}
											this.gM32E3q8HV = Time.time + 0.35f;
											if (55254 - 68124 != -12870)
											{
												continue;
											}
											int layerMask = 130816 - (1 << this.eJn2LMp2eA.layer) + 2;
											if (8678 - 63009 != -54331)
											{
												continue;
											}
											UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)2, (float)6, layerMask);
											if (108722 - 235849 != -127127)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
											if (169352 - 585313 == -415960)
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
												if (266002 - 260372 != 5630)
												{
													goto IL_2B2;
												}
												this.CDS2wowuBo.hit(1, gameObject, this.CDS2wowuBo.talAdjust(20), 2, 0, 0.5f * global::Math.vFlat(gameObject.transform.position - this.transform.position).normalized);
												if (14276 - 18288 == -4011)
												{
													goto IL_2B2;
												}
												UnityRuntimeServices.Update(enumerator, gameObject);
												if (187095 - 538362 != -351267)
												{
													goto IL_2B2;
												}
											}
											if (70547 - 372390 != -301843)
											{
												continue;
											}
											break;
										}
									}
								}
							}
							this.StartCoroutine_Auto(this.onDestroy());
							if (244770 - 265719 != -20948)
							{
								break;
							}
							continue;
						}
					}
					this.StartCoroutine_Auto(this.onDestroy());
					if (237823 - 372507 != -134684)
					{
						continue;
					}
					return;
				}
				if (53444 - 230680 == -177236)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x002A2808 File Offset: 0x002A0A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (31720 - 446203 != -414483)
		{
		}
		for (;;)
		{
			if (!this.Yhw2M4UToq)
			{
				goto IL_1FC;
			}
			if (248361 - 158941 == 89421)
			{
				continue;
			}
			if (this.MN32fIIUIG)
			{
				goto IL_1FC;
			}
			if (264224 - 168884 != 95340)
			{
				continue;
			}
			this.audio.volume = Mathf.Clamp(this.audio.volume + Time.deltaTime, (float)0, 0.6f);
			if (173497 - 417744 != -244247)
			{
				continue;
			}
			IL_2CA:
			if (!this.CDS2wowuBo)
			{
				if (155039 - 509313 != -354274)
				{
					continue;
				}
				break;
			}
			else if (this.CDS2wowuBo.isMine)
			{
				if (24062 - 579384 != -555322)
				{
					continue;
				}
				if (this.hXN2Pa8K7h)
				{
					if (75624 - 55221 == 20404)
					{
						continue;
					}
					Vector3 vector = global::Math.vFlat(this.hXN2Pa8K7h.transform.position - this.transform.position);
					if (167395 - 330401 == -163005)
					{
						continue;
					}
					Vector3 normalized = vector.normalized;
					if (290550 - 433409 != -142859)
					{
						continue;
					}
					if (normalized != Vector3.zero)
					{
						if (90516 - 462548 != -372032)
						{
							continue;
						}
						this.rigidbody.AddForce((float)10 * normalized.normalized);
						if (109957 - 592642 == -482684)
						{
							continue;
						}
					}
				}
				Vector3 velocity = this.rigidbody.velocity;
				if (162017 - 267413 != -105396)
				{
					continue;
				}
				if (velocity.magnitude > (float)50)
				{
					if (92860 - 486592 == -393731)
					{
						continue;
					}
					this.rigidbody.velocity = (float)50 * this.rigidbody.velocity.normalized;
					if (132146 - 496609 == -364462)
					{
						continue;
					}
				}
				Vector3 a = global::Math.vFlat(this.transform.position - this.eJn2LMp2eA.transform.position);
				if (209807 - 521063 != -311256)
				{
					continue;
				}
				if (a.sqrMagnitude <= (float)900)
				{
					break;
				}
				if (159177 - 291216 == -132038)
				{
					continue;
				}
				this.rigidbody.AddForce((float)-10 * a);
				if (265008 - 454724 != -189715)
				{
					break;
				}
				continue;
			}
			else
			{
				Vector3 vector2 = global::Math.vFlat(this.nPosition - this.transform.position);
				if (273456 - 47112 != 226344)
				{
					continue;
				}
				if (vector2.sqrMagnitude <= 0.1f)
				{
					break;
				}
				if (220696 - 372750 != -152054)
				{
					continue;
				}
				this.rigidbody.AddForce((float)10 * vector2.normalized);
				if (160598 - 399921 != -239322)
				{
					break;
				}
				continue;
			}
			IL_1FC:
			if (!this.MN32fIIUIG)
			{
				goto IL_2CA;
			}
			if (210438 - 185885 == 24553)
			{
				this.audio.volume = Mathf.Clamp(this.audio.volume - Time.deltaTime, (float)0, 0.6f);
				if (208143 - 364714 != -156570)
				{
					goto IL_2CA;
				}
			}
		}
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x002A2C40 File Offset: 0x002A0E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMove(Vector3 nPos, Vector3 nDir)
	{
		this.nPosition = nPos;
		this.nVelocity = nDir;
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x002A2C50 File Offset: 0x002A0E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDestroy()
	{
		return new WindGod_windTwister.$onDestroy$19731(this).GetEnumerator();
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x002A2C60 File Offset: 0x002A0E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x002A2C64 File Offset: 0x002A0E64
	internal static bool JD1gqP6XxlkBPIH8bdk()
	{
		return true;
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x002A2C68 File Offset: 0x002A0E68
	internal static bool ifbMWs6Q1ybByRdHKdR()
	{
		return false;
	}

	// Token: 0x04001649 RID: 5705
	private bool Yhw2M4UToq;

	// Token: 0x0400164A RID: 5706
	private bool MN32fIIUIG;

	// Token: 0x0400164B RID: 5707
	private GameObject eJn2LMp2eA;

	// Token: 0x0400164C RID: 5708
	private CharacterControl CDS2wowuBo;

	// Token: 0x0400164D RID: 5709
	private WindGod_gm DiC2U5Vm7W;

	// Token: 0x0400164E RID: 5710
	private float N5L2NZiDaT;

	// Token: 0x0400164F RID: 5711
	private float gM32E3q8HV;

	// Token: 0x04001650 RID: 5712
	private GameObject hXN2Pa8K7h;

	// Token: 0x04001651 RID: 5713
	private CharacterControl rkl2S5F77s;

	// Token: 0x04001652 RID: 5714
	private int Tlc2BNj2sF;

	// Token: 0x04001653 RID: 5715
	public Vector3 nPosition;

	// Token: 0x04001654 RID: 5716
	public Vector3 nVelocity;

	// Token: 0x02000463 RID: 1123
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDestroy$19731 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A17 RID: 6679 RVA: 0x002A2C6C File Offset: 0x002A0E6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDestroy$19731(WindGod_windTwister self_)
		{
			if (142909 - 288176 != -145266)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22406 - 568944 == -546538)
				{
					base..ctor();
					if (174146 - 264678 != -90531)
					{
						this.$self_$19733 = self_;
						if (284323 - 417121 != -132797)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x002A2D04 File Offset: 0x002A0F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_windTwister.$onDestroy$19731.$(this.$self_$19733);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x002A2D14 File Offset: 0x002A0F14
		internal static bool fXSqQb6kk0046TByKDw()
		{
			return true;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x002A2D18 File Offset: 0x002A0F18
		internal static bool Bv9Me16G8YTWNLFeODD()
		{
			return false;
		}

		// Token: 0x04001655 RID: 5717
		internal WindGod_windTwister $self_$19733;

		// Token: 0x02000464 RID: 1124
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A1B RID: 6683 RVA: 0x002A2D1C File Offset: 0x002A0F1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(WindGod_windTwister self_)
			{
				if (246490 - 300992 != -54502)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150786 - 541836 == -391050)
					{
						base..ctor();
						if (298126 - 81934 != 216193)
						{
							this.$self_$19732 = self_;
							if (112378 - 352298 == -239920)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001A1C RID: 6684 RVA: 0x002A2DB4 File Offset: 0x002A0FB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89783 - 155107 != -65324)
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
						UnityEngine.Object.Destroy(this.$self_$19732.gameObject);
						if (138294 - 43279 == 95016)
						{
							continue;
						}
						this.YieldDefault(1);
						if (296919 - 368668 != -71748)
						{
							goto Block_7;
						}
						continue;
					default:
						if (185838 - 148208 == 37631)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19732.MN32fIIUIG)
					{
						if (215342 - 300126 != -84783)
						{
							break;
						}
					}
					else
					{
						this.$self_$19732.MN32fIIUIG = true;
						if (36304 - 438905 != -402600)
						{
							this.$self_$19732.animation.Play("destroy");
							if (1266 - 472327 != -471060)
							{
								this.$self_$19732.animation.wrapMode = WrapMode.Once;
								if (137998 - 491837 != -353838)
								{
									goto Block_8;
								}
							}
						}
					}
				}
				Block_7:
				goto IL_15D;
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_15D:
				return false;
			}

			// Token: 0x06001A1D RID: 6685 RVA: 0x002A2F30 File Offset: 0x002A1130
			internal static bool diBk3N6HcaybSqEmwhn()
			{
				return true;
			}

			// Token: 0x06001A1E RID: 6686 RVA: 0x002A2F34 File Offset: 0x002A1134
			internal static bool AYmxku6Wtm2jgggGAUK()
			{
				return false;
			}

			// Token: 0x04001656 RID: 5718
			internal WindGod_windTwister $self_$19732;
		}
	}
}
