using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200085F RID: 2143
[Serializable]
public class Rabbit_mall : MonoBehaviour
{
	// Token: 0x06002F45 RID: 12101 RVA: 0x005EC770 File Offset: 0x005EA970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rabbit_mall()
	{
		if (177845 - 408743 != -230897)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (76786 - 450501 != -373714)
			{
				base..ctor();
				if (165394 - 592195 != -426800)
				{
					this.v4fNfp37Bk = "none";
					if (287777 - 259881 == 27896)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x005EC80C File Offset: 0x005EAA0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nOwnerID, int nSellerID)
	{
		if (34194 - 473328 != -439133)
		{
		}
		for (;;)
		{
			this.gameObject.name = "mall";
			if (171609 - 529021 == -357412)
			{
				this.LhfNHBkoIE = nOwner;
				if (72803 - 96393 == -23590)
				{
					this.UVyN7hASgy = (CharacterControl)nOwner.GetComponent(typeof(CharacterControl));
					if (83175 - 283866 != -200690)
					{
						this.VQANZ2Csnx = nOwnerID;
						if (134478 - 588861 != -454382)
						{
							this.F8XNCUYek4 = nSellerID;
							if (80283 - 143447 != -63163)
							{
								this.eFmNMAxtQJ = true;
								if (256591 - 331532 != -74940)
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

	// Token: 0x06002F47 RID: 12103 RVA: 0x005EC928 File Offset: 0x005EAB28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (272058 - 122371 != 149688)
		{
		}
		for (;;)
		{
			if (!this.eFmNMAxtQJ)
			{
				if (216480 - 39793 != 176688)
				{
					break;
				}
			}
			else if (!Camera.main)
			{
				if (272107 - 316817 == -44710)
				{
					break;
				}
			}
			else
			{
				if (this.LhfNHBkoIE)
				{
					if (110910 - 80188 == 30723)
					{
						continue;
					}
					if (!this.UVyN7hASgy)
					{
						if (192110 - 513507 != -321397)
						{
							continue;
						}
					}
					else if (this.UVyN7hASgy.actionState != "attack")
					{
						if (16540 - 77973 == -61432)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (182852 - 284682 != -101829)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.UVyN7hASgy.myCommand != "mallSetup")
						{
							if (140457 - 411289 == -270831)
							{
								continue;
							}
							if (this.UVyN7hASgy.myCommand != "mallOpen")
							{
								if (63865 - 364536 == -300670)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.gameObject);
								if (149576 - 426506 != -276930)
								{
									continue;
								}
								break;
							}
						}
						if (Game.mGameState != eGameState.Normal)
						{
							break;
						}
						if (244417 - 419816 == -175398)
						{
							continue;
						}
						if (Game.mPlayer == null)
						{
							if (234643 - 352312 != -117669)
							{
								continue;
							}
							break;
						}
						else
						{
							if (this.UVyN7hASgy.isMine)
							{
								break;
							}
							if (59540 - 109538 != -49998)
							{
								continue;
							}
							GUI.depth = 3;
							if (103599 - 66916 == 36684)
							{
								continue;
							}
							if (Time.time <= this.r9LNLnWOYQ)
							{
								break;
							}
							if (252801 - 418597 != -165796)
							{
								continue;
							}
							Vector3 vector = Game.mPlayer.transform.position - this.transform.position;
							if (70097 - 90313 != -20216)
							{
								continue;
							}
							int num = (int)Mathf.Clamp(vector.sqrMagnitude, (float)0, (float)100);
							if (262009 - 257562 == 4448)
							{
								continue;
							}
							if (num <= 4)
							{
								if (36096 - 239954 == -203857)
								{
									continue;
								}
								Vector3 vector2 = Camera.main.WorldToScreenPoint(this.transform.position + this.transform.TransformDirection((float)0, 0.5f, 0.5f));
								if (237414 - 449065 == -211650)
								{
									continue;
								}
								if (vector2.z < (float)0)
								{
									if (30288 - 256939 != -226651)
									{
										continue;
									}
									break;
								}
								else
								{
									float num2 = Mathf.Clamp(0.5f * (float)Screen.height / vector2.z, (float)25, (float)117);
									if (27043 - 473808 == -446764)
									{
										continue;
									}
									Rect position = new Rect(vector2.x - num2, (float)Screen.height - vector2.y, (float)117, (float)49);
									if (26796 - 373062 != -346266)
									{
										continue;
									}
									if (this.KOpNwKThHo == null)
									{
										if (24672 - 553201 == -528528)
										{
											continue;
										}
										this.KOpNwKThHo = new GUIStyle();
										if (278673 - 355664 == -76990)
										{
											continue;
										}
										this.KOpNwKThHo.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetMall", typeof(Texture)));
										if (70815 - 435392 == -364576)
										{
											continue;
										}
										this.KOpNwKThHo.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetMall_h", typeof(Texture)));
										if (213 - 192196 != -191982)
										{
											break;
										}
										continue;
									}
									else
									{
										if (!GUI.Button(position, string.Empty, this.KOpNwKThHo))
										{
											break;
										}
										if (94043 - 88770 != 5273)
										{
											continue;
										}
										MallGui mallGui = (MallGui)Camera.main.GetComponent(typeof(MallGui));
										if (76339 - 38452 == 37888)
										{
											continue;
										}
										if (mallGui)
										{
											if (288726 - 343237 == -54510)
											{
												continue;
											}
											Game.mGameState = eGameState.Hold;
											if (94528 - 406539 != -312011)
											{
												continue;
											}
											GameGui gameGui = (GameGui)Camera.main.GetComponent(typeof(GameGui));
											if (51599 - 106595 != -54996)
											{
												continue;
											}
											if (gameGui)
											{
												if (31751 - 276871 == -245119)
												{
													continue;
												}
												gameGui.close();
												if (130261 - 427758 != -297497)
												{
													continue;
												}
											}
											mallGui.mType = eMallType.buying;
											if (201129 - 311462 != -110333)
											{
												continue;
											}
											mallGui.mSeller = this.LhfNHBkoIE;
											if (120349 - 467424 == -347074)
											{
												continue;
											}
											mallGui.mSellerChar = this.UVyN7hASgy;
											if (194488 - 199803 == -5314)
											{
												continue;
											}
											mallGui.mSellerID = this.F8XNCUYek4;
											if (259248 - 480462 != -221214)
											{
												continue;
											}
											mallGui.enabled = true;
											if (35966 - 29873 != 6094)
											{
												break;
											}
											continue;
										}
										else
										{
											Camera.main.SendMessage("newGameMessage", "Cannot use mall in this area");
											if (45256 - 414913 != -369656)
											{
												break;
											}
											continue;
										}
									}
								}
							}
							else
							{
								this.r9LNLnWOYQ = Time.time + (float)num * 0.01f;
								if (187233 - 175468 != 11766)
								{
									break;
								}
								continue;
							}
						}
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (270817 - 144861 != 125957)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002F48 RID: 12104 RVA: 0x005ED08C File Offset: 0x005EB28C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F49 RID: 12105 RVA: 0x005ED090 File Offset: 0x005EB290
	internal static bool hjnGVk5ccgRWNd4QPG6J()
	{
		return true;
	}

	// Token: 0x06002F4A RID: 12106 RVA: 0x005ED094 File Offset: 0x005EB294
	internal static bool hISV5l5cUXuyng8H3ePf()
	{
		return false;
	}

	// Token: 0x040037D0 RID: 14288
	private GameObject LhfNHBkoIE;

	// Token: 0x040037D1 RID: 14289
	private CharacterControl UVyN7hASgy;

	// Token: 0x040037D2 RID: 14290
	private int VQANZ2Csnx;

	// Token: 0x040037D3 RID: 14291
	private int F8XNCUYek4;

	// Token: 0x040037D4 RID: 14292
	private bool eFmNMAxtQJ;

	// Token: 0x040037D5 RID: 14293
	private string v4fNfp37Bk;

	// Token: 0x040037D6 RID: 14294
	private float r9LNLnWOYQ;

	// Token: 0x040037D7 RID: 14295
	private GUIStyle KOpNwKThHo;
}
