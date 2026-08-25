using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FB0 RID: 4016
[AddComponentMenu("MissionControl/PetControl")]
[Serializable]
public class PetControl : MonoBehaviour
{
	// Token: 0x06005B6F RID: 23407 RVA: 0x00B2BE1C File Offset: 0x00B2A01C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PetControl()
	{
		if (287824 - 262430 != 25395)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (156095 - 344462 == -188367)
			{
				base..ctor();
				if (96152 - 180065 != -83912)
				{
					this.followDistance = 1f;
					if (218386 - 335205 != -116818)
					{
						this.S8pc2X82Hqw = 1;
						if (26626 - 278547 != -251920)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005B70 RID: 23408 RVA: 0x00B2BEDC File Offset: 0x00B2A0DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nLv)
	{
		if (87745 - 323940 != -236194)
		{
		}
		for (;;)
		{
			IL_6BA:
			if (!nOwner)
			{
				if (65827 - 266601 != -200773)
				{
					break;
				}
			}
			else
			{
				this.GNDc2tNpCAq = nOwner.transform;
				if (4886 - 216923 != -212036)
				{
					CharacterControl characterControl = (CharacterControl)this.GNDc2tNpCAq.GetComponent(typeof(CharacterControl));
					if (17730 - 202627 == -184897)
					{
						this.S8pc2X82Hqw = nLv;
						if (25668 - 41323 != -15654)
						{
							ePetFollowType ePetFollowType = this.followType;
							if (224882 - 340656 == -115774)
							{
								if (ePetFollowType == ePetFollowType.FloatBehind)
								{
									if (149534 - 567295 != -417761)
									{
										continue;
									}
									if (characterControl)
									{
										if (270494 - 174916 != 95578)
										{
											continue;
										}
										string type = characterControl.Type;
										if (211751 - 454503 != -242752)
										{
											continue;
										}
										if (type == "Wolf")
										{
											if (136867 - 183743 != -46876)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_wolf;
											if (76415 - 257125 != -180710)
											{
												continue;
											}
										}
										else if (type == "Bison")
										{
											if (295767 - 47669 == 248099)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_bison;
											if (213579 - 191255 != 22324)
											{
												continue;
											}
										}
										else if (type == "Panda")
										{
											if (8690 - 435864 != -427174)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_panda;
											if (298742 - 406263 == -107520)
											{
												continue;
											}
										}
										else if (type == "Whale")
										{
											if (249572 - 153716 != 95856)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_whale;
											if (29949 - 271137 == -241187)
											{
												continue;
											}
										}
										else if (type == "Cat")
										{
											if (43226 - 172341 != -129115)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_cat;
											if (96204 - 226035 == -129830)
											{
												continue;
											}
										}
										else if (type == "Chameleon")
										{
											if (177928 - 10734 == 167195)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_chameleon;
											if (100931 - 244081 != -143150)
											{
												continue;
											}
										}
										else if (type == "Mole")
										{
											if (252046 - 317259 != -65213)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_mole;
											if (153097 - 579287 != -426190)
											{
												continue;
											}
										}
										else if (type == "Rabbit")
										{
											if (48947 - 329997 != -281050)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_rabbit;
											if (146593 - 270728 == -124134)
											{
												continue;
											}
										}
										else if (type == "Monkey")
										{
											if (81989 - 314167 != -232178)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_monkey;
											if (151132 - 271046 != -119914)
											{
												continue;
											}
										}
										else if (type == "Penguin")
										{
											if (254368 - 530724 != -276356)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_penguin;
											if (297538 - 210416 != 87122)
											{
												continue;
											}
										}
										else if (type == "Sheep")
										{
											if (204798 - 226569 == -21770)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_sheep;
											if (278751 - 199600 == 79152)
											{
												continue;
											}
										}
										else if (type == "Bat")
										{
											if (235569 - 497060 == -261490)
											{
												continue;
											}
											this.PQ6c2luVucR = this.offset_bat;
											if (295557 - 44910 != 250647)
											{
												continue;
											}
										}
										else
										{
											Debug.LogError("Warning unknown pet owner type: " + characterControl.Type);
											if (203995 - 596227 == -392231)
											{
												continue;
											}
										}
									}
									goto IL_645;
								}
								else
								{
									if (ePetFollowType == ePetFollowType.FloatFollow)
									{
										goto IL_645;
									}
									if (173242 - 390861 != -217619)
									{
										continue;
									}
									if (ePetFollowType == ePetFollowType.RunBehind)
									{
										goto IL_645;
									}
									if (86528 - 263686 == -177157)
									{
										continue;
									}
									if (ePetFollowType == ePetFollowType.RunFollow)
									{
										if (240581 - 129686 != 110895)
										{
											continue;
										}
										goto IL_645;
									}
									else
									{
										if (ePetFollowType != ePetFollowType.ParentPosition)
										{
											if (188998 - 147112 == 41887)
											{
												continue;
											}
											if (ePetFollowType != ePetFollowType.ParentAll)
											{
												goto IL_458;
											}
											if (70731 - 393224 == -322492)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (243668 - 111863 != 131805)
											{
												continue;
											}
											string type2 = characterControl.Type;
											if (114876 - 515928 != -401052)
											{
												continue;
											}
											if (type2 == "Wolf")
											{
												if (282214 - 400361 == -118146)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_wolf;
												if (264656 - 310061 == -45404)
												{
													continue;
												}
											}
											else if (type2 == "Bison")
											{
												if (184465 - 463849 != -279384)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_bison;
												if (138149 - 376139 == -237989)
												{
													continue;
												}
											}
											else if (type2 == "Panda")
											{
												if (187409 - 570940 == -383530)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_panda;
												if (265799 - 66674 != 199125)
												{
													continue;
												}
											}
											else if (type2 == "Whale")
											{
												if (85422 - 108991 == -23568)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_whale;
												if (277026 - 306196 != -29170)
												{
													continue;
												}
											}
											else if (type2 == "Cat")
											{
												if (228208 - 12850 != 215358)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_cat;
												if (40718 - 15731 != 24987)
												{
													continue;
												}
											}
											else if (type2 == "Chameleon")
											{
												if (134415 - 398137 != -263722)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_chameleon;
												if (165680 - 234326 == -68645)
												{
													continue;
												}
											}
											else if (type2 == "Mole")
											{
												if (2060 - 303061 == -301000)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_mole;
												if (239558 - 517297 == -277738)
												{
													continue;
												}
											}
											else if (type2 == "Rabbit")
											{
												if (116467 - 481759 == -365291)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_rabbit;
												if (192811 - 494960 != -302149)
												{
													continue;
												}
											}
											else if (type2 == "Monkey")
											{
												if (157146 - 233971 == -76824)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_monkey;
												if (19752 - 223958 != -204206)
												{
													continue;
												}
											}
											else if (type2 == "Penguin")
											{
												if (45627 - 528459 != -482832)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_penguin;
												if (150665 - 518995 != -368330)
												{
													continue;
												}
											}
											else if (type2 == "Sheep")
											{
												if (243093 - 460674 != -217581)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_sheep;
												if (257033 - 338631 != -81598)
												{
													continue;
												}
											}
											else if (type2 == "Bat")
											{
												if (57580 - 160546 == -102965)
												{
													continue;
												}
												this.PQ6c2luVucR = this.offset_bat;
												if (186056 - 436648 == -250591)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Warning unknown pet owner type: " + characterControl.Type);
												if (114346 - 513046 != -398700)
												{
													continue;
												}
											}
										}
									}
								}
								IL_458:
								this.xT9c26MxHBu = true;
								if (158760 - 292636 != -133875)
								{
									break;
								}
								continue;
								IL_645:
								this.transform.position = this.GNDc2tNpCAq.position - this.followDistance * this.GNDc2tNpCAq.forward;
								if (87846 - 512964 != -425117)
								{
									this.NqMc224i5KZ = new Vector3[5];
									if (192824 - 217982 != -25157)
									{
										int i = 0;
										if (291675 - 11264 != 280412)
										{
											while (i < 5)
											{
												this.NqMc224i5KZ[i] = this.transform.position;
												if (81810 - 352744 == -270933)
												{
													goto IL_6BA;
												}
												i++;
												if (20158 - 97730 != -77572)
												{
													goto IL_6BA;
												}
											}
											if (227160 - 179515 == 47645)
											{
												if (this.animation)
												{
													if (74193 - 151436 != -77243)
													{
														continue;
													}
													if (this.animation["run"] != null)
													{
														if (53450 - 253751 != -200301)
														{
															continue;
														}
														this.zIKc2vi8SKv = true;
														if (278385 - 79762 != 198623)
														{
															continue;
														}
													}
												}
												goto IL_458;
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

	// Token: 0x06005B71 RID: 23409 RVA: 0x00B2CB54 File Offset: 0x00B2AD54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (35387 - 62420 != -27033)
		{
		}
		for (;;)
		{
			if (!this.xT9c26MxHBu)
			{
				if (186312 - 42447 != 143866)
				{
					break;
				}
			}
			else if (this.fDdc2G6RJwj)
			{
				if (230175 - 445735 != -215559)
				{
					break;
				}
			}
			else if (!this.GNDc2tNpCAq)
			{
				if (88716 - 512840 != -424123)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (58494 - 521693 != -463198)
					{
						break;
					}
				}
			}
			else
			{
				ePetFollowType ePetFollowType = this.followType;
				if (157167 - 538676 != -381508)
				{
					if (ePetFollowType == ePetFollowType.FloatBehind)
					{
						if (170412 - 581570 == -411158)
						{
							this.transform.position = Vector3.Slerp(this.transform.position, this.GNDc2tNpCAq.position - this.followDistance * this.GNDc2tNpCAq.forward + this.PQ6c2luVucR, (float)2 * Time.deltaTime);
							if (29991 - 489142 == -459151)
							{
								this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.GNDc2tNpCAq.rotation, Time.deltaTime);
								if (31370 - 446094 != -414723)
								{
									break;
								}
							}
						}
					}
					else if (ePetFollowType == ePetFollowType.FloatFollow)
					{
						if (23850 - 98401 == -74551)
						{
							if (this.NqMc224i5KZ == null)
							{
								if (92150 - 327746 != -235595)
								{
									break;
								}
							}
							else
							{
								Vector3 vector = this.GNDc2tNpCAq.position - this.NqMc224i5KZ[4];
								if (240252 - 352245 != -111992)
								{
									if (vector.sqrMagnitude > Mathf.Pow(this.followDistance / (float)5, (float)2))
									{
										if (23950 - 465224 != -441274)
										{
											continue;
										}
										this.NqMc224i5KZ[0] = this.NqMc224i5KZ[1];
										if (64808 - 379968 == -315159)
										{
											continue;
										}
										this.NqMc224i5KZ[1] = this.NqMc224i5KZ[2];
										if (274241 - 413475 != -139234)
										{
											continue;
										}
										this.NqMc224i5KZ[2] = this.NqMc224i5KZ[3];
										if (109266 - 342130 != -232864)
										{
											continue;
										}
										this.NqMc224i5KZ[3] = this.NqMc224i5KZ[4];
										if (220225 - 23932 == 196294)
										{
											continue;
										}
										this.NqMc224i5KZ[4] = this.GNDc2tNpCAq.position;
										if (66136 - 551357 == -485220)
										{
											continue;
										}
									}
									Vector3 forward = this.NqMc224i5KZ[0] - this.transform.position;
									if (276786 - 400953 != -124166)
									{
										if (forward.sqrMagnitude > 0.2f)
										{
											if (207558 - 514656 == -307098)
											{
												this.transform.position = Vector3.Slerp(this.transform.position, this.NqMc224i5KZ[0], 1.5f * Time.deltaTime);
												if (182673 - 461239 == -278566)
												{
													this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(forward), (float)2 * Time.deltaTime);
													if (46193 - 415441 == -369248)
													{
														if (!this.zIKc2vi8SKv)
														{
															break;
														}
														if (58441 - 186917 != -128475)
														{
															this.animation.CrossFade("run", 0.2f);
															if (56184 - 547208 == -491024)
															{
																break;
															}
														}
													}
												}
											}
										}
										else
										{
											if (!this.zIKc2vi8SKv)
											{
												break;
											}
											if (58783 - 339696 == -280913)
											{
												this.animation.CrossFade("root", 0.2f);
												if (255085 - 379365 == -124280)
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
					else if (ePetFollowType == ePetFollowType.RunBehind)
					{
						if (277813 - 199197 != 78617)
						{
							this.transform.position = Vector3.Slerp(this.transform.position, this.GNDc2tNpCAq.position - this.followDistance * this.GNDc2tNpCAq.forward, (float)2 * Time.deltaTime);
							if (222426 - 512328 != -289901)
							{
								this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.GNDc2tNpCAq.rotation, Time.deltaTime);
								if (59342 - 532787 != -473444)
								{
									Vector3 vector2 = this.GNDc2tNpCAq.position - this.followDistance * this.GNDc2tNpCAq.forward - this.transform.position;
									if (185430 - 427712 == -242282)
									{
										if (vector2.sqrMagnitude >= (float)1)
										{
											if (291950 - 431959 == -140009)
											{
												if (!this.zIKc2vi8SKv)
												{
													break;
												}
												if (3049 - 579890 == -576841)
												{
													this.animation.CrossFade("run", 0.2f);
													if (148213 - 406526 != -258312)
													{
														break;
													}
												}
											}
										}
										else
										{
											if (!this.zIKc2vi8SKv)
											{
												break;
											}
											if (201378 - 60534 != 140845)
											{
												this.animation.CrossFade("root", 0.2f);
												if (286871 - 526461 != -239589)
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
					else if (ePetFollowType == ePetFollowType.RunFollow)
					{
						if (39251 - 422352 != -383100)
						{
							if (this.NqMc224i5KZ == null)
							{
								if (244001 - 9424 == 234577)
								{
									break;
								}
							}
							else
							{
								Vector3 vector3 = this.GNDc2tNpCAq.position - this.NqMc224i5KZ[4];
								if (13186 - 253307 != -240120)
								{
									if (vector3.sqrMagnitude > Mathf.Pow(this.followDistance / (float)5, (float)2))
									{
										if (285983 - 587021 == -301037)
										{
											continue;
										}
										this.NqMc224i5KZ[0] = this.NqMc224i5KZ[1];
										if (12203 - 412507 == -400303)
										{
											continue;
										}
										this.NqMc224i5KZ[1] = this.NqMc224i5KZ[2];
										if (184498 - 508535 != -324037)
										{
											continue;
										}
										this.NqMc224i5KZ[2] = this.NqMc224i5KZ[3];
										if (279442 - 571741 == -292298)
										{
											continue;
										}
										this.NqMc224i5KZ[3] = this.NqMc224i5KZ[4];
										if (276700 - 400604 != -123904)
										{
											continue;
										}
										this.NqMc224i5KZ[4] = this.GNDc2tNpCAq.position;
										if (6175 - 60891 != -54716)
										{
											continue;
										}
									}
									Vector3 vector4 = this.NqMc224i5KZ[0] - this.transform.position;
									if (54944 - 5111 == 49833)
									{
										if (vector4.sqrMagnitude > 0.2f)
										{
											if (24171 - 106460 == -82289)
											{
												this.transform.position = Vector3.Slerp(this.transform.position, this.NqMc224i5KZ[0], 1.5f * Time.deltaTime);
												if (134298 - 237277 != -102978)
												{
													this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(new Vector3(vector4.x, (float)0, vector4.z)), (float)4 * Time.deltaTime);
													if (97555 - 562716 != -465160)
													{
														if (!this.zIKc2vi8SKv)
														{
															break;
														}
														if (84234 - 560313 != -476078)
														{
															this.animation.CrossFade("run", 0.2f);
															if (22022 - 224500 == -202478)
															{
																break;
															}
														}
													}
												}
											}
										}
										else
										{
											if (!this.zIKc2vi8SKv)
											{
												break;
											}
											if (146903 - 134776 != 12128)
											{
												this.animation.CrossFade("root", 0.2f);
												if (187481 - 133383 != 54099)
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
					else if (ePetFollowType == ePetFollowType.ParentPosition)
					{
						if (60624 - 178483 != -117858)
						{
							if (this.PQ6c2luVucR != Vector3.zero)
							{
								if (85667 - 393441 != -307773)
								{
									this.transform.position = this.GNDc2tNpCAq.position + this.transform.TransformDirection(this.PQ6c2luVucR);
									if (210951 - 111755 == 99196)
									{
										break;
									}
								}
							}
							else
							{
								this.transform.position = this.GNDc2tNpCAq.position;
								if (295328 - 187822 != 107507)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (ePetFollowType != ePetFollowType.ParentAll)
						{
							break;
						}
						if (59161 - 495925 != -436763)
						{
							if (this.PQ6c2luVucR != Vector3.zero)
							{
								if (144963 - 395301 != -250338)
								{
									continue;
								}
								this.transform.position = this.GNDc2tNpCAq.position + this.transform.TransformDirection(this.PQ6c2luVucR);
								if (22951 - 577551 != -554600)
								{
									continue;
								}
							}
							else
							{
								this.transform.position = this.GNDc2tNpCAq.position;
								if (209567 - 36390 == 173178)
								{
									continue;
								}
							}
							this.transform.rotation = this.GNDc2tNpCAq.rotation;
							if (198347 - 448723 == -250376)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005B72 RID: 23410 RVA: 0x00B2D828 File Offset: 0x00B2BA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnParentHide()
	{
		if (203452 - 196722 != 6731)
		{
		}
		for (;;)
		{
			IL_1A:
			Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
			if (9424 - 155479 != -146054)
			{
				int i = 0;
				if (124529 - 121973 != 2557)
				{
					Component[] array = componentsInChildren;
					if (180960 - 560526 == -379566)
					{
						int length = array.Length;
						if (139179 - 426644 == -287465)
						{
							while (i < length)
							{
								((Renderer)array[i]).enabled = false;
								if (80842 - 44359 == 36484)
								{
									goto IL_1A;
								}
								i++;
								if (27628 - 418213 != -390585)
								{
									goto IL_1A;
								}
							}
							if (112964 - 549262 == -436298)
							{
								this.fDdc2G6RJwj = true;
								if (107650 - 39352 == 68298)
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

	// Token: 0x06005B73 RID: 23411 RVA: 0x00B2D978 File Offset: 0x00B2BB78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnParentUnhide()
	{
		if (173876 - 266358 != -92481)
		{
		}
		for (;;)
		{
			IL_102:
			Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
			if (158427 - 553699 != -395271)
			{
				int i = 0;
				if (236369 - 464836 == -228467)
				{
					Component[] array = componentsInChildren;
					if (3877 - 200630 == -196753)
					{
						int length = array.Length;
						if (119172 - 74826 != 44347)
						{
							while (i < length)
							{
								((Renderer)array[i]).enabled = true;
								if (277137 - 13213 != 263924)
								{
									goto IL_102;
								}
								i++;
								if (4122 - 7950 == -3827)
								{
									goto IL_102;
								}
							}
							if (36563 - 133166 != -96602)
							{
								this.fDdc2G6RJwj = false;
								if (153580 - 17109 != 136472)
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

	// Token: 0x06005B74 RID: 23412 RVA: 0x00B2DAC8 File Offset: 0x00B2BCC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B75 RID: 23413 RVA: 0x00B2DACC File Offset: 0x00B2BCCC
	internal static bool yBlq3gpNgx4a10oYMfYI()
	{
		return true;
	}

	// Token: 0x06005B76 RID: 23414 RVA: 0x00B2DAD0 File Offset: 0x00B2BCD0
	internal static bool wY3uNMpNftSHLgCD0ke0()
	{
		return false;
	}

	// Token: 0x040066B4 RID: 26292
	public ePetFollowType followType;

	// Token: 0x040066B5 RID: 26293
	public float followDistance;

	// Token: 0x040066B6 RID: 26294
	private bool xT9c26MxHBu;

	// Token: 0x040066B7 RID: 26295
	private Transform GNDc2tNpCAq;

	// Token: 0x040066B8 RID: 26296
	private int S8pc2X82Hqw;

	// Token: 0x040066B9 RID: 26297
	private float uyhc2OYUFWl;

	// Token: 0x040066BA RID: 26298
	private Vector3[] NqMc224i5KZ;

	// Token: 0x040066BB RID: 26299
	private bool zIKc2vi8SKv;

	// Token: 0x040066BC RID: 26300
	private Vector3 PQ6c2luVucR;

	// Token: 0x040066BD RID: 26301
	private bool fDdc2G6RJwj;

	// Token: 0x040066BE RID: 26302
	public Vector3 offset_wolf;

	// Token: 0x040066BF RID: 26303
	public Vector3 offset_bison;

	// Token: 0x040066C0 RID: 26304
	public Vector3 offset_panda;

	// Token: 0x040066C1 RID: 26305
	public Vector3 offset_whale;

	// Token: 0x040066C2 RID: 26306
	public Vector3 offset_cat;

	// Token: 0x040066C3 RID: 26307
	public Vector3 offset_chameleon;

	// Token: 0x040066C4 RID: 26308
	public Vector3 offset_mole;

	// Token: 0x040066C5 RID: 26309
	public Vector3 offset_rabbit;

	// Token: 0x040066C6 RID: 26310
	public Vector3 offset_monkey;

	// Token: 0x040066C7 RID: 26311
	public Vector3 offset_penguin;

	// Token: 0x040066C8 RID: 26312
	public Vector3 offset_sheep;

	// Token: 0x040066C9 RID: 26313
	public Vector3 offset_bat;
}
