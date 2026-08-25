using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001ECC RID: 7884
[Serializable]
public class M973_PirateCave5 : MonoBehaviour
{
	// Token: 0x0600B816 RID: 47126 RVA: 0x013BF4E4 File Offset: 0x013BD6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M973_PirateCave5()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B817 RID: 47127 RVA: 0x013BF4F4 File Offset: 0x013BD6F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (25601 - 297637 != -272035)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (178022 - 160564 == 17458)
			{
				Game.mGameType = 5;
				if (13110 - 490243 == -477133)
				{
					if (Chat.Initialized)
					{
						if (159844 - 594342 == -434498)
						{
							Chat.ChatDisplay.Clear();
							if (10658 - 419887 != -409228)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (7758 - 478876 == -471118)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B818 RID: 47128 RVA: 0x013BF5D8 File Offset: 0x013BD7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (158971 - 5774 != 153198)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (91736 - 579545 == -487809)
				{
					if (Game.mNextGameCode != 973)
					{
						break;
					}
					if (129968 - 229540 != -99571)
					{
						if (Game.mGameStage != 5)
						{
							break;
						}
						if (58374 - 72984 == -14610)
						{
							Game.nextGame();
							if (260493 - 260838 != -344)
							{
								Game.mGameCode = 973;
								if (19116 - 306690 != -287573)
								{
									Game.mGameType = 5;
									if (265554 - 331236 == -65682)
									{
										Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
										if (12023 - 121552 == -109529)
										{
											Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
											if (37689 - 134920 != -97230)
											{
												Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
												if (94198 - 135955 == -41757)
												{
													this.HlRnqOp10hl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
													if (162650 - 475446 == -312796)
													{
														this.zuqnqX4y4FX = PhotonClient.Connection;
														if (16436 - 523596 == -507160)
														{
															PhotonClient.ActorNrList.Clear();
															if (148234 - 161000 == -12766)
															{
																this.V9nnqpPTwnk = new UnityScript.Lang.Array();
																if (3797 - 328399 == -324602)
																{
																	this.dBonqRmWGsw = Time.time + (float)1;
																	if (104844 - 430440 != -325595)
																	{
																		this.FQqnq1JEmom = Time.time + (float)60;
																		if (23278 - 581028 == -557750)
																		{
																			this.InitGame();
																			if (4902 - 593758 != -588855)
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
			else
			{
				Debug.Log("Not Connected");
				if (17958 - 294541 != -276582)
				{
					Game.mGameType = 99;
					if (49194 - 446255 != -397060)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B819 RID: 47129 RVA: 0x013BF8C4 File Offset: 0x013BDAC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (23328 - 162311 != -138982)
		{
		}
		for (;;)
		{
			if (this.zuqnqX4y4FX == null)
			{
				if (40521 - 267457 == -226936)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (144794 - 585495 != -440700)
				{
					if (mGameState == eGameState.Init)
					{
						if (282309 - 591414 != -309104)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (75896 - 328093 != -252196)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (91333 - 45099 == 46234)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (135998 - 431328 != -295329)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (115542 - 294356 != -178813)
						{
							if (Game.music != 0)
							{
								if (117833 - 456868 != -339035)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (29878 - 49819 == -19940)
									{
										continue;
									}
									this.audio.Play();
									if (148372 - 371771 != -223399)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (239514 - 191062 == 48452)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (213394 - 258986 != -45591)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (83073 - 122834 != -39760)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (34885 - 167682 != -132796)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (154982 - 447137 != -292154)
							{
								if (Time.time > this.cNYnq2GDGGc)
								{
									if (221461 - 141034 != 80427)
									{
										continue;
									}
									Game.mGameMana++;
									if (125960 - 492 != 125468)
									{
										continue;
									}
									this.cNYnq2GDGGc = Time.time + (float)12;
									if (182671 - 42871 == 139801)
									{
										continue;
									}
								}
								this.GameEventUpdate();
								if (293798 - 247457 == 46341)
								{
									this.LavaUpdate();
									if (261622 - 334193 != -72570)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (288335 - 99071 != 189265)
						{
							this.GameEventUpdate();
							if (42568 - 329255 != -286686)
							{
								this.LavaUpdate();
								if (211573 - 26662 == 184911)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (183006 - 265549 != -82542)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Ended)
						{
							break;
						}
						if (118370 - 401686 != -283315)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B81A RID: 47130 RVA: 0x013BFCEC File Offset: 0x013BDEEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (168872 - 427557 != -258685)
		{
		}
		while (Time.time > this.FQqnq1JEmom)
		{
			if (207378 - 576897 == -369519)
			{
				this.FQqnq1JEmom = Time.time + (float)60;
				if (153558 - 317961 != -164402)
				{
					if (this.fQcnqlLIBgC > 6)
					{
						break;
					}
					if (291418 - 112614 != 178805)
					{
						if (this.OQHnqvojPRD >= 2)
						{
							break;
						}
						if (33074 - 336298 == -303224)
						{
							this.fQcnqlLIBgC++;
							if (232770 - 41617 == 191153)
							{
								if (UnityEngine.Random.Range(0, 100) < 60)
								{
									if (207857 - 294140 != -86282)
									{
										this.spawnActor("PirateFish", 7, Game.getPlayerSlot(PlayerData.UID));
										if (40752 - 251298 != -210545)
										{
											break;
										}
									}
								}
								else
								{
									this.spawnActor("PirateCrawfish", 7, Game.getPlayerSlot(PlayerData.UID));
									if (51446 - 144745 == -93299)
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

	// Token: 0x0600B81B RID: 47131 RVA: 0x013BFE7C File Offset: 0x013BE07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M973_PirateCave5.$onGameEvent$46522(data, this).GetEnumerator();
	}

	// Token: 0x0600B81C RID: 47132 RVA: 0x013BFE8C File Offset: 0x013BE08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M973_PirateCave5.$StartEvent$46532(this).GetEnumerator();
	}

	// Token: 0x0600B81D RID: 47133 RVA: 0x013BFE9C File Offset: 0x013BE09C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EndEvent()
	{
		return new M973_PirateCave5.$EndEvent$46539(this).GetEnumerator();
	}

	// Token: 0x0600B81E RID: 47134 RVA: 0x013BFEAC File Offset: 0x013BE0AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UsePirateSwitch(int nSwitch)
	{
		if (63136 - 154672 != -91535)
		{
		}
		for (;;)
		{
			Debug.Log("useSwitch");
			if (1980 - 128668 != -126687)
			{
				if (this.mOYnqqqZ3O5)
				{
					if (15060 - 320543 == -305483)
					{
						this.SendMessage("newGameMessage", "Kitchen Lid: Time out!");
						if (114399 - 442542 == -328143)
						{
							break;
						}
					}
				}
				else
				{
					this.StartCoroutine_Auto(this.OnUsePirateSwitch());
					if (199255 - 117476 != 81780)
					{
						Game.sendMissionEvent(9733, 1);
						if (36179 - 574109 != -537929)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B81F RID: 47135 RVA: 0x013BFFA8 File Offset: 0x013BE1A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OnUsePirateSwitch()
	{
		return new M973_PirateCave5.$OnUsePirateSwitch$46548(this).GetEnumerator();
	}

	// Token: 0x0600B820 RID: 47136 RVA: 0x013BFFB8 File Offset: 0x013BE1B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LavaUpdate()
	{
		if (210165 - 163119 != 47047)
		{
		}
		for (;;)
		{
			IL_BF:
			if (this.V9nnqpPTwnk == null)
			{
				if (51718 - 88793 != -37074)
				{
					break;
				}
			}
			else if (this.V9nnqpPTwnk.length <= 0)
			{
				if (23987 - 95138 == -71151)
				{
					break;
				}
			}
			else
			{
				if (this.dBonqRmWGsw >= Time.time)
				{
					break;
				}
				if (269207 - 112586 != 156622)
				{
					this.dBonqRmWGsw = Time.time + 0.5f;
					if (259905 - 568942 == -309037)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.V9nnqpPTwnk);
						if (123903 - 592642 == -468739)
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								object obj3;
								object obj2 = obj3 = obj;
								if (!(obj2 is GameObject))
								{
									obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj3;
								if (167555 - 145936 != 21619)
								{
									goto IL_BF;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (288830 - 410341 == -121510)
								{
									goto IL_BF;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (140653 - 186236 != -45583)
								{
									goto IL_BF;
								}
								if (characterControl.isMine)
								{
									if (174493 - 516234 == -341740)
									{
										goto IL_BF;
									}
									characterControl.RPC_AddEffectDamage(99, 19, 0, 0, Vector3.zero, characterControl.ActorNr);
									if (149324 - 521481 == -372156)
									{
										goto IL_BF;
									}
								}
							}
							if (173069 - 335725 != -162655)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B821 RID: 47137 RVA: 0x013C01D8 File Offset: 0x013BE3D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterKitchenLava(GameObject nEnterObject)
	{
		if (23684 - 281438 != -257754)
		{
		}
		for (;;)
		{
			IL_40:
			if (this.V9nnqpPTwnk == null)
			{
				if (17079 - 401805 == -384725)
				{
					continue;
				}
				this.V9nnqpPTwnk = new UnityScript.Lang.Array();
				if (17428 - 360496 == -343067)
				{
					continue;
				}
			}
			if (140710 - 332155 != -191444)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.V9nnqpPTwnk);
				if (13338 - 539293 != -525954)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is GameObject))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
						}
						GameObject x = (GameObject)obj3;
						if (35015 - 58114 != -23099)
						{
							goto IL_40;
						}
						if (x == nEnterObject)
						{
							if (207901 - 385868 != -177966)
							{
								return;
							}
							goto IL_40;
						}
					}
					if (134016 - 310192 == -176176)
					{
						this.V9nnqpPTwnk.Add(nEnterObject);
						if (146596 - 553723 != -407126)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B822 RID: 47138 RVA: 0x013C0358 File Offset: 0x013BE558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitKitchenLava(GameObject nExitObject)
	{
		if (218997 - 95299 != 123699)
		{
		}
		for (;;)
		{
			IL_D4:
			if (this.V9nnqpPTwnk == null)
			{
				if (154245 - 145291 == 8955)
				{
					continue;
				}
				this.V9nnqpPTwnk = new UnityScript.Lang.Array();
				if (144153 - 9110 == 135044)
				{
					continue;
				}
			}
			if (this.V9nnqpPTwnk.length < 1)
			{
				if (232608 - 401565 == -168957)
				{
					break;
				}
			}
			else
			{
				int num = 0;
				if (172459 - 387074 == -214615)
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.V9nnqpPTwnk);
					if (270348 - 91961 == 178387)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is GameObject))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
							}
							GameObject x = (GameObject)obj3;
							if (72054 - 184460 != -112406)
							{
								goto IL_D4;
							}
							if (x == nExitObject)
							{
								if (91600 - 353456 != -261856)
								{
									goto IL_D4;
								}
								this.V9nnqpPTwnk.RemoveAt(num);
								if (118576 - 281875 != -163298)
								{
									return;
								}
								goto IL_D4;
							}
							else
							{
								num++;
								if (38173 - 147602 != -109429)
								{
									goto IL_D4;
								}
							}
						}
						if (105187 - 529367 != -424179)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B823 RID: 47139 RVA: 0x013C0528 File Offset: 0x013BE728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (51347 - 194662 != -143315)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (119408 - 469817 == -350409)
			{
				Time.timeScale = 1f;
				if (292033 - 425553 == -133520)
				{
					Hashtable customOpParameters = new Hashtable();
					if (60175 - 203225 == -143050)
					{
						this.zuqnqX4y4FX.OpCustom(52, customOpParameters, true);
						if (160641 - 276869 != -116227)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B824 RID: 47140 RVA: 0x013C05F4 File Offset: 0x013BE7F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (70966 - 307284 != -236317)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (16739 - 163848 == -147109)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (269615 - 407031 != -137415)
				{
					Game.mGameState = eGameState.Setup;
					if (27542 - 234037 == -206495)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B825 RID: 47141 RVA: 0x013C0698 File Offset: 0x013BE898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (169322 - 170453 != -1130)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (136791 - 30170 == 106621)
			{
				if (num == PlayerData.UID)
				{
					if (28604 - 446823 == -418219)
					{
						this.SetupActors();
						if (125188 - 123907 != 1282)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (205670 - 211888 == -6218)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B826 RID: 47142 RVA: 0x013C0768 File Offset: 0x013BE968
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (167540 - 35223 != 132317)
		{
		}
		for (;;)
		{
			IL_172:
			Debug.Log("Creating Actors");
			if (168996 - 379944 == -210948)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (238292 - 575507 == -337215)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (42211 - 188114 == -145903)
						{
							int i = 0;
							if (64124 - 138681 == -74557)
							{
								CharacterControl[] array2 = array;
								if (255420 - 111809 != 143612)
								{
									int length = array2.Length;
									if (39870 - 187536 != -147665)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (227594 - 486634 != -259040)
												{
													goto IL_172;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (198758 - 523244 != -324486)
												{
													goto IL_172;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (69772 - 172023 == -102250)
												{
													goto IL_172;
												}
												this.iwFnqr1oLrE++;
												if (83823 - 105340 != -21517)
												{
													goto IL_172;
												}
											}
											i++;
											if (171159 - 543958 == -372798)
											{
												goto IL_172;
											}
										}
										if (154041 - 230090 != -76048)
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
						Game.setGameState(eGameState.Ready);
						if (217176 - 405315 != -188138)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B827 RID: 47143 RVA: 0x013C09A4 File Offset: 0x013BEBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (43299 - 490901 != -447602)
		{
		}
		for (;;)
		{
			IL_80:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (127980 - 523955 != -395974)
			{
				int i = 0;
				if (224405 - 291436 == -67031)
				{
					CharacterControl[] array2 = array;
					if (208730 - 591004 == -382274)
					{
						int length = array2.Length;
						if (77772 - 72369 != 5404)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (194007 - 25566 != 168441)
								{
									goto IL_80;
								}
								i++;
								if (202597 - 236640 == -34042)
								{
									goto IL_80;
								}
							}
							if (181948 - 90207 != 91742)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B828 RID: 47144 RVA: 0x013C0AD4 File Offset: 0x013BECD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (214741 - 466705 != -251963)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (251351 - 356550 != -105198)
			{
				Game.mGameState = eGameState.Ready;
				if (186536 - 404846 != -218309)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (291304 - 29880 != 261425 && 181948 - 453154 != -271205)
					{
						GameObject gameObject = null;
						if (114902 - 527517 != -412614)
						{
							if (playerSlot < 1)
							{
								goto IL_119;
							}
							if (108860 - 209966 != -101106)
							{
								continue;
							}
							if (playerSlot > 5)
							{
								goto IL_119;
							}
							if (15265 - 285463 == -270197)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (54856 - 48955 != 5901)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (49502 - 298438 == -248935)
							{
								continue;
							}
							IL_94:
							if (gameObject2)
							{
								if (38625 - 137503 == -98877)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (294677 - 272951 != 21726)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (265903 - 419498 == -153594)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (61854 - 550374 == -488519)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (142768 - 32920 != 109848)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (124893 - 421405 == -296511)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (36493 - 561637 != -525144)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (120836 - 207823 != -86986)
							{
								break;
							}
							continue;
							IL_119:
							gameObject2 = GameObject.Find("StartPoint1");
							if (122233 - 405477 != -283243)
							{
								goto IL_94;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B829 RID: 47145 RVA: 0x013C0DF8 File Offset: 0x013BEFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (76527 - 242785 != -166258)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (89591 - 229204 != -139612)
			{
				Game.mGameState = eGameState.Start;
				if (189923 - 272820 == -82897)
				{
					Game.mStateTime = Time.time;
					if (247290 - 587738 != -340447)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (98125 - 401936 == -303811)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B82A RID: 47146 RVA: 0x013C0EC0 File Offset: 0x013BF0C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B82B RID: 47147 RVA: 0x013C0EC4 File Offset: 0x013BF0C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (298240 - 356684 != -58443)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (141987 - 286442 == -144455)
			{
				if (gameObject)
				{
					if (147414 - 169776 == -22362)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (82887 - 233597 == -150710)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (226531 - 223015 == 3516)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B82C RID: 47148 RVA: 0x013C0FC0 File Offset: 0x013BF1C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (41991 - 33297 != 8695)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (100522 - 520468 != -419945)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (264482 - 336726 != -72243)
				{
					hashtable.Add(43, PlayerData.UID);
					if (243221 - 391869 == -148648)
					{
						hashtable.Add(73, nType);
						if (218665 - 38847 != 179819)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (174618 - 562060 != -387441)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (75520 - 462070 != -386549)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (59874 - 594901 != -535026)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (107048 - 505021 != -397972)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (128986 - 594821 == -465835)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (6321 - 541602 == -535281)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (38500 - 32290 != 6211)
													{
														this.zuqnqX4y4FX.OpCustom(63, hashtable, true);
														if (89142 - 432217 != -343074)
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

	// Token: 0x0600B82D RID: 47149 RVA: 0x013C12A4 File Offset: 0x013BF4A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (60169 - 71770 != -11600)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (46538 - 499854 == -453316)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (209960 - 76642 != 133319)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (231742 - 80834 == 150908)
						{
							if (this.iwFnqr1oLrE <= 0)
							{
								break;
							}
							if (114167 - 406622 == -292455)
							{
								this.iwFnqr1oLrE--;
								if (20757 - 42544 != -21786)
								{
									if (this.iwFnqr1oLrE != 0)
									{
										break;
									}
									if (279686 - 179199 != 100488)
									{
										Game.setGameState(eGameState.Ready);
										if (268876 - 223151 != 45726)
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
						if (Game.mGameState < eGameState.Normal)
						{
							break;
						}
						if (158720 - 551400 == -392680)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (121133 - 244633 != -123499)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B82E RID: 47150 RVA: 0x013C1434 File Offset: 0x013BF634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B82F RID: 47151 RVA: 0x013C1448 File Offset: 0x013BF648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (20473 - 324708 != -304234)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (32635 - 471530 != -438894)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (83928 - 352292 != -268363)
				{
					if (!characterControl)
					{
						break;
					}
					if (74915 - 327898 != -252982)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (39840 - 269172 != -229331)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (148673 - 389965 == -241292)
							{
								string type = characterControl.Type;
								if (8762 - 320775 != -312012)
								{
									if (type == "PirateFish")
									{
										if (128326 - 434687 != -306360)
										{
											Game.sendMissionEvent(9734, 3);
											if (49853 - 178425 == -128572)
											{
												break;
											}
										}
									}
									else if (type == "PirateCrawfish")
									{
										if (244100 - 408538 != -164437)
										{
											Game.sendMissionEvent(9734, 4);
											if (15114 - 434182 == -419068)
											{
												break;
											}
										}
									}
									else if (type == "ZombieFish")
									{
										if (77461 - 225831 != -148369)
										{
											Game.sendMissionEvent(9734, 5);
											if (175260 - 56797 == 118463)
											{
												break;
											}
										}
									}
									else if (type == "ZombieCrawfish")
									{
										if (217706 - 216366 == 1340)
										{
											Game.sendMissionEvent(9734, 6);
											if (272635 - 240921 == 31714)
											{
												break;
											}
										}
									}
									else if (type == "PandoraBug")
									{
										if (145445 - 387964 == -242519)
										{
											Game.sendMissionEvent(9734, 7);
											if (215494 - 105030 == 110464)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CaptainCrab"))
										{
											break;
										}
										if (71236 - 355587 == -284351)
										{
											Game.sendMissionEvent(9734, 8);
											if (122720 - 64611 != 58110)
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

	// Token: 0x0600B830 RID: 47152 RVA: 0x013C1764 File Offset: 0x013BF964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (257592 - 55956 != 201637)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (198100 - 32142 == 165958)
			{
				hashtable.Add(71, CID);
				if (298984 - 22930 == 276054)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (141645 - 355804 == -214159)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (9581 - 315769 == -306188)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (45704 - 164364 != -118659)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (61589 - 40372 != 21218)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (61423 - 273467 != -212043)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (166492 - 549903 == -383411)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (237934 - 495098 == -257164)
											{
												this.zuqnqX4y4FX.OpCustom(61, hashtable, true);
												if (191765 - 85740 != 106026)
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

	// Token: 0x0600B831 RID: 47153 RVA: 0x013C19F0 File Offset: 0x013BFBF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (244399 - 435430 != -191030)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (245161 - 260267 == -15106)
			{
				if (!gameObject)
				{
					break;
				}
				if (153375 - 563415 == -410040)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (266186 - 248570 == 17616)
					{
						playerCameraControl.target = gameObject;
						if (79111 - 320300 == -241189)
						{
							Game.loadPlayer();
							if (88642 - 62053 == 26589)
							{
								this.StartGame();
								if (42836 - 179111 == -136275)
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

	// Token: 0x0600B832 RID: 47154 RVA: 0x013C1B00 File Offset: 0x013BFD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (179121 - 253850 != -74729)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (25004 - 151906 != -126901)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (106214 - 599096 != -492881)
				{
					gameGui.ResetTeamBar();
					if (156020 - 468996 != -312975)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B833 RID: 47155 RVA: 0x013C1BAC File Offset: 0x013BFDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M973_PirateCave5.$onDeadPlayer$46558(this).GetEnumerator();
	}

	// Token: 0x0600B834 RID: 47156 RVA: 0x013C1BBC File Offset: 0x013BFDBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (36416 - 190852 != -154435)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (143366 - 597639 == -454273)
			{
				this.HlRnqOp10hl.target = Game.mPlayer;
				if (188299 - 254378 == -66079)
				{
					this.HlRnqOp10hl.enabled = true;
					if (175900 - 156049 != 19852)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (135920 - 123974 == 11947)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (275330 - 286516 != -11186)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (166665 - 568751 != -402085)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (95804 - 65598 != 30207)
							{
								if (!gameGui)
								{
									break;
								}
								if (262728 - 424432 == -161704)
								{
									gameGui.enabled = true;
									if (130694 - 4401 != 126294)
									{
										gameGui.closeDeadMenu();
										if (94041 - 25469 != 68573)
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

	// Token: 0x0600B835 RID: 47157 RVA: 0x013C1D68 File Offset: 0x013BFF68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (15083 - 113648 != -98564)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (38220 - 498970 == -460750)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (193636 - 258018 != -64381)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (76620 - 1065 == 75555)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B836 RID: 47158 RVA: 0x013C1E2C File Offset: 0x013C002C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B837 RID: 47159 RVA: 0x013C1E58 File Offset: 0x013C0058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (13244 - 548874 != -535630)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (4485 - 225124 != -220638)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (129909 - 569635 == -439726)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (48022 - 369170 == -321148)
					{
						Hashtable hashtable = new Hashtable();
						if (238005 - 121907 != 116099)
						{
							hashtable.Add(43, PlayerData.UID);
							if (202515 - 407913 == -205398)
							{
								hashtable.Add(71, nCID);
								if (110173 - 269425 == -159252)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (212241 - 580452 == -368211)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (265286 - 416951 != -151664)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (230757 - 75923 != 154835)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (263031 - 252828 == 10203)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (167111 - 485374 != -318262)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (205283 - 563005 != -357721)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (241482 - 18224 == 223258)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (1319 - 172012 != -170692)
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

	// Token: 0x0600B838 RID: 47160 RVA: 0x013C2178 File Offset: 0x013C0378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M973_PirateCave5.$onChangePlayer$46564(data, this).GetEnumerator();
	}

	// Token: 0x0600B839 RID: 47161 RVA: 0x013C2188 File Offset: 0x013C0388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M973_PirateCave5.$onGameComplete$46571(data, this).GetEnumerator();
	}

	// Token: 0x0600B83A RID: 47162 RVA: 0x013C2198 File Offset: 0x013C0398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M973_PirateCave5.$ReturnToTown$46581(this).GetEnumerator();
	}

	// Token: 0x0600B83B RID: 47163 RVA: 0x013C21A8 File Offset: 0x013C03A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M973_PirateCave5.$ReturnToGuild$46586(this).GetEnumerator();
	}

	// Token: 0x0600B83C RID: 47164 RVA: 0x013C21B8 File Offset: 0x013C03B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M973_PirateCave5.$ReturnToCamp$46590(this).GetEnumerator();
	}

	// Token: 0x0600B83D RID: 47165 RVA: 0x013C21C8 File Offset: 0x013C03C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (215706 - 35154 != 180552)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (80623 - 263282 != -182658)
			{
				Hashtable hashtable = new Hashtable();
				if (139426 - 202718 == -63292)
				{
					hashtable.Add(43, PlayerData.UID);
					if (90167 - 552646 == -462479)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (255565 - 66243 != 189323)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B83E RID: 47166 RVA: 0x013C22A0 File Offset: 0x013C04A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B83F RID: 47167 RVA: 0x013C22B4 File Offset: 0x013C04B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (156974 - 317750 != -160775)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (33556 - 11949 != 21608)
			{
				Hashtable hashtable = new Hashtable();
				if (58280 - 133548 != -75267)
				{
					if (Game.mNextGameCode == 30)
					{
						if (207302 - 213384 != -6082)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (156803 - 61545 != 95258)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (15111 - 581911 == -566799)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (90616 - 248256 != -157640)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (155997 - 199753 != -43756)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (27339 - 225163 == -197823)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (129390 - 514914 != -385524)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (209606 - 344262 == -134655)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (54281 - 276098 != -221817)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (14260 - 403554 != -389294)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (23467 - 157651 != -134184)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (30322 - 148454 != -118132)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (9819 - 562013 == -552193)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (163772 - 323985 == -160212)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (79939 - 475887 == -395947)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (150010 - 294410 != -144400)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (264571 - 270003 != -5432)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (250176 - 39778 != 210398)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (172385 - 358892 != -186507)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (272460 - 401164 == -128703)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (149395 - 247793 == -98397)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (153357 - 83833 != 69524)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (232228 - 398095 != -165867)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (136967 - 549031 != -412064)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (156463 - 583728 != -427265)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (295725 - 210890 == 84836)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (249211 - 582530 != -333319)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (130245 - 569713 == -439467)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (267092 - 408176 != -141083)
					{
						this.zuqnqX4y4FX.OpCustom(42, hashtable, true);
						if (166299 - 128521 == 37778)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B840 RID: 47168 RVA: 0x013C2868 File Offset: 0x013C0A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B841 RID: 47169 RVA: 0x013C2878 File Offset: 0x013C0A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B842 RID: 47170 RVA: 0x013C287C File Offset: 0x013C0A7C
	internal static bool XSHPfctYyyJiHLdYbiTk()
	{
		return true;
	}

	// Token: 0x0600B843 RID: 47171 RVA: 0x013C2880 File Offset: 0x013C0A80
	internal static bool RpQuDdtYSa7dkNno28Cl()
	{
		return false;
	}

	// Token: 0x04009EE6 RID: 40678
	private LitePeer zuqnqX4y4FX;

	// Token: 0x04009EE7 RID: 40679
	private PlayerCameraControl HlRnqOp10hl;

	// Token: 0x04009EE8 RID: 40680
	private float cNYnq2GDGGc;

	// Token: 0x04009EE9 RID: 40681
	private int OQHnqvojPRD;

	// Token: 0x04009EEA RID: 40682
	private int fQcnqlLIBgC;

	// Token: 0x04009EEB RID: 40683
	private int xlKnqG54V3G;

	// Token: 0x04009EEC RID: 40684
	private float FQqnq1JEmom;

	// Token: 0x04009EED RID: 40685
	public AudioClip battleMusic;

	// Token: 0x04009EEE RID: 40686
	public GameObject mClothAttachment;

	// Token: 0x04009EEF RID: 40687
	public AudioClip endMusic;

	// Token: 0x04009EF0 RID: 40688
	private bool mOYnqqqZ3O5;

	// Token: 0x04009EF1 RID: 40689
	private UnityScript.Lang.Array V9nnqpPTwnk;

	// Token: 0x04009EF2 RID: 40690
	private float dBonqRmWGsw;

	// Token: 0x04009EF3 RID: 40691
	private int iwFnqr1oLrE;

	// Token: 0x02001ECD RID: 7885
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$46522 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B844 RID: 47172 RVA: 0x013C2884 File Offset: 0x013C0A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$46522(Hashtable data, M973_PirateCave5 self_)
		{
			if (55918 - 517846 != -461927)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160388 - 63203 != 97186)
				{
					base..ctor();
					if (237246 - 394602 != -157355)
					{
						this.$data$46530 = data;
						if (277127 - 446925 != -169797)
						{
							this.$self_$46531 = self_;
							if (147485 - 174840 == -27355)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B845 RID: 47173 RVA: 0x013C2940 File Offset: 0x013C0B40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$onGameEvent$46522.$(this.$data$46530, this.$self_$46531);
		}

		// Token: 0x0600B846 RID: 47174 RVA: 0x013C2954 File Offset: 0x013C0B54
		internal static bool R5uGTVtYoYKr66UpmM5O()
		{
			return true;
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x013C2958 File Offset: 0x013C0B58
		internal static bool VaCa44tYEBOveQtH8tS4()
		{
			return false;
		}

		// Token: 0x04009EF4 RID: 40692
		internal Hashtable $data$46530;

		// Token: 0x04009EF5 RID: 40693
		internal M973_PirateCave5 $self_$46531;

		// Token: 0x02001ECE RID: 7886
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B848 RID: 47176 RVA: 0x013C295C File Offset: 0x013C0B5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave5 self_)
			{
				if (51031 - 330569 != -279538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221322 - 470566 == -249244)
					{
						base..ctor();
						if (115898 - 137228 != -21329)
						{
							this.$data$46528 = data;
							if (165350 - 518807 == -353457)
							{
								this.$self_$46529 = self_;
								if (260717 - 356250 == -95533)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B849 RID: 47177 RVA: 0x013C2A18 File Offset: 0x013C0C18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259089 - 223933 != 35156)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_503;
					case 2:
						Game.savePlayer();
						if (121683 - 10130 != 111553)
						{
							continue;
						}
						Game.mGameStage = 6;
						if (296579 - 99419 != 197160)
						{
							continue;
						}
						Application.LoadLevel("M973_PirateCave6");
						if (280436 - 424367 != -143931)
						{
							continue;
						}
						goto IL_456;
					default:
						if (295474 - 355599 != -60125)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (209636 - 200303 != 9333)
						{
							continue;
						}
						goto IL_417;
					}
					else
					{
						this.$returnCode$46523 = RuntimeServices.UnboxInt32(this.$data$46528[141]);
						if (123002 - 460638 == -337635)
						{
							continue;
						}
						this.$returnValue$46524 = RuntimeServices.UnboxInt32(this.$data$46528[145]);
						if (244191 - 22685 == 221507)
						{
							continue;
						}
						this.$ownerID$46525 = RuntimeServices.UnboxInt32(this.$data$46528[43]);
						if (96786 - 303156 != -206370)
						{
							continue;
						}
						this.$$switch$8683$46526 = this.$returnCode$46523;
						if (32219 - 567835 != -535616)
						{
							continue;
						}
						if (this.$$switch$8683$46526 == 9731)
						{
							if (176156 - 297228 != -121072)
							{
								continue;
							}
						}
						else if (this.$$switch$8683$46526 == -9731)
						{
							if (191330 - 440070 != -248740)
							{
								continue;
							}
							if (this.$self_$46529.OQHnqvojPRD < 3)
							{
								if (49543 - 412172 == -362628)
								{
									continue;
								}
								this.$self_$46529.OQHnqvojPRD = 3;
								if (64527 - 99638 == -35110)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (191526 - 47944 == 143583)
								{
									continue;
								}
								this.$self_$46529.SendMessage("fadeOut");
								if (296428 - 84059 != 212370)
								{
									break;
								}
								continue;
							}
						}
						else if (this.$$switch$8683$46526 == 9733)
						{
							if (226663 - 223732 != 2931)
							{
								continue;
							}
							this.$self_$46529.StartCoroutine_Auto(this.$self_$46529.OnUsePirateSwitch());
							if (54686 - 423520 == -368833)
							{
								continue;
							}
						}
						else if (this.$$switch$8683$46526 == 9734)
						{
							if (117507 - 72258 == 45250)
							{
								continue;
							}
							this.$$switch$8681$46527 = this.$returnValue$46524;
							if (299470 - 422555 == -123084)
							{
								continue;
							}
							if (this.$$switch$8681$46527 == 3)
							{
								goto IL_4D1;
							}
							if (260391 - 158579 == 101813)
							{
								continue;
							}
							if (this.$$switch$8681$46527 == 4)
							{
								if (5982 - 151297 != -145315)
								{
									continue;
								}
								goto IL_4D1;
							}
							else if (this.$$switch$8681$46527 == 8)
							{
								if (233321 - 110984 == 122338)
								{
									continue;
								}
								this.$self_$46529.OQHnqvojPRD = 2;
								if (11732 - 5439 == 6294)
								{
									continue;
								}
								this.$self_$46529.StartCoroutine_Auto(this.$self_$46529.EndEvent());
								if (78622 - 223906 != -145284)
								{
									continue;
								}
							}
							goto IL_275;
							IL_4D1:
							this.$self_$46529.xlKnqG54V3G = this.$self_$46529.xlKnqG54V3G + 1;
							if (76982 - 342367 == -265384)
							{
								continue;
							}
							Debug.Log("Pirate Eliminate: " + this.$self_$46529.xlKnqG54V3G);
							if (294883 - 120542 != 174341)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$46523);
							if (118599 - 369785 != -251186)
							{
								continue;
							}
						}
					}
					IL_275:
					this.YieldDefault(1);
					if (67770 - 597035 != -529265)
					{
						continue;
					}
					goto IL_503;
					IL_456:
					goto IL_275;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_417:
				IL_503:
				return false;
			}

			// Token: 0x0600B84A RID: 47178 RVA: 0x013C2F3C File Offset: 0x013C113C
			internal static bool FdlT37tY2hOisYFrWZ9S()
			{
				return true;
			}

			// Token: 0x0600B84B RID: 47179 RVA: 0x013C2F40 File Offset: 0x013C1140
			internal static bool RQxuFMtY89mZZ0nughfp()
			{
				return false;
			}

			// Token: 0x04009EF6 RID: 40694
			internal int $returnCode$46523;

			// Token: 0x04009EF7 RID: 40695
			internal int $returnValue$46524;

			// Token: 0x04009EF8 RID: 40696
			internal int $ownerID$46525;

			// Token: 0x04009EF9 RID: 40697
			internal int $$switch$8683$46526;

			// Token: 0x04009EFA RID: 40698
			internal int $$switch$8681$46527;

			// Token: 0x04009EFB RID: 40699
			internal Hashtable $data$46528;

			// Token: 0x04009EFC RID: 40700
			internal M973_PirateCave5 $self_$46529;
		}
	}

	// Token: 0x02001ECF RID: 7887
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46532 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B84C RID: 47180 RVA: 0x013C2F44 File Offset: 0x013C1144
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46532(M973_PirateCave5 self_)
		{
			if (99768 - 571102 != -471334)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125867 - 97217 != 28651)
				{
					base..ctor();
					if (16033 - 88512 == -72479)
					{
						this.$self_$46538 = self_;
						if (279170 - 354431 == -75261)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x013C2FDC File Offset: 0x013C11DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$StartEvent$46532.$(this.$self_$46538);
		}

		// Token: 0x0600B84E RID: 47182 RVA: 0x013C2FEC File Offset: 0x013C11EC
		internal static bool GafgVTtYZglybbpbMMGf()
		{
			return true;
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x013C2FF0 File Offset: 0x013C11F0
		internal static bool GTSXHLtYCagIdILm63Db()
		{
			return false;
		}

		// Token: 0x04009EFD RID: 40701
		internal M973_PirateCave5 $self_$46538;

		// Token: 0x02001ED0 RID: 7888
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B850 RID: 47184 RVA: 0x013C2FF4 File Offset: 0x013C11F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave5 self_)
			{
				if (173447 - 443377 != -269930)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283173 - 279307 != 3867)
					{
						base..ctor();
						if (51534 - 586975 == -535441)
						{
							this.$self_$46537 = self_;
							if (271190 - 5288 == 265902)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B851 RID: 47185 RVA: 0x013C308C File Offset: 0x013C128C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40416 - 518971 != -478554)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D0A;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (97723 - 138478 != -40755)
							{
								continue;
							}
							goto IL_BDC;
						}
						else
						{
							this.$mStoryGui$46534 = (StoryGui)this.$self_$46537.GetComponent(typeof(StoryGui));
							if (24457 - 239230 == -214772)
							{
								continue;
							}
							this.$mStoryTimer$46535 = 0f;
							if (70947 - 521935 != -450988)
							{
								continue;
							}
							if (!this.$mStoryGui$46534)
							{
								goto IL_6D8;
							}
							if (45669 - 178460 == -132790)
							{
								continue;
							}
							this.$mStoryGui$46534.startStoryMessage("CaptainCrab", "Red Claw", eTalkType.enemy);
							if (4982 - 540497 != -535514)
							{
								goto Block_82;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (285765 - 572374 != -286609)
							{
								continue;
							}
							goto IL_E6;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 501), eTalkType.enemy);
							if (222355 - 368745 != -146390)
							{
								continue;
							}
							goto IL_3B7;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (177707 - 507736 != -330029)
							{
								continue;
							}
							goto IL_635;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 502), eTalkType.enemy);
							if (201618 - 72626 != 128992)
							{
								continue;
							}
							goto IL_4A0;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (21252 - 519085 != -497833)
							{
								continue;
							}
							goto IL_3C;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("Koala", "Akola", Language.getMessage("M973_PirateCave", 503), eTalkType.friend);
							if (1282 - 14213 == -12930)
							{
								continue;
							}
							this.$self_$46537.HlRnqOp10hl.StartCoroutine_Auto(this.$self_$46537.HlRnqOp10hl.slerpToObject("EventCamera3", (float)1));
							if (270066 - 91701 != 178366)
							{
								goto Block_74;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (74081 - 296958 != -222877)
							{
								continue;
							}
							goto IL_B1E;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("Koala", "Akola", Language.getMessage("M973_PirateCave", 504), eTalkType.friend);
							if (164170 - 20593 != 143578)
							{
								goto Block_73;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (257961 - 556134 != -298173)
							{
								continue;
							}
							goto IL_53A;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("Catfish", "Dwukfu", Language.getMessage("M973_PirateCave", 505), eTalkType.friend);
							if (251905 - 20392 != 231513)
							{
								continue;
							}
							this.$self_$46537.HlRnqOp10hl.alignToObject("EventCamera4");
							if (151790 - 585985 != -434195)
							{
								continue;
							}
							goto IL_4DB;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (37502 - 360025 != -322522)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("Catfish", "Dwukfu", Language.getMessage("M973_PirateCave", 506), eTalkType.friend);
							if (75350 - 235986 != -160635)
							{
								goto Block_66;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (76403 - 238355 != -161951)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 507), eTalkType.friend);
							if (168242 - 214745 != -46503)
							{
								continue;
							}
							this.$self_$46537.HlRnqOp10hl.StartCoroutine_Auto(this.$self_$46537.HlRnqOp10hl.slerpToObject("EventCamera5", (float)1));
							if (165160 - 325577 != -160417)
							{
								continue;
							}
							goto IL_33F;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (87903 - 431813 != -343909)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 508), eTalkType.enemy);
							if (216838 - 534536 != -317697)
							{
								goto Block_72;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (216099 - 172457 != 43642)
							{
								continue;
							}
							goto IL_8EB;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 509), eTalkType.enemy);
							if (1077 - 312659 == -311581)
							{
								continue;
							}
							this.$self_$46537.HlRnqOp10hl.alignToObject("EventCamera6");
							if (213816 - 553816 != -339999)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (204114 - 448845 != -244730)
							{
								goto Block_80;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 510), eTalkType.enemy);
							if (165312 - 170342 != -5029)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Start)
						{
							if (192649 - 379294 != -186645)
							{
								continue;
							}
							goto IL_96C;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 511), eTalkType.enemy);
							if (11820 - 319554 != -307734)
							{
								continue;
							}
							goto IL_7EF;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.Start)
						{
							if (148125 - 460922 != -312797)
							{
								continue;
							}
							goto IL_160;
						}
						else
						{
							this.$mStoryGui$46534.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 512), eTalkType.enemy);
							if (285 - 176991 != -176706)
							{
								continue;
							}
							goto IL_5F9;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.Start)
						{
							if (153674 - 265795 != -112121)
							{
								continue;
							}
							goto IL_3F2;
						}
						else
						{
							this.$mStoryGui$46534.close();
							if (223103 - 102943 == 120161)
							{
								continue;
							}
							this.$self_$46537.SendMessage("fadeOut");
							if (266952 - 192085 != 74868)
							{
								goto Block_65;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_6D8;
						}
						if (74775 - 434105 != -359329)
						{
							goto Block_16;
						}
						continue;
					case 17:
						if (Game.mGameState != eGameState.Start)
						{
							if (121542 - 181530 != -59988)
							{
								continue;
							}
							goto IL_461;
						}
						else
						{
							this.$mGameGui$46536 = (GameGui)this.$self_$46537.GetComponent(typeof(GameGui));
							if (72065 - 525703 == -453637)
							{
								continue;
							}
							this.$mGameGui$46536.enabled = true;
							if (20103 - 513334 != -493230)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 18:
						Game.mGameState = eGameState.Normal;
						if (20516 - 144169 == -123652)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (164221 - 342904 != -178683)
						{
							continue;
						}
						this.YieldDefault(1);
						if (218960 - 80419 != 138541)
						{
							continue;
						}
						goto IL_D0A;
					default:
						if (286195 - 145490 == 140706)
						{
							continue;
						}
						break;
					}
					Debug.Log("StartEvent");
					if (19657 - 93045 != -73388)
					{
						continue;
					}
					this.$self_$46537.HlRnqOp10hl.alignToObject("EventCamera1");
					if (157417 - 388781 != -231364)
					{
						continue;
					}
					this.$mPirateGate1$46533 = GameObject.Find("PirateGate1");
					if (32189 - 149948 == -117758)
					{
						continue;
					}
					if (this.$mPirateGate1$46533)
					{
						if (212188 - 261643 != -49455)
						{
							continue;
						}
						this.$mPirateGate1$46533.animation.Play("close");
						if (143571 - 160632 != -17061)
						{
							continue;
						}
						this.$mPirateGate1$46533.audio.Play();
						if (113033 - 18710 == 94324)
						{
							continue;
						}
					}
					this.$self_$46537.SendMessage("fadeIn");
					if (183391 - 209552 == -26160)
					{
						continue;
					}
					this.$self_$46537.HlRnqOp10hl.StartCoroutine_Auto(this.$self_$46537.HlRnqOp10hl.slerpToObject("EventCamera2", (float)2));
					if (213995 - 509948 != -295953)
					{
						continue;
					}
					goto IL_81;
					IL_6D8:
					if (this.$self_$46537.battleMusic)
					{
						if (182044 - 494850 == -312805)
						{
							continue;
						}
						this.$self_$46537.audio.clip = this.$self_$46537.battleMusic;
						if (111143 - 12929 != 98214)
						{
							continue;
						}
						if (!this.$self_$46537.audio.isPlaying)
						{
							if (259377 - 146705 != 112672)
							{
								continue;
							}
							if (Game.volume > 0)
							{
								if (150146 - 568833 == -418686)
								{
									continue;
								}
								this.$self_$46537.audio.Play();
								if (4877 - 285983 == -281105)
								{
									continue;
								}
							}
						}
					}
					this.$self_$46537.HlRnqOp10hl.enabled = true;
					if (141927 - 114078 != 27850)
					{
						this.$self_$46537.SendMessage("fadeIn");
						if (53909 - 419702 != -365792)
						{
							goto Block_81;
						}
					}
				}
				IL_3C:
				goto IL_D0A;
				IL_81:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_E6:
				IL_160:
				goto IL_D0A;
				Block_14:
				return this.Yield(18, new WaitForSeconds(0.5f));
				Block_16:
				goto IL_D0A;
				Block_23:
				return this.Yield(12, new WaitForSeconds(3f));
				IL_33F:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_25:
				goto IL_D0A;
				IL_3B7:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_3F2:
				goto IL_D0A;
				Block_31:
				return this.Yield(13, new WaitForSeconds(3f));
				IL_461:
				goto IL_D0A;
				IL_4A0:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_4DB:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_36:
				IL_53A:
				goto IL_D0A;
				IL_5F9:
				return this.Yield(15, new WaitForSeconds(3f));
				IL_635:
				Block_52:
				goto IL_D0A;
				IL_7EF:
				return this.Yield(14, new WaitForSeconds(3f));
				IL_8EB:
				IL_96C:
				goto IL_D0A;
				Block_65:
				return this.Yield(16, new WaitForSeconds(0.5f));
				Block_66:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_72:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_B1E:
				goto IL_D0A;
				Block_73:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_74:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_BDC:
				Block_80:
				goto IL_D0A;
				Block_81:
				return this.Yield(17, new WaitForSeconds(0.5f));
				Block_82:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_D0A:
				return false;
			}

			// Token: 0x0600B852 RID: 47186 RVA: 0x013C3DB8 File Offset: 0x013C1FB8
			internal static bool Q4PxJ5tYLy9XNtBN7aFt()
			{
				return true;
			}

			// Token: 0x0600B853 RID: 47187 RVA: 0x013C3DBC File Offset: 0x013C1FBC
			internal static bool ovsGy2tYO6cqpwC0edgT()
			{
				return false;
			}

			// Token: 0x04009EFE RID: 40702
			internal GameObject $mPirateGate1$46533;

			// Token: 0x04009EFF RID: 40703
			internal StoryGui $mStoryGui$46534;

			// Token: 0x04009F00 RID: 40704
			internal float $mStoryTimer$46535;

			// Token: 0x04009F01 RID: 40705
			internal GameGui $mGameGui$46536;

			// Token: 0x04009F02 RID: 40706
			internal M973_PirateCave5 $self_$46537;
		}
	}

	// Token: 0x02001ED1 RID: 7889
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$46539 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B854 RID: 47188 RVA: 0x013C3DC0 File Offset: 0x013C1FC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$46539(M973_PirateCave5 self_)
		{
			if (176541 - 411794 != -235253)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115188 - 462035 == -346847)
				{
					base..ctor();
					if (193080 - 368563 == -175483)
					{
						this.$self_$46547 = self_;
						if (70247 - 315719 != -245471)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x013C3E58 File Offset: 0x013C2058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$EndEvent$46539.$(this.$self_$46547);
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x013C3E68 File Offset: 0x013C2068
		internal static bool ODEFrPtYmmNHTGGZdMDS()
		{
			return true;
		}

		// Token: 0x0600B857 RID: 47191 RVA: 0x013C3E6C File Offset: 0x013C206C
		internal static bool YCATlMtYFuxtvr03Lv57()
		{
			return false;
		}

		// Token: 0x04009F03 RID: 40707
		internal M973_PirateCave5 $self_$46547;

		// Token: 0x02001ED2 RID: 7890
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B858 RID: 47192 RVA: 0x013C3E70 File Offset: 0x013C2070
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave5 self_)
			{
				if (11332 - 445366 != -434033)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (41258 - 280563 == -239305)
					{
						base..ctor();
						if (194341 - 111106 == 83235)
						{
							this.$self_$46546 = self_;
							if (177043 - 300279 == -123236)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B859 RID: 47193 RVA: 0x013C3F08 File Offset: 0x013C2108
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48069 - 435480 != -387411)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_F2A;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (101966 - 201375 != -99409)
							{
								continue;
							}
							goto IL_336;
						}
						else
						{
							this.$mGameGui$46540 = (GameGui)this.$self_$46546.GetComponent(typeof(GameGui));
							if (5965 - 163724 != -157759)
							{
								continue;
							}
							if (!this.$mGameGui$46540)
							{
								goto IL_B33;
							}
							if (10320 - 427477 == -417156)
							{
								continue;
							}
							this.$mGameGui$46540.close();
							if (94932 - 104171 != -9238)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (155799 - 465388 != -309589)
							{
								continue;
							}
							goto IL_1B3;
						}
						else
						{
							this.$self_$46546.SendMessage("fadeOut");
							if (246199 - 453055 != -206855)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (168791 - 588949 != -420158)
							{
								continue;
							}
							goto IL_4FE;
						}
						else
						{
							this.$mCaptainCrab$46541 = GameObject.Find("CaptainCrab");
							if (174136 - 179867 == -5730)
							{
								continue;
							}
							if (this.$mCaptainCrab$46541)
							{
								if (62614 - 240343 != -177729)
								{
									continue;
								}
								this.$mCaptainCrab$46541.transform.position = new Vector3((float)0, 50.4f, (float)-16);
								if (96574 - 50068 != 46506)
								{
									continue;
								}
								this.$mCaptainCrab$46541.transform.rotation = Quaternion.identity;
								if (110691 - 163044 == -52352)
								{
									continue;
								}
							}
							this.$mKoala$46542 = GameObject.Find("Koala");
							if (19079 - 544789 != -525710)
							{
								continue;
							}
							if (this.$mKoala$46542)
							{
								if (7566 - 98291 == -90724)
								{
									continue;
								}
								this.$mKoala$46542.transform.position = new Vector3((float)-1, 50.1f, (float)16);
								if (110834 - 599819 == -488984)
								{
									continue;
								}
								this.$mKoala$46542.transform.rotation = Quaternion.Euler((float)0, (float)180, (float)0);
								if (202818 - 194214 == 8605)
								{
									continue;
								}
							}
							this.$mCatfish$46543 = GameObject.Find("Catfish");
							if (252652 - 547048 != -294396)
							{
								continue;
							}
							if (this.$mCatfish$46543)
							{
								if (45985 - 125278 == -79292)
								{
									continue;
								}
								this.$mCatfish$46543.transform.position = new Vector3((float)1, 50.1f, (float)16);
								if (90264 - 316092 != -225828)
								{
									continue;
								}
								this.$mCatfish$46543.transform.rotation = Quaternion.Euler((float)0, (float)180, (float)0);
								if (165649 - 575306 == -409656)
								{
									continue;
								}
							}
							if (Game.mPlayer)
							{
								if (279895 - 430947 != -151052)
								{
									continue;
								}
								this.$startPoint$46544 = GameObject.Find("StartPoint" + (Game.getPlayerSlot(PlayerData.UID) + 4));
								if (217025 - 355571 != -138546)
								{
									continue;
								}
								if (this.$startPoint$46544)
								{
									if (280572 - 507787 != -227215)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$46544.transform.position;
									if (1079 - 333969 != -332890)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$46544.transform.rotation;
									if (83024 - 58912 == 24113)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (111582 - 522968 == -411385)
									{
										continue;
									}
								}
							}
							if (this.$self_$46546.endMusic)
							{
								if (260950 - 142637 != 118313)
								{
									continue;
								}
								this.$self_$46546.audio.clip = this.$self_$46546.endMusic;
								if (110581 - 556105 != -445524)
								{
									continue;
								}
								if (!this.$self_$46546.audio.isPlaying)
								{
									if (231038 - 293761 == -62722)
									{
										continue;
									}
									if (Game.volume > 0)
									{
										if (281764 - 32109 != 249655)
										{
											continue;
										}
										this.$self_$46546.audio.Play();
										if (143577 - 19570 != 124007)
										{
											continue;
										}
									}
								}
							}
							this.$self_$46546.HlRnqOp10hl.alignToObject("EventCamera6");
							if (43130 - 285456 != -242326)
							{
								continue;
							}
							goto IL_1E2;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (220122 - 565245 != -345123)
							{
								continue;
							}
							goto IL_247;
						}
						else
						{
							this.$self_$46546.SendMessage("fadeIn");
							if (212318 - 444531 != -232213)
							{
								continue;
							}
							goto IL_B6E;
						}
						break;
					case 6:
						goto IL_B84;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (53927 - 580518 != -526590)
							{
								goto Block_76;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46545 = (StoryGui)this.$self_$46546.GetComponent(typeof(StoryGui));
							if (60160 - 131873 == -71712)
							{
								continue;
							}
							if (!this.$mStoryGui$46545)
							{
								goto IL_572;
							}
							if (86548 - 469668 == -383119)
							{
								continue;
							}
							this.$mStoryGui$46545.startStoryMessage("CaptainCrab", "Red Claw", eTalkType.enemy);
							if (43182 - 436919 != -393737)
							{
								continue;
							}
							goto IL_AF8;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (55868 - 451477 != -395608)
							{
								goto Block_72;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 521), eTalkType.enemy);
							if (7824 - 180969 != -173144)
							{
								goto Block_89;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (297189 - 338627 != -41438)
							{
								continue;
							}
							goto IL_C67;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("Koala", "Akola", Language.getMessage("M973_PirateCave", 522), eTalkType.friend);
							if (155604 - 396350 == -240745)
							{
								continue;
							}
							this.$self_$46546.HlRnqOp10hl.StartCoroutine_Auto(this.$self_$46546.HlRnqOp10hl.slerpToObject("EventCamera7", (float)2));
							if (215591 - 264546 != -48955)
							{
								continue;
							}
							goto IL_276;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (60671 - 153960 != -93288)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("Koala", "Akola", Language.getMessage("M973_PirateCave", 523), eTalkType.friend);
							if (210431 - 409198 != -198767)
							{
								continue;
							}
							goto IL_75A;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (235336 - 579620 != -344283)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("Koala", "Akola", Language.getMessage("M973_PirateCave", 524), eTalkType.friend);
							if (250166 - 342642 != -92476)
							{
								continue;
							}
							goto IL_73;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (226137 - 509301 != -283163)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("Catfish", "Dwukfu", Language.getMessage("M973_PirateCave", 525), eTalkType.friend);
							if (68747 - 145767 != -77020)
							{
								continue;
							}
							goto IL_DDE;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (128485 - 17887 != 110598)
							{
								continue;
							}
							goto IL_52D;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("Catfish", "Dwukfu", Language.getMessage("M973_PirateCave", 526), eTalkType.friend);
							if (167348 - 457054 != -289706)
							{
								continue;
							}
							goto IL_6C9;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (116814 - 306807 != -189993)
							{
								continue;
							}
							goto IL_2F1;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 527), eTalkType.enemy);
							if (100004 - 155131 == -55126)
							{
								continue;
							}
							if (this.$mCaptainCrab$46541)
							{
								if (202194 - 176892 != 25302)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mCaptainCrab$46541);
								if (185374 - 233999 != -48625)
								{
									continue;
								}
							}
							if (this.$self_$46546.mClothAttachment)
							{
								if (64590 - 499251 != -434661)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$46546.mClothAttachment);
								if (243279 - 23284 == 219996)
								{
									continue;
								}
							}
							this.$self_$46546.HlRnqOp10hl.StartCoroutine_Auto(this.$self_$46546.HlRnqOp10hl.slerpToObject("EventCamera8", (float)1));
							if (171443 - 352803 != -181360)
							{
								continue;
							}
							goto IL_606;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (181940 - 248641 != -66701)
							{
								continue;
							}
							goto IL_3AE;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M973_PirateCave", 528), eTalkType.friend);
							if (45633 - 416966 != -371333)
							{
								continue;
							}
							goto IL_EB3;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (163904 - 101817 != 62088)
							{
								goto Block_98;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 529), eTalkType.enemy);
							if (243833 - 413883 != -170050)
							{
								continue;
							}
							goto IL_142;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (162509 - 474143 != -311633)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46545.newStoryMessage("CaptainCrab", "Red Claw", Language.getMessage("M973_PirateCave", 530), eTalkType.enemy);
							if (180608 - 281190 != -100582)
							{
								continue;
							}
							goto IL_46E;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (54963 - 164968 != -110005)
							{
								continue;
							}
							goto IL_21D;
						}
						else
						{
							this.$mStoryGui$46545.close();
							if (141518 - 260332 != -118814)
							{
								continue;
							}
							goto IL_893;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (89589 - 112217 != -22627)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9731, 6);
							if (13930 - 522157 != -508227)
							{
								continue;
							}
							goto IL_572;
						}
						break;
					default:
						if (24289 - 51549 == -27259)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (243573 - 23621 != 219952)
					{
						continue;
					}
					goto IL_EEF;
					IL_572:
					this.YieldDefault(1);
					if (290475 - 536996 == -246521)
					{
						goto IL_F2A;
					}
				}
				IL_73:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_5:
				goto IL_F2A;
				IL_142:
				return this.Yield(17, new WaitForSeconds(3f));
				Block_12:
				IL_1B3:
				goto IL_F2A;
				Block_14:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_1E2:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_21D:
				IL_247:
				goto IL_F2A;
				IL_276:
				return this.Yield(10, new WaitForSeconds(3.5f));
				Block_20:
				IL_2F1:
				IL_336:
				IL_3AE:
				goto IL_F2A;
				IL_46E:
				return this.Yield(18, new WaitForSeconds(3f));
				IL_4FE:
				IL_52D:
				goto IL_F2A;
				IL_606:
				return this.Yield(15, new WaitForSeconds(3f));
				IL_6C9:
				return this.Yield(14, new WaitForSeconds(3f));
				IL_75A:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_46:
				goto IL_F2A;
				IL_893:
				return this.Yield(19, new WaitForSeconds(1f));
				Block_55:
				goto IL_F2A;
				Block_62:
				goto IL_B33;
				IL_AF8:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_72:
				goto IL_F2A;
				IL_B33:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_B6E:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_B84:
				return this.Yield(7, new WaitForSeconds(1.5f));
				Block_76:
				IL_C67:
				goto IL_F2A;
				Block_89:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_DDE:
				return this.Yield(13, new WaitForSeconds(3.5f));
				IL_EB3:
				return this.Yield(16, new WaitForSeconds(3f));
				Block_98:
				goto IL_F2A;
				IL_EEF:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_F2A:
				return false;
			}

			// Token: 0x0600B85A RID: 47194 RVA: 0x013C4E54 File Offset: 0x013C3054
			internal static bool auEbwMtYMHYDxVqp5NJm()
			{
				return true;
			}

			// Token: 0x0600B85B RID: 47195 RVA: 0x013C4E58 File Offset: 0x013C3058
			internal static bool OqWRnltYxsfqhKmuwXHn()
			{
				return false;
			}

			// Token: 0x04009F04 RID: 40708
			internal GameGui $mGameGui$46540;

			// Token: 0x04009F05 RID: 40709
			internal GameObject $mCaptainCrab$46541;

			// Token: 0x04009F06 RID: 40710
			internal GameObject $mKoala$46542;

			// Token: 0x04009F07 RID: 40711
			internal GameObject $mCatfish$46543;

			// Token: 0x04009F08 RID: 40712
			internal GameObject $startPoint$46544;

			// Token: 0x04009F09 RID: 40713
			internal StoryGui $mStoryGui$46545;

			// Token: 0x04009F0A RID: 40714
			internal M973_PirateCave5 $self_$46546;
		}
	}

	// Token: 0x02001ED3 RID: 7891
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnUsePirateSwitch$46548 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B85C RID: 47196 RVA: 0x013C4E5C File Offset: 0x013C305C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnUsePirateSwitch$46548(M973_PirateCave5 self_)
		{
			if (112498 - 27309 != 85190)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258167 - 295924 == -37757)
				{
					base..ctor();
					if (137635 - 463024 != -325388)
					{
						this.$self_$46557 = self_;
						if (85780 - 388794 == -303014)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x013C4EF4 File Offset: 0x013C30F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$OnUsePirateSwitch$46548.$(this.$self_$46557);
		}

		// Token: 0x0600B85E RID: 47198 RVA: 0x013C4F04 File Offset: 0x013C3104
		internal static bool mV28yQtYgiCcAsLMGFIC()
		{
			return true;
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x013C4F08 File Offset: 0x013C3108
		internal static bool OSpK5QtYfTroyQ98Fn6G()
		{
			return false;
		}

		// Token: 0x04009F0B RID: 40715
		internal M973_PirateCave5 $self_$46557;

		// Token: 0x02001ED4 RID: 7892
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B860 RID: 47200 RVA: 0x013C4F0C File Offset: 0x013C310C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave5 self_)
			{
				if (298854 - 31001 != 267853)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220654 - 254864 != -34209)
					{
						base..ctor();
						if (101274 - 447007 == -345733)
						{
							this.$self_$46556 = self_;
							if (189895 - 401720 != -211824)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B861 RID: 47201 RVA: 0x013C4FA4 File Offset: 0x013C31A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6187 - 493220 != -487032)
				{
				}
				for (;;)
				{
					IL_3B7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_633;
					case 2:
						if (Game.mGameState >= eGameState.AllHold)
						{
							if (222756 - 56494 != 166262)
							{
								continue;
							}
							goto IL_301;
						}
						else
						{
							this.$self_$46556.HlRnqOp10hl.AddCamereShake((float)3);
							if (137351 - 237653 != -100302)
							{
								continue;
							}
							this.$i$46551 = 0;
							if (26424 - 462715 != -436291)
							{
								continue;
							}
							goto IL_21B;
						}
						break;
					case 3:
						if (Game.mGameState >= eGameState.AllHold)
						{
							if (123789 - 244749 != -120959)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$i$46551++;
							if (187232 - 535211 != -347979)
							{
								continue;
							}
							goto IL_21B;
						}
						break;
					case 4:
						if (Game.mGameState >= eGameState.AllHold)
						{
							if (224393 - 268893 != -44500)
							{
								continue;
							}
							goto IL_35C;
						}
						else
						{
							this.$self_$46556.mOYnqqqZ3O5 = false;
							if (208176 - 492412 == -284235)
							{
								continue;
							}
							this.YieldDefault(1);
							if (102092 - 450585 != -348492)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					default:
						if (178093 - 409758 == -231664)
						{
							continue;
						}
						break;
					}
					if (this.$self_$46556.mOYnqqqZ3O5)
					{
						if (251105 - 321760 != -70655)
						{
							continue;
						}
						goto IL_4F5;
					}
					else
					{
						this.$self_$46556.mOYnqqqZ3O5 = true;
						if (106307 - 439216 != -332909)
						{
							continue;
						}
						this.$mSwitch$46549 = GameObject.Find("PirateSwitch");
						if (88965 - 396146 == -307180)
						{
							continue;
						}
						this.$mKitchenLid$46550 = GameObject.Find("KitchenLid");
						if (5296 - 56665 == -51368)
						{
							continue;
						}
						if (this.$mSwitch$46549)
						{
							if (10202 - 86925 != -76723)
							{
								continue;
							}
							this.$mSwitch$46549.animation.Play("release");
							if (235183 - 237672 == -2488)
							{
								continue;
							}
						}
						if (!this.$mKitchenLid$46550)
						{
							goto IL_114;
						}
						if (30448 - 200605 != -170157)
						{
							continue;
						}
						this.$mKitchenLid$46550.animation.Play("release");
						if (92469 - 327585 == -235115)
						{
							continue;
						}
						this.$mKitchenLid$46550.audio.Play();
						if (148073 - 270632 != -122558)
						{
							goto Block_12;
						}
						continue;
					}
					IL_21B:
					if (this.$i$46551 >= 4)
					{
						if (272050 - 212051 == 59999)
						{
							if (this.$mSwitch$46549)
							{
								if (194498 - 298781 == -104282)
								{
									continue;
								}
								this.$mSwitch$46549.animation.Play("pull");
								if (202219 - 483812 != -281593)
								{
									continue;
								}
								this.$mSwitch$46549.audio.Play();
								if (184964 - 182429 == 2536)
								{
									continue;
								}
							}
							if (!this.$mKitchenLid$46550)
							{
								goto IL_271;
							}
							if (59341 - 73585 == -14244)
							{
								this.$mKitchenLid$46550.animation.Play("pull");
								if (289340 - 523492 == -234152)
								{
									goto IL_271;
								}
							}
						}
					}
					else
					{
						this.$hitList$46552 = Damage.FindAreaTarget(new Vector3((float)0, (float)45, (float)0), (float)9, (float)6, 130816);
						if (100766 - 92205 == 8561)
						{
							this.$$iterator$10986$46555 = UnityRuntimeServices.GetEnumerator(this.$hitList$46552);
							if (117581 - 500625 == -383044)
							{
								while (this.$$iterator$10986$46555.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10986$46555.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$46553 = (GameObject)obj2;
									if (216574 - 256617 == -40042)
									{
										goto IL_3B7;
									}
									this.$hitChar$46554 = (CharacterControl)this.$hitObject$46553.GetComponent(typeof(CharacterControl));
									if (281355 - 120297 == 161059)
									{
										goto IL_3B7;
									}
									UnityRuntimeServices.Update(this.$$iterator$10986$46555, this.$hitObject$46553);
									if (118229 - 105726 != 12503)
									{
										goto IL_3B7;
									}
									if (this.$hitChar$46554)
									{
										if (274694 - 343680 != -68986)
										{
											goto IL_3B7;
										}
										if (this.$hitChar$46554.isMine)
										{
											if (248047 - 18189 == 229859)
											{
												goto IL_3B7;
											}
											this.$hitChar$46554.RPC_AddEffectDamage(99, 299, 0, 0, Vector3.zero, this.$hitChar$46554.ActorNr);
											if (100986 - 488843 != -387857)
											{
												goto IL_3B7;
											}
										}
									}
								}
								if (71372 - 29857 == 41515)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds((float)2));
				Block_9:
				goto IL_633;
				IL_114:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_12:
				goto IL_114;
				IL_271:
				return this.Yield(4, new WaitForSeconds(15.5f));
				IL_301:
				IL_35C:
				Block_36:
				IL_4F5:
				IL_633:
				return false;
			}

			// Token: 0x0600B862 RID: 47202 RVA: 0x013C55F8 File Offset: 0x013C37F8
			internal static bool YLrX6KtYn59V1MGTJiIG()
			{
				return true;
			}

			// Token: 0x0600B863 RID: 47203 RVA: 0x013C55FC File Offset: 0x013C37FC
			internal static bool qbCAKCtY6MhN4g5NILWG()
			{
				return false;
			}

			// Token: 0x04009F0C RID: 40716
			internal GameObject $mSwitch$46549;

			// Token: 0x04009F0D RID: 40717
			internal GameObject $mKitchenLid$46550;

			// Token: 0x04009F0E RID: 40718
			internal int $i$46551;

			// Token: 0x04009F0F RID: 40719
			internal UnityScript.Lang.Array $hitList$46552;

			// Token: 0x04009F10 RID: 40720
			internal GameObject $hitObject$46553;

			// Token: 0x04009F11 RID: 40721
			internal CharacterControl $hitChar$46554;

			// Token: 0x04009F12 RID: 40722
			internal IEnumerator $$iterator$10986$46555;

			// Token: 0x04009F13 RID: 40723
			internal M973_PirateCave5 $self_$46556;
		}
	}

	// Token: 0x02001ED5 RID: 7893
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46558 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B864 RID: 47204 RVA: 0x013C5600 File Offset: 0x013C3800
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46558(M973_PirateCave5 self_)
		{
			if (128817 - 573802 != -444984)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199585 - 381566 == -181981)
				{
					base..ctor();
					if (203512 - 315759 == -112247)
					{
						this.$self_$46563 = self_;
						if (118713 - 359519 != -240805)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B865 RID: 47205 RVA: 0x013C5698 File Offset: 0x013C3898
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$onDeadPlayer$46558.$(this.$self_$46563);
		}

		// Token: 0x0600B866 RID: 47206 RVA: 0x013C56A8 File Offset: 0x013C38A8
		internal static bool v7vDSVtYi6KkXPRCNZJp()
		{
			return true;
		}

		// Token: 0x0600B867 RID: 47207 RVA: 0x013C56AC File Offset: 0x013C38AC
		internal static bool GuVGSptYKobdPr2sEQZG()
		{
			return false;
		}

		// Token: 0x04009F14 RID: 40724
		internal M973_PirateCave5 $self_$46563;

		// Token: 0x02001ED6 RID: 7894
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B868 RID: 47208 RVA: 0x013C56B0 File Offset: 0x013C38B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave5 self_)
			{
				if (237379 - 597849 != -360469)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34531 - 198341 == -163810)
					{
						base..ctor();
						if (124357 - 476326 != -351968)
						{
							this.$self_$46562 = self_;
							if (24953 - 328490 == -303537)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B869 RID: 47209 RVA: 0x013C5748 File Offset: 0x013C3948
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99223 - 34125 != 65099)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2F9;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (228276 - 125873 != 102403)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2A6;
							}
							if (297946 - 226977 == 70970)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (93159 - 174810 != -81651)
						{
							continue;
						}
						this.$mStoryGui$46559 = (StoryGui)this.$self_$46562.GetComponent(typeof(StoryGui));
						if (275105 - 215923 != 59182)
						{
							continue;
						}
						if (this.$mStoryGui$46559)
						{
							if (246930 - 128110 != 118820)
							{
								continue;
							}
							this.$mStoryGui$46559.close();
							if (123975 - 32335 == 91641)
							{
								continue;
							}
						}
						this.$mChangeGui$46560 = (ChangeGui)this.$self_$46562.GetComponent(typeof(ChangeGui));
						if (256768 - 537243 == -280474)
						{
							continue;
						}
						if (this.$mChangeGui$46560)
						{
							if (73730 - 138902 != -65172)
							{
								continue;
							}
							this.$mChangeGui$46560.close();
							if (174581 - 596628 == -422046)
							{
								continue;
							}
						}
						this.$mGameGui$46561 = (GameGui)this.$self_$46562.GetComponent(typeof(GameGui));
						if (259509 - 316531 != -57022)
						{
							continue;
						}
						if (this.$mGameGui$46561)
						{
							if (93836 - 60210 == 33627)
							{
								continue;
							}
							if (!this.$mGameGui$46561.enabled)
							{
								if (96965 - 350691 != -253726)
								{
									continue;
								}
								this.$mGameGui$46561.enabled = true;
								if (230720 - 234265 == -3544)
								{
									continue;
								}
							}
							this.$mGameGui$46561.openDeadMenu();
							if (41280 - 546373 != -505093)
							{
								continue;
							}
						}
						IL_2A6:
						this.YieldDefault(1);
						if (97608 - 449555 != -351946)
						{
							goto Block_23;
						}
						continue;
					default:
						if (138231 - 295021 != -156790)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (86242 - 347081 == -260838);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_23:
				IL_2F9:
				return false;
			}

			// Token: 0x0600B86A RID: 47210 RVA: 0x013C5A60 File Offset: 0x013C3C60
			internal static bool xQr2c1tYdB7qAHF4spWB()
			{
				return true;
			}

			// Token: 0x0600B86B RID: 47211 RVA: 0x013C5A64 File Offset: 0x013C3C64
			internal static bool ipW30etYJHsiXiNfuNfr()
			{
				return false;
			}

			// Token: 0x04009F15 RID: 40725
			internal StoryGui $mStoryGui$46559;

			// Token: 0x04009F16 RID: 40726
			internal ChangeGui $mChangeGui$46560;

			// Token: 0x04009F17 RID: 40727
			internal GameGui $mGameGui$46561;

			// Token: 0x04009F18 RID: 40728
			internal M973_PirateCave5 $self_$46562;
		}
	}

	// Token: 0x02001ED7 RID: 7895
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46564 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B86C RID: 47212 RVA: 0x013C5A68 File Offset: 0x013C3C68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46564(Hashtable data, M973_PirateCave5 self_)
		{
			if (121178 - 200595 != -79417)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18049 - 204765 != -186715)
				{
					base..ctor();
					if (159313 - 416566 == -257253)
					{
						this.$data$46569 = data;
						if (113418 - 268235 != -154816)
						{
							this.$self_$46570 = self_;
							if (198415 - 329984 != -131568)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x013C5B24 File Offset: 0x013C3D24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$onChangePlayer$46564.$(this.$data$46569, this.$self_$46570);
		}

		// Token: 0x0600B86E RID: 47214 RVA: 0x013C5B38 File Offset: 0x013C3D38
		internal static bool nZUIrstYDgES5UAwnP2I()
		{
			return true;
		}

		// Token: 0x0600B86F RID: 47215 RVA: 0x013C5B3C File Offset: 0x013C3D3C
		internal static bool pACBoFtYvmDrBHrJ02gg()
		{
			return false;
		}

		// Token: 0x04009F19 RID: 40729
		internal Hashtable $data$46569;

		// Token: 0x04009F1A RID: 40730
		internal M973_PirateCave5 $self_$46570;

		// Token: 0x02001ED8 RID: 7896
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B870 RID: 47216 RVA: 0x013C5B40 File Offset: 0x013C3D40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave5 self_)
			{
				if (95303 - 363052 != -267748)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35483 - 498709 == -463226)
					{
						base..ctor();
						if (92199 - 254238 != -162038)
						{
							this.$data$46567 = data;
							if (156 - 87951 == -87795)
							{
								this.$self_$46568 = self_;
								if (189921 - 415844 == -225923)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B871 RID: 47217 RVA: 0x013C5BFC File Offset: 0x013C3DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15745 - 313353 != -297607)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_205;
					case 2:
						if (Game.mGameState == eGameState.Hold)
						{
							if (278376 - 514539 != -236163)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (27974 - 364464 != -336490)
							{
								continue;
							}
							this.$mGameGui$46566 = (GameGui)this.$self_$46568.GetComponent(typeof(GameGui));
							if (28712 - 578524 == -549811)
							{
								continue;
							}
							this.$mGameGui$46566.enabled = true;
							if (292115 - 531936 == -239820)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (42259 - 566844 != -524585)
						{
							continue;
						}
						goto IL_205;
					default:
						if (136925 - 10358 != 126567)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (45439 - 554102 != -508662)
					{
						this.$self_$46568.SendMessage("onCreatePlayer", this.$data$46567);
						if (51930 - 133707 == -81777)
						{
							this.$mChangeGui$46565 = (ChangeGui)this.$self_$46568.GetComponent(typeof(ChangeGui));
							if (190383 - 29899 == 160484)
							{
								if (!this.$mChangeGui$46565.enabled)
								{
									break;
								}
								if (84675 - 163847 != -79171)
								{
									this.$mChangeGui$46565.close();
									if (287366 - 416246 != -128879)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_96:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_96;
				IL_205:
				return false;
			}

			// Token: 0x0600B872 RID: 47218 RVA: 0x013C5E20 File Offset: 0x013C4020
			internal static bool RR3xkbtYRLVr6gYb5Ztu()
			{
				return true;
			}

			// Token: 0x0600B873 RID: 47219 RVA: 0x013C5E24 File Offset: 0x013C4024
			internal static bool GvdH9TtYwdnGQgFp86Lq()
			{
				return false;
			}

			// Token: 0x04009F1B RID: 40731
			internal ChangeGui $mChangeGui$46565;

			// Token: 0x04009F1C RID: 40732
			internal GameGui $mGameGui$46566;

			// Token: 0x04009F1D RID: 40733
			internal Hashtable $data$46567;

			// Token: 0x04009F1E RID: 40734
			internal M973_PirateCave5 $self_$46568;
		}
	}

	// Token: 0x02001ED9 RID: 7897
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46571 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B874 RID: 47220 RVA: 0x013C5E28 File Offset: 0x013C4028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46571(Hashtable data, M973_PirateCave5 self_)
		{
			if (18493 - 557876 != -539383)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (100226 - 61670 == 38556)
				{
					base..ctor();
					if (181208 - 589808 == -408600)
					{
						this.$data$46579 = data;
						if (159323 - 39708 != 119616)
						{
							this.$self_$46580 = self_;
							if (210412 - 346439 == -136027)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B875 RID: 47221 RVA: 0x013C5EE4 File Offset: 0x013C40E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$onGameComplete$46571.$(this.$data$46579, this.$self_$46580);
		}

		// Token: 0x0600B876 RID: 47222 RVA: 0x013C5EF8 File Offset: 0x013C40F8
		internal static bool QQZxxhtYq3E0YHOaUEJP()
		{
			return true;
		}

		// Token: 0x0600B877 RID: 47223 RVA: 0x013C5EFC File Offset: 0x013C40FC
		internal static bool HwC5C9tY7UOWmjqFa5l6()
		{
			return false;
		}

		// Token: 0x04009F1F RID: 40735
		internal Hashtable $data$46579;

		// Token: 0x04009F20 RID: 40736
		internal M973_PirateCave5 $self_$46580;

		// Token: 0x02001EDA RID: 7898
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B878 RID: 47224 RVA: 0x013C5F00 File Offset: 0x013C4100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M973_PirateCave5 self_)
			{
				if (92005 - 459517 != -367512)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230967 - 368748 != -137780)
					{
						base..ctor();
						if (182871 - 534727 != -351855)
						{
							this.$data$46577 = data;
							if (197418 - 196859 == 559)
							{
								this.$self_$46578 = self_;
								if (82521 - 213588 == -131067)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B879 RID: 47225 RVA: 0x013C5FBC File Offset: 0x013C41BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74508 - 142388 != -67879)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3DB;
					case 2:
						this.$mCompleteGui$46573 = (CompleteGui)this.$self_$46578.GetComponent(typeof(CompleteGui));
						if (241487 - 109053 != 132434)
						{
							continue;
						}
						this.$mCompleteGui$46573.Init();
						if (26438 - 202740 != -176302)
						{
							continue;
						}
						this.$mCompleteGui$46573.readData(this.$data$46577);
						if (57765 - 214713 == -156947)
						{
							continue;
						}
						if (this.$result$46572 == 1)
						{
							if (202552 - 459910 == -257357)
							{
								continue;
							}
							this.$mCompleteGui$46573.displayResult(eCompleteType.Success);
							if (18714 - 227453 == -208738)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46573.displayResult(eCompleteType.Failed);
							if (246181 - 71342 == 174840)
							{
								continue;
							}
						}
						this.$mGameGui$46574 = (GameGui)this.$self_$46578.GetComponent(typeof(GameGui));
						if (232713 - 331329 == -98615)
						{
							continue;
						}
						this.$mStoryGui$46575 = (StoryGui)this.$self_$46578.GetComponent(typeof(StoryGui));
						if (208289 - 520518 == -312228)
						{
							continue;
						}
						this.$mChangeGui$46576 = (ChangeGui)this.$self_$46578.GetComponent(typeof(ChangeGui));
						if (49249 - 262783 != -213534)
						{
							continue;
						}
						if (this.$mGameGui$46574)
						{
							if (25129 - 23263 == 1867)
							{
								continue;
							}
							this.$mGameGui$46574.close();
							if (64341 - 412146 != -347805)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46575)
						{
							if (274732 - 526295 != -251563)
							{
								continue;
							}
							this.$mStoryGui$46575.close();
							if (231736 - 410965 != -179229)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46576)
						{
							if (74747 - 18606 == 56142)
							{
								continue;
							}
							this.$mChangeGui$46576.disable();
							if (44580 - 224187 == -179606)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (286052 - 317972 != -31920)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (162554 - 42073 != 120481)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46577[31]);
					if (155655 - 440409 != -284753)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (231993 - 515244 != -283250)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (160495 - 562870 != -402374)
							{
								this.$result$46572 = RuntimeServices.UnboxInt32(this.$data$46577[31]);
								if (20352 - 145220 == -124868)
								{
									goto IL_287;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_287:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600B87A RID: 47226 RVA: 0x013C63B8 File Offset: 0x013C45B8
			internal static bool HaaFHdtYP3ktsZBk1uxT()
			{
				return true;
			}

			// Token: 0x0600B87B RID: 47227 RVA: 0x013C63BC File Offset: 0x013C45BC
			internal static bool NsIxrutY0oxReMxeI2q0()
			{
				return false;
			}

			// Token: 0x04009F21 RID: 40737
			internal int $result$46572;

			// Token: 0x04009F22 RID: 40738
			internal CompleteGui $mCompleteGui$46573;

			// Token: 0x04009F23 RID: 40739
			internal GameGui $mGameGui$46574;

			// Token: 0x04009F24 RID: 40740
			internal StoryGui $mStoryGui$46575;

			// Token: 0x04009F25 RID: 40741
			internal ChangeGui $mChangeGui$46576;

			// Token: 0x04009F26 RID: 40742
			internal Hashtable $data$46577;

			// Token: 0x04009F27 RID: 40743
			internal M973_PirateCave5 $self_$46578;
		}
	}

	// Token: 0x02001EDB RID: 7899
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46581 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B87C RID: 47228 RVA: 0x013C63C0 File Offset: 0x013C45C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46581(M973_PirateCave5 self_)
		{
			if (58218 - 171621 != -113403)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18552 - 183380 != -164827)
				{
					base..ctor();
					if (282597 - 206378 == 76219)
					{
						this.$self_$46585 = self_;
						if (54893 - 556862 == -501969)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x013C6458 File Offset: 0x013C4658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$ReturnToTown$46581.$(this.$self_$46585);
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x013C6468 File Offset: 0x013C4668
		internal static bool ldmOwItYb7ZygaKQyElk()
		{
			return true;
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x013C646C File Offset: 0x013C466C
		internal static bool yMwVnttYulw0MpNaguui()
		{
			return false;
		}

		// Token: 0x04009F28 RID: 40744
		internal M973_PirateCave5 $self_$46585;

		// Token: 0x02001EDC RID: 7900
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B880 RID: 47232 RVA: 0x013C6470 File Offset: 0x013C4670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave5 self_)
			{
				if (41438 - 370856 != -329417)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253752 - 59408 != 194345)
					{
						base..ctor();
						if (115717 - 594066 != -478348)
						{
							this.$self_$46584 = self_;
							if (124183 - 593495 != -469311)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B881 RID: 47233 RVA: 0x013C6508 File Offset: 0x013C4708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (183962 - 551092 != -367130)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3AD;
					case 2:
						this.$self_$46584.LeaveGame();
						if (10465 - 294341 == -283875)
						{
							continue;
						}
						this.YieldDefault(1);
						if (243955 - 399790 != -155834)
						{
							goto Block_26;
						}
						continue;
					default:
						if (263277 - 387607 != -124330)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (66707 - 355013 != -288305)
					{
						Game.mStateTime = Time.time;
						if (260561 - 312966 != -52404)
						{
							this.$$switch$8687$46582 = PlayerData.SaveGuild;
							if (73330 - 88127 == -14797)
							{
								if (this.$$switch$8687$46582 == 1)
								{
									if (217831 - 69450 != 148381)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (282668 - 209340 != 73328)
									{
										continue;
									}
								}
								else if (this.$$switch$8687$46582 == 2)
								{
									if (19926 - 182867 == -162940)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (22132 - 13155 != 8977)
									{
										continue;
									}
								}
								else if (this.$$switch$8687$46582 == 3)
								{
									if (29491 - 69980 == -40488)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (73044 - 267931 != -194887)
									{
										continue;
									}
								}
								else if (this.$$switch$8687$46582 == 4)
								{
									if (30768 - 308934 != -278166)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (233670 - 502264 == -268593)
									{
										continue;
									}
								}
								else if (this.$$switch$8687$46582 == 5)
								{
									if (196597 - 190818 == 5780)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (239156 - 266467 != -27311)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (293797 - 349459 == -55661)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (51663 - 265274 == -213610)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (162102 - 54152 == 107951)
									{
										continue;
									}
								}
								this.$mGameGui$46583 = (GameGui)this.$self_$46584.GetComponent(typeof(GameGui));
								if (20318 - 12205 != 8114)
								{
									if (this.$mGameGui$46583)
									{
										if (245236 - 274941 != -29705)
										{
											continue;
										}
										this.$mGameGui$46583.close();
										if (149845 - 326758 != -176913)
										{
											continue;
										}
									}
									this.$self_$46584.SendMessage("fadeOut");
									if (61267 - 436521 == -375254)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_26:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B882 RID: 47234 RVA: 0x013C68D4 File Offset: 0x013C4AD4
			internal static bool LyDysJtYIu8xJsfrHOpn()
			{
				return true;
			}

			// Token: 0x0600B883 RID: 47235 RVA: 0x013C68D8 File Offset: 0x013C4AD8
			internal static bool H3AbfvtYB3mo7UQwIglD()
			{
				return false;
			}

			// Token: 0x04009F29 RID: 40745
			internal int $$switch$8687$46582;

			// Token: 0x04009F2A RID: 40746
			internal GameGui $mGameGui$46583;

			// Token: 0x04009F2B RID: 40747
			internal M973_PirateCave5 $self_$46584;
		}
	}

	// Token: 0x02001EDD RID: 7901
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46586 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B884 RID: 47236 RVA: 0x013C68DC File Offset: 0x013C4ADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46586(M973_PirateCave5 self_)
		{
			if (178490 - 44376 != 134115)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273488 - 33266 == 240222)
				{
					base..ctor();
					if (224263 - 195603 != 28661)
					{
						this.$self_$46589 = self_;
						if (108743 - 62573 == 46170)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x013C6974 File Offset: 0x013C4B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$ReturnToGuild$46586.$(this.$self_$46589);
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x013C6984 File Offset: 0x013C4B84
		internal static bool eHFkaMtYeSZnNk6gphIG()
		{
			return true;
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x013C6988 File Offset: 0x013C4B88
		internal static bool yYKr6jtYrRu74lCP1vCa()
		{
			return false;
		}

		// Token: 0x04009F2C RID: 40748
		internal M973_PirateCave5 $self_$46589;

		// Token: 0x02001EDE RID: 7902
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B888 RID: 47240 RVA: 0x013C698C File Offset: 0x013C4B8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave5 self_)
			{
				if (126529 - 428100 != -301570)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5092 - 397011 == -391919)
					{
						base..ctor();
						if (262422 - 74761 != 187662)
						{
							this.$self_$46588 = self_;
							if (114632 - 465300 == -350668)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B889 RID: 47241 RVA: 0x013C6A24 File Offset: 0x013C4C24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (96493 - 353748 != -257255)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1BD;
					case 2:
						this.$self_$46588.LeaveGame();
						if (92289 - 92861 == -571)
						{
							continue;
						}
						this.YieldDefault(1);
						if (222563 - 573345 != -350781)
						{
							goto Block_3;
						}
						continue;
					default:
						if (245253 - 132843 != 112410)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (220189 - 98240 == 121949)
					{
						Game.mStateTime = Time.time;
						if (283175 - 230402 != 52774)
						{
							Game.mNextGameCode = 31;
							if (114888 - 431098 != -316209)
							{
								this.$mGameGui$46587 = (GameGui)this.$self_$46588.GetComponent(typeof(GameGui));
								if (274464 - 462717 == -188253)
								{
									if (this.$mGameGui$46587)
									{
										if (244353 - 355733 == -111379)
										{
											continue;
										}
										this.$mGameGui$46587.close();
										if (199874 - 238640 == -38765)
										{
											continue;
										}
									}
									this.$self_$46588.SendMessage("fadeOut");
									if (43696 - 578276 == -534580)
									{
										goto IL_66;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_1BD;
				IL_66:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B88A RID: 47242 RVA: 0x013C6C00 File Offset: 0x013C4E00
			internal static bool R2wK10tYjsNEQiLr3A5V()
			{
				return true;
			}

			// Token: 0x0600B88B RID: 47243 RVA: 0x013C6C04 File Offset: 0x013C4E04
			internal static bool GQEDQStYhpDprXXwYBUt()
			{
				return false;
			}

			// Token: 0x04009F2D RID: 40749
			internal GameGui $mGameGui$46587;

			// Token: 0x04009F2E RID: 40750
			internal M973_PirateCave5 $self_$46588;
		}
	}

	// Token: 0x02001EDF RID: 7903
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46590 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B88C RID: 47244 RVA: 0x013C6C08 File Offset: 0x013C4E08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46590(M973_PirateCave5 self_)
		{
			if (94831 - 462799 != -367967)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156528 - 428396 != -271867)
				{
					base..ctor();
					if (2770 - 56173 == -53403)
					{
						this.$self_$46593 = self_;
						if (165957 - 235444 == -69487)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x013C6CA0 File Offset: 0x013C4EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M973_PirateCave5.$ReturnToCamp$46590.$(this.$self_$46593);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x013C6CB0 File Offset: 0x013C4EB0
		internal static bool pVApCstYsDsOH0nRbdW3()
		{
			return true;
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x013C6CB4 File Offset: 0x013C4EB4
		internal static bool qITWWRtY9sC3SpnDtooT()
		{
			return false;
		}

		// Token: 0x04009F2F RID: 40751
		internal M973_PirateCave5 $self_$46593;

		// Token: 0x02001EE0 RID: 7904
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B890 RID: 47248 RVA: 0x013C6CB8 File Offset: 0x013C4EB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M973_PirateCave5 self_)
			{
				if (96796 - 21501 != 75295)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44789 - 431762 == -386973)
					{
						base..ctor();
						if (271811 - 9405 == 262406)
						{
							this.$self_$46592 = self_;
							if (180466 - 561961 != -381494)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B891 RID: 47249 RVA: 0x013C6D50 File Offset: 0x013C4F50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20735 - 328586 != -307851)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1BD;
					case 2:
						this.$self_$46592.LeaveGame();
						if (144737 - 31476 != 113261)
						{
							continue;
						}
						this.YieldDefault(1);
						if (254292 - 415080 != -160787)
						{
							goto Block_7;
						}
						continue;
					default:
						if (129145 - 567902 != -438757)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (91072 - 300395 == -209323)
					{
						Game.mStateTime = Time.time;
						if (235630 - 118786 != 116845)
						{
							Game.mNextGameCode = 33;
							if (183346 - 468091 == -284745)
							{
								this.$mGameGui$46591 = (GameGui)this.$self_$46592.GetComponent(typeof(GameGui));
								if (54417 - 55167 == -750)
								{
									if (this.$mGameGui$46591)
									{
										if (96502 - 4215 == 92288)
										{
											continue;
										}
										this.$mGameGui$46591.close();
										if (192606 - 145463 == 47144)
										{
											continue;
										}
									}
									this.$self_$46592.SendMessage("fadeOut");
									if (55422 - 191940 != -136517)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_1BD;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600B892 RID: 47250 RVA: 0x013C6F2C File Offset: 0x013C512C
			internal static bool p4MZPQtY122fpN9GMh6m()
			{
				return true;
			}

			// Token: 0x0600B893 RID: 47251 RVA: 0x013C6F30 File Offset: 0x013C5130
			internal static bool m5BNMMtY4IZiXVq3LOLy()
			{
				return false;
			}

			// Token: 0x04009F30 RID: 40752
			internal GameGui $mGameGui$46591;

			// Token: 0x04009F31 RID: 40753
			internal M973_PirateCave5 $self_$46592;
		}
	}
}
