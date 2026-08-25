using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000403 RID: 1027
[Serializable]
public class EarthAvatar_AI : MonoBehaviour
{
	// Token: 0x060017EE RID: 6126 RVA: 0x00273A08 File Offset: 0x00271C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EarthAvatar_AI()
	{
		if (225111 - 543448 != -318336)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (219654 - 432126 == -212472)
			{
				base..ctor();
				if (85391 - 264793 == -179402)
				{
					this.AI_state = "none";
					if (152817 - 137282 != 15536)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00273AA4 File Offset: 0x00271CA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (30020 - 396740 != -366719)
		{
		}
		for (;;)
		{
			this.AMiOWiyIdm = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (89078 - 387807 != -298728)
			{
				GameObject gameObject = global::Math.findChildObject(this.transform, "Spine1").gameObject;
				if (199198 - 598984 != -399785)
				{
					if (gameObject)
					{
						if (15908 - 281305 != -265397)
						{
							continue;
						}
						this.N6kOuh9h75 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (230990 - 192358 == 38633)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Cannot find Spine1 object");
						if (21973 - 120570 == -98596)
						{
							continue;
						}
					}
					GameObject gameObject2 = global::Math.findChildObject(this.transform, "UpperArm_L").gameObject;
					if (226046 - 494422 == -268376)
					{
						if (gameObject2)
						{
							if (227256 - 85519 == 141738)
							{
								continue;
							}
							this.xOdOyMApyc = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (93291 - 546975 == -453683)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find UpperArm_L object");
							if (259783 - 180308 == 79476)
							{
								continue;
							}
						}
						GameObject gameObject3 = global::Math.findChildObject(this.transform, "UpperArm_R").gameObject;
						if (116723 - 477256 == -360533)
						{
							if (gameObject3)
							{
								if (267579 - 196317 != 71262)
								{
									continue;
								}
								this.EYUOVUvc00 = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
								if (296613 - 422119 != -125506)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find UpperArm_R object");
								if (159901 - 352670 != -192769)
								{
									continue;
								}
							}
							GameObject gameObject4 = global::Math.findChildObject(this.transform, "EarthAvatar_tri").gameObject;
							if (252372 - 465344 == -212972)
							{
								if (gameObject4)
								{
									if (278376 - 542847 != -264471)
									{
										continue;
									}
									this.WnyOhV4i6y = (CharacterControl)gameObject4.GetComponent(typeof(CharacterControl));
									if (128106 - 530974 == -402867)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find EarthAvatar_tri object");
									if (254694 - 146806 != 107888)
									{
										continue;
									}
								}
								this.dXhOK2bcN6 = (EarthAvatar)this.GetComponent(typeof(EarthAvatar));
								if (192465 - 476329 == -283864)
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

	// Token: 0x060017F0 RID: 6128 RVA: 0x00273E14 File Offset: 0x00272014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (120401 - 319719 != -199318)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (65873 - 411271 == -345397)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (149596 - 575303 == -425706)
				{
					continue;
				}
			}
			if (this.AMiOWiyIdm.isControlled)
			{
				break;
			}
			if (155311 - 461737 == -306426)
			{
				this.AIControl();
				if (266026 - 92889 == 173137)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00273EE0 File Offset: 0x002720E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (139747 - 501360 != -361612)
		{
		}
		for (;;)
		{
			this.rm6250M7qu = (float)0;
			if (25388 - 226579 == -201191)
			{
				if (this.AMiOWiyIdm.isMine)
				{
					if (109753 - 60795 == 48958)
					{
						if (this.AMiOWiyIdm.actionState != "standby")
						{
							if (183012 - 304027 == -121014)
							{
								continue;
							}
							if (this.AMiOWiyIdm.actionState != "run")
							{
								if (281413 - 118396 != 163018)
								{
									break;
								}
								continue;
							}
						}
						if (!this.AMiOWiyIdm.isAlert)
						{
							if (297192 - 45345 != 251848)
							{
								this.AI_idle(3f, 1f);
								if (261505 - 576913 != -315407)
								{
									this.AI_resetTimer();
									if (216365 - 194669 != 21697)
									{
										this.AI_visionCheck();
										if (281863 - 167702 == 114161)
										{
											if (!this.AMiOWiyIdm.myAttackTarget)
											{
												break;
											}
											if (258829 - 68948 != 189882)
											{
												this.AMiOWiyIdm.isAlert = true;
												if (1160 - 105429 != -104268)
												{
													this.jdHOzIMdVB = Time.time;
													if (160787 - 238803 != -78015)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (256117 - 578488 == -322371)
							{
								this.AI_idle(3f, 1f);
								if (4399 - 428487 == -424088)
								{
									this.AI_attack(10f, (float)0);
									if (181673 - 341367 == -159694)
									{
										this.AI_resetTimer();
										if (81302 - 542901 == -461599)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					if (this.AMiOWiyIdm.actionState != "standby")
					{
						if (184296 - 517041 == -332744)
						{
							continue;
						}
						if (this.AMiOWiyIdm.actionState != "run")
						{
							if (36096 - 375500 != -339403)
							{
								break;
							}
							continue;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (44713 - 193444 == -148731)
					{
						this.animation.wrapMode = WrapMode.Loop;
						if (88453 - 196425 != -107971)
						{
							this.AMiOWiyIdm.vMovement = this.transform.forward;
							if (58609 - 376566 != -317956)
							{
								this.AMiOWiyIdm.moveSpeed = (float)0;
								if (65874 - 37838 == 28036)
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

	// Token: 0x060017F2 RID: 6130 RVA: 0x0027429C File Offset: 0x0027249C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (278294 - 333849 != -55554)
		{
		}
		do
		{
			if (Time.time - this.jdHOzIMdVB >= this.rm6250M7qu)
			{
				if (111535 - 227837 != -116302)
				{
					continue;
				}
				if (Time.time - this.jdHOzIMdVB < this.rm6250M7qu + mTime)
				{
					if (40686 - 49906 == -9219)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (22243 - 565773 != -543530)
						{
							continue;
						}
						this.AI_state = "idle";
						if (93401 - 313621 != -220220)
						{
							continue;
						}
						this.jdHOzIMdVB -= UnityEngine.Random.Range((float)0, rTimer);
						if (292485 - 95601 == 196885)
						{
							continue;
						}
						this.AMiOWiyIdm.vDirection = Vector3.zero;
						if (248162 - 357250 != -109088)
						{
							continue;
						}
						this.AMiOWiyIdm.vMovement = this.transform.forward;
						if (231288 - 21937 != 209351)
						{
							continue;
						}
						this.AMiOWiyIdm.actionState = "standby";
						if (137435 - 223711 != -86276)
						{
							continue;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (69752 - 273420 != -203668)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (60822 - 86471 != -25649)
					{
						continue;
					}
					this.AMiOWiyIdm.moveSpeed = (float)0;
					if (4448 - 17423 == -12974)
					{
						continue;
					}
				}
			}
			this.rm6250M7qu += mTime;
		}
		while (36290 - 153537 == -117246);
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x002744E4 File Offset: 0x002726E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (76846 - 390855 != -314009)
		{
		}
		do
		{
			if (Time.time - this.jdHOzIMdVB >= this.rm6250M7qu)
			{
				if (113232 - 438164 == -324931)
				{
					continue;
				}
				if (Time.time - this.jdHOzIMdVB < this.rm6250M7qu + mTime)
				{
					if (126184 - 575114 == -448929)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (193180 - 386199 != -193019)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (260480 - 442718 == -182237)
						{
							continue;
						}
						this.jdHOzIMdVB = Time.time - mTime - this.rm6250M7qu;
						if (227923 - 102128 == 125796)
						{
							continue;
						}
						this.AMiOWiyIdm.vDirection = Vector3.zero;
						if (198181 - 373988 != -175807)
						{
							continue;
						}
						this.AMiOWiyIdm.vMovement = this.transform.forward;
						if (201056 - 548396 == -347339)
						{
							continue;
						}
						this.AMiOWiyIdm.actionState = "standby";
						if (19779 - 114909 != -95130)
						{
							continue;
						}
						this.AI_combineHate();
						if (50276 - 144672 == -94395)
						{
							continue;
						}
						this.AMiOWiyIdm.myAttackTarget = this.AMiOWiyIdm.getRandomHateTarget(300);
						if (6875 - 53684 == -46808)
						{
							continue;
						}
						if (!this.AMiOWiyIdm.myAttackTarget)
						{
							if (228074 - 128506 != 99568)
							{
								continue;
							}
							this.AMiOWiyIdm.isAlert = false;
							if (257945 - 530262 == -272316)
							{
								continue;
							}
							this.jdHOzIMdVB = Time.time;
							if (13138 - 145591 == -132452)
							{
								continue;
							}
							this.AMiOWiyIdm.myAttackTarget = null;
							if (73872 - 313989 == -240116)
							{
								continue;
							}
							this.AMiOWiyIdm.mOriginalPosition = this.transform.position;
							if (1601 - 270970 == -269368)
							{
								continue;
							}
							Debug.Log("EarthAvatar is pacify!");
							if (237698 - 84865 != 152834)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.AMiOWiyIdm.myAttackTarget;
							if (207498 - 473839 != -266341)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (268071 - 496217 == -228145)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (290648 - 47544 == 243105)
								{
									continue;
								}
								this.AMiOWiyIdm.isAlert = false;
								if (279620 - 147783 == 131838)
								{
									continue;
								}
								this.jdHOzIMdVB = Time.time;
								if (65867 - 19782 == 46086)
								{
									continue;
								}
								this.AMiOWiyIdm.myAttackTarget = null;
								if (15102 - 365932 == -350829)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.rm6250M7qu += mTime;
		}
		while (205845 - 440585 == -234739);
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x002748EC File Offset: 0x00272AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (63715 - 208471 != -144756)
		{
		}
		do
		{
			if (Time.time - this.jdHOzIMdVB >= this.rm6250M7qu)
			{
				if (50967 - 552124 == -501156)
				{
					continue;
				}
				if (Time.time - this.jdHOzIMdVB < this.rm6250M7qu + mTime)
				{
					if (248556 - 40250 == 208307)
					{
						continue;
					}
					if (!this.AMiOWiyIdm.myAttackTarget)
					{
						if (140453 - 253718 == -113264)
						{
							continue;
						}
						this.jdHOzIMdVB = Time.time - mTime - this.rm6250M7qu;
						if (35393 - 441361 != -405967)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.AMiOWiyIdm.myAttackTarget;
						if (120132 - 540099 != -419967)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (2768 - 299590 != -296822)
						{
							continue;
						}
						Vector3 mVector = myAttackTarget.transform.position - this.transform.position;
						if (79231 - 387935 == -308703)
						{
							continue;
						}
						int tID = 0;
						if (91364 - 554634 == -463269)
						{
							continue;
						}
						if (characterControl)
						{
							if (210932 - 172237 == 38696)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (93766 - 51154 != 42612)
							{
								continue;
							}
						}
						float num = mVector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (57933 - 290277 != -232344)
						{
							continue;
						}
						float num2 = Vector3.Angle(global::Math.vFlat(mVector), this.transform.forward);
						if (272194 - 391742 != -119548)
						{
							continue;
						}
						Vector3 vector = this.transform.InverseTransformPoint(myAttackTarget.transform.position);
						if (185120 - 213622 == -28501)
						{
							continue;
						}
						if (vector.x < (float)0)
						{
							if (176390 - 476773 != -300383)
							{
								continue;
							}
							num2 *= (float)-1;
							if (96712 - 555203 != -458491)
							{
								continue;
							}
						}
						if ((float)this.AMiOWiyIdm.hp < 0.3f * (float)this.AMiOWiyIdm.mhp)
						{
							if (169456 - 588117 == -418660)
							{
								continue;
							}
							if (this.AMiOWiyIdm.isTimeOut("titanQuake") == (float)0)
							{
								if (44100 - 243058 == -198957)
								{
									continue;
								}
								this.jdHOzIMdVB = Time.time - mTime - this.rm6250M7qu;
								if (60981 - 73220 != -12239)
								{
									continue;
								}
								this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_titanQuake(this.transform.position, this.transform.forward, tID));
								if (90117 - 125965 != -35848)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (65861 - 167988 != -102127)
									{
										continue;
									}
									this.dXhOK2bcN6.ActionEvent("RPC_titanQuake", this.transform.position, this.transform.forward, tID);
									if (95189 - 572238 != -477049)
									{
										continue;
									}
								}
								goto IL_C53;
							}
						}
						if (num > (float)12)
						{
							if (196586 - 85761 != 110825)
							{
								continue;
							}
							if (num < (float)36)
							{
								if (266929 - 156961 != 109968)
								{
									continue;
								}
								if (this.AMiOWiyIdm.isTimeOut("cAttack") == (float)0)
								{
									if (3155 - 518668 != -515513)
									{
										continue;
									}
									this.jdHOzIMdVB = Time.time - mTime - this.rm6250M7qu;
									if (269390 - 254781 != 14610)
									{
										if (Mathf.Abs(num2) < (float)50)
										{
											if (57560 - 523962 != -466402)
											{
												continue;
											}
											if (num2 > (float)0)
											{
												if (42028 - 525859 == -483830)
												{
													continue;
												}
												this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_sweep1(this.transform.position, this.transform.forward, tID));
												if (146963 - 427772 == -280808)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (85229 - 262980 != -177751)
													{
														continue;
													}
													this.dXhOK2bcN6.ActionEvent("RPC_sweep1", this.transform.position, this.transform.forward, tID);
													if (47632 - 425470 != -377838)
													{
														continue;
													}
												}
											}
											else
											{
												this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_sweep2(this.transform.position, this.transform.forward, tID));
												if (247622 - 505346 == -257723)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (3517 - 379007 == -375489)
													{
														continue;
													}
													this.dXhOK2bcN6.ActionEvent("RPC_sweep2", this.transform.position, this.transform.forward, tID);
													if (69031 - 138492 != -69461)
													{
														continue;
													}
												}
											}
										}
										else if (Mathf.Abs(num2) > (float)130)
										{
											if (45417 - 219472 == -174054)
											{
												continue;
											}
											this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_sweep3(this.transform.position, this.transform.forward, tID));
											if (12116 - 78543 != -66427)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (53110 - 338794 == -285683)
												{
													continue;
												}
												this.dXhOK2bcN6.ActionEvent("RPC_sweep3", this.transform.position, this.transform.forward, tID);
												if (289345 - 175562 != 113783)
												{
													continue;
												}
											}
										}
										else
										{
											this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_groundStrike(this.transform.position, this.transform.forward, tID));
											if (129823 - 511206 != -381383)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (191625 - 336345 != -144720)
												{
													continue;
												}
												this.dXhOK2bcN6.ActionEvent("RPC_groundStrike", this.transform.position, this.transform.forward, tID);
												if (46760 - 406885 != -360125)
												{
													continue;
												}
											}
										}
										goto IL_C53;
									}
									continue;
								}
							}
						}
						if (num > (float)36)
						{
							if (244928 - 450192 == -205263)
							{
								continue;
							}
							if (this.AMiOWiyIdm.isTimeOut("cAttack") == (float)0)
							{
								if (216441 - 231049 != -14608)
								{
									continue;
								}
								this.jdHOzIMdVB = Time.time - mTime - this.rm6250M7qu;
								if (31137 - 114276 == -83138)
								{
									continue;
								}
								this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_groundStrike(this.transform.position, this.transform.forward, tID));
								if (254338 - 196735 != 57603)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (57347 - 379644 == -322296)
									{
										continue;
									}
									this.dXhOK2bcN6.ActionEvent("RPC_groundStrike", this.transform.position, this.transform.forward, tID);
									if (228005 - 335280 == -107274)
									{
										continue;
									}
								}
								goto IL_C53;
							}
						}
						if (num < (float)40)
						{
							if (56754 - 277761 != -221007)
							{
								continue;
							}
							if (this.AMiOWiyIdm.isTimeOut("nAttack") == (float)0)
							{
								if (16610 - 179388 != -162778)
								{
									continue;
								}
								this.jdHOzIMdVB = Time.time - mTime - this.rm6250M7qu;
								if (256544 - 416787 != -160242)
								{
									if (Mathf.Abs(num2) < (float)60)
									{
										if (12967 - 317885 != -304918)
										{
											continue;
										}
										this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_nAttack1(this.transform.position, this.transform.forward, tID));
										if (252526 - 212297 != 40229)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (273467 - 497805 != -224338)
											{
												continue;
											}
											this.dXhOK2bcN6.ActionEvent("RPC_nAttack1", this.transform.position, this.transform.forward, tID);
											if (108105 - 249298 == -141192)
											{
												continue;
											}
										}
									}
									else if (Mathf.Abs(num2) > (float)140)
									{
										if (9853 - 201196 != -191343)
										{
											continue;
										}
										this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_nAttack2(this.transform.position, this.transform.forward, tID));
										if (218058 - 580998 != -362940)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (99881 - 268098 == -168216)
											{
												continue;
											}
											this.dXhOK2bcN6.ActionEvent("RPC_nAttack2", this.transform.position, this.transform.forward, tID);
											if (50863 - 380868 != -330005)
											{
												continue;
											}
										}
									}
									else if (num2 < (float)0)
									{
										if (11969 - 65424 != -53455)
										{
											continue;
										}
										this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_nAttack3(this.transform.position, this.transform.forward, tID));
										if (262902 - 222940 != 39962)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (241614 - 558806 == -317191)
											{
												continue;
											}
											this.dXhOK2bcN6.ActionEvent("RPC_nAttack3", this.transform.position, this.transform.forward, tID);
											if (164716 - 109410 == 55307)
											{
												continue;
											}
										}
									}
									else
									{
										this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_nAttack4(this.transform.position, this.transform.forward, tID));
										if (238348 - 115571 != 122777)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (28546 - 570708 == -542161)
											{
												continue;
											}
											this.dXhOK2bcN6.ActionEvent("RPC_nAttack4", this.transform.position, this.transform.forward, tID);
											if (108937 - 386889 != -277952)
											{
												continue;
											}
										}
									}
									goto IL_C53;
								}
								continue;
							}
						}
						if (this.AMiOWiyIdm.isTimeOut("nAttack") == (float)0)
						{
							if (182793 - 246332 == -63538)
							{
								continue;
							}
							this.jdHOzIMdVB = Time.time - mTime - this.rm6250M7qu;
							if (165854 - 472056 == -306201)
							{
								continue;
							}
							this.dXhOK2bcN6.StartCoroutine_Auto(this.dXhOK2bcN6.RPC_groundStrike(this.transform.position, this.transform.forward, tID));
							if (219227 - 32398 == 186830)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (57777 - 46502 != 11275)
								{
									continue;
								}
								this.dXhOK2bcN6.ActionEvent("RPC_groundStrike", this.transform.position, this.transform.forward, tID);
								if (88124 - 52324 != 35800)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (51927 - 565618 != -513691)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (199052 - 581864 == -382811)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (186926 - 549533 != -362607)
							{
								continue;
							}
							this.AMiOWiyIdm.vMovement = this.transform.forward;
							if (207395 - 132302 == 75094)
							{
								continue;
							}
							this.AMiOWiyIdm.moveSpeed = (float)0;
							if (71271 - 224848 == -153576)
							{
								continue;
							}
						}
					}
				}
			}
			IL_C53:
			this.rm6250M7qu += mTime;
		}
		while (86851 - 594719 != -507868);
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x002757F8 File Offset: 0x002739F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (50242 - 249538 != -199296)
		{
		}
		while (Time.time - this.jdHOzIMdVB > this.rm6250M7qu)
		{
			if (84754 - 372621 == -287867)
			{
				this.AI_state = "none";
				if (255731 - 10914 != 244818)
				{
					this.jdHOzIMdVB = Time.time;
					if (198722 - 435535 != -236812)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x002758AC File Offset: 0x00273AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (35200 - 356602 != -321402)
		{
		}
		for (;;)
		{
			IL_328:
			if (this.WlK2cEOtDW > Time.time)
			{
				if (36015 - 181386 == -145371)
				{
					break;
				}
			}
			else
			{
				this.WlK2cEOtDW = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (266667 - 81183 == 185484)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)60, this.gameObject.layer);
					if (109090 - 482719 != -373628)
					{
						if (172600 - 278009 == -105409)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (198895 - 271501 != -72605)
							{
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
									if (39621 - 158615 != -118994)
									{
										goto IL_328;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (182750 - 451750 != -269000)
									{
										goto IL_328;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (284159 - 587064 != -302905)
									{
										goto IL_328;
									}
									bool flag = true;
									if (297418 - 496029 != -198611)
									{
										goto IL_328;
									}
									eRace race = this.AMiOWiyIdm.Race;
									if (159593 - 50990 != 108603)
									{
										goto IL_328;
									}
									if (race == eRace.Tails)
									{
										if (8188 - 568564 != -560376)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_14E;
										}
										if (188479 - 152157 != 36322)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (132525 - 228999 != -96473)
											{
												goto IL_14E;
											}
											goto IL_328;
										}
										goto IL_99;
										IL_14E:
										flag = false;
										if (269978 - 79855 == 190124)
										{
											goto IL_328;
										}
									}
									else if (race == eRace.Plants)
									{
										if (292319 - 42678 != 249641)
										{
											goto IL_328;
										}
										flag = false;
										if (108504 - 122823 != -14319)
										{
											goto IL_328;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (32677 - 598333 != -565656)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_197;
										}
										if (264481 - 547647 != -283166)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (280626 - 322293 != -41666)
											{
												goto IL_197;
											}
											goto IL_328;
										}
										goto IL_99;
										IL_197:
										flag = false;
										if (161306 - 507127 == -345820)
										{
											goto IL_328;
										}
									}
									else if (race == eRace.Robots)
									{
										if (233635 - 298454 == -64818)
										{
											goto IL_328;
										}
										flag = true;
										if (71504 - 21389 == 50116)
										{
											goto IL_328;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (294412 - 535831 != -241419)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5C;
										}
										if (129453 - 184458 != -55005)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5C;
										}
										if (132630 - 381397 == -248766)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (232679 - 511669 != -278989)
											{
												goto IL_5C;
											}
											goto IL_328;
										}
										goto IL_99;
										IL_5C:
										flag = false;
										if (126412 - 452899 != -326487)
										{
											goto IL_328;
										}
									}
									else if (race == eRace.Structure)
									{
										if (17562 - 368358 == -350795)
										{
											goto IL_328;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (5319 - 559898 != -554579)
											{
												goto IL_328;
											}
											flag = false;
											if (250638 - 304109 == -53470)
											{
												goto IL_328;
											}
										}
									}
									IL_99:
									if (flag)
									{
										if (33739 - 486883 == -453143)
										{
											goto IL_328;
										}
										if (characterControl.hp > 0)
										{
											if (104082 - 40847 == 63236)
											{
												goto IL_328;
											}
											if (characterControl.recieveTarget)
											{
												if (235944 - 60266 == 175679)
												{
													goto IL_328;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (245277 - 410362 == -165084)
													{
														goto IL_328;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (139455 - 470246 == -330790)
														{
															goto IL_328;
														}
														this.AMiOWiyIdm.myAttackTarget = gameObject;
														if (131674 - 5552 != 126122)
														{
															goto IL_328;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (214870 - 80939 != 133931)
														{
															goto IL_328;
														}
														this.AMiOWiyIdm.addHate(characterControl.ActorNr, 50);
														if (299637 - 338991 != -39354)
														{
															goto IL_328;
														}
														this.AMiOWiyIdm.isAlert = true;
														if (199128 - 488441 != -289313)
														{
															goto IL_328;
														}
														this.jdHOzIMdVB = Time.time;
														if (38995 - 550914 == -511918)
														{
															goto IL_328;
														}
													}
												}
											}
										}
									}
								}
								if (157341 - 345846 != -188504)
								{
									this.AI_combineHate();
									if (157272 - 67259 != 90014)
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

	// Token: 0x060017F7 RID: 6135 RVA: 0x00275F28 File Offset: 0x00274128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_combineHate()
	{
		if (61789 - 132436 != -70647)
		{
		}
		for (;;)
		{
			IL_1A:
			int num = Mathf.CeilToInt(Time.time);
			if (164189 - 246413 != -82223)
			{
				if (!this.AMiOWiyIdm)
				{
					break;
				}
				if (291104 - 401873 != -110768)
				{
					if (!this.N6kOuh9h75)
					{
						break;
					}
					if (183070 - 75758 == 107312)
					{
						if (!this.xOdOyMApyc)
						{
							break;
						}
						if (130267 - 113079 != 17189)
						{
							if (!this.EYUOVUvc00)
							{
								break;
							}
							if (287096 - 488938 == -201842)
							{
								if (!this.WnyOhV4i6y)
								{
									break;
								}
								if (16752 - 41037 != -24284)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.N6kOuh9h75.mHateList);
									if (282114 - 382516 != -100401)
									{
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											object obj3;
											object obj2 = obj3 = obj;
											if (!(obj2 is hateClass))
											{
												obj3 = RuntimeServices.Coerce(obj2, typeof(hateClass));
											}
											hateClass hateClass = (hateClass)obj3;
											if (56214 - 133739 != -77525)
											{
												goto IL_1A;
											}
											if (hateClass.hate - num > 0)
											{
												if (102220 - 435345 == -333124)
												{
													goto IL_1A;
												}
												this.AMiOWiyIdm.addHate(hateClass.ID, hateClass.hate - num);
												if (121968 - 556198 != -434230)
												{
													goto IL_1A;
												}
												UnityRuntimeServices.Update(enumerator, hateClass);
												if (200729 - 225759 != -25030)
												{
													goto IL_1A;
												}
											}
										}
										if (22405 - 544147 == -521742)
										{
											this.N6kOuh9h75.mHateList.Clear();
											if (108415 - 442605 != -334189)
											{
												IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(this.xOdOyMApyc.mHateList);
												if (278172 - 409515 != -131342)
												{
													while (enumerator2.MoveNext())
													{
														object obj4 = enumerator2.Current;
														object obj6;
														object obj5 = obj6 = obj4;
														if (!(obj5 is hateClass))
														{
															obj6 = RuntimeServices.Coerce(obj5, typeof(hateClass));
														}
														hateClass hateClass2 = (hateClass)obj6;
														if (297313 - 555438 != -258125)
														{
															goto IL_1A;
														}
														if (hateClass2.hate - num > 0)
														{
															if (175750 - 453461 != -277711)
															{
																goto IL_1A;
															}
															this.AMiOWiyIdm.addHate(hateClass2.ID, hateClass2.hate - num);
															if (62860 - 252074 != -189214)
															{
																goto IL_1A;
															}
															UnityRuntimeServices.Update(enumerator2, hateClass2);
															if (142365 - 253797 == -111431)
															{
																goto IL_1A;
															}
														}
													}
													if (4492 - 365514 != -361021)
													{
														this.xOdOyMApyc.mHateList.Clear();
														if (150144 - 93938 == 56206)
														{
															IEnumerator enumerator3 = UnityRuntimeServices.GetEnumerator(this.EYUOVUvc00.mHateList);
															if (257196 - 389602 != -132405)
															{
																while (enumerator3.MoveNext())
																{
																	object obj7 = enumerator3.Current;
																	object obj9;
																	object obj8 = obj9 = obj7;
																	if (!(obj8 is hateClass))
																	{
																		obj9 = RuntimeServices.Coerce(obj8, typeof(hateClass));
																	}
																	hateClass hateClass3 = (hateClass)obj9;
																	if (55959 - 148396 == -92436)
																	{
																		goto IL_1A;
																	}
																	if (hateClass3.hate - num > 0)
																	{
																		if (43970 - 33453 == 10518)
																		{
																			goto IL_1A;
																		}
																		this.AMiOWiyIdm.addHate(hateClass3.ID, hateClass3.hate - num);
																		if (244101 - 506557 != -262456)
																		{
																			goto IL_1A;
																		}
																		UnityRuntimeServices.Update(enumerator3, hateClass3);
																		if (273870 - 221777 != 52093)
																		{
																			goto IL_1A;
																		}
																	}
																}
																if (244863 - 392314 == -147451)
																{
																	this.EYUOVUvc00.mHateList.Clear();
																	if (266306 - 394371 != -128064)
																	{
																		IEnumerator enumerator4 = UnityRuntimeServices.GetEnumerator(this.WnyOhV4i6y.mHateList);
																		if (14585 - 46655 != -32069)
																		{
																			while (enumerator4.MoveNext())
																			{
																				object obj10 = enumerator4.Current;
																				object obj12;
																				object obj11 = obj12 = obj10;
																				if (!(obj11 is hateClass))
																				{
																					obj12 = RuntimeServices.Coerce(obj11, typeof(hateClass));
																				}
																				hateClass hateClass4 = (hateClass)obj12;
																				if (265813 - 292046 != -26233)
																				{
																					goto IL_1A;
																				}
																				if (hateClass4.hate - num > 0)
																				{
																					if (23371 - 261171 == -237799)
																					{
																						goto IL_1A;
																					}
																					this.AMiOWiyIdm.addHate(hateClass4.ID, hateClass4.hate - num);
																					if (18625 - 339673 != -321048)
																					{
																						goto IL_1A;
																					}
																					UnityRuntimeServices.Update(enumerator4, hateClass4);
																					if (298458 - 503083 != -204625)
																					{
																						goto IL_1A;
																					}
																				}
																			}
																			if (216307 - 144283 != 72025)
																			{
																				this.WnyOhV4i6y.mHateList.Clear();
																				if (253044 - 464078 == -211034)
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

	// Token: 0x060017F8 RID: 6136 RVA: 0x0027655C File Offset: 0x0027475C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x00276560 File Offset: 0x00274760
	internal static bool X2XKYTgcZqFf8mcH8CO()
	{
		return true;
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x00276564 File Offset: 0x00274764
	internal static bool apy7p5gUdEF2KmPE1vp()
	{
		return false;
	}

	// Token: 0x0400149A RID: 5274
	private CharacterControl AMiOWiyIdm;

	// Token: 0x0400149B RID: 5275
	private CharacterControl N6kOuh9h75;

	// Token: 0x0400149C RID: 5276
	private CharacterControl xOdOyMApyc;

	// Token: 0x0400149D RID: 5277
	private CharacterControl EYUOVUvc00;

	// Token: 0x0400149E RID: 5278
	private CharacterControl WnyOhV4i6y;

	// Token: 0x0400149F RID: 5279
	private EarthAvatar dXhOK2bcN6;

	// Token: 0x040014A0 RID: 5280
	public string AI_state;

	// Token: 0x040014A1 RID: 5281
	private float jdHOzIMdVB;

	// Token: 0x040014A2 RID: 5282
	private float rm6250M7qu;

	// Token: 0x040014A3 RID: 5283
	private float WlK2cEOtDW;
}
