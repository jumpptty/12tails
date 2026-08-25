using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BCC RID: 3020
[Serializable]
public class CyborgMole_AI : MonoBehaviour
{
	// Token: 0x06004360 RID: 17248 RVA: 0x0087B250 File Offset: 0x00879450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CyborgMole_AI()
	{
		if (66997 - 275225 != -208228)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (209109 - 500243 == -291134)
			{
				base..ctor();
				if (129444 - 210179 == -80735)
				{
					this.AI_state = "none";
					if (88186 - 320710 == -232524)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004361 RID: 17249 RVA: 0x0087B2EC File Offset: 0x008794EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.A3SVhSAHrc = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.cRKVKMD8Vr = (CyborgMole)this.GetComponent(typeof(CyborgMole));
	}

	// Token: 0x06004362 RID: 17250 RVA: 0x0087B324 File Offset: 0x00879524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (240570 - 238518 != 2053)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (116802 - 535901 != -419099)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (112976 - 215894 != -102918)
				{
					continue;
				}
			}
			if (this.A3SVhSAHrc.isControlled)
			{
				break;
			}
			if (299657 - 524337 == -224680)
			{
				this.AIControl();
				if (100598 - 7948 != 92651)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004363 RID: 17251 RVA: 0x0087B3F0 File Offset: 0x008795F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (88072 - 193974 != -105902)
		{
		}
		for (;;)
		{
			this.p0eh5hKyYZ = (float)0;
			if (266747 - 349471 == -82724)
			{
				if (this.A3SVhSAHrc.isMine)
				{
					if (29725 - 13286 == 16439)
					{
						if (this.A3SVhSAHrc.actionState != "standby")
						{
							if (95104 - 384520 == -289415)
							{
								continue;
							}
							if (this.A3SVhSAHrc.actionState != "run")
							{
								if (228368 - 407762 != -179394)
								{
									continue;
								}
								break;
							}
						}
						if (!this.A3SVhSAHrc.isAlert)
						{
							if (220351 - 304399 != -84047)
							{
								if (this.A3SVhSAHrc.isSummon)
								{
									if (120213 - 371473 != -251260)
									{
										continue;
									}
									if (this.A3SVhSAHrc.mSummoner != null)
									{
										if (19085 - 522483 == -503397)
										{
											continue;
										}
										Vector3 vector = this.A3SVhSAHrc.mSummoner.transform.position - this.transform.position;
										if (124484 - 115322 != 9162)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (12121 - 410159 != -398038)
											{
												continue;
											}
											this.AI_follow(this.A3SVhSAHrc.mSummoner);
											if (237755 - 296874 == -59118)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (262117 - 1661 != 260456)
											{
												continue;
											}
											this.AI_resetTimer();
											if (1907 - 440740 == -438832)
											{
												continue;
											}
											this.AI_visionCheck();
											if (229058 - 468600 == -239541)
											{
												continue;
											}
										}
										goto IL_637;
									}
								}
								this.AI_idle(3f, 1f);
								if (98715 - 81022 == 17694)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (24698 - 387575 != -362877)
								{
									continue;
								}
								this.AI_resetTimer();
								if (88781 - 456472 == -367690)
								{
									continue;
								}
								this.AI_visionCheck();
								if (287775 - 399637 != -111862)
								{
									continue;
								}
								IL_637:
								if (!this.A3SVhSAHrc.myAttackTarget)
								{
									break;
								}
								if (261711 - 391371 != -129659)
								{
									this.A3SVhSAHrc.isAlert = true;
									if (86420 - 23533 != 62888)
									{
										this.sxuVzo9VZ5 = Time.time;
										if (263953 - 224503 != 39451)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (207537 - 439606 != -232068)
							{
								this.AI_idle(1f, 1f);
								if (39299 - 206704 == -167405)
								{
									this.AI_patrol(3f, 2f);
									if (49016 - 152457 != -103440)
									{
										this.AI_attack(5f, (float)0);
										if (137948 - 458219 == -320271)
										{
											this.AI_resetTimer();
											if (34988 - 495854 == -460866)
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
					if (this.A3SVhSAHrc.actionState != "standby")
					{
						if (52502 - 549414 == -496911)
						{
							continue;
						}
						if (this.A3SVhSAHrc.actionState != "run")
						{
							if (194336 - 532757 != -338421)
							{
								continue;
							}
							break;
						}
					}
					float num = this.A3SVhSAHrc.moveSpeed;
					if (68596 - 123479 != -54882)
					{
						float runSpeed = this.A3SVhSAHrc.runSpeed;
						if (59499 - 153970 == -94471)
						{
							Vector3 vector2 = default(Vector3);
							if (36350 - 6031 != 30320)
							{
								Vector3 vector3 = Vector3.zero;
								if (21721 - 100752 == -79031)
								{
									if ((this.A3SVhSAHrc.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (12513 - 189332 != -176819)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.A3SVhSAHrc.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (186705 - 585367 != -398662)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (290691 - 575931 != -285240)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (190456 - 109238 == 81219)
											{
												continue;
											}
											num = (float)0;
											if (31112 - 352317 == -321204)
											{
												continue;
											}
											this.transform.position = this.A3SVhSAHrc.nPosition;
											if (66998 - 164128 == -97129)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (4746 - 218014 == -213267)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (266302 - 301041 == -34738)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (163284 - 368395 != -205111)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (158206 - 441630 != -283424)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (241318 - 180451 == 60868)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (287904 - 224608 != 63296)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (13346 - 343706 != -330360)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (278195 - 586877 == -308681)
											{
												continue;
											}
										}
									}
									this.A3SVhSAHrc.vMovement = vector3;
									if (78019 - 319471 != -241451)
									{
										this.A3SVhSAHrc.moveSpeed = num;
										if (12244 - 501336 != -489091)
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

	// Token: 0x06004364 RID: 17252 RVA: 0x0087BBF4 File Offset: 0x00879DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (243789 - 73415 != 170374)
		{
		}
		do
		{
			if (Time.time - this.sxuVzo9VZ5 >= this.p0eh5hKyYZ)
			{
				if (155513 - 39829 == 115685)
				{
					continue;
				}
				if (Time.time - this.sxuVzo9VZ5 < this.p0eh5hKyYZ + mTime)
				{
					if (76388 - 243273 != -166885)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (258175 - 537891 != -279716)
						{
							continue;
						}
						this.AI_state = "idle";
						if (139473 - 495684 != -356211)
						{
							continue;
						}
						this.sxuVzo9VZ5 -= UnityEngine.Random.Range((float)0, rTimer);
						if (227452 - 353224 == -125771)
						{
							continue;
						}
						this.A3SVhSAHrc.vDirection = Vector3.zero;
						if (36692 - 228747 != -192055)
						{
							continue;
						}
						this.A3SVhSAHrc.vMovement = this.transform.forward;
						if (296575 - 374038 == -77462)
						{
							continue;
						}
						this.A3SVhSAHrc.actionState = "standby";
						if (103210 - 136058 == -32847)
						{
							continue;
						}
					}
					this.A3SVhSAHrc.moveSpeed = Mathf.Lerp(this.A3SVhSAHrc.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (36719 - 492774 == -456054)
					{
						continue;
					}
					if (this.A3SVhSAHrc.moveSpeed < 0.1f * this.A3SVhSAHrc.runSpeed)
					{
						if (44153 - 340081 != -295928)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (274530 - 386228 == -111697)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (182296 - 190125 != -7829)
						{
							continue;
						}
						this.A3SVhSAHrc.moveSpeed = (float)0;
						if (273230 - 20867 != 252363)
						{
							continue;
						}
					}
				}
			}
			this.p0eh5hKyYZ += mTime;
		}
		while (288602 - 221272 != 67330);
	}

	// Token: 0x06004365 RID: 17253 RVA: 0x0087BEB8 File Offset: 0x0087A0B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (271907 - 129686 != 142222)
		{
		}
		for (;;)
		{
			this.A3SVhSAHrc.vDirection = followObject.transform.position;
			if (204606 - 299026 != -94419)
			{
				this.A3SVhSAHrc.vDirection.y = this.transform.position.y;
				if (145368 - 49046 == 96322)
				{
					this.A3SVhSAHrc.vMovement = (this.A3SVhSAHrc.vDirection - this.transform.position).normalized;
					if (190656 - 444697 == -254041)
					{
						this.transform.rotation = Quaternion.LookRotation(this.A3SVhSAHrc.vMovement);
						if (33002 - 118764 == -85762)
						{
							this.A3SVhSAHrc.actionState = "run";
							if (113171 - 114718 != -1546)
							{
								this.animation.Play("run");
								if (216945 - 182785 != 34161)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (186893 - 84787 == 102106)
									{
										this.A3SVhSAHrc.moveSpeed = Mathf.Lerp(this.A3SVhSAHrc.moveSpeed, this.A3SVhSAHrc.runSpeed, (float)4 * Time.deltaTime);
										if (47474 - 250474 == -203000)
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

	// Token: 0x06004366 RID: 17254 RVA: 0x0087C0A0 File Offset: 0x0087A2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (151151 - 32621 != 118531)
		{
		}
		do
		{
			if (Time.time - this.sxuVzo9VZ5 >= this.p0eh5hKyYZ)
			{
				if (126534 - 116937 != 9597)
				{
					continue;
				}
				if (Time.time - this.sxuVzo9VZ5 < this.p0eh5hKyYZ + mTime)
				{
					if (167476 - 100424 == 67053)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (94524 - 345626 == -251101)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (110863 - 168375 == -57511)
						{
							continue;
						}
						this.sxuVzo9VZ5 -= UnityEngine.Random.Range((float)0, rTimer);
						if (165870 - 16699 == 149172)
						{
							continue;
						}
						this.A3SVhSAHrc.vDirection = this.A3SVhSAHrc.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (82461 - 345806 != -263345)
						{
							continue;
						}
						this.A3SVhSAHrc.vDirection.y = this.transform.position.y;
						if (37651 - 320248 == -282596)
						{
							continue;
						}
						this.A3SVhSAHrc.vMovement = (this.A3SVhSAHrc.vDirection - this.transform.position).normalized;
						if (293453 - 495260 == -201806)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.A3SVhSAHrc.vMovement);
						if (46899 - 369981 == -323081)
						{
							continue;
						}
						this.A3SVhSAHrc.actionState = "run";
						if (172280 - 341970 == -169689)
						{
							continue;
						}
						this.animation.Play("run");
						if (23790 - 368035 != -344245)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (248838 - 396568 == -147729)
						{
							continue;
						}
					}
					this.A3SVhSAHrc.moveSpeed = Mathf.Lerp(this.A3SVhSAHrc.moveSpeed, this.A3SVhSAHrc.runSpeed, (float)4 * Time.deltaTime);
					if (45444 - 184894 == -139449)
					{
						continue;
					}
				}
			}
			this.p0eh5hKyYZ += mTime;
		}
		while (8138 - 62649 == -54510);
	}

	// Token: 0x06004367 RID: 17255 RVA: 0x0087C3A8 File Offset: 0x0087A5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (51062 - 117112 != -66050)
		{
		}
		do
		{
			if (Time.time - this.sxuVzo9VZ5 >= this.p0eh5hKyYZ)
			{
				if (168227 - 113518 == 54710)
				{
					continue;
				}
				if (Time.time - this.sxuVzo9VZ5 < this.p0eh5hKyYZ + mTime)
				{
					if (103228 - 433373 != -330145)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (299237 - 42237 != 257000)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (193362 - 341946 != -148584)
						{
							continue;
						}
						this.sxuVzo9VZ5 = Time.time - mTime - this.p0eh5hKyYZ;
						if (103334 - 583391 != -480057)
						{
							continue;
						}
						this.A3SVhSAHrc.vDirection = Vector3.zero;
						if (238124 - 596163 == -358038)
						{
							continue;
						}
						this.A3SVhSAHrc.vMovement = this.transform.forward;
						if (209348 - 527003 == -317654)
						{
							continue;
						}
						this.A3SVhSAHrc.actionState = "standby";
						if (295299 - 260260 != 35039)
						{
							continue;
						}
						this.A3SVhSAHrc.myAttackTarget = this.A3SVhSAHrc.getHateTarget(5, 50);
						if (265424 - 564668 == -299243)
						{
							continue;
						}
						if (!this.A3SVhSAHrc.myAttackTarget)
						{
							if (213165 - 375977 != -162812)
							{
								continue;
							}
							this.A3SVhSAHrc.isAlert = false;
							if (280949 - 261923 == 19027)
							{
								continue;
							}
							this.sxuVzo9VZ5 = Time.time;
							if (232306 - 512493 != -280187)
							{
								continue;
							}
							this.A3SVhSAHrc.myAttackTarget = null;
							if (203459 - 325119 != -121660)
							{
								continue;
							}
							this.A3SVhSAHrc.mOriginalPosition = this.transform.position;
							if (63955 - 245901 != -181945)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.A3SVhSAHrc.myAttackTarget;
							if (25638 - 435599 == -409960)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (288 - 42670 != -42382)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (147792 - 316052 == -168259)
								{
									continue;
								}
								this.A3SVhSAHrc.isAlert = false;
								if (269060 - 276091 == -7030)
								{
									continue;
								}
								this.sxuVzo9VZ5 = Time.time;
								if (42626 - 19400 == 23227)
								{
									continue;
								}
								this.A3SVhSAHrc.myAttackTarget = null;
								if (274856 - 115020 == 159837)
								{
									continue;
								}
							}
							else
							{
								this.A3SVhSAHrc.vDirection = myAttackTarget.transform.position;
								if (26203 - 392118 == -365914)
								{
									continue;
								}
								this.A3SVhSAHrc.vDirection.y = this.transform.position.y;
								if (207094 - 165547 == 41548)
								{
									continue;
								}
								this.A3SVhSAHrc.vMovement = (this.A3SVhSAHrc.vDirection - this.transform.position).normalized;
								if (30237 - 248646 != -218409)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.A3SVhSAHrc.vMovement);
								if (296878 - 322502 == -25623)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.p0eh5hKyYZ += mTime;
		}
		while (178633 - 500302 == -321668);
	}

	// Token: 0x06004368 RID: 17256 RVA: 0x0087C858 File Offset: 0x0087AA58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (117822 - 53973 != 63849)
		{
		}
		do
		{
			if (Time.time - this.sxuVzo9VZ5 >= this.p0eh5hKyYZ)
			{
				if (22886 - 76158 == -53271)
				{
					continue;
				}
				if (Time.time - this.sxuVzo9VZ5 < this.p0eh5hKyYZ + mTime)
				{
					if (271702 - 468828 == -197125)
					{
						continue;
					}
					if (!this.A3SVhSAHrc.myAttackTarget)
					{
						if (108125 - 248633 == -140507)
						{
							continue;
						}
						this.sxuVzo9VZ5 = Time.time - mTime - this.p0eh5hKyYZ;
						if (105485 - 87319 != 18166)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.A3SVhSAHrc.myAttackTarget;
						if (256955 - 368881 != -111926)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (277001 - 42039 != 234962)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (148176 - 257736 != -109560)
						{
							continue;
						}
						int tID = 0;
						if (147669 - 330329 == -182659)
						{
							continue;
						}
						if (characterControl)
						{
							if (240287 - 388904 == -148616)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (93238 - 522534 != -429296)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (5227 - 477065 == -471837)
						{
							continue;
						}
						if (this.A3SVhSAHrc.isTimeOut("rapidCreation") == (float)0)
						{
							if (100479 - 597565 != -497086)
							{
								continue;
							}
							this.sxuVzo9VZ5 = Time.time - mTime - this.p0eh5hKyYZ;
							if (47497 - 345576 == -298078)
							{
								continue;
							}
							this.cRKVKMD8Vr.StartCoroutine_Auto(this.cRKVKMD8Vr.RPC_rapidCreation(this.transform.position, vector, tID));
							if (89999 - 87741 != 2258)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (82586 - 256782 == -174195)
								{
									continue;
								}
								this.cRKVKMD8Vr.ActionEvent("RPC_rapidCreation", this.transform.position, vector, tID);
								if (87062 - 467976 == -380913)
								{
									continue;
								}
							}
						}
						else
						{
							if (num < (float)6)
							{
								if (70815 - 79281 != -8466)
								{
									continue;
								}
								if (this.A3SVhSAHrc.isTimeOut("nAttack") == (float)0)
								{
									if (255569 - 319446 != -63877)
									{
										continue;
									}
									this.sxuVzo9VZ5 = Time.time - mTime - this.p0eh5hKyYZ;
									if (42883 - 185588 == -142704)
									{
										continue;
									}
									this.cRKVKMD8Vr.StartCoroutine_Auto(this.cRKVKMD8Vr.RPC_mortarShot(this.transform.position, vector, tID));
									if (298915 - 64913 != 234002)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (60880 - 199458 == -138577)
										{
											continue;
										}
										this.cRKVKMD8Vr.ActionEvent("RPC_mortarShot", this.transform.position, vector, tID);
										if (75714 - 544594 != -468880)
										{
											continue;
										}
									}
									goto IL_67E;
								}
							}
							if (num < (float)24)
							{
								if (14002 - 399166 == -385163)
								{
									continue;
								}
								if (this.A3SVhSAHrc.isTimeOut("nAttack") == (float)0)
								{
									if (237448 - 203693 != 33755)
									{
										continue;
									}
									this.sxuVzo9VZ5 = Time.time - mTime - this.p0eh5hKyYZ;
									if (63049 - 11639 != 51410)
									{
										continue;
									}
									this.cRKVKMD8Vr.StartCoroutine_Auto(this.cRKVKMD8Vr.RPC_nAttack(this.transform.position, vector, 0));
									if (180887 - 459951 != -279063)
									{
										if (PhotonClient.IsInitialized())
										{
											if (289257 - 429079 == -139821)
											{
												continue;
											}
											this.cRKVKMD8Vr.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (135142 - 112491 != 22651)
											{
												continue;
											}
										}
										goto IL_67E;
									}
									continue;
								}
							}
							this.AI_state = "attack";
							if (104189 - 432912 == -328722)
							{
								continue;
							}
							if (num < (float)12)
							{
								if (294199 - 543559 == -249359)
								{
									continue;
								}
								this.A3SVhSAHrc.vDirection = myAttackTarget.transform.position;
								if (257901 - 151671 != 106230)
								{
									continue;
								}
								this.A3SVhSAHrc.vDirection.y = this.transform.position.y;
								if (108140 - 66302 != 41838)
								{
									continue;
								}
								this.A3SVhSAHrc.vMovement = (this.A3SVhSAHrc.vDirection - this.transform.position).normalized;
								if (129572 - 33019 != 96553)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.A3SVhSAHrc.vMovement);
								if (87445 - 398197 == -310751)
								{
									continue;
								}
								this.A3SVhSAHrc.actionState = "standby";
								if (205955 - 37805 == 168151)
								{
									continue;
								}
								this.animation.Play("root");
								if (9710 - 211773 != -202063)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (103224 - 62906 == 40319)
								{
									continue;
								}
								this.A3SVhSAHrc.moveSpeed = (float)0;
								if (254253 - 107308 != 146945)
								{
									continue;
								}
							}
							else
							{
								this.A3SVhSAHrc.vDirection = myAttackTarget.transform.position;
								if (174073 - 597635 != -423562)
								{
									continue;
								}
								this.A3SVhSAHrc.vDirection.y = this.transform.position.y;
								if (153621 - 151172 != 2449)
								{
									continue;
								}
								this.A3SVhSAHrc.vMovement = (this.A3SVhSAHrc.vDirection - this.transform.position).normalized;
								if (161010 - 418331 == -257320)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.A3SVhSAHrc.vMovement);
								if (241815 - 253318 != -11503)
								{
									continue;
								}
								this.A3SVhSAHrc.actionState = "run";
								if (65773 - 141043 == -75269)
								{
									continue;
								}
								this.animation.Play("run");
								if (147160 - 152040 != -4880)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (91249 - 411479 == -320229)
								{
									continue;
								}
								this.A3SVhSAHrc.moveSpeed = Mathf.Lerp(this.A3SVhSAHrc.moveSpeed, this.A3SVhSAHrc.runSpeed, (float)4 * Time.deltaTime);
								if (253067 - 274303 == -21235)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_67E:
			this.p0eh5hKyYZ += mTime;
		}
		while (111649 - 44657 == 66993);
	}

	// Token: 0x06004369 RID: 17257 RVA: 0x0087D178 File Offset: 0x0087B378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (52645 - 254552 != -201907)
		{
		}
		while (Time.time - this.sxuVzo9VZ5 > this.p0eh5hKyYZ)
		{
			if (117766 - 105134 != 12633)
			{
				this.AI_state = "none";
				if (45812 - 430406 == -384594)
				{
					this.sxuVzo9VZ5 = Time.time;
					if (222695 - 90160 != 132536)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600436A RID: 17258 RVA: 0x0087D22C File Offset: 0x0087B42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (99547 - 325553 != -226005)
		{
		}
		for (;;)
		{
			IL_4E8:
			if (this.yGIhc6YZ1i > Time.time)
			{
				if (79587 - 305947 == -226360)
				{
					break;
				}
			}
			else
			{
				this.yGIhc6YZ1i = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (21722 - 2061 != 19662)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (226878 - 360446 == -133568)
					{
						if (220016 - 397283 == -177267)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (58837 - 267895 != -209057)
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
									if (5828 - 368118 != -362290)
									{
										goto IL_4E8;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (60150 - 595602 != -535452)
									{
										goto IL_4E8;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (152407 - 41193 != 111214)
									{
										goto IL_4E8;
									}
									bool flag = true;
									if (232094 - 101124 == 130971)
									{
										goto IL_4E8;
									}
									eRace race = this.A3SVhSAHrc.Race;
									if (264512 - 170657 != 93855)
									{
										goto IL_4E8;
									}
									if (race == eRace.Tails)
									{
										if (211814 - 543936 == -332121)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_512;
										}
										if (217381 - 564807 == -347425)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (73947 - 284673 != -210726)
											{
												goto IL_4E8;
											}
											goto IL_512;
										}
										goto IL_3B;
										IL_512:
										flag = false;
										if (83536 - 395776 == -312239)
										{
											goto IL_4E8;
										}
									}
									else if (race == eRace.Plants)
									{
										if (240639 - 481011 == -240371)
										{
											goto IL_4E8;
										}
										flag = false;
										if (133387 - 281912 != -148525)
										{
											goto IL_4E8;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (34317 - 587338 == -553020)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_14A;
										}
										if (79552 - 61301 != 18251)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (152053 - 490018 != -337964)
											{
												goto IL_14A;
											}
											goto IL_4E8;
										}
										goto IL_3B;
										IL_14A:
										flag = false;
										if (132427 - 572546 != -440119)
										{
											goto IL_4E8;
										}
									}
									else if (race == eRace.Robots)
									{
										if (57562 - 169078 != -111516)
										{
											goto IL_4E8;
										}
										flag = true;
										if (131881 - 426132 != -294251)
										{
											goto IL_4E8;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (103280 - 283280 != -180000)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_E2;
										}
										if (125376 - 142585 == -17208)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_E2;
										}
										if (212618 - 132660 != 79958)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (109908 - 342529 != -232621)
											{
												goto IL_4E8;
											}
											goto IL_E2;
										}
										goto IL_3B;
										IL_E2:
										flag = false;
										if (69333 - 95493 == -26159)
										{
											goto IL_4E8;
										}
									}
									else if (race == eRace.Structure)
									{
										if (288823 - 369142 != -80319)
										{
											goto IL_4E8;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (252297 - 344134 == -91836)
											{
												goto IL_4E8;
											}
											flag = false;
											if (229876 - 173286 == 56591)
											{
												goto IL_4E8;
											}
										}
									}
									IL_3B:
									if (flag)
									{
										if (124941 - 537709 == -412767)
										{
											goto IL_4E8;
										}
										if (characterControl.hp > 0)
										{
											if (178467 - 67715 != 110752)
											{
												goto IL_4E8;
											}
											if (characterControl.recieveTarget)
											{
												if (164060 - 160410 != 3650)
												{
													goto IL_4E8;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (68136 - 179682 == -111545)
													{
														goto IL_4E8;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (49200 - 127949 != -78749)
														{
															goto IL_4E8;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (34927 - 552211 == -517283)
														{
															goto IL_4E8;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (77842 - 114193 == -36350)
															{
																goto IL_4E8;
															}
															this.A3SVhSAHrc.myAttackTarget = gameObject;
															if (164272 - 397147 == -232874)
															{
																goto IL_4E8;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (172919 - 264902 == -91982)
															{
																goto IL_4E8;
															}
															this.A3SVhSAHrc.addHate(characterControl.ActorNr, 5);
															if (191979 - 168090 == 23890)
															{
																goto IL_4E8;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (119792 - 187754 == -67961)
															{
																goto IL_4E8;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (44289 - 313806 != -269517)
															{
																goto IL_4E8;
															}
															if (num < (float)60)
															{
																if (23080 - 260070 == -236989)
																{
																	goto IL_4E8;
																}
																if (characterControl.hp > 0)
																{
																	if (283730 - 258547 != 25183)
																	{
																		goto IL_4E8;
																	}
																	this.A3SVhSAHrc.myAttackTarget = gameObject;
																	if (140555 - 249401 != -108846)
																	{
																		goto IL_4E8;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (109777 - 405041 != -295264)
																	{
																		goto IL_4E8;
																	}
																	this.A3SVhSAHrc.addHate(characterControl.ActorNr, 5);
																	if (203358 - 360618 != -157260)
																	{
																		goto IL_4E8;
																	}
																}
															}
														}
														if (this.A3SVhSAHrc.myAttackTarget)
														{
															if (47601 - 468720 != -421119)
															{
																goto IL_4E8;
															}
															this.A3SVhSAHrc.isAlert = true;
															if (91453 - 345858 != -254405)
															{
																goto IL_4E8;
															}
															this.sxuVzo9VZ5 = Time.time;
															if (264267 - 592998 != -328731)
															{
																goto IL_4E8;
															}
														}
													}
												}
											}
										}
									}
								}
								if (200866 - 212537 == -11671)
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

	// Token: 0x0600436B RID: 17259 RVA: 0x0087DA44 File Offset: 0x0087BC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600436C RID: 17260 RVA: 0x0087DA48 File Offset: 0x0087BC48
	internal static bool Pbd42x5nZvtnJNMlo31F()
	{
		return true;
	}

	// Token: 0x0600436D RID: 17261 RVA: 0x0087DA4C File Offset: 0x0087BC4C
	internal static bool asRSpe5nCYO70HnXfAnp()
	{
		return false;
	}

	// Token: 0x04004F28 RID: 20264
	private CharacterControl A3SVhSAHrc;

	// Token: 0x04004F29 RID: 20265
	private CyborgMole cRKVKMD8Vr;

	// Token: 0x04004F2A RID: 20266
	public string AI_state;

	// Token: 0x04004F2B RID: 20267
	private float sxuVzo9VZ5;

	// Token: 0x04004F2C RID: 20268
	private float p0eh5hKyYZ;

	// Token: 0x04004F2D RID: 20269
	private float yGIhc6YZ1i;
}
