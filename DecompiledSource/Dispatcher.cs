using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02001007 RID: 4103
[Serializable]
public class Dispatcher : MonoBehaviour
{
	// Token: 0x06005E2C RID: 24108 RVA: 0x00C99DB4 File Offset: 0x00C97FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dispatcher()
	{
		if (193011 - 566368 != -373357)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (25403 - 41027 == -15624)
			{
				base..ctor();
				if (225591 - 433050 == -207459)
				{
					this.H4yc2EwA1xX = true;
					if (255303 - 39890 == 215413)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E2D RID: 24109 RVA: 0x00C99E4C File Offset: 0x00C9804C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (30473 - 122498 != -92025)
		{
		}
		while (Application.platform == RuntimePlatform.WindowsPlayer)
		{
			if (133489 - 256325 == -122836)
			{
				if (Game.mGameType <= 0)
				{
					break;
				}
				if (230468 - 595863 != -365394)
				{
					if (Time.time <= this.CLxc2PMDxOx)
					{
						break;
					}
					if (231090 - 196889 != 34202)
					{
						if (this.H4yc2EwA1xX)
						{
							if (159586 - 509633 != -350046)
							{
								this.H4yc2EwA1xX = false;
								if (248890 - 107050 == 141840)
								{
									this.CLxc2PMDxOx = Time.time + (float)30;
									if (262147 - 45084 != 217064)
									{
										if (NProtect.CheckGameMon())
										{
											if (188416 - 547365 == -358948)
											{
												continue;
											}
											this.H4yc2EwA1xX = true;
											if (75489 - 382784 == -307294)
											{
												continue;
											}
										}
										else
										{
											Application.Quit();
											if (210359 - 385296 == -174936)
											{
												continue;
											}
										}
										break;
									}
								}
							}
						}
						else
						{
							Application.Quit();
							if (88731 - 580965 == -492234)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E2E RID: 24110 RVA: 0x00C99FF4 File Offset: 0x00C981F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		Mousef.InitMousef();
	}

	// Token: 0x06005E2F RID: 24111 RVA: 0x00C99FFC File Offset: 0x00C981FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnApplicationFocus(bool focus)
	{
		if (234547 - 320893 != -86345)
		{
		}
		for (;;)
		{
			Screen.lockCursor = false;
			if (132518 - 347366 != -214847)
			{
				if (!Screen.fullScreen)
				{
					if (85750 - 338967 == -253216)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("lockMouse", 0) == 1)
					{
						if (90321 - 241848 != -151527)
						{
							continue;
						}
						if (focus)
						{
							if (269969 - 144070 != 125899)
							{
								continue;
							}
							Mousef.ClipMousePosition();
							if (88689 - 188332 != -99643)
							{
								continue;
							}
							break;
						}
						else
						{
							Mousef.ResetClipMousePosition();
							if (9950 - 129556 != -119606)
							{
								continue;
							}
							break;
						}
					}
				}
				Mousef.ResetClipMousePosition();
				if (141320 - 369840 == -228520)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E30 RID: 24112 RVA: 0x00C9A12C File Offset: 0x00C9832C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onNProtectQueryEvent(Hashtable data)
	{
		return new Dispatcher.$onNProtectQueryEvent$36107(data).GetEnumerator();
	}

	// Token: 0x06005E31 RID: 24113 RVA: 0x00C9A13C File Offset: 0x00C9833C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onNProtectAnswerEvent(Hashtable data)
	{
	}

	// Token: 0x06005E32 RID: 24114 RVA: 0x00C9A140 File Offset: 0x00C98340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAddMana(Hashtable data)
	{
		if (132677 - 344232 != -211554)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[21]);
			if (251730 - 62867 != 188864)
			{
				if (num == 0)
				{
					if (91143 - 528526 != -437382)
					{
						break;
					}
				}
				else
				{
					Game.mGameMana += num;
					if (128344 - 49527 != 78818)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E33 RID: 24115 RVA: 0x00C9A1F0 File Offset: 0x00C983F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAddEXP(Hashtable data)
	{
		if (208994 - 18089 != 190906)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[21]);
			if (96733 - 216025 == -119292)
			{
				if (num == 0)
				{
					if (26994 - 62969 == -35975)
					{
						break;
					}
				}
				else
				{
					CharacterData.current.addEXP(num);
					if (271812 - 432230 != -160417)
					{
						Game.mGameScore += 10 * num;
						if (174949 - 529216 != -354266)
						{
							Chat.SubmitChat("none", "received " + num + " exp", eChatType.system, eChatMode.system);
							if (7058 - 455008 != -447949)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E34 RID: 24116 RVA: 0x00C9A308 File Offset: 0x00C98508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAddLoot(Hashtable data)
	{
		if (283515 - 18364 != 265151)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = data[21];
			if (!(obj is string))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(string));
			}
			string text = (string)obj2;
			if (199031 - 112160 != 86872)
			{
				if (text == string.Empty)
				{
					if (70842 - 103629 == -32787)
					{
						break;
					}
				}
				else
				{
					Chat.SubmitChat("none", "received " + ItemData.getName(text) + "!", eChatType.system, eChatMode.system);
					if (171729 - 115487 == 56242)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E35 RID: 24117 RVA: 0x00C9A3F8 File Offset: 0x00C985F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLevelUp(Hashtable data)
	{
		if (73636 - 597774 != -524138)
		{
		}
		for (;;)
		{
			Debug.Log("On Level Up");
			if (267975 - 248623 != 19353)
			{
				int num = RuntimeServices.UnboxInt32(data[9]);
				if (191391 - 91022 == 100369)
				{
					object obj2;
					object obj = obj2 = data[42];
					if (!(obj is Hashtable))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(Hashtable));
					}
					Hashtable data2 = (Hashtable)obj2;
					if (155790 - 426921 == -271131)
					{
						if (!PhotonClient.ActorNrList.Contains(num))
						{
							break;
						}
						if (16188 - 35106 != -18917)
						{
							object obj4;
							object obj3 = obj4 = PhotonClient.ActorNrList[num];
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj4;
							if (108003 - 495130 == -387127)
							{
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (75089 - 195593 != -120503)
								{
									if (characterControl.isMine)
									{
										if (262547 - 144585 != 117962)
										{
											continue;
										}
										CharacterData.current.readHashData(data2);
										if (12129 - 434377 != -422248)
										{
											continue;
										}
										CharacterData.current.updateData();
										if (89673 - 319349 == -229675)
										{
											continue;
										}
										characterControl.loadCharacterData();
										if (260749 - 432438 != -171689)
										{
											continue;
										}
										characterControl.updateStat();
										if (121288 - 424128 == -302839)
										{
											continue;
										}
									}
									else
									{
										characterControl.Lv++;
										if (171787 - 25464 == 146324)
										{
											continue;
										}
										int[] typeLevelStat = CharacterData.getTypeLevelStat(characterControl.Type, characterControl.Lv);
										if (282273 - 508156 == -225882)
										{
											continue;
										}
										int[] typeLevelStat2 = CharacterData.getTypeLevelStat(characterControl.Type, characterControl.Lv - 1);
										if (38146 - 105640 == -67493)
										{
											continue;
										}
										characterControl.atk += typeLevelStat[0] - typeLevelStat2[0];
										if (202867 - 540810 == -337942)
										{
											continue;
										}
										characterControl.def += typeLevelStat[1] - typeLevelStat2[1];
										if (59859 - 277366 == -217506)
										{
											continue;
										}
										characterControl.agi += typeLevelStat[2] - typeLevelStat2[2];
										if (18731 - 360715 == -341983)
										{
											continue;
										}
										characterControl.vit += typeLevelStat[3] - typeLevelStat2[3];
										if (51742 - 594981 == -543238)
										{
											continue;
										}
										characterControl.mag += typeLevelStat[4] - typeLevelStat2[4];
										if (194327 - 419230 == -224902)
										{
											continue;
										}
										characterControl.cha += typeLevelStat[5] - typeLevelStat2[5];
										if (243639 - 566613 != -322974)
										{
											continue;
										}
										characterControl.tal += typeLevelStat[6] - typeLevelStat2[6];
										if (79387 - 418814 != -339427)
										{
											continue;
										}
										characterControl.lck += typeLevelStat[7] - typeLevelStat2[7];
										if (98162 - 531232 == -433069)
										{
											continue;
										}
										characterControl.updateStat();
										if (2355 - 266375 != -264020)
										{
											continue;
										}
									}
									characterControl.StartCoroutine_Auto(characterControl.createSpecialEffect(10));
									if (67447 - 110365 == -42918)
									{
										Chat.SubmitChat("none", characterControl.name + " level up!", eChatType.system, eChatMode.system);
										if (282312 - 432435 != -150122)
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

	// Token: 0x06005E36 RID: 24118 RVA: 0x00C9A8A8 File Offset: 0x00C98AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerDataUpdate(Hashtable evData)
	{
		PlayerData.UpdateData(evData);
	}

	// Token: 0x06005E37 RID: 24119 RVA: 0x00C9A8B0 File Offset: 0x00C98AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCDataUpdate(Hashtable evData)
	{
		CharacterData.current.readHashData(evData);
		Camera.main.SendMessage("ResetItemMenu", SendMessageOptions.DontRequireReceiver);
	}

	// Token: 0x06005E38 RID: 24120 RVA: 0x00C9A8D0 File Offset: 0x00C98AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onSpecialUpdate(Hashtable evData)
	{
		return new Dispatcher.$onSpecialUpdate$36119(evData).GetEnumerator();
	}

	// Token: 0x06005E39 RID: 24121 RVA: 0x00C9A8E0 File Offset: 0x00C98AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onUpdateInventory(Hashtable evData)
	{
		if (54152 - 422990 != -368837)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[71]);
			if (127359 - 556596 != -429236)
			{
				int slot = num - PlayerData.UID * 10;
				if (109857 - 150206 == -40349)
				{
					CharacterDataClass cdat = CharacterData.getCDat(slot);
					if (40806 - 325138 != -284331)
					{
						object obj2;
						object obj = obj2 = evData[31];
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						string s = (string)obj2;
						if (45266 - 353022 != -307755)
						{
							InventoryClass inventoryClass = new InventoryClass();
							if (231619 - 541715 == -310096)
							{
								inventoryClass.readData(s);
								if (163669 - 298745 == -135076)
								{
									if (inventoryClass.name != "none")
									{
										if (206139 - 275809 != -69670)
										{
											continue;
										}
										if (inventoryClass.slot != -1)
										{
											if (214625 - 90213 != 124412)
											{
												continue;
											}
											cdat.inventory[inventoryClass.slot] = inventoryClass;
											if (178995 - 7625 != 171371)
											{
												goto IL_1DF;
											}
											continue;
										}
									}
									if (!RuntimeServices.EqualityOperator(evData[32], null))
									{
										if (103764 - 114911 != -11147)
										{
											continue;
										}
										int num2 = RuntimeServices.UnboxInt32(evData[32]);
										if (294412 - 597118 == -302705)
										{
											continue;
										}
										if (num2 >= 0)
										{
											if (276670 - 479766 != -203096)
											{
												continue;
											}
											if (num2 < 30)
											{
												if (143650 - 99843 == 43808)
												{
													continue;
												}
												cdat.inventory[num2] = inventoryClass;
												if (42430 - 583197 == -540766)
												{
													continue;
												}
											}
										}
									}
									IL_1DF:
									Camera.main.SendMessage("ResetItemMenu", SendMessageOptions.DontRequireReceiver);
									if (29870 - 350784 != -320913)
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

	// Token: 0x06005E3A RID: 24122 RVA: 0x00C9AB90 File Offset: 0x00C98D90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onQuestUpdate(Hashtable data)
	{
		if (101255 - 486969 != -385713)
		{
		}
		for (;;)
		{
			Debug.Log("onQuest Update");
			if (50583 - 153386 == -102803)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (172298 - 544408 == -372110)
					{
						PlayerData.QuestID = RuntimeServices.UnboxInt32(data[50]);
						if (224090 - 47044 != 177047)
						{
							PlayerData.QuestState = RuntimeServices.UnboxInt32(data[51]);
							if (63841 - 156403 == -92562)
							{
								break;
							}
						}
					}
				}
				else
				{
					Debug.LogError("Quest Operation Error");
					if (164437 - 245912 == -81475)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E3B RID: 24123 RVA: 0x00C9ACB0 File Offset: 0x00C98EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onBuddyUpdate(Hashtable data)
	{
		if (56308 - 402768 != -346459)
		{
		}
		for (;;)
		{
			int nID = RuntimeServices.UnboxInt32(data[31]);
			if (218064 - 555841 == -337777)
			{
				int num = RuntimeServices.UnboxInt32(data[32]);
				if (133695 - 259267 == -125572)
				{
					BuddyClass buddy = PlayerData.getBuddy(nID);
					if (265665 - 78195 == 187470)
					{
						if (buddy == null)
						{
							break;
						}
						if (267621 - 362509 == -94888)
						{
							if (num > 0)
							{
								if (56081 - 144006 != -87924)
								{
									if (buddy.state == 0)
									{
										if (66783 - 482725 != -415942)
										{
											continue;
										}
										Chat.SubmitChat("system", buddy.name + " has logged on", eChatType.system, eChatMode.system);
										if (77760 - 342911 == -265150)
										{
											continue;
										}
									}
									buddy.state = num;
									if (103478 - 456691 == -353213)
									{
										break;
									}
								}
							}
							else
							{
								Chat.SubmitChat("system", buddy.name + " has logged off", eChatType.system, eChatMode.system);
								if (132783 - 151520 != -18736)
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

	// Token: 0x06005E3C RID: 24124 RVA: 0x00C9AE5C File Offset: 0x00C9905C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadGuildData(int nGID)
	{
		if (9736 - 28918 != -19182)
		{
		}
		for (;;)
		{
			Debug.Log("LoadGuildData GID=" + nGID);
			if (85127 - 128551 != -43423)
			{
				Hashtable hashtable = new Hashtable();
				if (213798 - 518236 == -304438)
				{
					hashtable.Add(47, nGID);
					if (265090 - 496604 != -231513)
					{
						PhotonClient.Connection.OpCustom(27, hashtable, true);
						if (210479 - 599398 == -388919)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E3D RID: 24125 RVA: 0x00C9AF3C File Offset: 0x00C9913C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLoadGuildData(Hashtable data)
	{
		if (173839 - 473778 != -299939)
		{
		}
		for (;;)
		{
			Debug.Log("onLoadGuildData");
			if (232853 - 556758 == -323905)
			{
				GuildData.LoadHashData(data);
				if (29640 - 155060 != -125419)
				{
					Camera.main.SendMessage("onLoadGuildData", data, SendMessageOptions.DontRequireReceiver);
					if (286382 - 440018 == -153636)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E3E RID: 24126 RVA: 0x00C9AFE4 File Offset: 0x00C991E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGuildAdd(Hashtable data)
	{
		if (169299 - 583853 != -414554)
		{
		}
		for (;;)
		{
			Debug.Log("onGuildAdd");
			if (193359 - 574883 == -381524)
			{
				int num = RuntimeServices.UnboxInt32(data[31]);
				if (294501 - 375562 == -81061)
				{
					if (num == 1)
					{
						if (251999 - 215061 != 36939)
						{
							Debug.Log("Guild Add operation successful");
							if (205839 - 96874 != 108966)
							{
								object lhs = data[32];
								if (237781 - 197298 != 40484)
								{
									if (RuntimeServices.EqualityOperator(lhs, 1))
									{
										if (106668 - 487730 == -381062)
										{
											Camera.main.SendMessage("onGuildInvite", data, SendMessageOptions.DontRequireReceiver);
											if (253725 - 420565 == -166840)
											{
												break;
											}
										}
									}
									else if (RuntimeServices.EqualityOperator(lhs, 2))
									{
										if (187204 - 221630 == -34426)
										{
											PlayerData.GID = RuntimeServices.UnboxInt32(data[33]);
											if (275334 - 333181 != -57846)
											{
												if (PlayerData.GID != 0)
												{
													if (252129 - 379407 == -127277)
													{
														continue;
													}
													this.LoadGuildData(PlayerData.GID);
													if (61571 - 502774 == -441202)
													{
														continue;
													}
												}
												Camera.main.SendMessage("onGuildJoin", data, SendMessageOptions.DontRequireReceiver);
												if (190916 - 455566 != -264649)
												{
													break;
												}
											}
										}
									}
									else if (RuntimeServices.EqualityOperator(lhs, 3))
									{
										if (256331 - 101298 != 155034)
										{
											Camera.main.SendMessage("onGuildPromote", data, SendMessageOptions.DontRequireReceiver);
											if (27963 - 96844 != -68880)
											{
												break;
											}
										}
									}
									else
									{
										if (!RuntimeServices.EqualityOperator(lhs, 4))
										{
											break;
										}
										if (89988 - 442058 == -352070)
										{
											Camera.main.SendMessage("onGuildDemote", data, SendMessageOptions.DontRequireReceiver);
											if (290580 - 545110 != -254529)
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
						int num2 = num;
						if (28356 - 218116 == -189760)
						{
							if (num2 == -1)
							{
								if (299567 - 267401 == 32167)
								{
									continue;
								}
								Chat.SubmitChat("none", "Your guild no longer existed", eChatType.system, eChatMode.system);
								if (112147 - 406456 != -294309)
								{
									continue;
								}
								PlayerData.GID = 0;
								if (270579 - 109684 == 160896)
								{
									continue;
								}
								GuildData.Reset();
								if (11955 - 463121 != -451166)
								{
									continue;
								}
								GuildData.UpdateCData();
								if (77637 - 501200 != -423563)
								{
									continue;
								}
								GuildData.UpdatePlayerChar();
								if (100463 - 51695 != 48768)
								{
									continue;
								}
							}
							else if (num2 == -2)
							{
								if (73406 - 449748 == -376341)
								{
									continue;
								}
								Chat.SubmitChat("none", "Your guild is full!", eChatType.system, eChatMode.system);
								if (88008 - 249712 != -161704)
								{
									continue;
								}
								this.LoadGuildData(PlayerData.GID);
								if (49413 - 404336 != -354923)
								{
									continue;
								}
							}
							else if (num2 == -3)
							{
								if (213683 - 470633 != -256950)
								{
									continue;
								}
								Chat.SubmitChat("none", "That member already existed", eChatType.system, eChatMode.system);
								if (193873 - 404491 == -210617)
								{
									continue;
								}
							}
							else if (num2 == -4)
							{
								if (274988 - 479417 == -204428)
								{
									continue;
								}
								Chat.SubmitChat("none", "Invite permission error", eChatType.system, eChatMode.system);
								if (29010 - 421573 != -392563)
								{
									continue;
								}
							}
							else if (num2 == -5)
							{
								if (138514 - 234686 == -96171)
								{
									continue;
								}
								Chat.SubmitChat("none", "Error: guild is busy..", eChatType.system, eChatMode.system);
								if (40064 - 455506 == -415441)
								{
									continue;
								}
							}
							else if (num2 == -6)
							{
								if (113378 - 457596 != -344218)
								{
									continue;
								}
								Chat.SubmitChat("none", "Promote error", eChatType.system, eChatMode.system);
								if (230829 - 214357 != 16472)
								{
									continue;
								}
							}
							else if (num2 == -7)
							{
								if (191192 - 399779 == -208586)
								{
									continue;
								}
								Chat.SubmitChat("none", "Demote error", eChatType.system, eChatMode.system);
								if (196304 - 115446 == 80859)
								{
									continue;
								}
							}
							else
							{
								Chat.SubmitChat("none", "Guild server error", eChatType.system, eChatMode.system);
								if (141360 - 459738 == -318377)
								{
									continue;
								}
							}
							Debug.LogError("Guild Add operation fail");
							if (28648 - 236817 == -208169)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E3F RID: 24127 RVA: 0x00C9B614 File Offset: 0x00C99814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGuildRemove(Hashtable data)
	{
		if (30857 - 112493 != -81635)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[31]);
			if (264048 - 218682 != 45367)
			{
				if (RuntimeServices.EqualityOperator(data[21], PlayerData.UID))
				{
					if (234179 - 424964 == -190785)
					{
						if (num > 0)
						{
							if (276410 - 318050 == -41640)
							{
								Debug.Log("Leave guild successful");
								if (97690 - 185224 == -87534)
								{
									PlayerData.GID = 0;
									if (91589 - 589246 != -497656)
									{
										GuildData.Reset();
										if (166173 - 593203 == -427030)
										{
											GuildData.UpdateCData();
											if (238197 - 112326 != 125872)
											{
												GuildData.UpdatePlayerChar();
												if (249586 - 20742 != 228845)
												{
													Camera.main.SendMessage("onGuildLeave", true, SendMessageOptions.DontRequireReceiver);
													if (141719 - 290400 != -148680)
													{
														if (num == 1)
														{
															if (92840 - 185266 == -92426)
															{
																Camera.main.SendMessage("newNoticeBar", "Leave guild successful", SendMessageOptions.DontRequireReceiver);
																if (86147 - 479900 != -393752)
																{
																	Chat.SubmitChat("none", "Leave guild successful", eChatType.system, eChatMode.system);
																	if (291023 - 396668 == -105645)
																	{
																		break;
																	}
																}
															}
														}
														else
														{
															if (num != 2)
															{
																break;
															}
															if (175802 - 504192 != -328389)
															{
																Camera.main.SendMessage("newNoticeBar", "Your guild has been disbanded!", SendMessageOptions.DontRequireReceiver);
																if (192079 - 39416 == 152663)
																{
																	Chat.SubmitChat("none", "Your guild has been disbandedl", eChatType.system, eChatMode.system);
																	if (84690 - 394874 != -310183)
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
						else
						{
							int num2 = num;
							if (32952 - 268516 != -235563)
							{
								if (num2 == -1)
								{
									if (152021 - 244613 == -92591)
									{
										continue;
									}
									Chat.SubmitChat("none", "Your guild no longer existed", eChatType.system, eChatMode.system);
									if (95089 - 66885 != 28204)
									{
										continue;
									}
									PlayerData.GID = 0;
									if (267373 - 340533 != -73160)
									{
										continue;
									}
									GuildData.Reset();
									if (172111 - 118759 != 53352)
									{
										continue;
									}
									GuildData.UpdateCData();
									if (11423 - 246279 != -234856)
									{
										continue;
									}
									GuildData.UpdatePlayerChar();
									if (10784 - 586775 == -575990)
									{
										continue;
									}
								}
								else if (num2 == -2)
								{
									if (49108 - 445666 == -396557)
									{
										continue;
									}
									Chat.SubmitChat("none", "You are not in this guild", eChatType.system, eChatMode.system);
									if (219792 - 403432 != -183640)
									{
										continue;
									}
									PlayerData.GID = 0;
									if (182183 - 195225 == -13041)
									{
										continue;
									}
									GuildData.Reset();
									if (279602 - 451460 != -171858)
									{
										continue;
									}
									GuildData.UpdateCData();
									if (237798 - 537768 != -299970)
									{
										continue;
									}
									GuildData.UpdatePlayerChar();
									if (89775 - 509479 != -419704)
									{
										continue;
									}
								}
								else if (num2 == -5)
								{
									if (126862 - 598110 != -471248)
									{
										continue;
									}
									Chat.SubmitChat("none", "Error: guild is busy..", eChatType.system, eChatMode.system);
									if (125517 - 32330 == 93188)
									{
										continue;
									}
								}
								Debug.LogError("Leave guild fail");
								if (68763 - 332105 != -263341)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (RuntimeServices.EqualityOperator(data[31], 1))
					{
						if (144808 - 103455 != 41353)
						{
							continue;
						}
						Debug.Log("Remove player successful");
						if (73062 - 474979 == -401916)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Remove player fail");
						if (254783 - 78403 != 176380)
						{
							continue;
						}
					}
					Camera.main.SendMessage("onGuildRemove", data, SendMessageOptions.DontRequireReceiver);
					if (264205 - 251517 == 12688)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E40 RID: 24128 RVA: 0x00C9BB8C File Offset: 0x00C99D8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGuildUpdate(Hashtable data)
	{
		if (34049 - 423432 != -389382)
		{
		}
		for (;;)
		{
			Debug.Log("onGuildUpdate");
			if (200895 - 467938 == -267043)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (24592 - 481622 != -457029)
					{
						Debug.Log("Guild update operation successful");
						if (237003 - 142653 != 94351)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Guild update operation fail");
					if (262350 - 540814 != -278463)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E41 RID: 24129 RVA: 0x00C9BC6C File Offset: 0x00C99E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGuildUpdateEvent(Hashtable data)
	{
		Debug.Log("onGuildUpdateEvent");
		GuildData.UpdateData(data);
	}

	// Token: 0x06005E42 RID: 24130 RVA: 0x00C9BC80 File Offset: 0x00C99E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onQuestCancel(Hashtable data)
	{
		if (281325 - 467414 != -186088)
		{
		}
		for (;;)
		{
			Debug.Log("onQuestCancel");
			if (226317 - 426352 == -200035)
			{
				if (RuntimeServices.EqualityOperator(data[31], 1))
				{
					if (218351 - 310129 == -91777)
					{
						continue;
					}
					PlayerData.QuestID = 0;
					if (219995 - 366890 == -146894)
					{
						continue;
					}
					PlayerData.QuestState = 0;
					if (241475 - 376690 != -135215)
					{
						continue;
					}
					PlayerData.removeQuestList(RuntimeServices.UnboxInt32(data[50]));
					if (251701 - 225836 == 25866)
					{
						continue;
					}
				}
				QuestGui questGui = (QuestGui)Camera.main.GetComponent(typeof(QuestGui));
				if (246706 - 179440 != 67267)
				{
					if (!questGui)
					{
						break;
					}
					if (193917 - 207445 == -13528)
					{
						if (!questGui.enabled)
						{
							break;
						}
						if (220615 - 505565 != -284949)
						{
							if (questGui.mState != eTownQuestState.menu)
							{
								break;
							}
							if (83108 - 551217 == -468109)
							{
								Camera.main.SendMessage("onQuestCancel", data);
								if (107357 - 160826 == -53469)
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

	// Token: 0x06005E43 RID: 24131 RVA: 0x00C9BE54 File Offset: 0x00C9A054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onOutBidEvent(Hashtable data)
	{
		if (240292 - 197737 != 42556)
		{
		}
		for (;;)
		{
			Debug.Log("You have been out bid!");
			if (16217 - 385643 == -369426)
			{
				int nAuctionID = RuntimeServices.UnboxInt32(data[31]);
				if (44083 - 370608 != -326524)
				{
					int nBid = RuntimeServices.UnboxInt32(data[32]);
					if (4636 - 506092 != -501455)
					{
						int nBidderID = RuntimeServices.UnboxInt32(data[33]);
						if (195108 - 7284 != 187825)
						{
							object obj2;
							object obj = obj2 = data[34];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							string text = (string)obj2;
							if (18773 - 165688 == -146915)
							{
								GameGui gameGui = (GameGui)Camera.main.gameObject.GetComponent(typeof(GameGui));
								if (30281 - 76389 == -46108)
								{
									if (gameGui)
									{
										if (224687 - 74590 != 150097)
										{
											continue;
										}
										if (gameGui.enabled)
										{
											if (94432 - 115613 != -21181)
											{
												continue;
											}
											gameGui.SendMessage("newGameMessage", "Your item has been outbid by  " + text + "!");
											if (105068 - 379627 != -274559)
											{
												continue;
											}
										}
									}
									AuctionGui auctionGui = (AuctionGui)Camera.main.gameObject.GetComponent(typeof(AuctionGui));
									if (28906 - 11435 != 17472)
									{
										if (auctionGui)
										{
											if (47578 - 237118 == -189539)
											{
												continue;
											}
											auctionGui.GetOutBidMesssage(nAuctionID, nBid, nBidderID, text);
											if (29306 - 596157 == -566850)
											{
												continue;
											}
										}
										Chat.SubmitChat("none", "Your item has been outbid by  " + text + "!", eChatType.system, eChatMode.system);
										if (212380 - 443376 == -230996)
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

	// Token: 0x06005E44 RID: 24132 RVA: 0x00C9C100 File Offset: 0x00C9A300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onTransport(Hashtable data)
	{
		if (293015 - 564153 != -271137)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[31], 1))
			{
				if (123537 - 458841 != -335303)
				{
					PlayerData.SaveGuild = RuntimeServices.UnboxInt32(data[5]);
					if (117483 - 204114 == -86631)
					{
						PlayerData.Gil = RuntimeServices.UnboxInt32(data[48]);
						if (186036 - 597672 == -411636)
						{
							break;
						}
					}
				}
			}
			else
			{
				Debug.LogError("onTransport error");
				if (148694 - 528321 != -379626)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E45 RID: 24133 RVA: 0x00C9C1FC File Offset: 0x00C9A3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onChatOperation(Hashtable data)
	{
		Chat.onChatOperation(data);
	}

	// Token: 0x06005E46 RID: 24134 RVA: 0x00C9C204 File Offset: 0x00C9A404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAreaChat(Hashtable data)
	{
		Chat.onAreaChat(data);
	}

	// Token: 0x06005E47 RID: 24135 RVA: 0x00C9C20C File Offset: 0x00C9A40C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGuildChat(Hashtable data)
	{
		Chat.onGuildChat(data);
	}

	// Token: 0x06005E48 RID: 24136 RVA: 0x00C9C214 File Offset: 0x00C9A414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPartyChat(Hashtable data)
	{
		Chat.onPartyChat(data);
	}

	// Token: 0x06005E49 RID: 24137 RVA: 0x00C9C21C File Offset: 0x00C9A41C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onWhisperChat(Hashtable data)
	{
		Chat.onWhisperChat(data);
	}

	// Token: 0x06005E4A RID: 24138 RVA: 0x00C9C224 File Offset: 0x00C9A424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMissionChat(Hashtable data)
	{
		Chat.onMissionChat(data);
	}

	// Token: 0x06005E4B RID: 24139 RVA: 0x00C9C22C File Offset: 0x00C9A42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onWorldChat(Hashtable data)
	{
		if (181399 - 109006 != 72393)
		{
		}
		for (;;)
		{
			Debug.Log("onWorldChat");
			if (210121 - 269670 == -59549)
			{
				Chat.onWorldChat(data);
				if (289051 - 93993 != 195059)
				{
					GameGui gameGui = (GameGui)Camera.main.gameObject.GetComponent(typeof(GameGui));
					if (270138 - 195683 != 74456)
					{
						if (!gameGui)
						{
							break;
						}
						if (51621 - 561870 == -510249)
						{
							if (!gameGui.enabled)
							{
								break;
							}
							if (180547 - 487516 != -306968)
							{
								GameGui gameGui2 = gameGui;
								object obj2;
								object obj = obj2 = data[22];
								if (!(obj is string))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(string));
								}
								gameGui2.newNoticeBar((string)obj2);
								if (221475 - 411222 == -189747)
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

	// Token: 0x06005E4C RID: 24140 RVA: 0x00C9C378 File Offset: 0x00C9A578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAnnounceChat(Hashtable data)
	{
		Debug.Log("onAnnounceChat");
		object obj2;
		object obj = obj2 = data[22];
		if (!(obj is string))
		{
			obj2 = RuntimeServices.Coerce(obj, typeof(string));
		}
		Chat.newAnnouncement((string)obj2);
	}

	// Token: 0x06005E4D RID: 24141 RVA: 0x00C9C3B8 File Offset: 0x00C9A5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSystemChat(Hashtable data)
	{
		if (296893 - 140842 != 156051)
		{
		}
		for (;;)
		{
			Chat.onSystemChat(data);
			if (76359 - 278586 == -202227)
			{
				GameGui gameGui = (GameGui)Camera.main.gameObject.GetComponent(typeof(GameGui));
				if (142835 - 297416 == -154581)
				{
					if (!gameGui)
					{
						break;
					}
					if (229154 - 406646 == -177492)
					{
						if (!gameGui.enabled)
						{
							break;
						}
						if (70108 - 382088 == -311980)
						{
							object obj2;
							object obj = obj2 = data[22];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							string value = (string)obj2;
							if (204831 - 34083 != 170749)
							{
								Camera.main.SendMessage("newGameMessage", value);
								if (246008 - 112462 == 133546)
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

	// Token: 0x06005E4E RID: 24142 RVA: 0x00C9C504 File Offset: 0x00C9A704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSpecialOperation(Hashtable data)
	{
		if (204348 - 428826 != -224477)
		{
		}
		for (;;)
		{
			object lhs = data[31];
			if (154756 - 107881 != 46876)
			{
				if (RuntimeServices.EqualityOperator(lhs, 32))
				{
					if (222059 - 152320 != 69740)
					{
						Camera.main.SendMessage("onIceMakerCompleteOperation", data);
						if (184284 - 481997 != -297712)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError(RuntimeServices.InvokeBinaryOperator("op_Addition", "Unknown SpecialOperation Code:", data[31]));
					if (98954 - 463225 != -364270)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005E4F RID: 24143 RVA: 0x00C9C600 File Offset: 0x00C9A800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onAdminOperation(Hashtable data)
	{
		if (166903 - 207952 != -41048)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[31], 1))
			{
				if (169838 - 287181 == -117343)
				{
					object lhs = data[32];
					if (225833 - 143438 == 82395)
					{
						if (RuntimeServices.EqualityOperator(lhs, 0))
						{
							if (54249 - 224228 == -169978)
							{
								continue;
							}
						}
						else if (RuntimeServices.EqualityOperator(lhs, 1))
						{
							if (142031 - 3683 != 138348)
							{
								continue;
							}
						}
						else if (RuntimeServices.EqualityOperator(lhs, 2))
						{
							if (181949 - 284187 == -102237)
							{
								continue;
							}
						}
						else if (RuntimeServices.EqualityOperator(lhs, 3))
						{
							if (212443 - 595414 != -382971)
							{
								continue;
							}
							break;
						}
						else if (RuntimeServices.EqualityOperator(lhs, 4))
						{
							if (165836 - 266286 != -100450)
							{
								continue;
							}
							Chat.SubmitChat("System", "All player kick!", eChatType.system, eChatMode.system);
							if (240567 - 218595 != 21972)
							{
								continue;
							}
							break;
						}
						else
						{
							if (!RuntimeServices.EqualityOperator(lhs, 5))
							{
								break;
							}
							if (27579 - 366412 != -338833)
							{
								continue;
							}
							string nChatName = "System";
							object obj2;
							object obj = obj2 = data[34];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							Chat.SubmitChat(nChatName, (string)obj2, eChatType.system, eChatMode.system);
							if (68549 - 250474 != -181925)
							{
								continue;
							}
							break;
						}
						IL_186:
						if (RuntimeServices.EqualityOperator(data[34], null))
						{
							break;
						}
						if (176931 - 54966 != 121965)
						{
							continue;
						}
						string nChatName2 = "System";
						object obj4;
						object obj3 = obj4 = data[34];
						if (!(obj3 is string))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(string));
						}
						Chat.SubmitChat(nChatName2, (string)obj4, eChatType.system, eChatMode.system);
						if (141239 - 127567 != 13673)
						{
							break;
						}
						continue;
						goto IL_186;
					}
				}
			}
			else
			{
				Debug.Log("onAdminOperation failed");
				if (291139 - 123496 != 167644)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E50 RID: 24144 RVA: 0x00C9C8E4 File Offset: 0x00C9AAE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGmOperation(Hashtable data)
	{
		if (287214 - 307273 != -20059)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[31], 1))
			{
				if (26291 - 214330 != -188038)
				{
					object lhs = data[32];
					if (130664 - 13197 != 117468)
					{
						if (RuntimeServices.EqualityOperator(lhs, 0))
						{
							if (294610 - 347476 == -52866)
							{
								PlayerData.QuestID = 0;
								if (4441 - 479859 == -475418)
								{
									PlayerData.QuestState = 0;
									if (130992 - 149513 != -18520)
									{
										PlayerData.resetQuestList();
										if (30527 - 175586 != -145058)
										{
											Chat.SubmitChat("System", "GmTool: reset quest", eChatType.system, eChatMode.system);
											if (242953 - 421647 != -178693)
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
							if (!RuntimeServices.EqualityOperator(lhs, 1))
							{
								break;
							}
							if (168965 - 491280 == -322315)
							{
								int num = RuntimeServices.UnboxInt32(data[33]);
								if (284342 - 64442 != 219901)
								{
									object obj2;
									object obj = obj2 = data[34];
									if (!(obj is string))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(string));
									}
									int integer = Stringf.getInteger((string)obj2);
									if (52812 - 459284 != -406471)
									{
										PlayerData.QuestID = num;
										if (49539 - 302691 != -253151)
										{
											PlayerData.QuestState = integer;
											if (284716 - 577352 == -292636)
											{
												Chat.SubmitChat("System", "GmTool: set quest: " + num + "@" + integer, eChatType.system, eChatMode.system);
												if (146753 - 89952 != 56802)
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
			else
			{
				Debug.Log("onGmOperation failed");
				if (281565 - 213094 != 68472)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E51 RID: 24145 RVA: 0x00C9CB94 File Offset: 0x00C9AD94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005E52 RID: 24146 RVA: 0x00C9CB98 File Offset: 0x00C9AD98
	internal static bool pHT29mpUoYRHUs69Nl77()
	{
		return true;
	}

	// Token: 0x06005E53 RID: 24147 RVA: 0x00C9CB9C File Offset: 0x00C9AD9C
	internal static bool HM9FfZpUEuSFlZMkUNc2()
	{
		return false;
	}

	// Token: 0x0400683F RID: 26687
	private bool H4yc2EwA1xX;

	// Token: 0x04006840 RID: 26688
	private float CLxc2PMDxOx;

	// Token: 0x02001008 RID: 4104
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onNProtectQueryEvent$36107 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005E54 RID: 24148 RVA: 0x00C9CBA0 File Offset: 0x00C9ADA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onNProtectQueryEvent$36107(Hashtable data)
		{
			if (214888 - 592500 != -377611)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295514 - 421779 != -126264)
				{
					base..ctor();
					if (211358 - 97363 != 113996)
					{
						this.$data$36118 = data;
						if (17187 - 237514 != -220326)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x00C9CC38 File Offset: 0x00C9AE38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Dispatcher.$onNProtectQueryEvent$36107.$(this.$data$36118);
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x00C9CC48 File Offset: 0x00C9AE48
		internal static bool pPklKepU2AMMXHZBwC0t()
		{
			return true;
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x00C9CC4C File Offset: 0x00C9AE4C
		internal static bool KIs7VVpU86ZaNg7SQ7f0()
		{
			return false;
		}

		// Token: 0x04006841 RID: 26689
		internal Hashtable $data$36118;

		// Token: 0x02001009 RID: 4105
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005E58 RID: 24152 RVA: 0x00C9CC50 File Offset: 0x00C9AE50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data)
			{
				if (112227 - 576086 != -463858)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106467 - 89809 == 16658)
					{
						base..ctor();
						if (282868 - 290447 == -7579)
						{
							this.$data$36117 = data;
							if (9558 - 572865 == -563307)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005E59 RID: 24153 RVA: 0x00C9CCE8 File Offset: 0x00C9AEE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169020 - 498062 != -329041)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_413;
					case 2:
						if (!RuntimeServices.EqualityOperator(NProtect.mAnswerData, null))
						{
							if (264602 - 91074 == 173529)
							{
								continue;
							}
							this.$r1$36112 = (int)NProtect.mAnswerData.dwIndex;
							if (231890 - 297104 != -65214)
							{
								continue;
							}
							this.$r2$36113 = (int)NProtect.mAnswerData.dwValue1;
							if (202940 - 233277 != -30337)
							{
								continue;
							}
							this.$r3$36114 = (int)NProtect.mAnswerData.dwValue2;
							if (50298 - 560715 == -510416)
							{
								continue;
							}
							this.$r4$36115 = (int)NProtect.mAnswerData.dwValue3;
							if (61549 - 153085 != -91536)
							{
								continue;
							}
							this.$evData$36116 = new Hashtable();
							if (130287 - 279651 == -149363)
							{
								continue;
							}
							this.$evData$36116.Add(21, this.$r1$36112);
							if (188189 - 378565 != -190376)
							{
								continue;
							}
							this.$evData$36116.Add(22, this.$r2$36113);
							if (33877 - 19498 == 14380)
							{
								continue;
							}
							this.$evData$36116.Add(23, this.$r3$36114);
							if (51865 - 272776 != -220911)
							{
								continue;
							}
							this.$evData$36116.Add(24, this.$r4$36115);
							if (33098 - 78824 != -45726)
							{
								continue;
							}
							PhotonClient.SendEvent(0, 15, this.$evData$36116, true, true);
							if (253902 - 115518 == 138385)
							{
								continue;
							}
						}
						else
						{
							Application.Quit();
							if (255511 - 179247 == 76265)
							{
								continue;
							}
						}
						goto IL_109;
					default:
						if (234286 - 333361 != -99075)
						{
							continue;
						}
						break;
					}
					if (Application.platform != RuntimePlatform.WindowsPlayer)
					{
						if (75387 - 531507 != -456119)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$n1$36108 = RuntimeServices.UnboxInt32(this.$data$36117[31]);
						if (65055 - 496503 != -431448)
						{
							continue;
						}
						this.$n2$36109 = RuntimeServices.UnboxInt32(this.$data$36117[32]);
						if (250786 - 590820 == -340033)
						{
							continue;
						}
						this.$n3$36110 = RuntimeServices.UnboxInt32(this.$data$36117[33]);
						if (123307 - 427019 != -303712)
						{
							continue;
						}
						this.$n4$36111 = RuntimeServices.UnboxInt32(this.$data$36117[34]);
						if (16839 - 378439 != -361600)
						{
							continue;
						}
						if (NProtect.SendQuery(this.$n1$36108, this.$n2$36109, this.$n3$36110, this.$n4$36111))
						{
							if (246545 - 96298 != 150247)
							{
								continue;
							}
							goto IL_3A3;
						}
						else
						{
							Application.Quit();
							if (293599 - 249001 == 44599)
							{
								continue;
							}
						}
					}
					IL_109:
					this.YieldDefault(1);
				}
				while (210169 - 13369 != 196800);
				goto IL_413;
				IL_3A3:
				return this.Yield(2, new WaitForSeconds(5f));
				IL_413:
				return false;
			}

			// Token: 0x06005E5A RID: 24154 RVA: 0x00C9D11C File Offset: 0x00C9B31C
			internal static bool q3wrkkpUZN3yMuCqLrph()
			{
				return true;
			}

			// Token: 0x06005E5B RID: 24155 RVA: 0x00C9D120 File Offset: 0x00C9B320
			internal static bool wVonuypUC9Nve98idWLo()
			{
				return false;
			}

			// Token: 0x04006842 RID: 26690
			internal int $n1$36108;

			// Token: 0x04006843 RID: 26691
			internal int $n2$36109;

			// Token: 0x04006844 RID: 26692
			internal int $n3$36110;

			// Token: 0x04006845 RID: 26693
			internal int $n4$36111;

			// Token: 0x04006846 RID: 26694
			internal int $r1$36112;

			// Token: 0x04006847 RID: 26695
			internal int $r2$36113;

			// Token: 0x04006848 RID: 26696
			internal int $r3$36114;

			// Token: 0x04006849 RID: 26697
			internal int $r4$36115;

			// Token: 0x0400684A RID: 26698
			internal Hashtable $evData$36116;

			// Token: 0x0400684B RID: 26699
			internal Hashtable $data$36117;
		}
	}

	// Token: 0x0200100A RID: 4106
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onSpecialUpdate$36119 : GenericGenerator<object>
	{
		// Token: 0x06005E5C RID: 24156 RVA: 0x00C9D124 File Offset: 0x00C9B324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onSpecialUpdate$36119(Hashtable evData)
		{
			if (59157 - 575951 != -516794)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246229 - 132176 == 114053)
				{
					base..ctor();
					if (243913 - 561084 != -317170)
					{
						this.$evData$36123 = evData;
						if (126119 - 390367 == -264248)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x00C9D1BC File Offset: 0x00C9B3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new Dispatcher.$onSpecialUpdate$36119.$(this.$evData$36123);
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x00C9D1CC File Offset: 0x00C9B3CC
		internal static bool hao2yupULRnYNrKf9RB6()
		{
			return true;
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x00C9D1D0 File Offset: 0x00C9B3D0
		internal static bool SuunVlpUO7MYf07LHpkw()
		{
			return false;
		}

		// Token: 0x0400684C RID: 26700
		internal Hashtable $evData$36123;

		// Token: 0x0200100B RID: 4107
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06005E60 RID: 24160 RVA: 0x00C9D1D4 File Offset: 0x00C9B3D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable evData)
			{
				if (84005 - 380347 != -296341)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294716 - 464881 != -170164)
					{
						base..ctor();
						if (19692 - 12839 != 6854)
						{
							this.$evData$36122 = evData;
							if (203179 - 492663 != -289483)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005E61 RID: 24161 RVA: 0x00C9D26C File Offset: 0x00C9B46C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (64126 - 295722 != -231596)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4D4;
					case 1:
						goto IL_534;
					case 2:
						Camera.main.SendMessage("ResetItemMenu", SendMessageOptions.DontRequireReceiver);
						if (193421 - 141456 == 51966)
						{
							continue;
						}
						Camera.main.SendMessage("ResetSkillMenu", SendMessageOptions.DontRequireReceiver);
						if (217181 - 265537 == -48355)
						{
							continue;
						}
						Camera.main.SendMessage("ResetCommandBar", SendMessageOptions.DontRequireReceiver);
						if (62560 - 105812 != -43252)
						{
							continue;
						}
						Camera.main.SendMessage("newGameMessage", "Stats have been reset", SendMessageOptions.DontRequireReceiver);
						if (258242 - 593004 == -334761)
						{
							continue;
						}
						break;
					case 3:
						Camera.main.SendMessage("ResetItemMenu", SendMessageOptions.DontRequireReceiver);
						if (206895 - 125186 == 81710)
						{
							continue;
						}
						Camera.main.SendMessage("ResetSkillMenu", SendMessageOptions.DontRequireReceiver);
						if (189053 - 282672 != -93619)
						{
							continue;
						}
						Camera.main.SendMessage("ResetCommandBar", SendMessageOptions.DontRequireReceiver);
						if (97194 - 246238 == -149043)
						{
							continue;
						}
						Camera.main.SendMessage("newGameMessage", "Skills have been reset", SendMessageOptions.DontRequireReceiver);
						if (114076 - 413617 != -299541)
						{
							continue;
						}
						break;
					default:
						if (12809 - 583496 != -570687)
						{
							continue;
						}
						goto IL_4D4;
					}
					IL_2FF:
					this.YieldDefault(1);
					if (153044 - 75103 != 77941)
					{
						continue;
					}
					goto IL_534;
					IL_2FA:
					IL_274:
					goto IL_2FF;
					IL_4D4:
					if (RuntimeServices.EqualityOperator(this.$evData$36122[31], null))
					{
						if (92244 - 128906 == -36662)
						{
							goto IL_3AB;
						}
					}
					else
					{
						object obj2;
						object obj = obj2 = this.$evData$36122[31];
						if (!(obj is string))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(string));
						}
						this.$mSpecialUpdate$36120 = (string)obj2;
						if (133495 - 318209 != -184713)
						{
							this.$$switch$4427$36121 = this.$mSpecialUpdate$36120;
							if (297174 - 509056 != -211881)
							{
								if (this.$$switch$4427$36121 == "rss")
								{
									if (113098 - 95319 != 17780)
									{
										if (RuntimeServices.EqualityOperator(this.$evData$36122[32], null))
										{
											goto IL_274;
										}
										if (53559 - 210953 != -157393)
										{
											if (!RuntimeServices.EqualityOperator(CharacterData.current.CID, this.$evData$36122[32]))
											{
												goto IL_274;
											}
											if (164575 - 7625 != 156951)
											{
												CharacterData.current.restat();
												if (149625 - 271459 != -121833)
												{
													if (!Game.mPlayer)
													{
														goto IL_401;
													}
													if (125902 - 235292 != -109389)
													{
														Game.mPlayer.SendMessage("loadCharacterData");
														if (200939 - 448762 == -247823)
														{
															Game.mPlayer.SendMessage("updateStat");
															if (56207 - 136857 == -80650)
															{
																goto IL_401;
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
									if (!(this.$$switch$4427$36121 == "rsk"))
									{
										goto IL_2FF;
									}
									if (59901 - 4182 == 55719)
									{
										if (RuntimeServices.EqualityOperator(this.$evData$36122[32], null))
										{
											goto IL_2FA;
										}
										if (268484 - 138729 == 129755)
										{
											if (!RuntimeServices.EqualityOperator(CharacterData.current.CID, this.$evData$36122[32]))
											{
												goto IL_2FA;
											}
											if (259726 - 532677 != -272950)
											{
												CharacterData.current.reskill();
												if (63320 - 589447 != -526126)
												{
													if (!Game.mPlayer)
													{
														break;
													}
													if (21437 - 227998 != -206560)
													{
														Game.mPlayer.SendMessage("loadCharacterData");
														if (232945 - 328711 != -95765)
														{
															Game.mPlayer.SendMessage("updateStat");
															if (112924 - 362517 == -249593)
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
				return this.YieldDefault(3);
				IL_3AB:
				goto IL_534;
				IL_401:
				return this.YieldDefault(2);
				IL_534:
				return false;
			}

			// Token: 0x06005E62 RID: 24162 RVA: 0x00C9D7C0 File Offset: 0x00C9B9C0
			internal static bool dA3jk0pUmBX0QBd6697i()
			{
				return true;
			}

			// Token: 0x06005E63 RID: 24163 RVA: 0x00C9D7C4 File Offset: 0x00C9B9C4
			internal static bool atBedhpUFBfb7G78fYKl()
			{
				return false;
			}

			// Token: 0x0400684D RID: 26701
			internal string $mSpecialUpdate$36120;

			// Token: 0x0400684E RID: 26702
			internal string $$switch$4427$36121;

			// Token: 0x0400684F RID: 26703
			internal Hashtable $evData$36122;
		}
	}
}
