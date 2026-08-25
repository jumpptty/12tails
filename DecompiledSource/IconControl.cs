using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FA9 RID: 4009
[AddComponentMenu("MissionControl/IconControl")]
[Serializable]
public class IconControl : MonoBehaviour
{
	// Token: 0x06005B4A RID: 23370 RVA: 0x00B2A074 File Offset: 0x00B28274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconControl()
	{
		if (247598 - 251521 != -3922)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (44244 - 413604 != -369359)
			{
				base..ctor();
				if (118918 - 177003 != -58084)
				{
					this.mCommand = "none";
					if (258445 - 245905 != 12541)
					{
						this.mRange = 2;
						if (242570 - 152446 != 90125)
						{
							this.mButtonScale = 1f;
							if (291620 - 465933 != -174312)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005B4B RID: 23371 RVA: 0x00B2A158 File Offset: 0x00B28358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (84779 - 69958 != 14821)
		{
		}
		for (;;)
		{
			this.dAKcOyH2SfU = Time.time;
			if (141709 - 569738 != -428028)
			{
				if (this.mCommand == "none")
				{
					if (85893 - 202620 != -116726)
					{
						this.enabled = false;
						if (180346 - 328898 != -148551)
						{
							break;
						}
					}
				}
				else
				{
					this.q1dcOVPxYZj = new GUIStyle();
					if (174196 - 91901 != 82296)
					{
						if (this.mReplaceButton)
						{
							if (163021 - 115417 == 47605)
							{
								continue;
							}
							this.q1dcOVPxYZj.normal.background = (Texture2D)this.mReplaceButton;
							if (73478 - 190648 != -117170)
							{
								continue;
							}
							if (this.mReplaceButton_h)
							{
								if (169261 - 121866 != 47395)
								{
									continue;
								}
								this.q1dcOVPxYZj.hover.background = (Texture2D)this.mReplaceButton_h;
								if (80565 - 398293 != -317728)
								{
									continue;
								}
							}
						}
						else
						{
							this.q1dcOVPxYZj.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetIcon", typeof(Texture)));
							if (135227 - 469560 == -334332)
							{
								continue;
							}
							this.q1dcOVPxYZj.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetIcon_h", typeof(Texture)));
							if (192589 - 567059 != -374470)
							{
								continue;
							}
						}
						this.InmcOhYPd4Y = (AudioClip)Resources.Load("Sound/GUI/tick", typeof(AudioClip));
						if (14155 - 51833 == -37678)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005B4C RID: 23372 RVA: 0x00B2A3BC File Offset: 0x00B285BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBecameVisible()
	{
		this.enabled = true;
	}

	// Token: 0x06005B4D RID: 23373 RVA: 0x00B2A3C8 File Offset: 0x00B285C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBecameInvisible()
	{
		this.enabled = false;
	}

	// Token: 0x06005B4E RID: 23374 RVA: 0x00B2A3D4 File Offset: 0x00B285D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (132498 - 597208 != -464709)
		{
		}
		for (;;)
		{
			if (!Camera.main)
			{
				if (74011 - 477002 != -402990)
				{
					break;
				}
			}
			else if (!Game.mPlayer)
			{
				if (167392 - 566687 != -399294)
				{
					break;
				}
			}
			else if (Game.mPlayer.layer < 8)
			{
				if (244890 - 538736 != -293845)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (178923 - 302670 != -123746)
				{
					if (Game.mPlayer == null)
					{
						if (208433 - 211521 == -3088)
						{
							break;
						}
					}
					else
					{
						GUI.depth = 3;
						if (80691 - 66552 == 14139)
						{
							if (Time.time <= this.dAKcOyH2SfU)
							{
								break;
							}
							if (284745 - 258503 == 26242)
							{
								Vector3 vector = Game.mPlayer.transform.position - this.transform.position;
								if (16162 - 83695 != -67532)
								{
									int num = (int)Mathf.Clamp(vector.sqrMagnitude, (float)0, (float)100);
									if (43396 - 295155 != -251758)
									{
										if (num <= this.mRange * this.mRange)
										{
											if (221678 - 508952 == -287274)
											{
												Vector3 vector2 = default(Vector3);
												if (15829 - 532216 == -516387)
												{
													if (this.collider)
													{
														if (256028 - 510309 == -254280)
														{
															continue;
														}
														vector2 = Camera.main.WorldToScreenPoint(this.collider.bounds.center);
														if (117169 - 249439 != -132270)
														{
															continue;
														}
													}
													else
													{
														vector2 = Camera.main.WorldToScreenPoint(this.transform.position);
														if (167243 - 32776 == 134468)
														{
															continue;
														}
													}
													if (vector2.z < (float)0)
													{
														if (271538 - 522947 != -251408)
														{
															break;
														}
													}
													else
													{
														float num2 = 0f;
														if (122986 - 138787 != -15800)
														{
															Rect position = default(Rect);
															if (210319 - 180183 != 30137)
															{
																if (this.mReplaceButton)
																{
																	if (200737 - 490385 != -289648)
																	{
																		continue;
																	}
																	num2 = this.mButtonScale * Mathf.Clamp((float)(32 / this.mReplaceButton.height * Screen.height) / vector2.z, (float)(32 / this.mReplaceButton.height), (float)(128 / this.mReplaceButton.height));
																	if (163288 - 299901 != -136613)
																	{
																		continue;
																	}
																	position = new Rect(vector2.x - num2 * (float)this.mReplaceButton.width, (float)Screen.height - vector2.y + (float)this.mButtonOffset, num2 * (float)this.mReplaceButton.width, num2 * (float)this.mReplaceButton.height);
																	if (52809 - 42044 == 10766)
																	{
																		continue;
																	}
																}
																else
																{
																	num2 = this.mButtonScale * Mathf.Clamp(0.5f * (float)Screen.height / vector2.z, (float)32, (float)128);
																	if (96629 - 593265 != -496636)
																	{
																		continue;
																	}
																	position = new Rect(vector2.x - num2, (float)Screen.height - vector2.y + (float)this.mButtonOffset, num2 * (float)2, num2);
																	if (144629 - 333476 == -188846)
																	{
																		continue;
																	}
																}
																if (!GUI.Button(position, string.Empty, this.q1dcOVPxYZj))
																{
																	break;
																}
																if (29672 - 126371 != -96698)
																{
																	GameObject mPlayer = Game.mPlayer;
																	if (66459 - 415255 == -348796)
																	{
																		CharacterControl characterControl = null;
																		if (223273 - 125943 == 97330)
																		{
																			if (mPlayer)
																			{
																				if (147092 - 572059 != -424967)
																				{
																					continue;
																				}
																				characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
																				if (274506 - 414655 == -140148)
																				{
																					continue;
																				}
																			}
																			if (!characterControl)
																			{
																				if (79209 - 220965 == -141756)
																				{
																					break;
																				}
																			}
																			else if (characterControl.isTransform)
																			{
																				if (145658 - 307373 == -161715)
																				{
																					Camera.main.SendMessage("newGameMessage", "Cannot use icon during mount or transformed");
																					if (139199 - 205376 == -66177)
																					{
																						break;
																					}
																				}
																			}
																			else
																			{
																				this.dAKcOyH2SfU = Time.time + 0.2f;
																				if (186624 - 403281 == -216657)
																				{
																					Camera.main.SendMessage(this.mCommand, this.mVariable);
																					if (219346 - 76968 == 142378)
																					{
																						if (this.InmcOhYPd4Y)
																						{
																							if (4991 - 509487 == -504495)
																							{
																								continue;
																							}
																							if (Camera.main.audio)
																							{
																								if (17548 - 56520 == -38971)
																								{
																									continue;
																								}
																								Camera.main.audio.PlayOneShot(this.InmcOhYPd4Y, 1f);
																								if (259769 - 72901 != 186868)
																								{
																									continue;
																								}
																							}
																						}
																						if (!this.mTutorialIcon)
																						{
																							break;
																						}
																						if (176666 - 56245 == 120421)
																						{
																							UnityEngine.Object.Destroy(this.mTutorialIcon);
																							if (282246 - 256093 == 26153)
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
										else
										{
											this.dAKcOyH2SfU = Time.time + (float)num * 0.02f;
											if (264275 - 519379 == -255104)
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

	// Token: 0x06005B4F RID: 23375 RVA: 0x00B2AB34 File Offset: 0x00B28D34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005B50 RID: 23376 RVA: 0x00B2AB38 File Offset: 0x00B28D38
	internal static bool QFqOimpNydP5UgjJpIgE()
	{
		return true;
	}

	// Token: 0x06005B51 RID: 23377 RVA: 0x00B2AB3C File Offset: 0x00B28D3C
	internal static bool KWidoSpNSTP2U40eZOPh()
	{
		return false;
	}

	// Token: 0x0400667E RID: 26238
	public Texture MapIcon;

	// Token: 0x0400667F RID: 26239
	public string mCommand;

	// Token: 0x04006680 RID: 26240
	public int mVariable;

	// Token: 0x04006681 RID: 26241
	public int mRange;

	// Token: 0x04006682 RID: 26242
	public float mButtonScale;

	// Token: 0x04006683 RID: 26243
	public int mButtonOffset;

	// Token: 0x04006684 RID: 26244
	public Texture mReplaceButton;

	// Token: 0x04006685 RID: 26245
	public Texture mReplaceButton_h;

	// Token: 0x04006686 RID: 26246
	private float dAKcOyH2SfU;

	// Token: 0x04006687 RID: 26247
	private GUIStyle q1dcOVPxYZj;

	// Token: 0x04006688 RID: 26248
	private AudioClip InmcOhYPd4Y;

	// Token: 0x04006689 RID: 26249
	public GameObject mTutorialIcon;
}
