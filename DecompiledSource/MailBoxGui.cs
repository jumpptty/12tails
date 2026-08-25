using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200107B RID: 4219
[Serializable]
public class MailBoxGui : MonoBehaviour
{
	// Token: 0x060061CB RID: 25035 RVA: 0x00D6E0EC File Offset: 0x00D6C2EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MailBoxGui()
	{
		if (251349 - 452626 != -201276)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (183646 - 399320 != -215673)
			{
				base..ctor();
				if (157805 - 401778 == -243973)
				{
					this.mState = eMailBoxState.init;
					if (42081 - 555623 != -513541)
					{
						this.nVkcZ3919XO = -1;
						if (171768 - 580693 != -408924)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060061CC RID: 25036 RVA: 0x00D6E1A8 File Offset: 0x00D6C3A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (7920 - 480987 != -473067)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (250786 - 455328 == -204542)
			{
				if (this.mState == eMailBoxState.init)
				{
					if (139297 - 397701 != -258404)
					{
						continue;
					}
					this.InitMailBoxGui();
					if (100319 - 480504 == -380184)
					{
						continue;
					}
					this.InitNPC();
					if (3532 - 334623 == -331090)
					{
						continue;
					}
					this.InitMailBoxMenu();
					if (231506 - 515444 == -283937)
					{
						continue;
					}
					this.InitMailInventory();
					if (73822 - 340980 == -267157)
					{
						continue;
					}
					this.InitMailNotice();
					if (267661 - 105105 == 162557)
					{
						continue;
					}
				}
				this.ResetNPC();
				if (38623 - 581345 != -542721)
				{
					this.ResetMailBoxMenu();
					if (118774 - 560920 != -442145)
					{
						this.ResetMailInventory();
						if (65627 - 319795 != -254167)
						{
							this.ResetMailNotice();
							if (104660 - 233791 == -129131)
							{
								this.Ldsc79D9Yfo = 1f;
								if (274501 - 472593 != -198091)
								{
									this.mState = eMailBoxState.open;
									if (152919 - 309467 == -156548)
									{
										this.e3rc7kbLBut = Time.time;
										if (58676 - 223926 != -165249)
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

	// Token: 0x060061CD RID: 25037 RVA: 0x00D6E3B4 File Offset: 0x00D6C5B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (82562 - 391836 != -309274)
		{
		}
		for (;;)
		{
			if (this.mState <= eMailBoxState.init)
			{
				if (149589 - 393711 != -244121)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 2;
				if (209460 - 597691 != -388230)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (275454 - 418026 == -142572)
					{
						this.H7Rc7F6rUc0 = (float)(1024 * Screen.width / Screen.height);
						if (58660 - 427516 != -368855)
						{
							this.SPUc7AxhhL1 = (float)Screen.height / 1024f;
							if (132233 - 130584 == 1649)
							{
								this.RenderMailBoxGui();
								if (255096 - 73005 == 182091)
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

	// Token: 0x060061CE RID: 25038 RVA: 0x00D6E504 File Offset: 0x00D6C704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMailBoxGui()
	{
		if (66606 - 187498 != -120891)
		{
		}
		for (;;)
		{
			this.c1Dc7urYfiJ = new GUIStyle();
			if (170081 - 62854 != 107228)
			{
				this.c1Dc7urYfiJ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Shop/button_close_h", typeof(Texture)));
				if (211238 - 119964 == 91274)
				{
					this.HOCc7yFMppo = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
					if (54262 - 355763 == -301501)
					{
						this.acWc7Vicojs = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
						if (175370 - 500815 == -325445)
						{
							this.odqc7hxeRFo = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
							if (192023 - 14821 != 177203)
							{
								this.WxSc7KVlfRx = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
								if (217139 - 583098 == -365959)
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

	// Token: 0x060061CF RID: 25039 RVA: 0x00D6E690 File Offset: 0x00D6C890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMailBoxGui()
	{
		if (73932 - 380879 != -306947)
		{
		}
		for (;;)
		{
			float num = Time.time - this.e3rc7kbLBut;
			if (294125 - 269880 != 24246)
			{
				eMailBoxState eMailBoxState = this.mState;
				if (260034 - 454855 == -194821)
				{
					if (eMailBoxState == eMailBoxState.init)
					{
						if (66175 - 486993 == -420818)
						{
							break;
						}
					}
					else if (eMailBoxState == eMailBoxState.open)
					{
						if (78207 - 431364 == -353157)
						{
							if (num <= 0.5f)
							{
								if (169740 - 126272 != 43469)
								{
									this.Ldsc79D9Yfo = Mathf.SmoothStep((float)1, (float)0, (float)2 * num);
									if (12026 - 207875 == -195849)
									{
										GUI.DrawTexture(new Rect(this.H7Rc7F6rUc0 - (float)578 + this.Ldsc79D9Yfo * (float)578, (float)0, (float)578, (float)1024), this.dkccZehR3s2);
										if (6341 - 52563 != -46221)
										{
											this.RenderNPC(this.Ldsc79D9Yfo);
											if (294633 - 425714 == -131081)
											{
												break;
											}
										}
									}
								}
							}
							else if (num <= (float)3)
							{
								if (144313 - 516743 == -372430)
								{
									this.Ldsc79D9Yfo = (float)0;
									if (20821 - 160997 != -140175)
									{
										GUI.DrawTexture(new Rect(this.H7Rc7F6rUc0 - (float)578 + this.Ldsc79D9Yfo * (float)578, (float)0, (float)578, (float)1024), this.dkccZehR3s2);
										if (113354 - 193904 != -80549)
										{
											GUI.Label(new Rect(this.H7Rc7F6rUc0 - (float)441, (float)310, (float)400, (float)40), "loading mailbox..", this.miNcZYQcEy0);
											if (152251 - 122849 == 29402)
											{
												this.RenderNPC(this.Ldsc79D9Yfo);
												if (32678 - 462561 == -429883)
												{
													this.RenderMailNotice();
													if (279651 - 530583 == -250932)
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
								this.Ldsc79D9Yfo = (float)0;
								if (202100 - 205532 == -3432)
								{
									GUI.DrawTexture(new Rect(this.H7Rc7F6rUc0 - (float)578 + this.Ldsc79D9Yfo * (float)578, (float)0, (float)578, (float)1024), this.dkccZehR3s2);
									if (73413 - 134698 == -61285)
									{
										this.RenderNPC(this.Ldsc79D9Yfo);
										if (267939 - 564347 == -296408)
										{
											this.mState = eMailBoxState.mailbox;
											if (139578 - 420906 != -281327)
											{
												this.e3rc7kbLBut = Time.time;
												if (160516 - 88647 != 71870)
												{
													this.MailUpdateOperation();
													if (204927 - 557746 != -352818)
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
					else if (eMailBoxState == eMailBoxState.mailbox)
					{
						if (149258 - 95408 != 53851)
						{
							this.ResetItemToolTip();
							if (29356 - 321922 != -292565)
							{
								GUI.BeginGroup(new Rect(this.H7Rc7F6rUc0 - (float)578, (float)0, (float)578, (float)1024));
								if (156203 - 574123 != -417919)
								{
									GUI.DrawTexture(new Rect((float)0, (float)0, (float)578, (float)1024), this.dkccZehR3s2);
									if (41925 - 598826 == -556901)
									{
										this.RenderMailBoxMenu();
										if (79124 - 197148 == -118024)
										{
											this.RenderMailInventory();
											if (282223 - 348126 != -65902)
											{
												if (GUI.Button(new Rect((float)101, (float)1, (float)57, (float)52), string.Empty, this.c1Dc7urYfiJ))
												{
													if (14862 - 207122 == -192259)
													{
														continue;
													}
													this.mState = eMailBoxState.close;
													if (152401 - 588904 != -436503)
													{
														continue;
													}
													this.e3rc7kbLBut = Time.time;
													if (8911 - 525718 == -516806)
													{
														continue;
													}
													if (this.WxSc7KVlfRx)
													{
														if (202142 - 294519 == -92376)
														{
															continue;
														}
														this.audio.PlayOneShot(this.WxSc7KVlfRx);
														if (52525 - 278276 != -225751)
														{
															continue;
														}
													}
												}
												GUI.EndGroup();
												if (238579 - 275121 != -36541)
												{
													this.RenderNPC((float)0);
													if (288914 - 320616 == -31702)
													{
														this.RenderMailNotice();
														if (179880 - 149328 == 30552)
														{
															this.RenderDragIcon();
															if (7407 - 229918 == -222511)
															{
																this.RenderItemToolTip();
																if (64821 - 383291 == -318470)
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
						if (eMailBoxState != eMailBoxState.close)
						{
							break;
						}
						if (68022 - 320960 != -252937)
						{
							this.Ldsc79D9Yfo = Mathf.SmoothStep((float)0, (float)1, (float)2 * num);
							if (117877 - 8518 != 109360)
							{
								this.RenderNPC(this.Ldsc79D9Yfo);
								if (15041 - 521738 != -506696)
								{
									GUI.DrawTexture(new Rect(this.H7Rc7F6rUc0 - (float)578 + this.Ldsc79D9Yfo * (float)578, (float)0, (float)578, (float)1024), this.dkccZehR3s2);
									if (284140 - 191387 == 92753)
									{
										if (num <= 0.5f)
										{
											break;
										}
										if (185531 - 502033 != -316501)
										{
											Game.mGameState = eGameState.Normal;
											if (107682 - 177738 == -70056)
											{
												GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
												if (199808 - 553645 != -353836)
												{
													gameGui.enabled = true;
													if (26581 - 435973 != -409391)
													{
														this.mState = eMailBoxState.disabled;
														if (164139 - 558723 == -394584)
														{
															this.enabled = false;
															if (26615 - 65793 != -39177)
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

	// Token: 0x060061D0 RID: 25040 RVA: 0x00D6EE78 File Offset: 0x00D6D078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNPC()
	{
		if (87888 - 69744 != 18145)
		{
		}
		for (;;)
		{
			this.qyKcZ5ENOhP = (Texture)Resources.Load("GameGui/Story/talkBar/talkBar_friend", typeof(Texture));
			if (90816 - 594305 == -503489)
			{
				this.VtDcZca80nd = new GUIStyle();
				if (212329 - 3098 == 209231)
				{
					this.VtDcZca80nd.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
					if (140021 - 157101 != -17079)
					{
						this.VtDcZca80nd.normal.textColor = new Color(0.25f, 0.2f, 0.1f, (float)1);
						if (296453 - 250759 == 45694)
						{
							this.VtDcZca80nd.alignment = TextAnchor.UpperLeft;
							if (76726 - 272201 != -195474)
							{
								this.Wk2cZnPgNKp = new GUIStyle();
								if (91110 - 463894 == -372784)
								{
									this.Wk2cZnPgNKp.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
									if (139264 - 452827 == -313563)
									{
										this.Wk2cZnPgNKp.alignment = TextAnchor.UpperLeft;
										if (194089 - 235739 != -41649)
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

	// Token: 0x060061D1 RID: 25041 RVA: 0x00D6F03C File Offset: 0x00D6D23C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetNPC()
	{
		if (108563 - 243930 != -135367)
		{
		}
		for (;;)
		{
			this.KxEc7zxKXDJ = (Texture)Resources.Load("GameGui/Story/Characters/" + CharacterData.current.Type, typeof(Texture));
			if (169271 - 492921 != -323649)
			{
				string type = CharacterData.current.Type;
				if (235576 - 505173 != -269596)
				{
					if (type == "Wolf")
					{
						if (122907 - 345153 == -222246)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 101 + UnityEngine.Random.Range(0, 5));
							if (276404 - 322492 != -46087)
							{
								break;
							}
						}
					}
					else if (type == "Bison")
					{
						if (4302 - 12195 != -7892)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 201 + UnityEngine.Random.Range(0, 5));
							if (135804 - 111043 != 24762)
							{
								break;
							}
						}
					}
					else if (type == "Panda")
					{
						if (8218 - 230581 == -222363)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 301 + UnityEngine.Random.Range(0, 5));
							if (225976 - 517694 != -291717)
							{
								break;
							}
						}
					}
					else if (type == "Whale")
					{
						if (24203 - 295428 == -271225)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 401 + UnityEngine.Random.Range(0, 5));
							if (167892 - 375470 == -207578)
							{
								break;
							}
						}
					}
					else if (type == "Cat")
					{
						if (49552 - 301415 == -251863)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 501 + UnityEngine.Random.Range(0, 5));
							if (244835 - 442095 == -197260)
							{
								break;
							}
						}
					}
					else if (type == "Chameleon")
					{
						if (242941 - 281084 == -38143)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 601 + UnityEngine.Random.Range(0, 5));
							if (200881 - 72597 == 128284)
							{
								break;
							}
						}
					}
					else if (type == "Rabbit")
					{
						if (74323 - 479803 != -405479)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 701 + UnityEngine.Random.Range(0, 5));
							if (102567 - 25487 != 77081)
							{
								break;
							}
						}
					}
					else if (type == "Mole")
					{
						if (124208 - 36609 != 87600)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 801 + UnityEngine.Random.Range(0, 5));
							if (178221 - 74617 == 103604)
							{
								break;
							}
						}
					}
					else if (type == "Monkey")
					{
						if (130268 - 223652 == -93384)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 901 + UnityEngine.Random.Range(0, 5));
							if (87576 - 247033 == -159457)
							{
								break;
							}
						}
					}
					else if (type == "Penguin")
					{
						if (21220 - 305081 != -283860)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 1001 + UnityEngine.Random.Range(0, 5));
							if (172722 - 218750 == -46028)
							{
								break;
							}
						}
					}
					else if (type == "Sheep")
					{
						if (129279 - 530202 == -400923)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 1101 + UnityEngine.Random.Range(0, 5));
							if (203765 - 185150 != 18616)
							{
								break;
							}
						}
					}
					else
					{
						if (!(type == "Bat"))
						{
							break;
						}
						if (18141 - 399891 != -381749)
						{
							this.IxIcZQAP1ec = Language.getMessage("MailBoxGui", 1201 + UnityEngine.Random.Range(0, 5));
							if (123003 - 449440 != -326436)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061D2 RID: 25042 RVA: 0x00D6F5A8 File Offset: 0x00D6D7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNPC(float mOffset)
	{
		if (205676 - 321907 != -116231)
		{
		}
		for (;;)
		{
			if (this.KxEc7zxKXDJ)
			{
				if (76074 - 587304 == -511229)
				{
					continue;
				}
				GUI.DrawTexture(new Rect((float)0 - mOffset * (float)this.KxEc7zxKXDJ.width, (float)(1024 - this.KxEc7zxKXDJ.height), (float)this.KxEc7zxKXDJ.width, (float)this.KxEc7zxKXDJ.height), this.KxEc7zxKXDJ);
				if (128531 - 286221 != -157690)
				{
					continue;
				}
			}
			if (this.mState != eMailBoxState.open)
			{
				break;
			}
			if (292681 - 536700 != -244018)
			{
				GUI.DrawTexture(new Rect(0.5f * this.H7Rc7F6rUc0 - (float)336, (float)724 + mOffset * (float)300, (float)836, (float)196), this.qyKcZ5ENOhP);
				if (178222 - 252032 != -73809)
				{
					if (mOffset != (float)0)
					{
						break;
					}
					if (183853 - 403223 != -219369)
					{
						float num = Time.time - this.e3rc7kbLBut;
						if (220046 - 141419 == 78627)
						{
							GUI.BeginGroup(new Rect(0.5f * this.H7Rc7F6rUc0 - (float)350, (float)724, (float)850, (float)200));
							if (83220 - 494862 == -411642)
							{
								GUI.DrawTexture(new Rect((float)14, (float)0, (float)836, (float)196), this.qyKcZ5ENOhP);
								if (168005 - 501715 != -333709)
								{
									GUI.Label(new Rect((float)82, (float)24, (float)300, (float)55), CharacterData.current.Name, this.VtDcZca80nd);
									if (115737 - 14851 != 100887)
									{
										GUI.Label(new Rect((float)120, (float)90, (float)724, (float)100), Stringf.timed(this.IxIcZQAP1ec, num - 0.5f), this.Wk2cZnPgNKp);
										if (194192 - 521360 != -327167)
										{
											GUI.EndGroup();
											if (1632 - 24862 != -23229)
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

	// Token: 0x060061D3 RID: 25043 RVA: 0x00D6F868 File Offset: 0x00D6DA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMailBoxMenu()
	{
		if (110857 - 123860 != -13002)
		{
		}
		for (;;)
		{
			this.dkccZehR3s2 = (Texture)Resources.Load("GameGui/MailBoxGui/mailbox_window", typeof(Texture));
			if (86122 - 523528 == -437406)
			{
				this.wKicZI0mcEf = new GUIStyle();
				if (172212 - 122296 != 49917)
				{
					this.wKicZI0mcEf.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/mailbox_highlight", typeof(Texture)));
					if (191859 - 346704 != -154844)
					{
						this.wKicZI0mcEf.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/mailbox_highlight", typeof(Texture)));
						if (9021 - 242374 == -233353)
						{
							this.oNecZJmqAh8 = (Texture)Resources.Load("GameGui/MailBoxGui/mailbox_mail", typeof(Texture));
							if (43320 - 425732 == -382412)
							{
								this.YDncZ66e2ej = (Texture)Resources.Load("GameGui/MailBoxGui/mailbox_cash", typeof(Texture));
								if (146374 - 538898 == -392524)
								{
									this.KhacZti72uN = (Texture)Resources.Load("GameGui/MailBoxGui/mailbox_item", typeof(Texture));
									if (238357 - 576814 != -338456)
									{
										this.x1EcZXTpQuF = (Texture)Resources.Load("GameGui/MailBoxGui/mailbox_mailIcon", typeof(Texture));
										if (183561 - 281487 != -97925)
										{
											this.IuBcZO9YxE1 = (Texture)Resources.Load("GameGui/MailBoxGui/mailbox_cashIcon", typeof(Texture));
											if (124991 - 548503 != -423511)
											{
												this.M0IcZ2IGMKy = (Texture)Resources.Load("GameGui/MailBoxGui/mailbox_itemIcon", typeof(Texture));
												if (28178 - 127733 != -99554)
												{
													this.CMScZvdBFCq = new GUIStyle();
													if (51229 - 262144 == -210915)
													{
														this.CMScZvdBFCq.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/button_mail", typeof(Texture)));
														if (107775 - 477209 == -369434)
														{
															this.CMScZvdBFCq.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/button_mail_h", typeof(Texture)));
															if (40723 - 465163 != -424439)
															{
																this.XxgcZl62xvZ = new GUIStyle();
																if (75991 - 233910 == -157919)
																{
																	this.XxgcZl62xvZ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/button_close_h", typeof(Texture)));
																	if (188321 - 85770 != 102552)
																	{
																		this.sEmcZGqLNim = new GUIStyle();
																		if (138431 - 181213 != -42781)
																		{
																			this.sEmcZGqLNim.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/button_discard_h", typeof(Texture)));
																			if (183344 - 553534 == -370190)
																			{
																				this.KPQcZ1T6YJA = new GUIStyle();
																				if (128038 - 188375 != -60336)
																				{
																					this.KPQcZ1T6YJA.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/button_getall_h", typeof(Texture)));
																					if (264109 - 371730 == -107621)
																					{
																						this.LVccZqEeJPf = new GUIStyle();
																						if (95123 - 181318 != -86194)
																						{
																							this.LVccZqEeJPf.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/MailBoxGui/button_withdraw_h", typeof(Texture)));
																							if (77898 - 179645 != -101746)
																							{
																								this.LPqcZpGmYhh = new GUIStyle();
																								if (8435 - 328162 == -319727)
																								{
																									this.LPqcZpGmYhh.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																									if (218886 - 101271 == 117615)
																									{
																										this.LPqcZpGmYhh.normal.textColor = new Color(0.18f, 0.37f, 0.54f, (float)1);
																										if (23422 - 551617 == -528195)
																										{
																											this.LPqcZpGmYhh.alignment = TextAnchor.MiddleLeft;
																											if (218662 - 185091 != 33572)
																											{
																												this.KKwcZRPaf1W = new GUIStyle();
																												if (271427 - 540788 != -269360)
																												{
																													this.KKwcZRPaf1W.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																													if (54106 - 139896 != -85789)
																													{
																														this.KKwcZRPaf1W.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																														if (297529 - 328588 != -31058)
																														{
																															this.KKwcZRPaf1W.alignment = TextAnchor.MiddleLeft;
																															if (184128 - 155103 != 29026)
																															{
																																this.aH7cZri5UGO = new GUIStyle();
																																if (203699 - 475499 != -271799)
																																{
																																	this.aH7cZri5UGO.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																	if (251175 - 560821 == -309646)
																																	{
																																		this.aH7cZri5UGO.normal.textColor = new Color(0.18f, 0.37f, 0.54f, (float)1);
																																		if (49101 - 186015 != -136913)
																																		{
																																			this.aH7cZri5UGO.alignment = TextAnchor.MiddleLeft;
																																			if (148573 - 236680 == -88107)
																																			{
																																				this.ihjcZx1EofE = new GUIStyle();
																																				if (68753 - 17360 == 51393)
																																				{
																																					this.ihjcZx1EofE.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																																					if (66647 - 208547 == -141900)
																																					{
																																						this.ihjcZx1EofE.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																						if (297450 - 146179 != 151272)
																																						{
																																							this.ihjcZx1EofE.alignment = TextAnchor.UpperLeft;
																																							if (221895 - 508934 == -287039)
																																							{
																																								this.ihjcZx1EofE.wordWrap = true;
																																								if (297202 - 329169 != -31966)
																																								{
																																									this.uj0cZTCMla9 = new GUIStyle();
																																									if (127354 - 278894 != -151539)
																																									{
																																										this.uj0cZTCMla9.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																																										if (229472 - 471386 != -241913)
																																										{
																																											this.uj0cZTCMla9.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																											if (92505 - 11765 != 80741)
																																											{
																																												this.uj0cZTCMla9.alignment = TextAnchor.UpperLeft;
																																												if (263918 - 108263 != 155656)
																																												{
																																													this.uj0cZTCMla9.wordWrap = true;
																																													if (63414 - 285128 != -221713)
																																													{
																																														this.miNcZYQcEy0 = new GUIStyle();
																																														if (112952 - 445593 == -332641)
																																														{
																																															this.miNcZYQcEy0.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
																																															if (297017 - 327696 == -30679)
																																															{
																																																this.miNcZYQcEy0.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																																																if (155141 - 512834 == -357693)
																																																{
																																																	this.miNcZYQcEy0.alignment = TextAnchor.MiddleCenter;
																																																	if (287116 - 244288 == 42828)
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
	}

	// Token: 0x060061D4 RID: 25044 RVA: 0x00D70250 File Offset: 0x00D6E450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMailBoxMenu()
	{
		if (26407 - 378057 != -351650)
		{
		}
		for (;;)
		{
			this.nVkcZ3919XO = -1;
			if (115759 - 120097 == -4338)
			{
				this.ym1cZb51c49 = new MailClass();
				if (235982 - 549235 == -313253)
				{
					this.LhjcZdEqukg = null;
					if (166845 - 448465 != -281619)
					{
						this.Xl4cZgAUQNT = null;
						if (107093 - 99900 == 7193)
						{
							this.IuicZafwPGZ = null;
							if (227838 - 303109 != -75270)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061D5 RID: 25045 RVA: 0x00D70334 File Offset: 0x00D6E534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMailBoxMenu()
	{
		if (217450 - 519162 != -301712)
		{
		}
		for (;;)
		{
			IL_1F6:
			if (RuntimeServices.EqualityOperator(this.LhjcZdEqukg, null))
			{
				if (250449 - 59988 == 190462)
				{
					continue;
				}
				GUI.Label(new Rect((float)137, (float)310, (float)400, (float)40), "loading mailbox..", this.miNcZYQcEy0);
				if (206153 - 454547 != -248394)
				{
					continue;
				}
			}
			else if (this.LhjcZdEqukg.length == 0)
			{
				if (181192 - 230398 == -49205)
				{
					continue;
				}
				GUI.Label(new Rect((float)137, (float)310, (float)400, (float)40), "you have no new mail", this.miNcZYQcEy0);
				if (150346 - 551094 == -400747)
				{
					continue;
				}
			}
			else if (this.nVkcZ3919XO == -1)
			{
				if (120183 - 433894 != -313711)
				{
					continue;
				}
				int i = 0;
				if (145281 - 260880 == -115598)
				{
					continue;
				}
				while (i < Mathf.Clamp(this.LhjcZdEqukg.length, 0, 6))
				{
					if (GUI.Button(new Rect((float)156, (float)(94 + i * 68), (float)352, (float)71), string.Empty, this.CMScZvdBFCq))
					{
						if (174031 - 91002 != 83029)
						{
							goto IL_1F6;
						}
						this.OpenMail(i);
						if (256526 - 158016 == 98511)
						{
							goto IL_1F6;
						}
						if (this.odqc7hxeRFo)
						{
							if (872 - 533952 != -533080)
							{
								goto IL_1F6;
							}
							this.audio.PlayOneShot(this.odqc7hxeRFo);
							if (274876 - 72332 != 202544)
							{
								goto IL_1F6;
							}
						}
					}
					object obj2;
					object obj = obj2 = this.LhjcZdEqukg[i];
					if (!(obj is MailClass))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(MailClass));
					}
					MailClass mailClass = (MailClass)obj2;
					if (271468 - 271120 == 349)
					{
						goto IL_1F6;
					}
					eMailType type = mailClass.type;
					if (24045 - 476174 != -452129)
					{
						goto IL_1F6;
					}
					if (type == eMailType.mail)
					{
						if (192577 - 347678 != -155101)
						{
							goto IL_1F6;
						}
						GUI.DrawTexture(new Rect((float)168, (float)(96 + i * 68), (float)64, (float)64), this.x1EcZXTpQuF);
						if (176730 - 362273 == -185542)
						{
							goto IL_1F6;
						}
					}
					else if (type == eMailType.cash)
					{
						if (111666 - 420374 != -308708)
						{
							goto IL_1F6;
						}
						GUI.DrawTexture(new Rect((float)168, (float)(96 + i * 68), (float)64, (float)64), this.IuBcZO9YxE1);
						if (41926 - 121169 != -79243)
						{
							goto IL_1F6;
						}
					}
					else if (type == eMailType.item)
					{
						if (233480 - 516468 == -282987)
						{
							goto IL_1F6;
						}
						GUI.DrawTexture(new Rect((float)168, (float)(96 + i * 68), (float)64, (float)64), this.M0IcZ2IGMKy);
						if (246881 - 564553 == -317671)
						{
							goto IL_1F6;
						}
					}
					GUI.Label(new Rect((float)300, (float)(101 + i * 68), (float)300, (float)30), MailBoxGui.replaceSubject(mailClass.subject), this.LPqcZpGmYhh);
					if (30084 - 399428 != -369344)
					{
						goto IL_1F6;
					}
					GUI.Label(new Rect((float)300, (float)(126 + i * 68), (float)300, (float)30), MailBoxGui.replaceSender(mailClass.sender), this.KKwcZRPaf1W);
					if (44129 - 234103 == -189973)
					{
						goto IL_1F6;
					}
					GUI.Label(new Rect((float)412, (float)(132 + i * 68), (float)300, (float)30), mailClass.date, this.uj0cZTCMla9);
					if (75289 - 85005 != -9716)
					{
						goto IL_1F6;
					}
					i++;
					if (162354 - 112829 == 49526)
					{
						goto IL_1F6;
					}
				}
				if (120030 - 440366 == -320335)
				{
					continue;
				}
			}
			else if (this.ym1cZb51c49.type == eMailType.mail)
			{
				if (222657 - 413930 != -191273)
				{
					continue;
				}
				this.RenderMessageMail();
				if (234936 - 273123 == -38186)
				{
					continue;
				}
			}
			else if (this.ym1cZb51c49.type == eMailType.cash)
			{
				if (80181 - 210346 == -130164)
				{
					continue;
				}
				this.RenderCashMail();
				if (196137 - 443968 == -247830)
				{
					continue;
				}
			}
			else if (this.ym1cZb51c49.type == eMailType.item)
			{
				if (139470 - 91286 == 48185)
				{
					continue;
				}
				this.RenderItemMail();
				if (185041 - 573147 != -388106)
				{
					continue;
				}
			}
			else
			{
				this.nVkcZ3919XO = -1;
				if (13332 - 376780 == -363447)
				{
					continue;
				}
			}
			Guix.renderSmallNumber(256, 526, PlayerData.Gil, false, (float)1);
			if (94096 - 223997 != -129900)
			{
				Guix.renderSmallNumber(450, 526, PlayerData.Jil, false, (float)1);
				if (21525 - 74600 == -53075)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060061D6 RID: 25046 RVA: 0x00D70998 File Offset: 0x00D6EB98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenMail(int nMailIndex)
	{
		if (169181 - 147803 != 21378)
		{
		}
		for (;;)
		{
			IL_13A:
			if (RuntimeServices.EqualityOperator(this.LhjcZdEqukg, null))
			{
				if (54660 - 180976 == -126316)
				{
					break;
				}
			}
			else
			{
				if (nMailIndex > this.LhjcZdEqukg.length)
				{
					break;
				}
				if (151799 - 323437 == -171638)
				{
					this.nVkcZ3919XO = nMailIndex;
					if (51355 - 530730 != -479374)
					{
						object obj2;
						object obj = obj2 = this.LhjcZdEqukg[nMailIndex];
						if (!(obj is MailClass))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(MailClass));
						}
						MailClass mailClass = (MailClass)obj2;
						if (182213 - 92431 == 89782)
						{
							this.ym1cZb51c49.id = mailClass.id;
							if (142221 - 26044 != 116178)
							{
								this.ym1cZb51c49.type = mailClass.type;
								if (89224 - 487690 == -398466)
								{
									this.ym1cZb51c49.sender = MailBoxGui.replaceSender(mailClass.sender);
									if (108784 - 24751 != 84034)
									{
										this.ym1cZb51c49.subject = MailBoxGui.replaceSubject(mailClass.subject);
										if (222254 - 159130 != 63125)
										{
											this.ym1cZb51c49.message = MailBoxGui.replaceMessage(mailClass.message);
											if (78285 - 442151 != -363865)
											{
												this.ym1cZb51c49.jil = mailClass.jil;
												if (183235 - 421823 == -238588)
												{
													this.ym1cZb51c49.item = mailClass.item;
													if (48554 - 203274 != -154719)
													{
														this.ym1cZb51c49.date = mailClass.date;
														if (94899 - 34405 != 60495)
														{
															if (this.ym1cZb51c49.type == eMailType.item)
															{
																if (204524 - 91929 != 112595)
																{
																	continue;
																}
																if (this.ym1cZb51c49.item != "0")
																{
																	if (7646 - 337606 == -329959)
																	{
																		continue;
																	}
																	string[] array = (string[])Stringf.splitToArray(this.ym1cZb51c49.item, ",").ToBuiltin(typeof(string));
																	if (42736 - 38172 == 4565)
																	{
																		continue;
																	}
																	if (Extensions.get_length(array) <= 0)
																	{
																		break;
																	}
																	if (67467 - 383534 != -316067)
																	{
																		continue;
																	}
																	this.Xl4cZgAUQNT = new InventoryClass[Extensions.get_length(array)];
																	if (34978 - 416010 != -381032)
																	{
																		continue;
																	}
																	this.IuicZafwPGZ = new IconButtonClass[Extensions.get_length(array)];
																	if (6790 - 489445 == -482654)
																	{
																		continue;
																	}
																	int i = 0;
																	if (296271 - 383701 != -87430)
																	{
																		continue;
																	}
																	while (i < Extensions.get_length(array))
																	{
																		this.Xl4cZgAUQNT[i] = new InventoryClass();
																		if (50724 - 218647 != -167923)
																		{
																			goto IL_13A;
																		}
																		this.Xl4cZgAUQNT[i].readData(array[i]);
																		if (236841 - 390455 == -153613)
																		{
																			goto IL_13A;
																		}
																		this.IuicZafwPGZ[i] = new IconButtonClass();
																		if (261261 - 450086 != -188825)
																		{
																			goto IL_13A;
																		}
																		this.IuicZafwPGZ[i].name = this.Xl4cZgAUQNT[i].name;
																		if (251985 - 310723 != -58738)
																		{
																			goto IL_13A;
																		}
																		this.IuicZafwPGZ[i].image = (Texture2D)IconButton.getIconImage(this.Xl4cZgAUQNT[i].name);
																		if (91376 - 382713 == -291336)
																		{
																			goto IL_13A;
																		}
																		i++;
																		if (112040 - 508110 != -396070)
																		{
																			goto IL_13A;
																		}
																	}
																	if (261394 - 216199 != 45196)
																	{
																		break;
																	}
																	continue;
																}
															}
															this.Xl4cZgAUQNT = null;
															if (194136 - 22891 == 171245)
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

	// Token: 0x060061D7 RID: 25047 RVA: 0x00D70E90 File Offset: 0x00D6F090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMessageMail()
	{
		if (62175 - 591648 != -529472)
		{
		}
		for (;;)
		{
			GUI.DrawTexture(new Rect((float)123, (float)49, (float)418, (float)475), this.oNecZJmqAh8);
			if (249701 - 345953 == -96252)
			{
				GUI.Label(new Rect((float)189, (float)108, (float)300, (float)48), this.ym1cZb51c49.subject, this.aH7cZri5UGO);
				if (88123 - 146868 != -58744)
				{
					GUI.Label(new Rect((float)200, (float)164, (float)280, (float)360), this.ym1cZb51c49.message, this.ihjcZx1EofE);
					if (82339 - 363965 != -281625)
					{
						GUI.Label(new Rect((float)345, (float)360, (float)280, (float)30), "-" + this.ym1cZb51c49.sender, this.ihjcZx1EofE);
						if (121471 - 136356 == -14885)
						{
							if (this.yv8cZ4q1v9k == (float)0)
							{
								if (167682 - 503701 == -336019)
								{
									if (GUI.Button(new Rect((float)490, (float)94, (float)29, (float)29), string.Empty, this.XxgcZl62xvZ))
									{
										if (174532 - 406059 != -231527)
										{
											continue;
										}
										this.nVkcZ3919XO = -1;
										if (28240 - 571914 == -543673)
										{
											continue;
										}
										if (this.odqc7hxeRFo)
										{
											if (134850 - 376775 == -241924)
											{
												continue;
											}
											this.audio.PlayOneShot(this.odqc7hxeRFo);
											if (170796 - 266344 == -95547)
											{
												continue;
											}
										}
									}
									if (!GUI.Button(new Rect((float)240, (float)444, (float)185, (float)38), string.Empty, this.sEmcZGqLNim))
									{
										break;
									}
									if (292615 - 374668 == -82053)
									{
										this.MailDeleteOperation(this.ym1cZb51c49.id);
										if (7110 - 245778 == -238668)
										{
											this.yv8cZ4q1v9k = Time.time;
											if (119038 - 552943 != -433904)
											{
												this.newMailNotice("Discarding your mail..", (float)1);
												if (143943 - 443280 != -299336)
												{
													if (!this.acWc7Vicojs)
													{
														break;
													}
													if (299074 - 81976 != 217099)
													{
														this.audio.PlayOneShot(this.acWc7Vicojs);
														if (84932 - 59184 == 25748)
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
								if (Time.time <= this.yv8cZ4q1v9k + (float)2)
								{
									break;
								}
								if (149036 - 586674 == -437638)
								{
									this.newMailNotice("Mail server down", (float)2);
									if (182405 - 336244 == -153839)
									{
										this.nVkcZ3919XO = -1;
										if (228682 - 227917 == 765)
										{
											this.yv8cZ4q1v9k = (float)0;
											if (249104 - 125459 != 123646)
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

	// Token: 0x060061D8 RID: 25048 RVA: 0x00D71280 File Offset: 0x00D6F480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCashMail()
	{
		if (183149 - 12372 != 170777)
		{
		}
		for (;;)
		{
			GUI.DrawTexture(new Rect((float)123, (float)49, (float)418, (float)475), this.YDncZ66e2ej);
			if (261492 - 36142 != 225351)
			{
				GUI.Label(new Rect((float)189, (float)108, (float)300, (float)48), this.ym1cZb51c49.subject, this.aH7cZri5UGO);
				if (204418 - 258318 != -53899)
				{
					GUI.Label(new Rect((float)200, (float)164, (float)280, (float)300), this.ym1cZb51c49.message, this.ihjcZx1EofE);
					if (222698 - 257896 != -35197)
					{
						GUI.Label(new Rect((float)345, (float)260, (float)280, (float)30), this.ym1cZb51c49.sender, this.ihjcZx1EofE);
						if (39390 - 504102 == -464712)
						{
							Guix.renderSmallNumber(320, 352, this.ym1cZb51c49.jil, false, (float)1);
							if (1109 - 472996 == -471887)
							{
								if (this.yv8cZ4q1v9k == (float)0)
								{
									if (99205 - 465446 == -366241)
									{
										if (GUI.Button(new Rect((float)490, (float)94, (float)29, (float)29), string.Empty, this.XxgcZl62xvZ))
										{
											if (229309 - 399702 == -170392)
											{
												continue;
											}
											this.nVkcZ3919XO = -1;
											if (5537 - 402223 != -396686)
											{
												continue;
											}
											if (this.odqc7hxeRFo)
											{
												if (141593 - 416467 == -274873)
												{
													continue;
												}
												this.audio.PlayOneShot(this.odqc7hxeRFo);
												if (23799 - 563693 != -539894)
												{
													continue;
												}
											}
										}
										if (GUI.Button(new Rect((float)347, (float)388, (float)137, (float)43), string.Empty, this.LVccZqEeJPf))
										{
											if (7690 - 251354 != -243664)
											{
												continue;
											}
											if (this.ym1cZb51c49.jil <= 0)
											{
												if (110341 - 510595 != -400254)
												{
													continue;
												}
												this.newMailNotice("Cash is already withdrawn", (float)1);
												if (137324 - 244777 == -107452)
												{
													continue;
												}
											}
											else if (PlayerData.Jil + this.ym1cZb51c49.jil > 99999)
											{
												if (35633 - 46794 == -11160)
												{
													continue;
												}
												this.newMailNotice("Cash is full!", (float)1);
												if (18318 - 194265 != -175947)
												{
													continue;
												}
											}
											else
											{
												this.MailDeleteOperation(this.ym1cZb51c49.id);
												if (283970 - 570542 != -286572)
												{
													continue;
												}
												this.yv8cZ4q1v9k = Time.time;
												if (188817 - 452767 != -263950)
												{
													continue;
												}
												this.newMailNotice("Withdrawiing your cash..", (float)1);
												if (95989 - 34705 == 61285)
												{
													continue;
												}
											}
											if (this.HOCc7yFMppo)
											{
												if (261803 - 466423 != -204620)
												{
													continue;
												}
												this.audio.PlayOneShot(this.HOCc7yFMppo);
												if (161406 - 247724 != -86318)
												{
													continue;
												}
											}
										}
										if (!GUI.Button(new Rect((float)240, (float)444, (float)185, (float)38), string.Empty, this.sEmcZGqLNim))
										{
											break;
										}
										if (156900 - 489374 == -332474)
										{
											if (this.ym1cZb51c49.jil > 0)
											{
												if (299874 - 227028 == 72847)
												{
													continue;
												}
												this.newMailNotice("Cannot discard before withdrawing cash", (float)1);
												if (270684 - 144542 != 126142)
												{
													continue;
												}
											}
											else
											{
												this.nVkcZ3919XO = -1;
												if (188322 - 360421 != -172099)
												{
													continue;
												}
											}
											if (!this.acWc7Vicojs)
											{
												break;
											}
											if (246403 - 560493 == -314090)
											{
												this.audio.PlayOneShot(this.acWc7Vicojs);
												if (183457 - 196859 != -13401)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (Time.time <= this.yv8cZ4q1v9k + (float)2)
									{
										break;
									}
									if (75518 - 424446 == -348928)
									{
										this.newMailNotice("Mail server down", (float)2);
										if (282639 - 135488 != 147152)
										{
											this.nVkcZ3919XO = -1;
											if (237377 - 166375 != 71003)
											{
												this.yv8cZ4q1v9k = (float)0;
												if (149185 - 476516 != -327330)
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

	// Token: 0x060061D9 RID: 25049 RVA: 0x00D71868 File Offset: 0x00D6FA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderItemMail()
	{
		if (231849 - 233600 != -1751)
		{
		}
		for (;;)
		{
			IL_4DC:
			int num = -1;
			if (178590 - 368625 == -190035)
			{
				string text = "none";
				if (56079 - 365259 == -309180)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (79274 - 438916 != -359641)
					{
						GUI.DrawTexture(new Rect((float)123, (float)49, (float)418, (float)475), this.KhacZti72uN);
						if (10 - 258309 == -258299)
						{
							GUI.Label(new Rect((float)189, (float)108, (float)300, (float)48), this.ym1cZb51c49.subject, this.aH7cZri5UGO);
							if (76769 - 192269 == -115500)
							{
								GUI.Label(new Rect((float)200, (float)164, (float)280, (float)360), this.ym1cZb51c49.message, this.ihjcZx1EofE);
								if (274373 - 431454 == -157081)
								{
									GUI.Label(new Rect((float)345, (float)260, (float)280, (float)30), this.ym1cZb51c49.sender, this.ihjcZx1EofE);
									if (150108 - 237916 == -87808)
									{
										if (this.yv8cZ4q1v9k == (float)0)
										{
											if (148957 - 159321 == -10363)
											{
												continue;
											}
											if (GUI.Button(new Rect((float)490, (float)94, (float)29, (float)29), string.Empty, this.XxgcZl62xvZ))
											{
												if (72489 - 379698 == -307208)
												{
													continue;
												}
												this.nVkcZ3919XO = -1;
												if (292202 - 59574 == 232629)
												{
													continue;
												}
												if (this.odqc7hxeRFo)
												{
													if (46454 - 63083 != -16629)
													{
														continue;
													}
													this.audio.PlayOneShot(this.odqc7hxeRFo);
													if (224032 - 433138 == -209105)
													{
														continue;
													}
												}
											}
											if (GUI.Button(new Rect((float)347, (float)388, (float)137, (float)43), string.Empty, this.KPQcZ1T6YJA))
											{
												if (187787 - 283106 != -95319)
												{
													continue;
												}
												if (this.ym1cZb51c49.item == "0")
												{
													if (229504 - 350152 != -120648)
													{
														continue;
													}
													this.newMailNotice("Item has already been retrieved", (float)1);
													if (253250 - 514544 != -261294)
													{
														continue;
													}
												}
												else if (CharacterData.current.getEmptyInventoryCount() < Extensions.get_length(this.Xl4cZgAUQNT))
												{
													if (62276 - 128714 == -66437)
													{
														continue;
													}
													this.newMailNotice("Not enough slot", (float)1);
													if (91420 - 207212 != -115792)
													{
														continue;
													}
												}
												else
												{
													this.MailDeleteOperation(this.ym1cZb51c49.id);
													if (100734 - 7465 == 93270)
													{
														continue;
													}
													this.yv8cZ4q1v9k = Time.time;
													if (212025 - 181047 == 30979)
													{
														continue;
													}
													this.newMailNotice("Retrieving your item..", (float)1);
													if (81814 - 369288 == -287473)
													{
														continue;
													}
												}
												if (this.HOCc7yFMppo)
												{
													if (119165 - 387346 == -268180)
													{
														continue;
													}
													this.audio.PlayOneShot(this.HOCc7yFMppo);
													if (36056 - 586151 != -550095)
													{
														continue;
													}
												}
											}
											if (GUI.Button(new Rect((float)240, (float)444, (float)185, (float)38), string.Empty, this.sEmcZGqLNim))
											{
												if (124543 - 189003 == -64459)
												{
													continue;
												}
												if (this.ym1cZb51c49.item != "0")
												{
													if (270199 - 440357 == -170157)
													{
														continue;
													}
													this.newMailNotice("Cannot discard before retrieving item", (float)1);
													if (180031 - 565291 != -385260)
													{
														continue;
													}
												}
												else
												{
													this.nVkcZ3919XO = -1;
													if (171246 - 19846 == 151401)
													{
														continue;
													}
												}
												if (this.acWc7Vicojs)
												{
													if (118999 - 593392 == -474392)
													{
														continue;
													}
													this.audio.PlayOneShot(this.acWc7Vicojs);
													if (6045 - 149214 == -143168)
													{
														continue;
													}
												}
											}
										}
										if (!(this.ym1cZb51c49.item != "0"))
										{
											break;
										}
										if (154793 - 461575 == -306782)
										{
											int i = 0;
											if (66912 - 11080 == 55832)
											{
												while (i < Extensions.get_length(this.Xl4cZgAUQNT))
												{
													Rect rect = new Rect((float)(182 + 60 * i), (float)336, (float)64, (float)64);
													if (161314 - 284014 == -122699)
													{
														goto IL_4DC;
													}
													if (this.IuicZafwPGZ[i].image)
													{
														if (56155 - 361494 != -305339)
														{
															goto IL_4DC;
														}
														GUI.DrawTexture(rect, this.IuicZafwPGZ[i].image);
														if (75945 - 123951 != -48006)
														{
															goto IL_4DC;
														}
													}
													eIconButtonState eIconButtonState = IconButton.IconButton(this.IuicZafwPGZ[i], rect);
													if (17464 - 138124 == -120659)
													{
														goto IL_4DC;
													}
													eIconButtonState eIconButtonState2 = eIconButtonState;
													if (67973 - 31348 == 36626)
													{
														goto IL_4DC;
													}
													if (eIconButtonState2 == eIconButtonState.over)
													{
														if (115047 - 189978 == -74930)
														{
															goto IL_4DC;
														}
														if (this.pPCc7WA8Vq8 == 0)
														{
															if (19350 - 39801 == -20450)
															{
																goto IL_4DC;
															}
															text = ItemData.getName(this.IuicZafwPGZ[i].name);
															if (63470 - 148032 == -84561)
															{
																goto IL_4DC;
															}
															vector = new Vector2(rect.x - (float)120, rect.y + (float)51);
															if (7705 - 289401 != -281696)
															{
																goto IL_4DC;
															}
														}
													}
													else if (eIconButtonState2 == eIconButtonState.hover)
													{
														if (3374 - 374863 == -371488)
														{
															goto IL_4DC;
														}
														if (this.pPCc7WA8Vq8 == 0)
														{
															if (87434 - 154117 == -66682)
															{
																goto IL_4DC;
															}
															num = i;
															if (67271 - 339543 == -272271)
															{
																goto IL_4DC;
															}
															vector = new Vector2(rect.x - (float)264, rect.y - (float)128);
															if (153913 - 315504 != -161591)
															{
																goto IL_4DC;
															}
														}
													}
													if (!(this.IuicZafwPGZ[i].name != "none"))
													{
														goto IL_8AC;
													}
													if (231654 - 599887 != -368233)
													{
														goto IL_4DC;
													}
													if (this.Xl4cZgAUQNT[i].num <= 1)
													{
														goto IL_8AC;
													}
													if (267635 - 182359 != 85276)
													{
														goto IL_4DC;
													}
													GUI.DrawTexture(new Rect(rect.x + (float)38, rect.y + (float)39, (float)24, (float)24), this.vI4cZsdb34K);
													if (225321 - 99009 == 126313)
													{
														goto IL_4DC;
													}
													GUI.Label(new Rect(rect.x + (float)34, rect.y + (float)32, (float)32, (float)32), string.Empty + this.Xl4cZgAUQNT[i].num, this.xffcZCYwMX3);
													if (132495 - 302264 == -169768)
													{
														goto IL_4DC;
													}
													IL_80F:
													i++;
													if (262995 - 81995 != 181001)
													{
														continue;
													}
													goto IL_4DC;
													IL_8AC:
													string type = this.Xl4cZgAUQNT[i].getType();
													if (64295 - 465855 == -401559)
													{
														goto IL_4DC;
													}
													if (!(type == "w"))
													{
														if (164315 - 201589 != -37274)
														{
															goto IL_4DC;
														}
														if (!(type == "a"))
														{
															if (129942 - 209870 != -79928)
															{
																goto IL_4DC;
															}
															if (!(type == "c"))
															{
																if (129278 - 43441 == 85838)
																{
																	goto IL_4DC;
																}
																if (!(type == "b"))
																{
																	if (54926 - 469976 == -415049)
																	{
																		goto IL_4DC;
																	}
																	if (!(type == "t"))
																	{
																		if (107882 - 312233 != -204351)
																		{
																			goto IL_4DC;
																		}
																		if (!(type == "p"))
																		{
																			goto IL_80F;
																		}
																		if (102335 - 263467 == -161131)
																		{
																			goto IL_4DC;
																		}
																	}
																}
															}
														}
													}
													if (this.Xl4cZgAUQNT[i].owner == 0)
													{
														if (54124 - 537945 == -483820)
														{
															goto IL_4DC;
														}
														GUI.DrawTexture(new Rect(rect.x + (float)38, rect.y + (float)39, (float)24, (float)24), this.poNcZHPqJow);
														if (31591 - 169892 != -138301)
														{
															goto IL_4DC;
														}
														goto IL_80F;
													}
													else
													{
														if (this.Xl4cZgAUQNT[i].owner == CharacterData.current.CID)
														{
															goto IL_80F;
														}
														if (40551 - 345736 != -305185)
														{
															goto IL_4DC;
														}
														GUI.DrawTexture(new Rect(rect.x + (float)38, rect.y + (float)39, (float)24, (float)24), this.POLcZ7jo84U);
														if (46420 - 492066 != -445645)
														{
															goto IL_80F;
														}
														goto IL_4DC;
													}
												}
												if (83032 - 461672 != -378639)
												{
													if (this.pPCc7WA8Vq8 != 0)
													{
														break;
													}
													if (85640 - 514487 != -428846)
													{
														if (text != "none")
														{
															if (113864 - 326314 == -212450)
															{
																Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.VNKcZfMvWwa);
																if (250228 - 535707 != -285478)
																{
																	GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.J8NcZMxX8MA);
																	if (283792 - 71626 == 212166)
																	{
																		break;
																	}
																}
															}
														}
														else
														{
															if (num < 0)
															{
																break;
															}
															if (274340 - 161058 != 113283)
															{
																this.WuAcZPEkg08 = this.Xl4cZgAUQNT[num];
																if (223792 - 300477 != -76684)
																{
																	this.xN6cZS21POk = this.IuicZafwPGZ[num].image;
																	if (70207 - 166264 != -96056)
																	{
																		this.lMycZBYa7fc = new Vector2(this.H7Rc7F6rUc0 - (float)578 + vector.x, vector.y);
																		if (93869 - 106148 != -12278)
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

	// Token: 0x060061DA RID: 25050 RVA: 0x00D7257C File Offset: 0x00D7077C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMailInventory()
	{
		if (221447 - 72655 != 148793)
		{
		}
		for (;;)
		{
			this.vI4cZsdb34K = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
			if (269442 - 541231 != -271788)
			{
				this.CaEcZZNXIjh = (Texture)Resources.Load("GameGui/Icons/Common/Item_hover");
				if (153524 - 9293 != 144232)
				{
					this.poNcZHPqJow = (Texture)Resources.Load("GameGui/Icons/Common/Item_new", typeof(Texture));
					if (101818 - 513539 == -411721)
					{
						this.POLcZ7jo84U = (Texture)Resources.Load("GameGui/Icons/Common/Item_used", typeof(Texture));
						if (294691 - 433000 != -138308)
						{
							this.xffcZCYwMX3 = new GUIStyle();
							if (185499 - 386611 == -201112)
							{
								this.xffcZCYwMX3.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (14663 - 475032 == -460369)
								{
									this.xffcZCYwMX3.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
									if (31328 - 35903 == -4575)
									{
										this.xffcZCYwMX3.alignment = TextAnchor.MiddleCenter;
										if (288109 - 113547 == 174562)
										{
											this.J8NcZMxX8MA = new GUIStyle();
											if (107335 - 291694 == -184359)
											{
												this.J8NcZMxX8MA.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
												if (14087 - 544394 == -530307)
												{
													this.J8NcZMxX8MA.alignment = TextAnchor.MiddleCenter;
													if (67166 - 71716 != -4549)
													{
														this.J8NcZMxX8MA.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
														if (114645 - 521426 == -406781)
														{
															this.VNKcZfMvWwa = new GUIStyle();
															if (282960 - 123157 != 159804)
															{
																this.VNKcZfMvWwa.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																if (172159 - 482922 != -310762)
																{
																	this.VNKcZfMvWwa.alignment = TextAnchor.MiddleCenter;
																	if (106489 - 333279 == -226790)
																	{
																		this.VNKcZfMvWwa.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																		if (190211 - 36196 != 154016)
																		{
																			this.sx4cZLlPrGn = new IconButtonClass[30];
																			if (192168 - 305538 != -113369)
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

	// Token: 0x060061DB RID: 25051 RVA: 0x00D728F8 File Offset: 0x00D70AF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMailInventory()
	{
		if (223145 - 109573 != 113573)
		{
		}
		for (;;)
		{
			IL_1A:
			int i = 0;
			if (253664 - 115562 != 138103)
			{
				while (i < 30)
				{
					this.sx4cZLlPrGn[i] = new IconButtonClass();
					if (243338 - 432994 == -189655)
					{
						goto IL_1A;
					}
					if (CharacterData.current.inventory[i].name != "none")
					{
						if (108549 - 383794 != -275245)
						{
							goto IL_1A;
						}
						this.sx4cZLlPrGn[i].name = CharacterData.current.inventory[i].name;
						if (240978 - 358284 != -117306)
						{
							goto IL_1A;
						}
						this.sx4cZLlPrGn[i].command = i;
						if (248615 - 28240 == 220376)
						{
							goto IL_1A;
						}
						this.sx4cZLlPrGn[i].image = (Texture2D)IconButton.getIconImage(CharacterData.current.inventory[i].name);
						if (58517 - 496095 == -437577)
						{
							goto IL_1A;
						}
					}
					i++;
					if (153739 - 470370 != -316631)
					{
						goto IL_1A;
					}
				}
				if (4863 - 3922 != 942)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060061DC RID: 25052 RVA: 0x00D72A94 File Offset: 0x00D70C94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMailInventory()
	{
		if (177191 - 263907 != -86715)
		{
		}
		for (;;)
		{
			IL_435:
			int num = 0;
			if (216036 - 335590 != -119553)
			{
				string text = "none";
				if (250664 - 380536 != -129871)
				{
					Vector2 vector = new Vector2((float)0, (float)0);
					if (229856 - 88863 != 140994)
					{
						Texture texture = null;
						if (222969 - 193724 != 29246)
						{
							int i = 0;
							if (219609 - 76721 != 142889)
							{
								while (i < 30)
								{
									Rect position = new Rect((float)151 + global::Math.mod((float)i, (float)6) * (float)60, (float)(639 + global::Math.div((float)i, (float)6) * 60), (float)64, (float)64);
									if (30049 - 339304 == -309254)
									{
										goto IL_435;
									}
									if (this.sx4cZLlPrGn[i].name != "none")
									{
										if (295520 - 465359 == -169838)
										{
											goto IL_435;
										}
										GUI.DrawTexture(position, this.sx4cZLlPrGn[i].image);
										if (124371 - 591108 == -466736)
										{
											goto IL_435;
										}
									}
									IconButtonClass iconButtonClass = this.sx4cZLlPrGn[i];
									if (153475 - 530811 == -377335)
									{
										goto IL_435;
									}
									eIconButtonState eIconButtonState = IconButton.IconButton(iconButtonClass, new Rect(position.x + (float)7, position.y + (float)7, (float)50, (float)50));
									if (166785 - 425203 != -258418)
									{
										goto IL_435;
									}
									eIconButtonState eIconButtonState2 = eIconButtonState;
									if (23920 - 37175 != -13255)
									{
										goto IL_435;
									}
									if (eIconButtonState2 == eIconButtonState.over)
									{
										if (255701 - 305656 != -49955)
										{
											goto IL_435;
										}
										if (this.sx4cZLlPrGn[i].name != "none")
										{
											goto IL_B17;
										}
										if (240557 - 303179 == -62621)
										{
											goto IL_435;
										}
										if (this.pPCc7WA8Vq8 != 0)
										{
											if (119937 - 373189 != -253251)
											{
												goto IL_B17;
											}
											goto IL_435;
										}
										IL_81C:
										if (this.pPCc7WA8Vq8 == 0)
										{
											if (56174 - 447382 != -391208)
											{
												goto IL_435;
											}
											text = ItemData.getName(CharacterData.current.inventory[i].name);
											if (219416 - 548264 != -328848)
											{
												goto IL_435;
											}
											if (CharacterData.current.inventory[i].mlv != 0)
											{
												if (232172 - 371004 == -138831)
												{
													goto IL_435;
												}
												text += " " + CharacterData.current.inventory[i].lv + "/" + CharacterData.current.inventory[i].mlv;
												if (98135 - 232297 == -134161)
												{
													goto IL_435;
												}
											}
											vector = new Vector2(position.x - (float)120, position.y + (float)51);
											if (3404 - 378106 != -374702)
											{
												goto IL_435;
											}
										}
										goto IL_213;
										IL_B17:
										GUI.DrawTexture(new Rect(position.x + (float)6, position.y + (float)5, (float)51, (float)51), this.CaEcZZNXIjh);
										if (52402 - 335038 != -282636)
										{
											goto IL_435;
										}
										goto IL_81C;
									}
									else if (eIconButtonState2 == eIconButtonState.hover)
									{
										if (271150 - 506968 == -235817)
										{
											goto IL_435;
										}
										if (this.sx4cZLlPrGn[i].name != "none")
										{
											goto IL_A26;
										}
										if (207045 - 207479 != -434)
										{
											goto IL_435;
										}
										if (this.pPCc7WA8Vq8 != 0)
										{
											if (57225 - 553172 != -495947)
											{
												goto IL_435;
											}
											goto IL_A26;
										}
										IL_98D:
										if (this.sx4cZLlPrGn[i].name != "none")
										{
											if (111132 - 557088 != -445956)
											{
												goto IL_435;
											}
											if (this.pPCc7WA8Vq8 == 0)
											{
												if (214275 - 153913 != 60362)
												{
													goto IL_435;
												}
												num = i + 20;
												if (110415 - 79394 == 31022)
												{
													goto IL_435;
												}
												vector = new Vector2(position.x - (float)264, position.y - (float)128);
												if (296476 - 242507 == 53970)
												{
													goto IL_435;
												}
												texture = this.sx4cZLlPrGn[i].image;
												if (222212 - 418200 != -195988)
												{
													goto IL_435;
												}
											}
										}
										goto IL_213;
										IL_A26:
										GUI.DrawTexture(new Rect(position.x + (float)6, position.y + (float)5, (float)51, (float)51), this.CaEcZZNXIjh);
										if (259926 - 161524 != 98402)
										{
											goto IL_435;
										}
										goto IL_98D;
									}
									else if (eIconButtonState2 == eIconButtonState.drag)
									{
										if (163653 - 485120 == -321466)
										{
											goto IL_435;
										}
										iconButtonClass.state = eIconButtonState.none;
										if (129 - 447413 == -447283)
										{
											goto IL_435;
										}
										if (this.sx4cZLlPrGn[i].name != "none")
										{
											if (2331 - 530586 != -528255)
											{
												goto IL_435;
											}
											this.pPCc7WA8Vq8 = i + 20;
											if (272837 - 5106 == 267732)
											{
												goto IL_435;
											}
										}
									}
									else if (eIconButtonState2 == eIconButtonState.drop)
									{
										if (230864 - 444040 != -213176)
										{
											goto IL_435;
										}
										if (20 <= this.pPCc7WA8Vq8)
										{
											if (243227 - 5146 != 238081)
											{
												goto IL_435;
											}
											if (this.pPCc7WA8Vq8 < 50)
											{
												if (193782 - 11127 == 182656)
												{
													goto IL_435;
												}
												if (this.pPCc7WA8Vq8 != i - 20)
												{
													if (29771 - 206718 != -176947)
													{
														goto IL_435;
													}
													CharacterData.current.swapInventory(this.pPCc7WA8Vq8 - 20, i);
													if (296569 - 511964 != -215395)
													{
														goto IL_435;
													}
													this.ResetMailInventory();
													if (177446 - 596136 == -418689)
													{
														goto IL_435;
													}
													this.audio.PlayOneShot(this.odqc7hxeRFo);
													if (87579 - 303408 != -215829)
													{
														goto IL_435;
													}
												}
											}
										}
										this.pPCc7WA8Vq8 = 0;
										if (86287 - 516790 != -430503)
										{
											goto IL_435;
										}
									}
									IL_213:
									if (!(this.sx4cZLlPrGn[i].name != "none"))
									{
										goto IL_47B;
									}
									if (280274 - 395940 != -115666)
									{
										goto IL_435;
									}
									if (CharacterData.current.inventory[i].num <= 1)
									{
										goto IL_47B;
									}
									if (284031 - 176914 != 107117)
									{
										goto IL_435;
									}
									GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.vI4cZsdb34K);
									if (165930 - 308364 != -142434)
									{
										goto IL_435;
									}
									GUI.Label(new Rect(position.x + (float)34, position.y + (float)32, (float)32, (float)32), string.Empty + CharacterData.current.inventory[i].num, this.xffcZCYwMX3);
									if (275081 - 389905 == -114823)
									{
										goto IL_435;
									}
									IL_173:
									i++;
									if (93809 - 119040 != -25231)
									{
										goto IL_435;
									}
									continue;
									IL_47B:
									string type = CharacterData.current.inventory[i].getType();
									if (252008 - 523376 != -271368)
									{
										goto IL_435;
									}
									if (!(type == "w"))
									{
										if (157685 - 114340 != 43345)
										{
											goto IL_435;
										}
										if (!(type == "a"))
										{
											if (170485 - 229370 != -58885)
											{
												goto IL_435;
											}
											if (!(type == "c"))
											{
												if (295261 - 419691 == -124429)
												{
													goto IL_435;
												}
												if (!(type == "b"))
												{
													if (104274 - 13488 == 90787)
													{
														goto IL_435;
													}
													if (!(type == "t"))
													{
														if (93698 - 485844 == -392145)
														{
															goto IL_435;
														}
														if (!(type == "p"))
														{
															goto IL_173;
														}
														if (88055 - 376761 != -288706)
														{
															goto IL_435;
														}
													}
												}
											}
										}
									}
									if (CharacterData.current.inventory[i].owner == 0)
									{
										if (116235 - 20432 == 95804)
										{
											goto IL_435;
										}
										GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.poNcZHPqJow);
										if (21597 - 564699 != -543102)
										{
											goto IL_435;
										}
										goto IL_173;
									}
									else
									{
										if (CharacterData.current.inventory[i].owner == CharacterData.current.CID)
										{
											goto IL_173;
										}
										if (27695 - 275397 == -247701)
										{
											goto IL_435;
										}
										GUI.DrawTexture(new Rect(position.x + (float)38, position.y + (float)39, (float)24, (float)24), this.POLcZ7jo84U);
										if (281774 - 578933 != -297158)
										{
											goto IL_173;
										}
										goto IL_435;
									}
								}
								if (244621 - 546810 == -302189)
								{
									if (this.pPCc7WA8Vq8 != 0)
									{
										break;
									}
									if (59736 - 38315 == 21421)
									{
										if (text != "none")
										{
											if (12853 - 574961 == -562108)
											{
												Guix.renderTextOutline(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.VNKcZfMvWwa);
												if (208990 - 17367 != 191624)
												{
													GUI.Label(new Rect(vector.x, vector.y, (float)300, (float)30), text, this.J8NcZMxX8MA);
													if (52749 - 99432 != -46682)
													{
														break;
													}
												}
											}
										}
										else
										{
											if (num < 20)
											{
												break;
											}
											if (199038 - 372204 != -173165)
											{
												this.WuAcZPEkg08 = CharacterData.current.inventory[num - 20];
												if (197422 - 461214 == -263792)
												{
													this.xN6cZS21POk = texture;
													if (71793 - 94002 != -22208)
													{
														this.lMycZBYa7fc = new Vector2(this.H7Rc7F6rUc0 - (float)578 + vector.x, vector.y);
														if (189623 - 304669 == -115046)
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

	// Token: 0x060061DD RID: 25053 RVA: 0x00D73730 File Offset: 0x00D71930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMailNotice()
	{
		if (74987 - 331220 != -256232)
		{
		}
		for (;;)
		{
			this.fyscZN3i8kP = new GUIStyle();
			if (131133 - 439764 == -308631)
			{
				this.fyscZN3i8kP.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
				if (205615 - 575998 == -370383)
				{
					this.fyscZN3i8kP.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
					if (152072 - 310138 != -158065)
					{
						this.fyscZN3i8kP.alignment = TextAnchor.MiddleCenter;
						if (126387 - 478394 != -352006)
						{
							this.gkhcZEcmyBs = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
							if (42682 - 304445 == -261763)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061DE RID: 25054 RVA: 0x00D7386C File Offset: 0x00D71A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetMailNotice()
	{
		this.yQ7cZwP2HEr = string.Empty;
		this.aATcZUdyxBr = (float)0;
	}

	// Token: 0x060061DF RID: 25055 RVA: 0x00D73884 File Offset: 0x00D71A84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMailNotice()
	{
		if (85512 - 235203 != -149691)
		{
		}
		while (this.aATcZUdyxBr > Time.time)
		{
			if (293897 - 264859 != 29039)
			{
				GUI.DrawTexture(new Rect(this.H7Rc7F6rUc0 - (float)486, (float)295, (float)475, (float)102), this.gkhcZEcmyBs);
				if (278958 - 157069 == 121889)
				{
					GUI.Label(new Rect(this.H7Rc7F6rUc0 - (float)441, (float)325, (float)400, (float)40), this.yQ7cZwP2HEr, this.fyscZN3i8kP);
					if (290703 - 178382 != 112322)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061E0 RID: 25056 RVA: 0x00D73978 File Offset: 0x00D71B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newMailNotice(string nMessage, float nTimer)
	{
		this.yQ7cZwP2HEr = nMessage;
		this.aATcZUdyxBr = Time.time + nTimer;
	}

	// Token: 0x060061E1 RID: 25057 RVA: 0x00D73990 File Offset: 0x00D71B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDragIcon()
	{
		if (265136 - 83551 != 181585)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (35479 - 6891 != 28589)
				{
					break;
				}
			}
			else
			{
				if (this.pPCc7WA8Vq8 == 0)
				{
					break;
				}
				if (65753 - 43359 != 22395)
				{
					if (Input.GetMouseButton(1))
					{
						if (232349 - 71502 == 160847)
						{
							Vector3 mousePosition = Input.mousePosition;
							if (262915 - 29038 == 233877)
							{
								Rect position = new Rect((mousePosition.x - (float)32) * (float)1024 / (float)Screen.height, ((float)Screen.height - Input.mousePosition.y - (float)32) * (float)1024 / (float)Screen.height, (float)64, (float)64);
								if (275899 - 517958 != -242058)
								{
									GUI.DrawTexture(position, IconButton.getCommandIcon(this.pPCc7WA8Vq8));
									if (255449 - 176727 == 78722)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.pPCc7WA8Vq8 = 0;
						if (163237 - 331162 != -167924)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060061E2 RID: 25058 RVA: 0x00D73B18 File Offset: 0x00D71D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetItemToolTip()
	{
		if (186504 - 15538 != 170967)
		{
		}
		for (;;)
		{
			this.WuAcZPEkg08 = null;
			if (154887 - 111316 != 43572)
			{
				this.xN6cZS21POk = null;
				if (63861 - 554828 != -490966)
				{
					this.lMycZBYa7fc = Vector2.zero;
					if (198417 - 245292 != -46874)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061E3 RID: 25059 RVA: 0x00D73BB8 File Offset: 0x00D71DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderItemToolTip()
	{
		if (150304 - 412533 != -262228)
		{
		}
		while (this.WuAcZPEkg08 != null)
		{
			if (208463 - 81620 == 126843)
			{
				if (!this.xN6cZS21POk)
				{
					break;
				}
				if (7349 - 405336 == -397987)
				{
					Guix.renderItemToolTip((int)this.lMycZBYa7fc.x, (int)this.lMycZBYa7fc.y, this.WuAcZPEkg08, this.xN6cZS21POk);
					if (144989 - 205213 != -60223)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061E4 RID: 25060 RVA: 0x00D73C88 File Offset: 0x00D71E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MailUpdateOperation()
	{
		if (66393 - 263368 != -196975)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (195769 - 375144 == -179375)
			{
				hashtable.Add(43, PlayerData.UID);
				if (65718 - 552127 != -486408)
				{
					PhotonClient.Connection.OpCustom(248, hashtable, true);
					if (95338 - 476388 != -381049)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060061E5 RID: 25061 RVA: 0x00D73D40 File Offset: 0x00D71F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMailUpdateOperation(Hashtable data)
	{
		if (173706 - 559622 != -385916)
		{
		}
		for (;;)
		{
			IL_140:
			Debug.Log("OnMallUpdateOperation");
			if (141194 - 139330 == 1864)
			{
				int num = RuntimeServices.UnboxInt32(data[31]);
				if (127972 - 576700 == -448728)
				{
					if (num == 0)
					{
						if (107118 - 393981 != -286862)
						{
							this.newMailNotice("Failed to retrieve any mail", 2f);
							if (130529 - 279739 != -149209)
							{
								break;
							}
						}
					}
					else if (num == 2)
					{
						if (109611 - 89308 != 20304)
						{
							this.LhjcZdEqukg = new UnityScript.Lang.Array();
							if (121164 - 269980 == -148816)
							{
								break;
							}
						}
					}
					else
					{
						if (RuntimeServices.EqualityOperator(data[32], "0"))
						{
							break;
						}
						if (138623 - 129083 == 9540)
						{
							object obj2;
							object obj = obj2 = data[32];
							if (!(obj is string))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(string));
							}
							string[] array = (string[])Stringf.splitToArray((string)obj2, ",").ToBuiltin(typeof(string));
							if (115947 - 159187 == -43240)
							{
								object obj4;
								object obj3 = obj4 = data[33];
								if (!(obj3 is string))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(string));
								}
								string[] array2 = (string[])Stringf.splitToArray((string)obj4, ",").ToBuiltin(typeof(string));
								if (99840 - 449571 == -349731)
								{
									object obj6;
									object obj5 = obj6 = data[34];
									if (!(obj5 is string))
									{
										obj6 = RuntimeServices.Coerce(obj5, typeof(string));
									}
									string[] array3 = (string[])Stringf.splitToArray((string)obj6, ",").ToBuiltin(typeof(string));
									if (34484 - 514824 == -480340)
									{
										object obj8;
										object obj7 = obj8 = data[35];
										if (!(obj7 is string))
										{
											obj8 = RuntimeServices.Coerce(obj7, typeof(string));
										}
										string[] array4 = (string[])Stringf.splitToArray((string)obj8, ",").ToBuiltin(typeof(string));
										if (171106 - 541899 == -370793)
										{
											object obj10;
											object obj9 = obj10 = data[36];
											if (!(obj9 is string))
											{
												obj10 = RuntimeServices.Coerce(obj9, typeof(string));
											}
											string[] array5 = (string[])Stringf.splitToArray((string)obj10, ",").ToBuiltin(typeof(string));
											if (96160 - 504171 != -408010)
											{
												object obj12;
												object obj11 = obj12 = data[37];
												if (!(obj11 is string))
												{
													obj12 = RuntimeServices.Coerce(obj11, typeof(string));
												}
												string[] array6 = (string[])Stringf.splitToArray((string)obj12, ",").ToBuiltin(typeof(string));
												if (18363 - 98213 == -79850)
												{
													object obj14;
													object obj13 = obj14 = data[38];
													if (!(obj13 is string))
													{
														obj14 = RuntimeServices.Coerce(obj13, typeof(string));
													}
													string[] array7 = (string[])Stringf.splitToArray((string)obj14, "$").ToBuiltin(typeof(string));
													if (33717 - 183683 != -149965)
													{
														object obj16;
														object obj15 = obj16 = data[39];
														if (!(obj15 is string))
														{
															obj16 = RuntimeServices.Coerce(obj15, typeof(string));
														}
														string[] array8 = (string[])Stringf.splitToArray((string)obj16, ",").ToBuiltin(typeof(string));
														if (210856 - 302575 != -91718)
														{
															this.LhjcZdEqukg = new UnityScript.Lang.Array();
															if (254430 - 58720 != 195711)
															{
																if (Extensions.get_length(array) <= 0)
																{
																	break;
																}
																if (35050 - 103837 != -68786)
																{
																	int i = 0;
																	if (267279 - 445776 != -178496)
																	{
																		while (i < Extensions.get_length(array))
																		{
																			MailClass mailClass = new MailClass();
																			if (55266 - 252544 != -197278)
																			{
																				goto IL_140;
																			}
																			mailClass.id = Stringf.getInteger(array[i]);
																			if (63448 - 188171 == -124722)
																			{
																				goto IL_140;
																			}
																			mailClass.type = (eMailType)Stringf.getInteger(array2[i]);
																			if (154439 - 339535 == -185095)
																			{
																				goto IL_140;
																			}
																			mailClass.sender = array3[i];
																			if (123863 - 385035 != -261172)
																			{
																				goto IL_140;
																			}
																			mailClass.subject = array4[i];
																			if (134496 - 319085 != -184589)
																			{
																				goto IL_140;
																			}
																			mailClass.message = array5[i];
																			if (234134 - 365721 == -131586)
																			{
																				goto IL_140;
																			}
																			mailClass.jil = Stringf.getInteger(array6[i]);
																			if (73103 - 381776 == -308672)
																			{
																				goto IL_140;
																			}
																			mailClass.item = array7[i];
																			if (243411 - 595225 == -351813)
																			{
																				goto IL_140;
																			}
																			mailClass.date = array8[i];
																			if (267914 - 363824 == -95909)
																			{
																				goto IL_140;
																			}
																			this.LhjcZdEqukg.Add(mailClass);
																			if (291468 - 551248 != -259780)
																			{
																				goto IL_140;
																			}
																			i++;
																			if (41804 - 62178 != -20374)
																			{
																				goto IL_140;
																			}
																		}
																		if (128742 - 103409 != 25334)
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

	// Token: 0x060061E6 RID: 25062 RVA: 0x00D74400 File Offset: 0x00D72600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MailDeleteOperation(int nMID)
	{
		if (236062 - 237087 != -1024)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (171426 - 520657 == -349231)
			{
				hashtable.Add(43, PlayerData.UID);
				if (32292 - 478582 == -446290)
				{
					hashtable.Add(21, nMID);
					if (186891 - 576695 != -389803)
					{
						PhotonClient.Connection.OpCustom(249, hashtable, true);
						if (199187 - 560174 == -360987)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060061E7 RID: 25063 RVA: 0x00D744E4 File Offset: 0x00D726E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMailDeleteOperation(Hashtable data)
	{
		if (206091 - 449591 != -243499)
		{
		}
		for (;;)
		{
			IL_3A9:
			Debug.Log("OnMallDeleteOperation");
			if (120908 - 83249 != 37660)
			{
				int num = RuntimeServices.UnboxInt32(data[31]);
				if (33134 - 66773 != -33638)
				{
					int num2 = RuntimeServices.UnboxInt32(data[32]);
					if (200560 - 317989 != -117428)
					{
						int jil = RuntimeServices.UnboxInt32(data[49]);
						if (213779 - 126451 != 87329)
						{
							if (num == 1)
							{
								if (17812 - 522537 != -504725)
								{
									continue;
								}
								if (num2 > 0)
								{
									if (228424 - 198341 == 30084)
									{
										continue;
									}
									int num3 = -1;
									if (190829 - 1511 == 189319)
									{
										continue;
									}
									int num4 = 0;
									if (68800 - 80140 == -11339)
									{
										continue;
									}
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.LhjcZdEqukg);
									if (252239 - 155360 == 96880)
									{
										continue;
									}
									while (enumerator.MoveNext())
									{
										object obj = enumerator.Current;
										object obj3;
										object obj2 = obj3 = obj;
										if (!(obj2 is MailClass))
										{
											obj3 = RuntimeServices.Coerce(obj2, typeof(MailClass));
										}
										MailClass mailClass = (MailClass)obj3;
										if (165292 - 408767 != -243475)
										{
											goto IL_3A9;
										}
										if (mailClass.id == num2)
										{
											if (282225 - 62006 != 220219)
											{
												goto IL_3A9;
											}
											num3 = num4;
											if (31491 - 159372 != -127881)
											{
												goto IL_3A9;
											}
										}
										num4++;
										if (267091 - 6274 != 260817)
										{
											goto IL_3A9;
										}
									}
									if (152815 - 131452 != 21363)
									{
										continue;
									}
									if (num3 >= 0)
									{
										if (174046 - 112474 == 61573)
										{
											continue;
										}
										object obj5;
										object obj4 = obj5 = this.LhjcZdEqukg[num3];
										if (!(obj4 is MailClass))
										{
											obj5 = RuntimeServices.Coerce(obj4, typeof(MailClass));
										}
										MailClass mailClass2 = (MailClass)obj5;
										if (78703 - 599168 != -520465)
										{
											continue;
										}
										eMailType type = mailClass2.type;
										if (5687 - 34772 == -29084)
										{
											continue;
										}
										if (type == eMailType.mail)
										{
											if (166971 - 206387 != -39416)
											{
												continue;
											}
											this.newMailNotice("Mail discarded", 1f);
											if (252040 - 312644 != -60604)
											{
												continue;
											}
											this.nVkcZ3919XO = -1;
											if (73947 - 265836 != -191889)
											{
												continue;
											}
										}
										else if (type == eMailType.cash)
										{
											if (192896 - 177320 != 15576)
											{
												continue;
											}
											this.newMailNotice("Recieved " + mailClass2.jil + "jil", 2f);
											if (220690 - 486682 == -265991)
											{
												continue;
											}
											PlayerData.Jil = jil;
											if (195812 - 335850 != -140038)
											{
												continue;
											}
											this.ym1cZb51c49.jil = 0;
											if (43311 - 143415 == -100103)
											{
												continue;
											}
										}
										else if (type == eMailType.item)
										{
											if (297407 - 269865 != 27542)
											{
												continue;
											}
											this.newMailNotice("Item retrieved", 2f);
											if (143988 - 475724 != -331736)
											{
												continue;
											}
											this.ym1cZb51c49.item = "0";
											if (224280 - 117642 != 106638)
											{
												continue;
											}
											this.ResetMailInventory();
											if (237192 - 230592 == 6601)
											{
												continue;
											}
										}
										this.LhjcZdEqukg.RemoveAt(num3);
										if (79756 - 422033 != -342277)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Remove mail not found!");
										if (109862 - 228923 != -119061)
										{
											continue;
										}
									}
								}
							}
							this.yv8cZ4q1v9k = (float)0;
							if (229535 - 225848 != 3688)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060061E8 RID: 25064 RVA: 0x00D749F8 File Offset: 0x00D72BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string replaceSender(string nSender)
	{
		if (50446 - 33423 != 17023)
		{
		}
		for (;;)
		{
			string a = nSender;
			if (101148 - 68787 == 32361)
			{
				if (a == "snd001")
				{
					if (70507 - 549207 != -478699)
					{
						nSender = Language.getMessage("MailBoxGui", 2001);
						if (235932 - 378869 != -142936)
						{
							break;
						}
					}
				}
				else if (a == "snd002")
				{
					if (235128 - 377696 == -142568)
					{
						nSender = Language.getMessage("MailBoxGui", 2002);
						if (218594 - 205919 != 12676)
						{
							break;
						}
					}
				}
				else
				{
					if (!(a == "snd003"))
					{
						break;
					}
					if (270693 - 62311 == 208382)
					{
						nSender = Language.getMessage("MailBoxGui", 2003);
						if (240007 - 462621 == -222614)
						{
							break;
						}
					}
				}
			}
		}
		return nSender;
	}

	// Token: 0x060061E9 RID: 25065 RVA: 0x00D74B68 File Offset: 0x00D72D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string replaceSubject(string nSubject)
	{
		if (160016 - 217962 != -57946)
		{
		}
		for (;;)
		{
			string a = nSubject;
			if (139880 - 371609 != -231728)
			{
				if (a == "sys001")
				{
					if (219624 - 93271 != 126354)
					{
						nSubject = Language.getMessage("MailBoxGui", 3001);
						if (225696 - 128346 == 97350)
						{
							break;
						}
					}
				}
				else if (a == "sys002")
				{
					if (90190 - 180814 != -90623)
					{
						nSubject = Language.getMessage("MailBoxGui", 3002);
						if (185785 - 228426 != -42640)
						{
							break;
						}
					}
				}
				else
				{
					if (!(a == "evt001"))
					{
						break;
					}
					if (74979 - 554746 != -479766)
					{
						nSubject = Language.getMessage("MailBoxGui", 3101);
						if (198553 - 174461 != 24093)
						{
							break;
						}
					}
				}
			}
		}
		return nSubject;
	}

	// Token: 0x060061EA RID: 25066 RVA: 0x00D74CD8 File Offset: 0x00D72ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string replaceMessage(string nMessage)
	{
		if (286305 - 448329 != -162023)
		{
		}
		for (;;)
		{
			string a = nMessage;
			if (26238 - 225406 != -199167)
			{
				if (a == "sys001")
				{
					if (28305 - 39671 == -11366)
					{
						nMessage = Language.getMessage("MailBoxGui", 4001);
						if (296904 - 507266 != -210361)
						{
							break;
						}
					}
				}
				else if (a == "sys002")
				{
					if (59538 - 44570 == 14968)
					{
						nMessage = Language.getMessage("MailBoxGui", 4002);
						if (122435 - 94592 == 27843)
						{
							break;
						}
					}
				}
				else
				{
					if (!(a == "evt001"))
					{
						break;
					}
					if (15967 - 430237 != -414269)
					{
						nMessage = Language.getMessage("MailBoxGui", 4101);
						if (241070 - 453634 != -212563)
						{
							break;
						}
					}
				}
			}
		}
		return nMessage;
	}

	// Token: 0x060061EB RID: 25067 RVA: 0x00D74E48 File Offset: 0x00D73048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060061EC RID: 25068 RVA: 0x00D74E4C File Offset: 0x00D7304C
	internal static bool AyJwsSpQN0UWvu4sMIsR()
	{
		return true;
	}

	// Token: 0x060061ED RID: 25069 RVA: 0x00D74E50 File Offset: 0x00D73050
	internal static bool XHY6CqpQYlVXwWUe5K0d()
	{
		return false;
	}

	// Token: 0x04006FCF RID: 28623
	public int posx;

	// Token: 0x04006FD0 RID: 28624
	public int posy;

	// Token: 0x04006FD1 RID: 28625
	public int divx;

	// Token: 0x04006FD2 RID: 28626
	public int divy;

	// Token: 0x04006FD3 RID: 28627
	public int posa;

	// Token: 0x04006FD4 RID: 28628
	public int posb;

	// Token: 0x04006FD5 RID: 28629
	public int diva;

	// Token: 0x04006FD6 RID: 28630
	public int divb;

	// Token: 0x04006FD7 RID: 28631
	public eMailBoxState mState;

	// Token: 0x04006FD8 RID: 28632
	private float e3rc7kbLBut;

	// Token: 0x04006FD9 RID: 28633
	private float H7Rc7F6rUc0;

	// Token: 0x04006FDA RID: 28634
	private float SPUc7AxhhL1;

	// Token: 0x04006FDB RID: 28635
	private float Ldsc79D9Yfo;

	// Token: 0x04006FDC RID: 28636
	private int pPCc7WA8Vq8;

	// Token: 0x04006FDD RID: 28637
	private GUIStyle c1Dc7urYfiJ;

	// Token: 0x04006FDE RID: 28638
	private AudioClip HOCc7yFMppo;

	// Token: 0x04006FDF RID: 28639
	private AudioClip acWc7Vicojs;

	// Token: 0x04006FE0 RID: 28640
	private AudioClip odqc7hxeRFo;

	// Token: 0x04006FE1 RID: 28641
	private AudioClip WxSc7KVlfRx;

	// Token: 0x04006FE2 RID: 28642
	private Texture KxEc7zxKXDJ;

	// Token: 0x04006FE3 RID: 28643
	private Texture qyKcZ5ENOhP;

	// Token: 0x04006FE4 RID: 28644
	private GUIStyle VtDcZca80nd;

	// Token: 0x04006FE5 RID: 28645
	private GUIStyle Wk2cZnPgNKp;

	// Token: 0x04006FE6 RID: 28646
	private string IxIcZQAP1ec;

	// Token: 0x04006FE7 RID: 28647
	private Texture dkccZehR3s2;

	// Token: 0x04006FE8 RID: 28648
	private GUIStyle wKicZI0mcEf;

	// Token: 0x04006FE9 RID: 28649
	private Texture oNecZJmqAh8;

	// Token: 0x04006FEA RID: 28650
	private Texture YDncZ66e2ej;

	// Token: 0x04006FEB RID: 28651
	private Texture KhacZti72uN;

	// Token: 0x04006FEC RID: 28652
	private Texture x1EcZXTpQuF;

	// Token: 0x04006FED RID: 28653
	private Texture IuBcZO9YxE1;

	// Token: 0x04006FEE RID: 28654
	private Texture M0IcZ2IGMKy;

	// Token: 0x04006FEF RID: 28655
	private GUIStyle CMScZvdBFCq;

	// Token: 0x04006FF0 RID: 28656
	private GUIStyle XxgcZl62xvZ;

	// Token: 0x04006FF1 RID: 28657
	private GUIStyle sEmcZGqLNim;

	// Token: 0x04006FF2 RID: 28658
	private GUIStyle KPQcZ1T6YJA;

	// Token: 0x04006FF3 RID: 28659
	private GUIStyle LVccZqEeJPf;

	// Token: 0x04006FF4 RID: 28660
	private GUIStyle LPqcZpGmYhh;

	// Token: 0x04006FF5 RID: 28661
	private GUIStyle KKwcZRPaf1W;

	// Token: 0x04006FF6 RID: 28662
	private GUIStyle aH7cZri5UGO;

	// Token: 0x04006FF7 RID: 28663
	private GUIStyle ihjcZx1EofE;

	// Token: 0x04006FF8 RID: 28664
	private GUIStyle uj0cZTCMla9;

	// Token: 0x04006FF9 RID: 28665
	private GUIStyle miNcZYQcEy0;

	// Token: 0x04006FFA RID: 28666
	private int nVkcZ3919XO;

	// Token: 0x04006FFB RID: 28667
	private MailClass ym1cZb51c49;

	// Token: 0x04006FFC RID: 28668
	private UnityScript.Lang.Array LhjcZdEqukg;

	// Token: 0x04006FFD RID: 28669
	private InventoryClass[] Xl4cZgAUQNT;

	// Token: 0x04006FFE RID: 28670
	private IconButtonClass[] IuicZafwPGZ;

	// Token: 0x04006FFF RID: 28671
	private float yv8cZ4q1v9k;

	// Token: 0x04007000 RID: 28672
	private Texture vI4cZsdb34K;

	// Token: 0x04007001 RID: 28673
	private Texture poNcZHPqJow;

	// Token: 0x04007002 RID: 28674
	private Texture POLcZ7jo84U;

	// Token: 0x04007003 RID: 28675
	private Texture CaEcZZNXIjh;

	// Token: 0x04007004 RID: 28676
	private GUIStyle xffcZCYwMX3;

	// Token: 0x04007005 RID: 28677
	private GUIStyle J8NcZMxX8MA;

	// Token: 0x04007006 RID: 28678
	private GUIStyle VNKcZfMvWwa;

	// Token: 0x04007007 RID: 28679
	private IconButtonClass[] sx4cZLlPrGn;

	// Token: 0x04007008 RID: 28680
	private string yQ7cZwP2HEr;

	// Token: 0x04007009 RID: 28681
	private float aATcZUdyxBr;

	// Token: 0x0400700A RID: 28682
	private GUIStyle fyscZN3i8kP;

	// Token: 0x0400700B RID: 28683
	private Texture gkhcZEcmyBs;

	// Token: 0x0400700C RID: 28684
	private InventoryClass WuAcZPEkg08;

	// Token: 0x0400700D RID: 28685
	private Texture xN6cZS21POk;

	// Token: 0x0400700E RID: 28686
	private Vector2 lMycZBYa7fc;
}
